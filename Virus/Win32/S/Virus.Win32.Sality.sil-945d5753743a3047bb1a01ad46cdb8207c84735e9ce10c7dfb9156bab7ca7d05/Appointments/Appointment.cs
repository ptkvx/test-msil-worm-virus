using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Appointments;

[Table(Name = "dbo.Appointments")]
public class Appointment : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private Guid _ID;

	private Guid? _Patient_ID;

	private Guid? _Doctor_ID;

	private DateTime _Appointment_Date;

	private TimeSpan _Appointment_Time;

	private char _Timing_Zone;

	private string _Notes;

	private EntityRef<Doctor> _Doctor;

	private EntityRef<Patient> _Patient;

	[Column(Storage = "_ID", DbType = "UniqueIdentifier NOT NULL", IsPrimaryKey = true)]
	public Guid ID
	{
		get
		{
			return _ID;
		}
		set
		{
			if (_ID != value)
			{
				SendPropertyChanging();
				_ID = value;
				SendPropertyChanged("ID");
			}
		}
	}

	[Column(Storage = "_Patient_ID", DbType = "UniqueIdentifier")]
	public Guid? Patient_ID
	{
		get
		{
			return _Patient_ID;
		}
		set
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			if (_Patient_ID != value)
			{
				if (_Patient.get_HasLoadedOrAssignedValue())
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Patient_ID = value;
				SendPropertyChanged("Patient_ID");
			}
		}
	}

	[Column(Storage = "_Doctor_ID", DbType = "UniqueIdentifier")]
	public Guid? Doctor_ID
	{
		get
		{
			return _Doctor_ID;
		}
		set
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			if (_Doctor_ID != value)
			{
				if (_Doctor.get_HasLoadedOrAssignedValue())
				{
					throw new ForeignKeyReferenceAlreadyHasValueException();
				}
				SendPropertyChanging();
				_Doctor_ID = value;
				SendPropertyChanged("Doctor_ID");
			}
		}
	}

	[Column(Storage = "_Appointment_Date", DbType = "Date NOT NULL")]
	public DateTime Appointment_Date
	{
		get
		{
			return _Appointment_Date;
		}
		set
		{
			if (_Appointment_Date != value)
			{
				SendPropertyChanging();
				_Appointment_Date = value;
				SendPropertyChanged("Appointment_Date");
			}
		}
	}

	[Column(Storage = "_Appointment_Time", DbType = "Time NOT NULL")]
	public TimeSpan Appointment_Time
	{
		get
		{
			return _Appointment_Time;
		}
		set
		{
			if (_Appointment_Time != value)
			{
				SendPropertyChanging();
				_Appointment_Time = value;
				SendPropertyChanged("Appointment_Time");
			}
		}
	}

	[Column(Storage = "_Timing_Zone", DbType = "Char(1) NOT NULL")]
	public char Timing_Zone
	{
		get
		{
			return _Timing_Zone;
		}
		set
		{
			if (_Timing_Zone != value)
			{
				SendPropertyChanging();
				_Timing_Zone = value;
				SendPropertyChanged("Timing_Zone");
			}
		}
	}

	[Column(/*Could not decode attribute arguments.*/)]
	public string Notes
	{
		get
		{
			return _Notes;
		}
		set
		{
			if (_Notes != value)
			{
				SendPropertyChanging();
				_Notes = value;
				SendPropertyChanged("Notes");
			}
		}
	}

	[Association(Name = "Doctor_Appointment", Storage = "_Doctor", ThisKey = "Doctor_ID", OtherKey = "ID", IsForeignKey = true)]
	public Doctor Doctor
	{
		get
		{
			return _Doctor.get_Entity();
		}
		set
		{
			Doctor entity = _Doctor.get_Entity();
			if (entity != value || !_Doctor.get_HasLoadedOrAssignedValue())
			{
				SendPropertyChanging();
				if (entity != null)
				{
					_Doctor.set_Entity((Doctor)null);
					entity.Appointments.Remove(this);
				}
				_Doctor.set_Entity(value);
				if (value != null)
				{
					value.Appointments.Add(this);
					_Doctor_ID = value.ID;
				}
				else
				{
					_Doctor_ID = null;
				}
				SendPropertyChanged("Doctor");
			}
		}
	}

	[Association(Name = "Patient_Appointment", Storage = "_Patient", ThisKey = "Patient_ID", OtherKey = "ID", IsForeignKey = true)]
	public Patient Patient
	{
		get
		{
			return _Patient.get_Entity();
		}
		set
		{
			Patient entity = _Patient.get_Entity();
			if (entity != value || !_Patient.get_HasLoadedOrAssignedValue())
			{
				SendPropertyChanging();
				if (entity != null)
				{
					_Patient.set_Entity((Patient)null);
					entity.Appointments.Remove(this);
				}
				_Patient.set_Entity(value);
				if (value != null)
				{
					value.Appointments.Add(this);
					_Patient_ID = value.ID;
				}
				else
				{
					_Patient_ID = null;
				}
				SendPropertyChanged("Patient");
			}
		}
	}

	public event PropertyChangingEventHandler PropertyChanging;

	public event PropertyChangedEventHandler PropertyChanged;

	public Appointment()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		_Doctor = default(EntityRef<Doctor>);
		_Patient = default(EntityRef<Patient>);
	}

	protected virtual void SendPropertyChanging()
	{
		if (this.PropertyChanging != null)
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}

	protected virtual void SendPropertyChanged(string propertyName)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

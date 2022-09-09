using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Appointments;

[Table(Name = "dbo.Doctors")]
public class Doctor : INotifyPropertyChanging, INotifyPropertyChanged
{
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

	private Guid _ID;

	private string _Name;

	private EntitySet<Appointment> _Appointments;

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

	[Column(Storage = "_Name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			if (_Name != value)
			{
				SendPropertyChanging();
				_Name = value;
				SendPropertyChanged("Name");
			}
		}
	}

	[Association(Name = "Doctor_Appointment", Storage = "_Appointments", ThisKey = "ID", OtherKey = "Doctor_ID")]
	public EntitySet<Appointment> Appointments
	{
		get
		{
			return _Appointments;
		}
		set
		{
			_Appointments.Assign((IEnumerable<Appointment>)value);
		}
	}

	public event PropertyChangingEventHandler PropertyChanging;

	public event PropertyChangedEventHandler PropertyChanged;

	public Doctor()
	{
		_Appointments = new EntitySet<Appointment>((Action<Appointment>)attach_Appointments, (Action<Appointment>)detach_Appointments);
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

	private void attach_Appointments(Appointment entity)
	{
		SendPropertyChanging();
		entity.Doctor = this;
	}

	private void detach_Appointments(Appointment entity)
	{
		SendPropertyChanging();
		entity.Doctor = null;
	}
}

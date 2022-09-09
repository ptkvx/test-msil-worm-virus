using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Appointments.Properties;

namespace Appointments;

[Database(Name = "Appointments")]
public class myAppointmentsDataContext : DataContext
{
	private static MappingSource mappingSource = (MappingSource)new AttributeMappingSource();

	public Table<Appointment> Appointments => ((DataContext)this).GetTable<Appointment>();

	public Table<Doctor> Doctors => ((DataContext)this).GetTable<Doctor>();

	public Table<Patient> Patients => ((DataContext)this).GetTable<Patient>();

	public myAppointmentsDataContext()
		: base(Settings.Default.AppointmentsConnectionString, mappingSource)
	{
	}

	public myAppointmentsDataContext(string connection)
		: base(connection, mappingSource)
	{
	}

	public myAppointmentsDataContext(IDbConnection connection)
		: base(connection, mappingSource)
	{
	}

	public myAppointmentsDataContext(string connection, MappingSource mappingSource)
		: base(connection, mappingSource)
	{
	}

	public myAppointmentsDataContext(IDbConnection connection, MappingSource mappingSource)
		: base(connection, mappingSource)
	{
	}
}

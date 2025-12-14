using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IAppointmentRepository
{
    Task AddAppointmentAsync(AppointmentModel NewAppointment);
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDatetimeAndDoctorIDAsync(DateTime datetime, string DoctorID);
    Task<AppointmentModel?> GetNearestAppointmentByDoctorIDAsync(string DoctorID);
    Task<AppointmentModel?> GetNearestAppointmentByPatientIDAsync(string PatientID);
    Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID);
}

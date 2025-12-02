using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Data;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class AppointmentRepository : IAppointmentRepository
{
    public readonly DataContext _dataContext;
    public AppointmentRepository(DataContext dataContext)
    {
        _dataContext = dataContext; 
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID)
    {
        return await _dataContext.Appointments
                                .Include(a => a.Doctor)
                                .Include(a => a.Patient)
                                .Where(a => DoctorID.Contains(a.DoctorID))
                                .ToListAsync();
    }
}

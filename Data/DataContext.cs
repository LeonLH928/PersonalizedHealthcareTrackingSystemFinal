using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Helpers;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<UserModel> Users { get; set; } = null!;
    public DbSet<PatientModel> Patients { get; set; } = null!;
    public DbSet<DoctorModel> Doctors { get; set; } = null!;
    public DbSet<PharmacistModel> Pharmacists { get; set; } = null!;
    public DbSet<AppointmentModel> Appointments { get; set; } = null!;
    public DbSet<DoctorScheduleModel> DoctorSchedules { get; set; } = null!;
    public DbSet<MedicalRecordModel> MedicalRecords { get; set; } = null!;
    public DbSet<ClinicalExaminationModel> ClinicalExaminations { get; set; } = null!;
    public DbSet<PrescriptionModel> Prescriptions { get; set; } = null!;
    public DbSet<PrescriptionItemModel> PrescriptionItems { get; set; } = null!;
    public DbSet<MedicationModel> Medications { get; set; } = null!;
    public DbSet<MedicationStockLogModel> MedicationStockLogs { get; set; } = null!;
    public DbSet<MedicationInteractionModel> MedicationInteractions { get; set; } = null!; protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User -> Patient
        modelBuilder.Entity<UserModel>()
            .HasOne(u => u.Patient)
            .WithOne(p => p.User)
            .HasForeignKey<PatientModel>(p => p.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        // User -> Doctor
        modelBuilder.Entity<UserModel>()
            .HasOne(u => u.Doctor)
            .WithOne(d => d.User)
            .HasForeignKey<DoctorModel>(d => d.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        // User -> Pharmacist
        modelBuilder.Entity<UserModel>()
            .HasOne(u => u.Pharmacist)
            .WithOne(p => p.User)
            .HasForeignKey<PharmacistModel>(p => p.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        // Doctors -> DoctorSchedules
        modelBuilder.Entity<DoctorModel>()
            .HasMany(d => d.DoctorSchedules)
            .WithOne(ds => ds.Doctor)
            .HasForeignKey(ds => ds.DoctorID)
            .OnDelete(DeleteBehavior.Cascade);

        // Appointment -> MedicalRecord
        modelBuilder.Entity<AppointmentModel>()
            .HasOne(a => a.MedicalRecord)
            .WithOne(mr => mr.Appointment)
            .HasForeignKey<MedicalRecordModel>(mr => mr.AppointmentID)
            .OnDelete(DeleteBehavior.Cascade);

        // MedicalRecord -> ClinicalExamination
        modelBuilder.Entity<MedicalRecordModel>()
            .HasOne(mr => mr.ClinicalExamination)
            .WithOne(ce => ce.MedicalRecord)
            .HasForeignKey<ClinicalExaminationModel>(ce => ce.RecordID)
            .OnDelete(DeleteBehavior.Cascade);

        // MedicalRecord -> Prescription
        modelBuilder.Entity<MedicalRecordModel>()
            .HasOne(mr => mr.Prescription)
            .WithOne(p => p.MedicalRecord)
            .HasForeignKey<PrescriptionModel>(p => p.RecordID)
            .OnDelete(DeleteBehavior.Cascade);

        // Doctors -> DoctorSchedules (Composition: Cascade OK)
        modelBuilder.Entity<DoctorModel>()
            .HasMany(d => d.DoctorSchedules)
            .WithOne(s => s.Doctor)
            .HasForeignKey(s => s.DoctorID)
            .OnDelete(DeleteBehavior.Cascade);

        // Patients -> Appointments 
        modelBuilder.Entity<PatientModel>()
            .HasMany(p => p.Appointments)
            .WithOne(a => a.Patient)
            .HasForeignKey(a => a.PatientID)
            .OnDelete(DeleteBehavior.Restrict);

        // Doctors -> Appointments
        modelBuilder.Entity<DoctorModel>()
            .HasMany(d => d.Appointments)
            .WithOne(a => a.Doctor)
            .HasForeignKey(a => a.DoctorID)
            .OnDelete(DeleteBehavior.Restrict);

        // Pharmacists -> Prescriptions 
        modelBuilder.Entity<PharmacistModel>()
            .HasMany(ph => ph.Prescriptions)
            .WithOne(p => p.PharmacistChecking)
            .HasForeignKey(p => p.PharmacistID)
            .IsRequired(false) 
            .OnDelete(DeleteBehavior.SetNull);

        // Prescriptions -> PrescriptionItems
        modelBuilder.Entity<PrescriptionModel>()
            .HasMany(p => p.PrescriptionItems)
            .WithOne(pi => pi.Prescription)
            .HasForeignKey(pi => pi.PrescriptionID)
            .OnDelete(DeleteBehavior.Cascade);
        
        // Medications -> PrescriptionItems
        modelBuilder.Entity<MedicationModel>()
            .HasMany(m => m.PrescriptionItems)
            .WithOne(pi => pi.Medication)
            .HasForeignKey(pi => pi.MedicationID)
            .OnDelete(DeleteBehavior.Restrict);

        // Medications -> MedicationStockLogs
        modelBuilder.Entity<MedicationModel>()
            .HasMany(m => m.MedicationStockLogs)
            .WithOne(msl => msl.Medication)
            .HasForeignKey(msl => msl.MedicationID)
            .OnDelete(DeleteBehavior.Restrict);

        // Prescriptions -> MedicationStockLogs (Optional link in logs)
        modelBuilder.Entity<PrescriptionModel>()
           .HasMany(p => p.MedicationStockLogs)
           .WithOne(msl => msl.Prescription)
           .HasForeignKey(msl => msl.RelatedPrescriptionID)
           .OnDelete(DeleteBehavior.Restrict);

        // Medication 1 -> Interactions
        modelBuilder.Entity<MedicationModel>()
            .HasMany(m => m.MedicationInteractions1)
            .WithOne(mi1 => mi1.Medication1)
            .HasForeignKey(mi1 => mi1.MedicationID1)
            .OnDelete(DeleteBehavior.Restrict);

        // Medication 2 -> Interactions
        modelBuilder.Entity<MedicationModel>()
            .HasMany(m => m.MedicationInteractions2)
            .WithOne(mi2 => mi2.Medication2)
            .HasForeignKey(mi2 => mi2.MedicationID2)
            .OnDelete(DeleteBehavior.Restrict);

        DatabaseSeeder.Seed(modelBuilder);
    }
}

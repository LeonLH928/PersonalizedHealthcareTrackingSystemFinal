using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Helpers;
public static class DatabaseSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        SeedMedications(modelBuilder);
        SeedUsers(modelBuilder);
        SeedPatients(modelBuilder);
        SeedDoctors(modelBuilder);
        SeedPharmacists(modelBuilder);
        SeedAppointments(modelBuilder);
        SeedMedicalRecords(modelBuilder);
        SeedClinicalExaminations(modelBuilder);
        SeedPrescriptions(modelBuilder);
        SeedPrescriptionItems(modelBuilder);
    }

    private static void SeedMedications(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationModel>().HasData(
            new MedicationModel
            {
                MedicationID = "med-amox-500",
                Name = "Amoxicillin 500mg",
                Form = Form.Tablet, 
                Unit = "mg",
                SideEffect = "Nausea, rash",
                StorageInstruction = "Store at room temperature",
                StockQuantity = 1000,
                StockQuantityUnit = "box",
                Price = 150000
            },
            new MedicationModel
            {
                MedicationID = "med-ibu-400",
                Name = "Ibuprofen 400mg",
                 Form = Form.Tablet, 
                Unit = "mg",
                SideEffect = "Stomach upset",
                StorageInstruction = "Keep dry",
                StockQuantity = 500,
                StockQuantityUnit = "bottle",
                Price = 80000
            }
        );
    }

    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        // NOTE: Passwords should be hashed in a real app.
        modelBuilder.Entity<UserModel>().HasData(
            new UserModel
            {
                UserID = "user-pat-01",
                FirstName = "John",
                LastName = "Doe",
                Username = "john.doe",
                PasswordHash = "Password123!",
                Role = UserRole.Patient, 
                Email = "john@example.com",
                PhoneNumber = "0901234567",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-doc-01",
                FirstName = "Sarah",
                LastName = "Smith",
                Username = "dr.sarah",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor, 
                Email = "sarah.smith@clinic.com",
                PhoneNumber = "0909998887",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-phar-01",
                FirstName = "David",
                LastName = "Chen",
                Username = "phar.david",
                PasswordHash = "Password123!",
                Role = UserRole.Pharmacist, 
                Email = "david.chen@pharmacy.com",
                PhoneNumber = "0905554443",
                IsActive = true
            }
        );
    }

    private static void SeedPatients(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PatientModel>().HasData(
            new PatientModel
            {
                PatientID = "pat-01",
                UserID = "user-pat-01", 
                DateOfBirth = new DateTime(1985, 5, 20, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Male,
                InsuranceNumber = "INS-123456",
                BloodType = "A+"
            }
        );
    }

    private static void SeedDoctors(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorModel>().HasData(
            new DoctorModel
            {
                DoctorID = "doc-01",
                UserID = "user-doc-01", 
                Specialization = "General Practitioner",
                ConsultationFee = 300000,
                Rating = 4.8,
                YearsOfExperience = 10
            }
        );
    }

    private static void SeedPharmacists(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PharmacistModel>().HasData(
            new PharmacistModel
            {
                PharmacistID = "phar-01",
                UserID = "user-phar-01", 
                Department = "Main Dispensary"
            }
        );
    }

    private static void SeedAppointments(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppointmentModel>().HasData(
            new AppointmentModel
            {
                AppointmentID = "appt-01",
                PatientID = "pat-01",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-1).AddHours(9),
                ChiefComplaint = "Sore throat and mild fever lasting 2 days.",
                Location = "Room 101",
                Status = StatusAppointment.Completed, 
                Priority = Priority.Routine,
                VisitNumber = 1
            }
        );
    }

    private static void SeedMedicalRecords(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicalRecordModel>().HasData(
            new MedicalRecordModel
            {
                RecordID = "rec-01",
                AppointmentID = "appt-01",
                VisitTime = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(15),
                Diagnosis = "Acute Pharyngitis (Strep Throat)",
                TreatmentPlan = "Antibiotics course and rest.",
                DoctorNotes = "Patient advised to finish full course of medication.",
                NextVisitDate = DateTime.UtcNow.AddDays(7)
            }
        );
    }

    private static void SeedClinicalExaminations(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClinicalExaminationModel>().HasData(
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-01",
                RecordID = "rec-01",
                Symptoms = "Throat pain, difficulty swallowing, low-grade fever.",
                MedicalHistory = "None relevant.",
                FamilyHistory = "Father has hypertension.",
                LifestyleHabits = "Non-smoker.",
                Allergies = "No known allergies.",
                Temperature = 38.2,
                Height = 175,
                Weight = 70,
                Pulse = 85,
                BloodPressure = "120/80",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            }
        );
    }

    private static void SeedPrescriptions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrescriptionModel>().HasData(
            new PrescriptionModel
            {
                PrescriptionID = "presc-01",
                RecordID = "rec-01",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(30),
                 Status = PrescriptionStatus.Pending, 
                PharmacistID = null!,
                VerifiedAt = DateTime.UtcNow,
                Priority = Priority.Routine, 
                DispensedAt = DateTime.UtcNow
            }
        );
    }

    private static void SeedPrescriptionItems(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrescriptionItemModel>().HasData(
            new PrescriptionItemModel
            {
                ItemID = "pi-01",
                PrescriptionID = "presc-01",
                MedicationID = "med-amox-500",
                Quantity = 21,
                Dosage = "500mg",
                Frequency = "3 times a day (every 8 hours)",
                DurationDays = 7,
                Instruction = "Take after meals.",
                Indication = "For bacterial infection.",
                DoseScheduleJSON = "{\"morning\": 1, \"afternoon\": 1, \"evening\": 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-02",
                PrescriptionID = "presc-01",
                MedicationID = "med-ibu-400", 
                Quantity = 10,
                Dosage = "400mg",
                Frequency = "As needed for pain/fever, max 3 times daily",
                DurationDays = 5,
                Instruction = "Do not take on an empty stomach.",
                Indication = "For pain and fever management.",
                DoseScheduleJSON = "{\"as_needed\": true}"
            }
        );
    }
}
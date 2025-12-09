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
        SeedDoctorSchedules(modelBuilder);
        SeedMedicationInteractions(modelBuilder);
        SeedMedicationStockLogs(modelBuilder);
    }

    public static void SeedMedications(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationModel>().HasData(
            new MedicationModel
            {
                MedicationID = "med-amox-500",
                Name = "Amoxicillin 500mg",
                ActiveIngredient = "Amoxicillin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 1000,
                PackingUnit = "box",
                UnitsPerPack = 20, // Assuming 20 tablets per box
                PackingDescription = "Box of 20 tablets",
                SideEffect = "Nausea, rash, diarrhea",
                StorageInstruction = "Store at room temperature, away from moisture",
                Price = 150000
            },
            new MedicationModel
            {
                MedicationID = "med-ibu-400",
                Name = "Ibuprofen 400mg",
                ActiveIngredient = "Ibuprofen",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 500,
                PackingUnit = "bottle",
                UnitsPerPack = 50, // Assuming 50 tablets per bottle
                PackingDescription = "Bottle of 50 tablets",
                SideEffect = "Stomach upset, heartburn, dizziness",
                StorageInstruction = "Keep dry, store below 30°C",
                Price = 80000
            },
            new MedicationModel
            {
                MedicationID = "med-para-500",
                Name = "Paracetamol 500mg",
                ActiveIngredient = "Paracetamol",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 2000,
                PackingUnit = "box",
                UnitsPerPack = 100, // Assuming 100 tablets per box
                PackingDescription = "Box of 10 blisters x 10 tablets",
                SideEffect = "Liver toxicity (high dose or long-term use)",
                StorageInstruction = "Store in a cool, dry place",
                Price = 50000
            },
            new MedicationModel
            {
                MedicationID = "med-met-850",
                Name = "Metformin 850mg",
                ActiveIngredient = "Metformin Hydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 800,
                PackingUnit = "box",
                UnitsPerPack = 60, // Assuming 60 tablets per box
                PackingDescription = "Box of 60 tablets",
                SideEffect = "Nausea, gastrointestinal disturbance, metallic taste",
                StorageInstruction = "Store at room temperature",
                Price = 120000
            },
            new MedicationModel
            {
                MedicationID = "med-cet-10",
                Name = "Cetirizine 10mg",
                ActiveIngredient = "Cetirizine Dihydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 2000,
                PackingUnit = "blister",
                UnitsPerPack = 10, // Assuming 10 tablets per blister
                PackingDescription = "Blister pack of 10 tablets",
                SideEffect = "Drowsiness, dry mouth, fatigue",
                StorageInstruction = "Store in a dry place, protected from light",
                Price = 45000
            },
            new MedicationModel
            {
                MedicationID = "med-ator-20",
                Name = "Atorvastatin 20mg",
                ActiveIngredient = "Atorvastatin Calcium",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 800,
                PackingUnit = "box",
                UnitsPerPack = 30, // Assuming 30 tablets per box
                PackingDescription = "Box of 30 tablets",
                SideEffect = "Muscle pain, digestive issues, liver enzyme changes",
                StorageInstruction = "Store at room temperature",
                Price = 180000
            },
            new MedicationModel
            {
                MedicationID = "med-omep-20",
                Name = "Omeprazole 20mg",
                ActiveIngredient = "Omeprazole",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 1200,
                PackingUnit = "bottle",
                UnitsPerPack = 28, // Assuming 28 capsules per bottle
                PackingDescription = "Bottle of 28 capsules",
                SideEffect = "Headache, nausea, diarrhea, stomach pain",
                StorageInstruction = "Keep away from light and moisture",
                Price = 95000
            },
            new MedicationModel
            {
                MedicationID = "med-salb-inhaler",
                Name = "Salbutamol Inhaler",
                ActiveIngredient = "Salbutamol Sulfate",
                Form = Form.Inhaler,
                BaseUnit = "mcg", // Micrograms per actuation
                StockTotalQuantity = 300,
                PackingUnit = "canister",
                UnitsPerPack = 200, // Assuming 200 actuations (doses) per canister
                PackingDescription = "Canister with 200 metered doses",
                SideEffect = "Tremors, nervousness, increased heart rate",
                StorageInstruction = "Store below 30°C, away from direct sunlight and heat",
                Price = 110000
            },
            new MedicationModel
            {
                MedicationID = "med-vit-c-500",
                Name = "Vitamin C 500mg",
                ActiveIngredient = "Ascorbic Acid",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 5000,
                PackingUnit = "bottle",
                UnitsPerPack = 100, // Assuming 100 tablets per bottle
                PackingDescription = "Bottle of 100 chewable tablets",
                SideEffect = "Stomach cramps, nausea (high dose)",
                StorageInstruction = "Keep tightly closed in a cool, dry place",
                Price = 60000
            }
        );
    }
    private static void SeedUsers(ModelBuilder modelBuilder)
    {
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
            },
            new UserModel
            {
                UserID = "user-pat-02",
                FirstName = "Alice",
                LastName = "Brown",
                Username = "alice.brown",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "alice.b@example.com",
                PhoneNumber = "0908887776",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-doc-02",
                FirstName = "James",
                LastName = "Wilson",
                Username = "dr.james",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "james.wilson@clinic.com",
                PhoneNumber = "0901112223",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-03",
                FirstName = "Michael",
                LastName = "Jordan",
                Username = "mike.j",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "mike.j@example.com",
                PhoneNumber = "0901122334",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-04",
                FirstName = "Emily",
                LastName = "Clark",
                Username = "emily.c",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "emily.c@example.com",
                PhoneNumber = "0909988776",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-doc-03",
                FirstName = "Gregory",
                LastName = "House",
                Username = "dr.house",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "house@clinic.com",
                PhoneNumber = "0906666666",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-doc-04",
                FirstName = "Meredith",
                LastName = "Grey",
                Username = "dr.grey",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "grey@clinic.com",
                PhoneNumber = "0907777777",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-phar-02",
                FirstName = "Lisa",
                LastName = "Wong",
                Username = "phar.lisa",
                PasswordHash = "Password123!",
                Role = UserRole.Pharmacist,
                Email = "lisa.w@pharmacy.com",
                PhoneNumber = "0904443332",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-05",
                FirstName = "Robert",
                LastName = "Taylor",
                Username = "robert.t",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "robert.t@example.com",
                PhoneNumber = "0903322110",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-06",
                FirstName = "Jennifer",
                LastName = "Martinez",
                Username = "jennifer.m",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "jennifer.m@example.com",
                PhoneNumber = "0902233445",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-07",
                FirstName = "William",
                LastName = "Anderson",
                Username = "william.a",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "william.a@example.com",
                PhoneNumber = "0901122558",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-08",
                FirstName = "Sophia",
                LastName = "Thomas",
                Username = "sophia.t",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "sophia.t@example.com",
                PhoneNumber = "0909988765",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-09",
                FirstName = "Daniel",
                LastName = "Jackson",
                Username = "daniel.j",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "daniel.j@example.com",
                PhoneNumber = "0908877654",
                IsActive = true
            },
            new UserModel
            {
                UserID = "user-pat-10",
                FirstName = "Olivia",
                LastName = "White",
                Username = "olivia.w",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "olivia.w@example.com",
                PhoneNumber = "0907766543",
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
            },
            new PatientModel
            {
                PatientID = "pat-02",
                UserID = "user-pat-02",
                DateOfBirth = new DateTime(1990, 8, 15, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Female,
                InsuranceNumber = "INS-987654",
                BloodType = "O-"
            },
            new PatientModel
            {
                PatientID = "pat-03",
                UserID = "user-pat-03",
                DateOfBirth = new DateTime(1975, 2, 14, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Male,
                InsuranceNumber = "INS-555666",
                BloodType = "AB-"
            },
            new PatientModel
            {
                PatientID = "pat-04",
                UserID = "user-pat-04",
                DateOfBirth = new DateTime(2015, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Female,
                InsuranceNumber = "INS-CHILD-01",
                BloodType = "B+"
            },
            new PatientModel
            {
                PatientID = "pat-05",
                UserID = "user-pat-05",
                DateOfBirth = new DateTime(1982, 11, 8, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Male,
                InsuranceNumber = "INS-777888",
                BloodType = "O+"
            },
            new PatientModel
            {
                PatientID = "pat-06",
                UserID = "user-pat-06",
                DateOfBirth = new DateTime(1995, 3, 22, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Female,
                InsuranceNumber = "INS-666555",
                BloodType = "A-"
            },
            new PatientModel
            {
                PatientID = "pat-07",
                UserID = "user-pat-07",
                DateOfBirth = new DateTime(1968, 7, 15, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Male,
                InsuranceNumber = "INS-444333",
                BloodType = "AB+"
            },
            new PatientModel
            {
                PatientID = "pat-08",
                UserID = "user-pat-08",
                DateOfBirth = new DateTime(2001, 9, 30, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Female,
                InsuranceNumber = "INS-222111",
                BloodType = "B-"
            },
            new PatientModel
            {
                PatientID = "pat-09",
                UserID = "user-pat-09",
                DateOfBirth = new DateTime(1978, 12, 5, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Male,
                InsuranceNumber = "INS-999000",
                BloodType = "O-"
            },
            new PatientModel
            {
                PatientID = "pat-10",
                UserID = "user-pat-10",
                DateOfBirth = new DateTime(1988, 4, 18, 0, 0, 0, DateTimeKind.Utc),
                Gender = Gender.Female,
                InsuranceNumber = "INS-111222",
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
            },
            new DoctorModel
            {
                DoctorID = "doc-02",
                UserID = "user-doc-02",
                Specialization = "Cardiologist",
                ConsultationFee = 500000,
                Rating = 4.9,
                YearsOfExperience = 15
            },
            new DoctorModel
            {
                DoctorID = "doc-03",
                UserID = "user-doc-03",
                Specialization = "Diagnostician",
                ConsultationFee = 1000000,
                Rating = 3.5,
                YearsOfExperience = 20
            },
            new DoctorModel
            {
                DoctorID = "doc-04",
                UserID = "user-doc-04",
                Specialization = "General Surgery",
                ConsultationFee = 600000,
                Rating = 4.9,
                YearsOfExperience = 8
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
            },
            new PharmacistModel
            {
                PharmacistID = "phar-02",
                UserID = "user-phar-02",
                Department = "Inpatient Pharmacy"
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
            },
            new AppointmentModel
            {
                AppointmentID = "appt-02",
                PatientID = "pat-02",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-2).AddHours(14),
                ChiefComplaint = "Regular checkup for hypertension.",
                Location = "Room 205",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-03",
                PatientID = "pat-03",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-5).AddHours(10),
                ChiefComplaint = "Chest pain after exercise.",
                Location = "Room 205",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 1
            },
                new AppointmentModel
                {
                    AppointmentID = "appt-04",
                    PatientID = "pat-04",
                    DoctorID = "doc-01",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(1).AddHours(9),
                    ChiefComplaint = "Vaccination schedule.",
                    Location = "Room 102",
                    Status = StatusAppointment.Scheduled,
                    Priority = Priority.Routine,
                    VisitNumber = 1
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-05",
                    PatientID = "pat-01",
                    DoctorID = "doc-03",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(-10).AddHours(14),
                    ChiefComplaint = "Unexplained leg pain.",
                    Location = "Room 303",
                    Status = StatusAppointment.Completed,
                    Priority = Priority.Stat,
                    VisitNumber = 2
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-06",
                    PatientID = "pat-02",
                    DoctorID = "doc-04",
                    AppointmentDateTime = DateTime.UtcNow.AddHours(2),
                    ChiefComplaint = "Follow up on surgical scar.",
                    Location = "Room 401",
                    Status = StatusAppointment.Scheduled,
                    Priority = Priority.Routine,
                    VisitNumber = 2
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-07",
                    PatientID = "pat-05",
                    DoctorID = "doc-01",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(-3).AddHours(11),
                    ChiefComplaint = "Migraine headaches for the past week.",
                    Location = "Room 103",
                    Status = StatusAppointment.Completed,
                    Priority = Priority.Routine,
                    VisitNumber = 1
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-08",
                    PatientID = "pat-06",
                    DoctorID = "doc-02",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(-7).AddHours(16),
                    ChiefComplaint = "Shortness of breath and fatigue.",
                    Location = "Room 206",
                    Status = StatusAppointment.Completed,
                    Priority = Priority.Urgent,
                    VisitNumber = 1
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-09",
                    PatientID = "pat-07",
                    DoctorID = "doc-03",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(-14).AddHours(13),
                    ChiefComplaint = "Chronic back pain radiating to legs.",
                    Location = "Room 304",
                    Status = StatusAppointment.Completed,
                    Priority = Priority.Routine,
                    VisitNumber = 1
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-10",
                    PatientID = "pat-08",
                    DoctorID = "doc-04",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(-4).AddHours(10),
                    ChiefComplaint = "Skin rash and itching.",
                    Location = "Room 402",
                    Status = StatusAppointment.Completed,
                    Priority = Priority.Routine,
                    VisitNumber = 1
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-11",
                    PatientID = "pat-09",
                    DoctorID = "doc-01",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(2).AddHours(14),
                    ChiefComplaint = "Annual health checkup.",
                    Location = "Room 104",
                    Status = StatusAppointment.Scheduled,
                    Priority = Priority.Routine,
                    VisitNumber = 1
                },
                new AppointmentModel
                {
                    AppointmentID = "appt-12",
                    PatientID = "pat-10",
                    DoctorID = "doc-02",
                    AppointmentDateTime = DateTime.UtcNow.AddDays(3).AddHours(9),
                    ChiefComplaint = "Abdominal pain and bloating.",
                    Location = "Room 207",
                    Status = StatusAppointment.Scheduled,
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
            },
            new MedicalRecordModel
            {
                RecordID = "rec-02",
                AppointmentID = "appt-02",
                VisitTime = DateTime.UtcNow.AddDays(-2).AddHours(14).AddMinutes(30),
                Diagnosis = "Essential Hypertension",
                TreatmentPlan = "Lifestyle modification and daily medication.",
                DoctorNotes = "BP slightly elevated. Monitoring required.",
                NextVisitDate = DateTime.UtcNow.AddMonths(1)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-03",
                AppointmentID = "appt-03",
                VisitTime = DateTime.UtcNow.AddDays(-5).AddHours(10).AddMinutes(30),
                Diagnosis = "Stable Angina",
                TreatmentPlan = "Prescribed statins and nitroglycerin. Cardiac stress test ordered.",
                DoctorNotes = "Patient needs to monitor heart rate.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-04",
                AppointmentID = "appt-05",
                VisitTime = DateTime.UtcNow.AddDays(-10).AddHours(15),
                Diagnosis = "Deep Vein Thrombosis (DVT)",
                TreatmentPlan = "Anticoagulant therapy immediately.",
                DoctorNotes = "Confirmed via Ultrasound.",
                NextVisitDate = DateTime.UtcNow.AddDays(3)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-05",
                AppointmentID = "appt-07",
                VisitTime = DateTime.UtcNow.AddDays(-3).AddHours(11).AddMinutes(20),
                Diagnosis = "Migraine with Aura",
                TreatmentPlan = "Triptan medication and lifestyle modifications.",
                DoctorNotes = "Patient advised to identify triggers.",
                NextVisitDate = DateTime.UtcNow.AddDays(30)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-06",
                AppointmentID = "appt-08",
                VisitTime = DateTime.UtcNow.AddDays(-7).AddHours(16).AddMinutes(25),
                Diagnosis = "Anemia",
                TreatmentPlan = "Iron supplements and dietary changes.",
                DoctorNotes = "Blood test shows low hemoglobin.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-07",
                AppointmentID = "appt-09",
                VisitTime = DateTime.UtcNow.AddDays(-14).AddHours(13).AddMinutes(30),
                Diagnosis = "Lumbar Disc Herniation",
                TreatmentPlan = "Physical therapy and pain management.",
                DoctorNotes = "MRI recommended if symptoms persist.",
                NextVisitDate = DateTime.UtcNow.AddDays(21)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-08",
                AppointmentID = "appt-10",
                VisitTime = DateTime.UtcNow.AddDays(-4).AddHours(10).AddMinutes(15),
                Diagnosis = "Contact Dermatitis",
                TreatmentPlan = "Topical corticosteroids and antihistamines.",
                DoctorNotes = "Avoid known irritants.",
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
                MedicalHistory = "",
                FamilyHistory = "Father has hypertension.",
                LifestyleHabits = "Non-smoker.",
                Allergies = "",
                Temperature = 38.2,
                Height = 175,
                Weight = 70,
                BMI = 23,
                StatusBMI = StatusBMI.Normal,
                Pulse = 85,
                BloodPressure = "120/80",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-02",
                RecordID = "rec-02",
                Symptoms = "Occasional headaches, dizziness.",
                MedicalHistory = "Diagnosed with hypertension 2 years ago.",
                FamilyHistory = "Mother has diabetes.",
                LifestyleHabits = "Sedentary lifestyle.",
                Allergies = "Penicillin.",
                Temperature = 36.8,
                Height = 162,
                Weight = 65,
                BMI = 24.8,
                StatusBMI = StatusBMI.Normal,
                Pulse = 78,
                BloodPressure = "145/95",
                RespiratoryRate = 18,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-03",
                RecordID = "rec-03",
                Symptoms = "Tightness in chest, shortness of breath on exertion.",
                MedicalHistory = "High cholesterol.",
                FamilyHistory = "Brother died of MI at 50.",
                LifestyleHabits = "Social smoker.",
                Allergies = "",
                Temperature = 37.0,
                Height = 198,
                Weight = 100,
                BMI = 25.4,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 92,
                BloodPressure = "150/95",
                RespiratoryRate = 20,
                OxygenSaturation = 96
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-04",
                RecordID = "rec-04",
                Symptoms = "Swelling in right calf, warm to touch.",
                MedicalHistory = "Recent long-haul flight.",
                FamilyHistory = "",
                LifestyleHabits = "Active.",
                Allergies = "Latex.",
                Temperature = 37.5,
                Height = 180,
                Weight = 80,
                BMI = 24.7,
                StatusBMI = StatusBMI.Normal,
                Pulse = 88,
                BloodPressure = "130/85",
                RespiratoryRate = 18,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-05",
                RecordID = "rec-05",
                Symptoms = "Severe headache with visual disturbances, nausea.",
                MedicalHistory = "History of occasional headaches.",
                FamilyHistory = "Mother has migraines.",
                LifestyleHabits = "High stress job.",
                Allergies = "",
                Temperature = 36.9,
                Height = 178,
                Weight = 75,
                BMI = 23.7,
                StatusBMI = StatusBMI.Normal,
                Pulse = 82,
                BloodPressure = "125/82",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-06",
                RecordID = "rec-06",
                Symptoms = "Fatigue, pale skin, shortness of breath on exertion.",
                MedicalHistory = "Heavy menstrual bleeding.",
                FamilyHistory = "",
                LifestyleHabits = "Vegetarian diet.",
                Allergies = "Shellfish.",
                Temperature = 36.5,
                Height = 165,
                Weight = 55,
                BMI = 20.2,
                StatusBMI = StatusBMI.Normal,
                Pulse = 95,
                BloodPressure = "110/70",
                RespiratoryRate = 18,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-07",
                RecordID = "rec-07",
                Symptoms = "Lower back pain, numbness in right leg.",
                MedicalHistory = "Previous back injury 5 years ago.",
                FamilyHistory = "Father has back problems.",
                LifestyleHabits = "Sedentary work, occasional exercise.",
                Allergies = "",
                Temperature = 37.1,
                Height = 172,
                Weight = 85,
                BMI = 28.7,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 76,
                BloodPressure = "135/88",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-08",
                RecordID = "rec-08",
                Symptoms = "Red rash on arms, itching, mild swelling.",
                MedicalHistory = "History of sensitive skin.",
                FamilyHistory = "",
                LifestyleHabits = "",
                Allergies = "Nickel, certain cosmetics.",
                Temperature = 36.8,
                Height = 170,
                Weight = 60,
                BMI = 20.8,
                StatusBMI = StatusBMI.Normal,
                Pulse = 78,
                BloodPressure = "118/75",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            }
        );
    }

    private static void SeedPrescriptions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrescriptionModel>().HasData(
            // 1. PENDING (New)
            new PrescriptionModel
            {
                PrescriptionID = "presc-01",
                RecordID = "rec-01",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(30),
                Status = PrescriptionStatus.Pending,
                PharmacistID = null!,
                VerifiedAt = null,
                Priority = Priority.Routine,
                DispensedAt = null,
                Reason = null,
                CancelledAt = null
            },
            // 2. DISPENSED (Done)
            new PrescriptionModel
            {
                PrescriptionID = "presc-02",
                RecordID = "rec-02",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-2).AddHours(15),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(30),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(45),
                Reason = null,
                CancelledAt = null
            },
            // 3. VERIFIED / COMPLETED (Ready for pickup)
            new PrescriptionModel
            {
                PrescriptionID = "presc-03",
                RecordID = "rec-03",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-5).AddHours(11),
                Status = PrescriptionStatus.Completed, // Or PrescriptionStatus.Completed
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(15),
                Priority = Priority.Urgent,
                DispensedAt = null,
                Reason = null,
                CancelledAt = null
            },
            // 4. CANCELLED (By System/Doctor)
            new PrescriptionModel
            {
                PrescriptionID = "presc-04",
                RecordID = "rec-04",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-10).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Cancelled,
                PharmacistID = null!,
                VerifiedAt = null,
                Priority = Priority.Stat,
                DispensedAt = null,
                Reason = "Duplicate prescription detected.",
                CancelledAt = DateTime.UtcNow.AddDays(-10).AddHours(16)
            },
            // 5. DISPENSED (Done)
            new PrescriptionModel
            {
                PrescriptionID = "presc-05",
                RecordID = "rec-05",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-3).AddHours(11).AddMinutes(45),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-3).AddHours(12),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-3).AddHours(12).AddMinutes(15),
                Reason = null,
                CancelledAt = null
            },
            // 6. PENDING (New)
            new PrescriptionModel
            {
                PrescriptionID = "presc-06",
                RecordID = "rec-06",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-7).AddHours(16).AddMinutes(45),
                Status = PrescriptionStatus.Pending,
                PharmacistID = null!,
                VerifiedAt = null,
                Priority = Priority.Urgent,
                DispensedAt = null,
                Reason = null,
                CancelledAt = null
            },
            // 7. VERIFIED / COMPLETED (Ready for pickup)
            new PrescriptionModel
            {
                PrescriptionID = "presc-07",
                RecordID = "rec-07",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-14).AddHours(14),
                Status = PrescriptionStatus.Completed, // Or PrescriptionStatus.Completed
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-14).AddHours(14).AddMinutes(30),
                Priority = Priority.Routine,
                DispensedAt = null,
                Reason = null,
                CancelledAt = null
            },
            // 8. CANCELLED (By Patient)
            new PrescriptionModel
            {
                PrescriptionID = "presc-08",
                RecordID = "rec-08",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-4).AddHours(10).AddMinutes(30),
                Status = PrescriptionStatus.Cancelled,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-4).AddHours(11),
                Priority = Priority.Routine,
                DispensedAt = null,
                Reason = "Patient refused medication due to cost.",
                CancelledAt = DateTime.UtcNow.AddDays(-4).AddHours(11).AddMinutes(10)
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
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}"
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
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-03",
                PrescriptionID = "presc-02",
                MedicationID = "med-met-850",
                Quantity = 60,
                Dosage = "850mg",
                Frequency = "Twice a day",
                DurationDays = 30,
                Instruction = "Take with meals to reduce stomach upset.",
                Indication = "Diabetes management.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-04",
                PrescriptionID = "presc-03",
                MedicationID = "med-ator-20",
                Quantity = 30,
                Dosage = "20mg",
                Frequency = "Once daily at night",
                DurationDays = 30,
                Instruction = "Avoid grapefruit juice.",
                Indication = "Cholesterol management.",
                DoseScheduleJSON = "{&quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-05",
                PrescriptionID = "presc-03",
                MedicationID = "med-omep-20",
                Quantity = 14,
                Dosage = "20mg",
                Frequency = "Once daily before breakfast",
                DurationDays = 14,
                Instruction = "Take 30 mins before food.",
                Indication = "Gastric protection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-06",
                PrescriptionID = "presc-04",
                MedicationID = "med-ibu-400",
                Quantity = 20,
                Dosage = "400mg",
                Frequency = "Every 6 hours",
                DurationDays = 5,
                Instruction = "Take with food.",
                Indication = "Pain relief.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1, &quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-07",
                PrescriptionID = "presc-05",
                MedicationID = "med-para-500",
                Quantity = 15,
                Dosage = "500mg",
                Frequency = "Every 6 hours as needed",
                DurationDays = 7,
                Instruction = "Take at onset of headache.",
                Indication = "Migraine pain relief.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-08",
                PrescriptionID = "presc-06",
                MedicationID = "med-cet-10",
                Quantity = 30,
                Dosage = "10mg",
                Frequency = "Once daily at night",
                DurationDays = 30,
                Instruction = "May cause drowsiness.",
                Indication = "Allergy management.",
                DoseScheduleJSON = "{&quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-09",
                PrescriptionID = "presc-07",
                MedicationID = "med-ibu-400",
                Quantity = 40,
                Dosage = "400mg",
                Frequency = "Every 8 hours as needed",
                DurationDays = 14,
                Instruction = "Take with meals.",
                Indication = "Back pain management.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-10",
                PrescriptionID = "presc-08",
                MedicationID = "med-omep-20",
                Quantity = 30,
                Dosage = "20mg",
                Frequency = "Once daily before breakfast",
                DurationDays = 30,
                Instruction = "Take 30 mins before food.",
                Indication = "Gastric protection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            }
        );
    }
    private static void SeedMedicationInteractions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationInteractionModel>().HasData(
            new MedicationInteractionModel
            {
                InteractionID = "int-01",
                Medication1ID = "med-ibu-400",
                Medication2ID = "med-met-850",
                Severity = Severity.Moderate,
                Description = "Potential reduction in renal function.",
                ClinicalEffects = "NSAIDs may impair renal function, increasing the risk of metformin-associated lactic acidosis.",
                Management = "Monitor renal function periodically."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-02",
                Medication1ID = "med-ator-20",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Altered absorption.",
                ClinicalEffects = "Omeprazole may slightly increase the serum concentration of Atorvastatin.",
                Management = "Monitor for statin-related side effects like muscle pain."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-03",
                Medication1ID = "med-ibu-400",
                Medication2ID = "med-ator-20",
                Severity = Severity.Mild,
                Description = "Potential reduced antihypertensive effect.",
                ClinicalEffects = "NSAIDs may reduce the cardiovascular protection of statins in high risk patients.",
                Management = "Use lowest effective dose of NSAID."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-04",
                Medication1ID = "med-amox-500",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Reduced antibiotic absorption.",
                ClinicalEffects = "Omeprazole may decrease the absorption of amoxicillin.",
                Management = "Separate administration by 2 hours if possible."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-05",
                Medication1ID = "med-para-500",
                Medication2ID = "med-ibu-400",
                Severity = Severity.Moderate,
                Description = "Increased risk of kidney damage.",
                ClinicalEffects = "Combined use may increase risk of renal toxicity.",
                Management = "Monitor kidney function, avoid prolonged use."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-06",
                Medication1ID = "med-cet-10",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Altered drug metabolism.",
                ClinicalEffects = "Omeprazole may increase cetirizine levels slightly.",
                Management = "Monitor for increased drowsiness."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-07",
                Medication1ID = "med-met-850",
                Medication2ID = "med-ator-20",
                Severity = Severity.Mild,
                Description = "Potential muscle effects.",
                ClinicalEffects = "Rare cases of increased muscle pain when combined.",
                Management = "Monitor for muscle symptoms."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-08",
                Medication1ID = "med-vit-c-500",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Reduced vitamin C absorption.",
                ClinicalEffects = "Omeprazole may decrease vitamin C absorption.",
                Management = "Take vitamin C supplements separately."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-09",
                Medication1ID = "med-amox-500",
                Medication2ID = "med-cet-10",
                Severity = Severity.Mild,
                Description = "No significant interaction.",
                ClinicalEffects = "Generally safe to use together.",
                Management = "No special precautions needed."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-10",
                Medication1ID = "med-met-850",
                Medication2ID = "med-ibu-400",
                Severity = Severity.Severe,
                Description = "High risk of lactic acidosis.",
                ClinicalEffects = "NSAIDs may significantly increase metformin levels.",
                Management = "Avoid combination if possible, monitor closely."
            }
        );
    }
    private static void SeedMedicationStockLogs(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationStockLogModel>().HasData(
            new MedicationStockLogModel
            {
                LogID = "log-01",
                MedicationID = "med-amox-500",
                QuantityChange = 1000,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-02",
                MedicationID = "med-ibu-400",
                QuantityChange = 500,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-03",
                MedicationID = "med-amox-500",
                QuantityChange = -21,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-01",
                CreatedAt = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(45)
            },
            new MedicationStockLogModel
            {
                LogID = "log-04",
                MedicationID = "med-ibu-400",
                QuantityChange = -10,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-01",
                CreatedAt = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(45)
            },
            new MedicationStockLogModel
            {
                LogID = "log-05",
                MedicationID = "med-met-850",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-02",
                CreatedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(45)
            },
            new MedicationStockLogModel
            {
                LogID = "log-06",
                MedicationID = "med-ator-20",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-03",
                CreatedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(30)
            },
            new MedicationStockLogModel
            {
                LogID = "log-07",
                MedicationID = "med-omep-20",
                QuantityChange = -14,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-03",
                CreatedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(30)
            },
            new MedicationStockLogModel
            {
                LogID = "log-08",
                MedicationID = "med-para-500",
                QuantityChange = 2000,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-09",
                MedicationID = "med-cet-10",
                QuantityChange = 2000,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-10",
                MedicationID = "med-para-500",
                QuantityChange = -15,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-05",
                CreatedAt = DateTime.UtcNow.AddDays(-3).AddHours(12).AddMinutes(15)
            },
            new MedicationStockLogModel
            {
                LogID = "log-11",
                MedicationID = "med-cet-10",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-06",
                CreatedAt = DateTime.UtcNow.AddDays(-7).AddHours(17).AddMinutes(20)
            },
            new MedicationStockLogModel
            {
                LogID = "log-12",
                MedicationID = "med-ibu-400",
                QuantityChange = -40,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-07",
                CreatedAt = DateTime.UtcNow
            },
            new MedicationStockLogModel
            {
                LogID = "log-13",
                MedicationID = "med-omep-20",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-08",
                CreatedAt = DateTime.UtcNow.AddDays(-4).AddHours(11).AddMinutes(25)
            }
        );
    }

    private static void SeedDoctorSchedules(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorScheduleModel>().HasData(
            new DoctorScheduleModel
            {
                ScheduleID = "sch-01",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(-1).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-1).Date.AddHours(17)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-02",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(1).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(1).Date.AddHours(17)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-03",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-2).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(-2).Date.AddHours(21)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-04",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-5).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-5).Date.AddHours(16)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-05",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(-10).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(-10).Date.AddHours(18)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-06",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.Date.AddHours(7),
                EndTime = DateTime.UtcNow.Date.AddHours(19)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-07",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(2).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(2).Date.AddHours(17)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-08",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.AddDays(3).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(3).Date.AddHours(16)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-09",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(4).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(4).Date.AddHours(17)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-10",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(5).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(5).Date.AddHours(21)
            }
        );
    }
}
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
            },
            new MedicationModel
            {
                MedicationID = "med-para-500",
                Name = "Paracetamol 500mg",
                Form = Form.Tablet,
                Unit = "mg",
                SideEffect = "Liver toxicity (high dose)",
                StorageInstruction = "Store in cool place",
                StockQuantity = 2000,
                StockQuantityUnit = "box",
                Price = 50000
            },
            new MedicationModel
            {
                MedicationID = "med-met-850",
                Name = "Metformin 850mg",
                Form = Form.Tablet,
                Unit = "mg",
                SideEffect = "Nausea, gastrointestinal disturbance",
                StorageInstruction = "Store at room temperature",
                StockQuantity = 800,
                StockQuantityUnit = "box",
                Price = 120000
            },
            new MedicationModel
            {
                MedicationID = "med-cet-10",
                Name = "Cetirizine 10mg",
                Form = Form.Tablet,
                Unit = "mg",
                SideEffect = "Drowsiness, dry mouth",
                StorageInstruction = "Store in dry place",
                StockQuantity = 2000,
                StockQuantityUnit = "blister",
                Price = 45000
            },
            new MedicationModel
            {
                MedicationID = "med-ator-20",
                Name = "Atorvastatin 20mg",
                Form = Form.Tablet,
                Unit = "mg",
                SideEffect = "Muscle pain, digestive issues",
                StorageInstruction = "Store at room temperature",
                StockQuantity = 800,
                StockQuantityUnit = "box",
                Price = 180000
            },
            new MedicationModel
            {
                MedicationID = "med-omep-20",
                Name = "Omeprazole 20mg",
                Form = Form.Capsule,
                Unit = "mg",
                SideEffect = "Headache, nausea",
                StorageInstruction = "Keep away from light",
                StockQuantity = 1200,
                StockQuantityUnit = "bottle",
                Price = 95000
            },
            new MedicationModel
            {
                MedicationID = "med-salb-inhaler",
                Name = "Salbutamol Inhaler",
                Form = Form.Inhaler,
                Unit = "mcg",
                SideEffect = "Tremors, nervousness",
                StorageInstruction = "Store below 30°C",
                StockQuantity = 300,
                StockQuantityUnit = "canister",
                Price = 110000
            },
            new MedicationModel
            {
                MedicationID = "med-vit-c-500",
                Name = "Vitamin C 500mg",
                Form = Form.Tablet,
                Unit = "mg",
                SideEffect = "Stomach cramps (high dose)",
                StorageInstruction = "Keep tightly closed",
                StockQuantity = 5000,
                StockQuantityUnit = "bottle",
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
                Allergies = "None.",
                Temperature = 37.0,
                Height = 198,
                Weight = 100,
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
                FamilyHistory = "Unknown.",
                LifestyleHabits = "Active.",
                Allergies = "Latex.",
                Temperature = 37.5,
                Height = 180,
                Weight = 80,
                Pulse = 88,
                BloodPressure = "130/85",
                RespiratoryRate = 18,
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
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-02",
                RecordID = "rec-02",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-2).AddHours(15),
                Status = PrescriptionStatus.Verified,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(30),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(45)
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-03",
                RecordID = "rec-03",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-5).AddHours(11),
                Status = PrescriptionStatus.Verified,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(15),
                Priority = Priority.Urgent,
                DispensedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(30)
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-04",
                RecordID = "rec-04",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-10).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Cancelled,
                PharmacistID = null!,
                VerifiedAt = DateTime.UtcNow.AddDays(-10).AddHours(16),
                Priority = Priority.Stat,
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
                DoseScheduleJSON = "{\"morning\": 1, \"evening\": 1}"
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
                DoseScheduleJSON = "{\"night\": 1}"
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
                DoseScheduleJSON = "{\"morning\": 1}"
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
                DoseScheduleJSON = "{\"morning\": 1, \"afternoon\": 1, \"evening\": 1, \"night\": 1}"
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
            }
        );
    }
}

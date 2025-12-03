using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 18, 23, 12, 235, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 12, 1, 18, 38, 12, 235, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "Form", "Name", "Price", "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[,]
                {
                    { "med-ator-20", 0, "Atorvastatin 20mg", 180000, "Muscle pain, digestive issues", 800, "box", "Store at room temperature", "mg" },
                    { "med-cet-10", 0, "Cetirizine 10mg", 45000, "Drowsiness, dry mouth", 2000, "blister", "Store in dry place", "mg" },
                    { "med-met-850", 0, "Metformin 850mg", 120000, "Nausea, gastrointestinal disturbance", 800, "box", "Store at room temperature", "mg" },
                    { "med-omep-20", 1, "Omeprazole 20mg", 95000, "Headache, nausea", 1200, "bottle", "Keep away from light", "mg" },
                    { "med-para-500", 0, "Paracetamol 500mg", 50000, "Liver toxicity (high dose)", 2000, "box", "Store in cool place", "mg" },
                    { "med-salb-inhaler", 6, "Salbutamol Inhaler", 110000, "Tremors, nervousness", 300, "canister", "Store below 30°C", "mcg" },
                    { "med-vit-c-500", 0, "Vitamin C 500mg", 60000, "Stomach cramps (high dose)", 5000, "bottle", "Keep tightly closed", "mg" }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 12, 1, 18, 53, 12, 235, DateTimeKind.Utc).AddTicks(7244), new DateTime(2025, 12, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { "user-doc-02", "james.wilson@clinic.com", "James", true, "Wilson", "Password123!", "0901112223", 1, "dr.james" },
                    { "user-doc-03", "house@clinic.com", "Gregory", true, "House", "Password123!", "0906666666", 1, "dr.house" },
                    { "user-doc-04", "grey@clinic.com", "Meredith", true, "Grey", "Password123!", "0907777777", 1, "dr.grey" },
                    { "user-pat-02", "alice.b@example.com", "Alice", true, "Brown", "Password123!", "0908887776", 0, "alice.brown" },
                    { "user-pat-03", "mike.j@example.com", "Michael", true, "Jordan", "Password123!", "0901122334", 0, "mike.j" },
                    { "user-pat-04", "emily.c@example.com", "Emily", true, "Clark", "Password123!", "0909988776", 0, "emily.c" },
                    { "user-phar-02", "lisa.w@pharmacy.com", "Lisa", true, "Wong", "Password123!", "0904443332", 2, "phar.lisa" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorID", "ConsultationFee", "Rating", "Specialization", "UserID", "YearsOfExperience" },
                values: new object[,]
                {
                    { "doc-02", 500000.0, 4.9000000000000004, "Cardiologist", "user-doc-02", 15 },
                    { "doc-03", 1000000.0, 3.5, "Diagnostician", "user-doc-03", 20 },
                    { "doc-04", 600000.0, 4.9000000000000004, "General Surgery", "user-doc-04", 8 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "BloodType", "DateOfBirth", "Gender", "InsuranceNumber", "UserID" },
                values: new object[,]
                {
                    { "pat-02", "O-", new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), 1, "INS-987654", "user-pat-02" },
                    { "pat-03", "AB-", new DateTime(1975, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), 0, "INS-555666", "user-pat-03" },
                    { "pat-04", "B+", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "INS-CHILD-01", "user-pat-04" }
                });

            migrationBuilder.InsertData(
                table: "Pharmacists",
                columns: new[] { "PharmacistID", "Department", "UserID" },
                values: new object[] { "phar-02", "Inpatient Pharmacy", "user-phar-02" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentDateTime", "ChiefComplaint", "DoctorID", "Location", "Note", "PatientID", "Priority", "Status", "VisitNumber" },
                values: new object[,]
                {
                    { "appt-02", new DateTime(2025, 11, 30, 23, 23, 12, 235, DateTimeKind.Utc).AddTicks(7087), "Regular checkup for hypertension.", "doc-02", "Room 205", "", "pat-02", 0, 2, 1 },
                    { "appt-03", new DateTime(2025, 11, 27, 19, 23, 12, 235, DateTimeKind.Utc).AddTicks(7091), "Chest pain after exercise.", "doc-02", "Room 205", "", "pat-03", 1, 2, 1 },
                    { "appt-04", new DateTime(2025, 12, 3, 18, 23, 12, 235, DateTimeKind.Utc).AddTicks(7094), "Vaccination schedule.", "doc-01", "Room 102", "", "pat-04", 0, 0, 1 },
                    { "appt-05", new DateTime(2025, 11, 22, 23, 23, 12, 235, DateTimeKind.Utc).AddTicks(7096), "Unexplained leg pain.", "doc-03", "Room 303", "", "pat-01", 2, 2, 2 },
                    { "appt-06", new DateTime(2025, 12, 2, 11, 23, 12, 235, DateTimeKind.Utc).AddTicks(7099), "Follow up on surgical scar.", "doc-04", "Room 401", "", "pat-02", 0, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "RecordID", "AppointmentID", "Diagnosis", "DoctorNotes", "NextVisitDate", "TreatmentPlan", "VisitTime" },
                values: new object[,]
                {
                    { "rec-02", "appt-02", "Essential Hypertension", "BP slightly elevated. Monitoring required.", new DateTime(2026, 1, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7142), "Lifestyle modification and daily medication.", new DateTime(2025, 11, 30, 23, 53, 12, 235, DateTimeKind.Utc).AddTicks(7140) },
                    { "rec-03", "appt-03", "Stable Angina", "Patient needs to monitor heart rate.", new DateTime(2025, 12, 16, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7166), "Prescribed statins and nitroglycerin. Cardiac stress test ordered.", new DateTime(2025, 11, 27, 19, 53, 12, 235, DateTimeKind.Utc).AddTicks(7164) },
                    { "rec-04", "appt-05", "Deep Vein Thrombosis (DVT)", "Confirmed via Ultrasound.", new DateTime(2025, 12, 5, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7169), "Anticoagulant therapy immediately.", new DateTime(2025, 11, 23, 0, 23, 12, 235, DateTimeKind.Utc).AddTicks(7168) }
                });

            migrationBuilder.InsertData(
                table: "ClinicalExaminations",
                columns: new[] { "ClinicalID", "Allergies", "BloodPressure", "FamilyHistory", "Height", "LifestyleHabits", "MedicalHistory", "OxygenSaturation", "Pulse", "RecordID", "RespiratoryRate", "Symptoms", "Temperature", "Weight" },
                values: new object[,]
                {
                    { "clin-02", "Penicillin.", "145/95", "Mother has diabetes.", 162.0, "Sedentary lifestyle.", "Diagnosed with hypertension 2 years ago.", 99.0, 78.0, "rec-02", 18.0, "Occasional headaches, dizziness.", 36.799999999999997, 65.0 },
                    { "clin-03", "None.", "150/95", "Brother died of MI at 50.", 198.0, "Social smoker.", "High cholesterol.", 96.0, 92.0, "rec-03", 20.0, "Tightness in chest, shortness of breath on exertion.", 37.0, 100.0 },
                    { "clin-04", "Latex.", "130/85", "Unknown.", 180.0, "Active.", "Recent long-haul flight.", 98.0, 88.0, "rec-04", 18.0, "Swelling in right calf, warm to touch.", 37.5, 80.0 }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionID", "DispensedAt", "PharmacistID", "PrescriptionDateTime", "Priority", "RecordID", "Status", "VerifiedAt" },
                values: new object[,]
                {
                    { "presc-02", new DateTime(2025, 12, 1, 1, 8, 12, 235, DateTimeKind.Utc).AddTicks(7257), "phar-01", new DateTime(2025, 12, 1, 0, 23, 12, 235, DateTimeKind.Utc).AddTicks(7255), 0, "rec-02", 1, new DateTime(2025, 12, 1, 0, 53, 12, 235, DateTimeKind.Utc).AddTicks(7256) },
                    { "presc-03", new DateTime(2025, 11, 27, 20, 53, 12, 235, DateTimeKind.Utc).AddTicks(7262), "phar-02", new DateTime(2025, 11, 27, 20, 23, 12, 235, DateTimeKind.Utc).AddTicks(7260), 1, "rec-03", 1, new DateTime(2025, 11, 27, 20, 38, 12, 235, DateTimeKind.Utc).AddTicks(7261) },
                    { "presc-04", new DateTime(2025, 12, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7267), null, new DateTime(2025, 11, 23, 0, 53, 12, 235, DateTimeKind.Utc).AddTicks(7265), 2, "rec-04", 3, new DateTime(2025, 11, 23, 1, 23, 12, 235, DateTimeKind.Utc).AddTicks(7266) }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionItems",
                columns: new[] { "ItemID", "Dosage", "DoseScheduleJSON", "DurationDays", "Frequency", "Indication", "Instruction", "MedicationID", "PrescriptionID", "Quantity" },
                values: new object[,]
                {
                    { "pi-03", "850mg", "{\"morning\": 1, \"evening\": 1}", 30, "Twice a day", "Diabetes management.", "Take with meals to reduce stomach upset.", "med-met-850", "presc-02", 60 },
                    { "pi-04", "20mg", "{\"night\": 1}", 30, "Once daily at night", "Cholesterol management.", "Avoid grapefruit juice.", "med-ator-20", "presc-03", 30 },
                    { "pi-05", "20mg", "{\"morning\": 1}", 14, "Once daily before breakfast", "Gastric protection.", "Take 30 mins before food.", "med-omep-20", "presc-03", 14 },
                    { "pi-06", "400mg", "{\"morning\": 1, \"afternoon\": 1, \"evening\": 1, \"night\": 1}", 5, "Every 6 hours", "Pain relief.", "Take with food.", "med-ibu-400", "presc-04", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-02");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-03");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-04");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-cet-10");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-para-500");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-salb-inhaler");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vit-c-500");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-03");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-04");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-05");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-06");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorID",
                keyValue: "doc-04");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ator-20");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-met-850");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-omep-20");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-04");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04");

            migrationBuilder.DeleteData(
                table: "Pharmacists",
                keyColumn: "PharmacistID",
                keyValue: "phar-02");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-04");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-04");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-phar-02");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorID",
                keyValue: "doc-02");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorID",
                keyValue: "doc-03");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-02");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-03");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-02");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-03");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-02");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-03");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 17, 42, 24, 502, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 9, 8, 42, 24, 502, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 12, 1, 17, 57, 24, 502, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 8, 42, 24, 502, DateTimeKind.Utc).AddTicks(8941), new DateTime(2025, 12, 1, 18, 12, 24, 502, DateTimeKind.Utc).AddTicks(8939), new DateTime(2025, 12, 2, 8, 42, 24, 502, DateTimeKind.Utc).AddTicks(8940) });
        }
    }
}

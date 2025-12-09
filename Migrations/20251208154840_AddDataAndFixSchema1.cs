using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAndFixSchema1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledAt",
                table: "Prescriptions",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Prescriptions",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 0, 48, 39, 328, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 5, 48, 39, 328, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 1, 48, 39, 328, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 0, 48, 39, 328, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 5, 48, 39, 328, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 17, 48, 39, 328, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-01",
                columns: new[] { "Allergies", "MedicalHistory" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-03",
                column: "Allergies",
                value: "");

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-04",
                column: "FamilyHistory",
                value: "");

            migrationBuilder.InsertData(
                table: "DoctorSchedules",
                columns: new[] { "ScheduleID", "DoctorID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { "sch-09", "doc-01", new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-10", "doc-02", new DateTime(2025, 12, 13, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 15, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 12, 8, 1, 3, 39, 328, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(857), new DateTime(2025, 12, 7, 6, 18, 39, 328, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(868), new DateTime(2025, 12, 4, 2, 18, 39, 328, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 11, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 11, 29, 6, 48, 39, 328, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.InsertData(
                table: "MedicationInteractions",
                columns: new[] { "InteractionID", "ClinicalEffects", "Description", "Management", "Medication1ID", "Medication2ID", "Severity" },
                values: new object[,]
                {
                    { "int-04", "Omeprazole may decrease the absorption of amoxicillin.", "Reduced antibiotic absorption.", "Separate administration by 2 hours if possible.", "med-amox-500", "med-omep-20", 0 },
                    { "int-05", "Combined use may increase risk of renal toxicity.", "Increased risk of kidney damage.", "Monitor kidney function, avoid prolonged use.", "med-para-500", "med-ibu-400", 1 },
                    { "int-06", "Omeprazole may increase cetirizine levels slightly.", "Altered drug metabolism.", "Monitor for increased drowsiness.", "med-cet-10", "med-omep-20", 0 },
                    { "int-07", "Rare cases of increased muscle pain when combined.", "Potential muscle effects.", "Monitor for muscle symptoms.", "med-met-850", "med-ator-20", 0 },
                    { "int-08", "Omeprazole may decrease vitamin C absorption.", "Reduced vitamin C absorption.", "Take vitamin C supplements separately.", "med-vit-c-500", "med-omep-20", 0 },
                    { "int-09", "Generally safe to use together.", "No significant interaction.", "No special precautions needed.", "med-amox-500", "med-cet-10", 0 },
                    { "int-10", "NSAIDs may significantly increase metformin levels.", "High risk of lactic acidosis.", "Avoid combination if possible, monitor closely.", "med-met-850", "med-ibu-400", 2 }
                });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 1, 33, 39, 328, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 1, 33, 39, 328, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 7, 33, 39, 328, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 3, 18, 39, 328, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 3, 18, 39, 328, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.InsertData(
                table: "MedicationStockLogs",
                columns: new[] { "LogID", "CreatedAt", "MedicationID", "QuantityChange", "Reason", "RelatedPrescriptionID" },
                values: new object[,]
                {
                    { "log-08", new DateTime(2025, 11, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1571), "med-para-500", 2000, "Initial Stock Import", null },
                    { "log-09", new DateTime(2025, 11, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1575), "med-cet-10", 2000, "Initial Stock Import", null }
                });

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-01",
                column: "DoseScheduleJSON",
                value: "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-02",
                column: "DoseScheduleJSON",
                value: "{&quot;as_needed&quot;: true}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-03",
                column: "DoseScheduleJSON",
                value: "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-04",
                column: "DoseScheduleJSON",
                value: "{&quot;night&quot;: 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-05",
                column: "DoseScheduleJSON",
                value: "{&quot;morning&quot;: 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-06",
                column: "DoseScheduleJSON",
                value: "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1, &quot;night&quot;: 1}");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "CancelledAt", "DispensedAt", "PrescriptionDateTime", "Reason", "VerifiedAt" },
                values: new object[] { null, null, new DateTime(2025, 12, 8, 1, 18, 39, 328, DateTimeKind.Utc).AddTicks(1060), null, null });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "CancelledAt", "DispensedAt", "PrescriptionDateTime", "Reason", "Status", "VerifiedAt" },
                values: new object[] { null, new DateTime(2025, 12, 7, 7, 33, 39, 328, DateTimeKind.Utc).AddTicks(1080), new DateTime(2025, 12, 7, 6, 48, 39, 328, DateTimeKind.Utc).AddTicks(1070), null, 2, new DateTime(2025, 12, 7, 7, 18, 39, 328, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "CancelledAt", "DispensedAt", "PrescriptionDateTime", "Reason", "VerifiedAt" },
                values: new object[] { null, null, new DateTime(2025, 12, 4, 2, 48, 39, 328, DateTimeKind.Utc).AddTicks(1085), null, new DateTime(2025, 12, 4, 3, 3, 39, 328, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "DispensedAt", "PrescriptionDateTime", "Reason", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 7, 48, 39, 328, DateTimeKind.Utc).AddTicks(1096), null, new DateTime(2025, 11, 29, 7, 18, 39, 328, DateTimeKind.Utc).AddTicks(1092), "Duplicate prescription detected.", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { "user-pat-05", "robert.t@example.com", "Robert", true, "Taylor", "Password123!", "0903322110", 0, "robert.t" },
                    { "user-pat-06", "jennifer.m@example.com", "Jennifer", true, "Martinez", "Password123!", "0902233445", 0, "jennifer.m" },
                    { "user-pat-07", "william.a@example.com", "William", true, "Anderson", "Password123!", "0901122558", 0, "william.a" },
                    { "user-pat-08", "sophia.t@example.com", "Sophia", true, "Thomas", "Password123!", "0909988765", 0, "sophia.t" },
                    { "user-pat-09", "daniel.j@example.com", "Daniel", true, "Jackson", "Password123!", "0908877654", 0, "daniel.j" },
                    { "user-pat-10", "olivia.w@example.com", "Olivia", true, "White", "Password123!", "0907766543", 0, "olivia.w" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "BloodType", "DateOfBirth", "Gender", "InsuranceNumber", "UserID" },
                values: new object[,]
                {
                    { "pat-05", "O+", new DateTime(1982, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), 0, "INS-777888", "user-pat-05" },
                    { "pat-06", "A-", new DateTime(1995, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), 1, "INS-666555", "user-pat-06" },
                    { "pat-07", "AB+", new DateTime(1968, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, "INS-444333", "user-pat-07" },
                    { "pat-08", "B-", new DateTime(2001, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), 1, "INS-222111", "user-pat-08" },
                    { "pat-09", "O-", new DateTime(1978, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), 0, "INS-999000", "user-pat-09" },
                    { "pat-10", "A+", new DateTime(1988, 4, 18, 0, 0, 0, 0, DateTimeKind.Utc), 1, "INS-111222", "user-pat-10" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentDateTime", "ChiefComplaint", "DoctorID", "Location", "Note", "PatientID", "Priority", "Status", "VisitNumber" },
                values: new object[,]
                {
                    { "appt-07", new DateTime(2025, 12, 6, 2, 48, 39, 328, DateTimeKind.Utc).AddTicks(751), "Migraine headaches for the past week.", "doc-01", "Room 103", "", "pat-05", 0, 2, 1 },
                    { "appt-08", new DateTime(2025, 12, 2, 7, 48, 39, 328, DateTimeKind.Utc).AddTicks(757), "Shortness of breath and fatigue.", "doc-02", "Room 206", "", "pat-06", 1, 2, 1 },
                    { "appt-09", new DateTime(2025, 11, 25, 4, 48, 39, 328, DateTimeKind.Utc).AddTicks(762), "Chronic back pain radiating to legs.", "doc-03", "Room 304", "", "pat-07", 0, 2, 1 },
                    { "appt-10", new DateTime(2025, 12, 5, 1, 48, 39, 328, DateTimeKind.Utc).AddTicks(768), "Skin rash and itching.", "doc-04", "Room 402", "", "pat-08", 0, 2, 1 },
                    { "appt-11", new DateTime(2025, 12, 11, 5, 48, 39, 328, DateTimeKind.Utc).AddTicks(773), "Annual health checkup.", "doc-01", "Room 104", "", "pat-09", 0, 0, 1 },
                    { "appt-12", new DateTime(2025, 12, 12, 0, 48, 39, 328, DateTimeKind.Utc).AddTicks(779), "Abdominal pain and bloating.", "doc-02", "Room 207", "", "pat-10", 0, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "RecordID", "AppointmentID", "Diagnosis", "DoctorNotes", "NextVisitDate", "TreatmentPlan", "VisitTime" },
                values: new object[,]
                {
                    { "rec-05", "appt-07", "Migraine with Aura", "Patient advised to identify triggers.", new DateTime(2026, 1, 7, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(881), "Triptan medication and lifestyle modifications.", new DateTime(2025, 12, 6, 3, 8, 39, 328, DateTimeKind.Utc).AddTicks(878) },
                    { "rec-06", "appt-08", "Anemia", "Blood test shows low hemoglobin.", new DateTime(2025, 12, 22, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(886), "Iron supplements and dietary changes.", new DateTime(2025, 12, 2, 8, 13, 39, 328, DateTimeKind.Utc).AddTicks(884) },
                    { "rec-07", "appt-09", "Lumbar Disc Herniation", "MRI recommended if symptoms persist.", new DateTime(2025, 12, 29, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(893), "Physical therapy and pain management.", new DateTime(2025, 11, 25, 5, 18, 39, 328, DateTimeKind.Utc).AddTicks(890) },
                    { "rec-08", "appt-10", "Contact Dermatitis", "Avoid known irritants.", new DateTime(2025, 12, 15, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(899), "Topical corticosteroids and antihistamines.", new DateTime(2025, 12, 5, 2, 3, 39, 328, DateTimeKind.Utc).AddTicks(896) }
                });

            migrationBuilder.InsertData(
                table: "ClinicalExaminations",
                columns: new[] { "ClinicalID", "Allergies", "BMI", "BloodPressure", "FamilyHistory", "Height", "LifestyleHabits", "MedicalHistory", "OxygenSaturation", "Pulse", "RecordID", "RespiratoryRate", "StatusBMI", "Symptoms", "Temperature", "Weight" },
                values: new object[,]
                {
                    { "clin-05", "", 23.699999999999999, "125/82", "Mother has migraines.", 178.0, "High stress job.", "History of occasional headaches.", 99.0, 82.0, "rec-05", 16.0, 1, "Severe headache with visual disturbances, nausea.", 36.899999999999999, 75.0 },
                    { "clin-06", "Shellfish.", 20.199999999999999, "110/70", "", 165.0, "Vegetarian diet.", "Heavy menstrual bleeding.", 98.0, 95.0, "rec-06", 18.0, 1, "Fatigue, pale skin, shortness of breath on exertion.", 36.5, 55.0 },
                    { "clin-07", "", 28.699999999999999, "135/88", "Father has back problems.", 172.0, "Sedentary work, occasional exercise.", "Previous back injury 5 years ago.", 99.0, 76.0, "rec-07", 16.0, 2, "Lower back pain, numbness in right leg.", 37.100000000000001, 85.0 },
                    { "clin-08", "Nickel, certain cosmetics.", 20.800000000000001, "118/75", "", 170.0, "", "History of sensitive skin.", 99.0, 78.0, "rec-08", 16.0, 1, "Red rash on arms, itching, mild swelling.", 36.799999999999997, 60.0 }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionID", "CancelledAt", "DispensedAt", "PharmacistID", "PrescriptionDateTime", "Priority", "Reason", "RecordID", "Status", "VerifiedAt" },
                values: new object[,]
                {
                    { "presc-05", null, new DateTime(2025, 12, 6, 4, 3, 39, 328, DateTimeKind.Utc).AddTicks(1104), "phar-01", new DateTime(2025, 12, 6, 3, 33, 39, 328, DateTimeKind.Utc).AddTicks(1100), 0, null, "rec-05", 2, new DateTime(2025, 12, 6, 3, 48, 39, 328, DateTimeKind.Utc).AddTicks(1102) },
                    { "presc-06", null, null, null, new DateTime(2025, 12, 2, 8, 33, 39, 328, DateTimeKind.Utc).AddTicks(1109), 1, null, "rec-06", 0, null },
                    { "presc-07", null, null, "phar-01", new DateTime(2025, 11, 25, 5, 48, 39, 328, DateTimeKind.Utc).AddTicks(1116), 0, null, "rec-07", 1, new DateTime(2025, 11, 25, 6, 18, 39, 328, DateTimeKind.Utc).AddTicks(1117) },
                    { "presc-08", new DateTime(2025, 12, 5, 2, 58, 39, 328, DateTimeKind.Utc).AddTicks(1183), null, "phar-02", new DateTime(2025, 12, 5, 2, 18, 39, 328, DateTimeKind.Utc).AddTicks(1178), 0, "Patient refused medication due to cost.", "rec-08", 3, new DateTime(2025, 12, 5, 2, 48, 39, 328, DateTimeKind.Utc).AddTicks(1180) }
                });

            migrationBuilder.InsertData(
                table: "MedicationStockLogs",
                columns: new[] { "LogID", "CreatedAt", "MedicationID", "QuantityChange", "Reason", "RelatedPrescriptionID" },
                values: new object[,]
                {
                    { "log-10", new DateTime(2025, 12, 6, 4, 3, 39, 328, DateTimeKind.Utc).AddTicks(1578), "med-para-500", -15, "Dispensed to Patient", "presc-05" },
                    { "log-11", new DateTime(2025, 12, 2, 9, 8, 39, 328, DateTimeKind.Utc).AddTicks(1583), "med-cet-10", -30, "Dispensed to Patient", "presc-06" },
                    { "log-12", new DateTime(2025, 12, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1587), "med-ibu-400", -40, "Dispensed to Patient", "presc-07" },
                    { "log-13", new DateTime(2025, 12, 5, 3, 13, 39, 328, DateTimeKind.Utc).AddTicks(1590), "med-omep-20", -30, "Dispensed to Patient", "presc-08" }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionItems",
                columns: new[] { "ItemID", "Dosage", "DoseScheduleJSON", "DurationDays", "Frequency", "Indication", "Instruction", "MedicationID", "PrescriptionID", "Quantity" },
                values: new object[,]
                {
                    { "pi-07", "500mg", "{&quot;as_needed&quot;: true}", 7, "Every 6 hours as needed", "Migraine pain relief.", "Take at onset of headache.", "med-para-500", "presc-05", 15 },
                    { "pi-08", "10mg", "{&quot;night&quot;: 1}", 30, "Once daily at night", "Allergy management.", "May cause drowsiness.", "med-cet-10", "presc-06", 30 },
                    { "pi-09", "400mg", "{&quot;as_needed&quot;: true}", 14, "Every 8 hours as needed", "Back pain management.", "Take with meals.", "med-ibu-400", "presc-07", 40 },
                    { "pi-10", "20mg", "{&quot;morning&quot;: 1}", 30, "Once daily before breakfast", "Gastric protection.", "Take 30 mins before food.", "med-omep-20", "presc-08", 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-05");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-06");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-07");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-08");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-04");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-05");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-06");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-07");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-08");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-09");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-10");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-07");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-08");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-09");

            migrationBuilder.DeleteData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-10");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-09");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-10");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-09");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-10");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-05");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-06");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-07");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-08");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-05");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-06");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-07");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-08");

            migrationBuilder.DropColumn(
                name: "CancelledAt",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Prescriptions");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 22, 12, 9, 224, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 3, 12, 9, 224, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 23, 12, 9, 224, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 22, 12, 9, 224, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 3, 12, 9, 224, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 15, 12, 9, 224, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-01",
                columns: new[] { "Allergies", "MedicalHistory" },
                values: new object[] { "No known allergies.", "None relevant." });

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-03",
                column: "Allergies",
                value: "None.");

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-04",
                column: "FamilyHistory",
                value: "Unknown.");

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1740), new DateTime(2025, 12, 7, 22, 27, 9, 224, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1744), new DateTime(2025, 12, 7, 3, 42, 9, 224, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1750), new DateTime(2025, 12, 3, 23, 42, 9, 224, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 11, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1753), new DateTime(2025, 11, 29, 4, 12, 9, 224, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 22, 57, 9, 224, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 22, 57, 9, 224, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 4, 57, 9, 224, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 0, 42, 9, 224, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 0, 42, 9, 224, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-01",
                column: "DoseScheduleJSON",
                value: "{\"morning\": 1, \"afternoon\": 1, \"evening\": 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-02",
                column: "DoseScheduleJSON",
                value: "{\"as_needed\": true}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-03",
                column: "DoseScheduleJSON",
                value: "{\"morning\": 1, \"evening\": 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-04",
                column: "DoseScheduleJSON",
                value: "{\"night\": 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-05",
                column: "DoseScheduleJSON",
                value: "{\"morning\": 1}");

            migrationBuilder.UpdateData(
                table: "PrescriptionItems",
                keyColumn: "ItemID",
                keyValue: "pi-06",
                column: "DoseScheduleJSON",
                value: "{\"morning\": 1, \"afternoon\": 1, \"evening\": 1, \"night\": 1}");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1840), new DateTime(2025, 12, 7, 22, 42, 9, 224, DateTimeKind.Utc).AddTicks(1831), new DateTime(2025, 12, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "Status", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 4, 57, 9, 224, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 12, 7, 4, 12, 9, 224, DateTimeKind.Utc).AddTicks(1843), 1, new DateTime(2025, 12, 7, 4, 42, 9, 224, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 42, 9, 224, DateTimeKind.Utc).AddTicks(1849), new DateTime(2025, 12, 4, 0, 12, 9, 224, DateTimeKind.Utc).AddTicks(1847), new DateTime(2025, 12, 4, 0, 27, 9, 224, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1853), new DateTime(2025, 11, 29, 4, 42, 9, 224, DateTimeKind.Utc).AddTicks(1851), new DateTime(2025, 11, 29, 5, 12, 9, 224, DateTimeKind.Utc).AddTicks(1852) });
        }
    }
}

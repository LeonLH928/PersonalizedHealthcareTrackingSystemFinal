using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class FixSchemaAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicationInteractions_Medications_MedicationID1",
                table: "MedicationInteractions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationInteractions_Medications_MedicationID2",
                table: "MedicationInteractions");

            migrationBuilder.RenameColumn(
                name: "InteractionId",
                table: "MedicationInteractions",
                newName: "InteractionID");

            migrationBuilder.RenameColumn(
                name: "MedicationID2",
                table: "MedicationInteractions",
                newName: "Medication2ID");

            migrationBuilder.RenameColumn(
                name: "MedicationID1",
                table: "MedicationInteractions",
                newName: "Medication1ID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationInteractions_MedicationID2",
                table: "MedicationInteractions",
                newName: "IX_MedicationInteractions_Medication2ID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationInteractions_MedicationID1",
                table: "MedicationInteractions",
                newName: "IX_MedicationInteractions_Medication1ID");

            migrationBuilder.AlterColumn<string>(
                name: "RelatedPrescriptionID",
                table: "MedicationStockLogs",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 14, 35, 18, 456, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 19, 35, 18, 456, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 28, 15, 35, 18, 456, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 14, 35, 18, 456, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 23, 19, 35, 18, 456, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 7, 35, 18, 456, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.InsertData(
                table: "DoctorSchedules",
                columns: new[] { "ScheduleID", "DoctorID", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { "sch-01", "doc-01", new DateTime(2025, 12, 2, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-02", "doc-01", new DateTime(2025, 12, 4, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 8, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-03", "doc-02", new DateTime(2025, 12, 1, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 13, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-04", "doc-02", new DateTime(2025, 11, 28, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 8, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-05", "doc-03", new DateTime(2025, 11, 23, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-06", "doc-04", new DateTime(2025, 12, 3, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 7, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-07", "doc-03", new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { "sch-08", "doc-04", new DateTime(2025, 12, 6, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 10, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9611), new DateTime(2025, 12, 2, 14, 50, 18, 456, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9615), new DateTime(2025, 12, 1, 20, 5, 18, 456, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 11, 28, 16, 5, 18, 456, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 6, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9629), new DateTime(2025, 11, 23, 20, 35, 18, 456, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.InsertData(
                table: "MedicationInteractions",
                columns: new[] { "InteractionID", "ClinicalEffects", "Description", "Management", "Medication1ID", "Medication2ID", "Severity" },
                values: new object[,]
                {
                    { "int-01", "NSAIDs may impair renal function, increasing the risk of metformin-associated lactic acidosis.", "Potential reduction in renal function.", "Monitor renal function periodically.", "med-ibu-400", "med-met-850", 1 },
                    { "int-02", "Omeprazole may slightly increase the serum concentration of Atorvastatin.", "Altered absorption.", "Monitor for statin-related side effects like muscle pain.", "med-ator-20", "med-omep-20", 0 },
                    { "int-03", "NSAIDs may reduce the cardiovascular protection of statins in high risk patients.", "Potential reduced antihypertensive effect.", "Use lowest effective dose of NSAID.", "med-ibu-400", "med-ator-20", 0 }
                });

            migrationBuilder.InsertData(
                table: "MedicationStockLogs",
                columns: new[] { "LogID", "CreatedAt", "MedicationID", "QuantityChange", "Reason", "RelatedPrescriptionID" },
                values: new object[,]
                {
                    { "log-01", new DateTime(2025, 11, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9974), "med-amox-500", 1000, "Initial Stock Import", null },
                    { "log-02", new DateTime(2025, 11, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9978), "med-ibu-400", 500, "Initial Stock Import", null },
                    { "log-03", new DateTime(2025, 12, 2, 15, 20, 18, 456, DateTimeKind.Utc).AddTicks(9980), "med-amox-500", -21, "Dispensed to Patient", "presc-01" },
                    { "log-04", new DateTime(2025, 12, 2, 15, 20, 18, 456, DateTimeKind.Utc).AddTicks(9982), "med-ibu-400", -10, "Dispensed to Patient", "presc-01" },
                    { "log-05", new DateTime(2025, 12, 1, 21, 20, 18, 456, DateTimeKind.Utc).AddTicks(9985), "med-met-850", -60, "Dispensed to Patient", "presc-02" },
                    { "log-06", new DateTime(2025, 11, 28, 17, 5, 18, 456, DateTimeKind.Utc).AddTicks(9987), "med-ator-20", -30, "Dispensed to Patient", "presc-03" },
                    { "log-07", new DateTime(2025, 11, 28, 17, 5, 18, 456, DateTimeKind.Utc).AddTicks(9989), "med-omep-20", -14, "Dispensed to Patient", "presc-03" }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9746), new DateTime(2025, 12, 2, 15, 5, 18, 456, DateTimeKind.Utc).AddTicks(9741), new DateTime(2025, 12, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 21, 20, 18, 456, DateTimeKind.Utc).AddTicks(9752), new DateTime(2025, 12, 1, 20, 35, 18, 456, DateTimeKind.Utc).AddTicks(9749), new DateTime(2025, 12, 1, 21, 5, 18, 456, DateTimeKind.Utc).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 17, 5, 18, 456, DateTimeKind.Utc).AddTicks(9757), new DateTime(2025, 11, 28, 16, 35, 18, 456, DateTimeKind.Utc).AddTicks(9755), new DateTime(2025, 11, 28, 16, 50, 18, 456, DateTimeKind.Utc).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9762), new DateTime(2025, 11, 23, 21, 5, 18, 456, DateTimeKind.Utc).AddTicks(9760), new DateTime(2025, 11, 23, 21, 35, 18, 456, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationInteractions_Medications_Medication1ID",
                table: "MedicationInteractions",
                column: "Medication1ID",
                principalTable: "Medications",
                principalColumn: "MedicationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationInteractions_Medications_Medication2ID",
                table: "MedicationInteractions",
                column: "Medication2ID",
                principalTable: "Medications",
                principalColumn: "MedicationID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicationInteractions_Medications_Medication1ID",
                table: "MedicationInteractions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationInteractions_Medications_Medication2ID",
                table: "MedicationInteractions");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-01");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-02");

            migrationBuilder.DeleteData(
                table: "MedicationInteractions",
                keyColumn: "InteractionID",
                keyValue: "int-03");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06");

            migrationBuilder.DeleteData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07");

            migrationBuilder.RenameColumn(
                name: "InteractionID",
                table: "MedicationInteractions",
                newName: "InteractionId");

            migrationBuilder.RenameColumn(
                name: "Medication2ID",
                table: "MedicationInteractions",
                newName: "MedicationID2");

            migrationBuilder.RenameColumn(
                name: "Medication1ID",
                table: "MedicationInteractions",
                newName: "MedicationID1");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationInteractions_Medication2ID",
                table: "MedicationInteractions",
                newName: "IX_MedicationInteractions_MedicationID2");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationInteractions_Medication1ID",
                table: "MedicationInteractions",
                newName: "IX_MedicationInteractions_MedicationID1");

            migrationBuilder.AlterColumn<string>(
                name: "RelatedPrescriptionID",
                table: "MedicationStockLogs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 18, 23, 12, 235, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 23, 23, 12, 235, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 19, 23, 12, 235, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 18, 23, 12, 235, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 22, 23, 23, 12, 235, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 11, 23, 12, 235, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 12, 1, 18, 38, 12, 235, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 11, 30, 23, 53, 12, 235, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 16, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 11, 27, 19, 53, 12, 235, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 5, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 11, 23, 0, 23, 12, 235, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 12, 1, 18, 53, 12, 235, DateTimeKind.Utc).AddTicks(7244), new DateTime(2025, 12, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 1, 8, 12, 235, DateTimeKind.Utc).AddTicks(7257), new DateTime(2025, 12, 1, 0, 23, 12, 235, DateTimeKind.Utc).AddTicks(7255), new DateTime(2025, 12, 1, 0, 53, 12, 235, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 20, 53, 12, 235, DateTimeKind.Utc).AddTicks(7262), new DateTime(2025, 11, 27, 20, 23, 12, 235, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 11, 27, 20, 38, 12, 235, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 9, 23, 12, 235, DateTimeKind.Utc).AddTicks(7267), new DateTime(2025, 11, 23, 0, 53, 12, 235, DateTimeKind.Utc).AddTicks(7265), new DateTime(2025, 11, 23, 1, 23, 12, 235, DateTimeKind.Utc).AddTicks(7266) });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationInteractions_Medications_MedicationID1",
                table: "MedicationInteractions",
                column: "MedicationID1",
                principalTable: "Medications",
                principalColumn: "MedicationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationInteractions_Medications_MedicationID2",
                table: "MedicationInteractions",
                column: "MedicationID2",
                principalTable: "Medications",
                principalColumn: "MedicationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

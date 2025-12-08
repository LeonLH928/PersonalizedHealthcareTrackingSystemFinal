using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class FieldBMI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BMI",
                table: "ClinicalExaminations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "StatusBMI",
                table: "ClinicalExaminations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 17, 53, 50, 602, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 22, 53, 50, 602, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 18, 53, 50, 602, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 17, 53, 50, 602, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 22, 53, 50, 602, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 10, 53, 50, 602, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-01",
                columns: new[] { "BMI", "StatusBMI" },
                values: new object[] { 23.0, 1 });

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-02",
                columns: new[] { "BMI", "StatusBMI" },
                values: new object[] { 24.800000000000001, 1 });

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-03",
                columns: new[] { "BMI", "StatusBMI" },
                values: new object[] { 25.399999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-04",
                columns: new[] { "BMI", "StatusBMI" },
                values: new object[] { 24.699999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 5, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 2, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 7, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 10, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 14, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 12, 6, 18, 8, 50, 602, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 7, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 12, 5, 23, 23, 50, 602, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7328), new DateTime(2025, 12, 2, 19, 23, 50, 602, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 10, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7330), new DateTime(2025, 11, 27, 23, 53, 50, 602, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 7, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 18, 38, 50, 602, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 18, 38, 50, 602, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 0, 38, 50, 602, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 20, 23, 50, 602, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 20, 23, 50, 602, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7413), new DateTime(2025, 12, 6, 18, 23, 50, 602, DateTimeKind.Utc).AddTicks(7405), new DateTime(2025, 12, 7, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 0, 38, 50, 602, DateTimeKind.Utc).AddTicks(7418), new DateTime(2025, 12, 5, 23, 53, 50, 602, DateTimeKind.Utc).AddTicks(7416), new DateTime(2025, 12, 6, 0, 23, 50, 602, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 20, 23, 50, 602, DateTimeKind.Utc).AddTicks(7423), new DateTime(2025, 12, 2, 19, 53, 50, 602, DateTimeKind.Utc).AddTicks(7421), new DateTime(2025, 12, 2, 20, 8, 50, 602, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 8, 53, 50, 602, DateTimeKind.Utc).AddTicks(7461), new DateTime(2025, 11, 28, 0, 23, 50, 602, DateTimeKind.Utc).AddTicks(7459), new DateTime(2025, 11, 28, 0, 53, 50, 602, DateTimeKind.Utc).AddTicks(7460) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BMI",
                table: "ClinicalExaminations");

            migrationBuilder.DropColumn(
                name: "StatusBMI",
                table: "ClinicalExaminations");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 19, 6, 37, 939, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 0, 6, 37, 939, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 20, 6, 37, 939, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 19, 6, 37, 939, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 0, 6, 37, 939, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 12, 6, 37, 939, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 11, 26, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 6, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 7, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 9, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 13, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9018), new DateTime(2025, 12, 5, 19, 21, 37, 939, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 6, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9021), new DateTime(2025, 12, 5, 0, 36, 37, 939, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 20, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9028), new DateTime(2025, 12, 1, 20, 36, 37, 939, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 9, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9030), new DateTime(2025, 11, 27, 1, 6, 37, 939, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 6, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 6, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 19, 51, 37, 939, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 19, 51, 37, 939, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 1, 51, 37, 939, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 21, 36, 37, 939, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 21, 36, 37, 939, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9130), new DateTime(2025, 12, 5, 19, 36, 37, 939, DateTimeKind.Utc).AddTicks(9124), new DateTime(2025, 12, 6, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 1, 51, 37, 939, DateTimeKind.Utc).AddTicks(9134), new DateTime(2025, 12, 5, 1, 6, 37, 939, DateTimeKind.Utc).AddTicks(9132), new DateTime(2025, 12, 5, 1, 36, 37, 939, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 21, 36, 37, 939, DateTimeKind.Utc).AddTicks(9138), new DateTime(2025, 12, 1, 21, 6, 37, 939, DateTimeKind.Utc).AddTicks(9136), new DateTime(2025, 12, 1, 21, 21, 37, 939, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 6, 37, 939, DateTimeKind.Utc).AddTicks(9143), new DateTime(2025, 11, 27, 1, 36, 37, 939, DateTimeKind.Utc).AddTicks(9141), new DateTime(2025, 11, 27, 2, 6, 37, 939, DateTimeKind.Utc).AddTicks(9142) });
        }
    }
}

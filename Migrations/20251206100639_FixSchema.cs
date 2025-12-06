using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class FixSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VerifiedAt",
                table: "Prescriptions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DispensedAt",
                table: "Prescriptions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VerifiedAt",
                table: "Prescriptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DispensedAt",
                table: "Prescriptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 2, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 4, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 1, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 23, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 3, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 7, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 6, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc) });

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

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 3, 5, 35, 18, 456, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 15, 20, 18, 456, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 15, 20, 18, 456, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 21, 20, 18, 456, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 28, 17, 5, 18, 456, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 28, 17, 5, 18, 456, DateTimeKind.Utc).AddTicks(9989));

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
        }
    }
}

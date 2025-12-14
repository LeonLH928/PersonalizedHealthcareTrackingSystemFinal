using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class FixAllUsersOffline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 16, 4, 9, 337, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 21, 4, 9, 337, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 17, 4, 9, 337, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 16, 4, 9, 337, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 21, 4, 9, 337, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 9, 4, 9, 337, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 18, 4, 9, 337, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 23, 4, 9, 337, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 20, 4, 9, 337, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 17, 4, 9, 337, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 21, 4, 9, 337, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 16, 4, 9, 337, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7581), new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7586), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7590), new DateTime(2025, 12, 12, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7594), new DateTime(2025, 12, 9, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7598), new DateTime(2025, 12, 4, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7602), new DateTime(2025, 12, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7605), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 12, 17, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7613), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7617), new DateTime(2025, 12, 19, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7314), new DateTime(2025, 12, 13, 16, 19, 9, 337, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7317), new DateTime(2025, 12, 12, 21, 34, 9, 337, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 12, 9, 17, 34, 9, 337, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7326), new DateTime(2025, 12, 4, 22, 4, 9, 337, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7328), new DateTime(2025, 12, 11, 18, 24, 9, 337, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 12, 7, 23, 29, 9, 337, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7334), new DateTime(2025, 11, 30, 20, 34, 9, 337, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7336), new DateTime(2025, 12, 10, 17, 19, 9, 337, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 16, 49, 9, 337, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 16, 49, 9, 337, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 22, 49, 9, 337, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 18, 34, 9, 337, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 18, 34, 9, 337, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 19, 19, 9, 337, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 0, 24, 9, 337, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 18, 29, 9, 337, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 13, 16, 34, 9, 337, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 22, 49, 9, 337, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 12, 12, 22, 4, 9, 337, DateTimeKind.Utc).AddTicks(7465), new DateTime(2025, 12, 12, 22, 34, 9, 337, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 4, 9, 337, DateTimeKind.Utc).AddTicks(7475), new DateTime(2025, 12, 9, 18, 19, 9, 337, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 23, 4, 9, 337, DateTimeKind.Utc).AddTicks(7480), new DateTime(2025, 12, 4, 22, 34, 9, 337, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 19, 19, 9, 337, DateTimeKind.Utc).AddTicks(7484), new DateTime(2025, 12, 11, 18, 49, 9, 337, DateTimeKind.Utc).AddTicks(7482), new DateTime(2025, 12, 11, 19, 4, 9, 337, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 7, 23, 49, 9, 337, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 4, 9, 337, DateTimeKind.Utc).AddTicks(7489), new DateTime(2025, 11, 30, 21, 34, 9, 337, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 18, 14, 9, 337, DateTimeKind.Utc).AddTicks(7494), new DateTime(2025, 12, 10, 17, 34, 9, 337, DateTimeKind.Utc).AddTicks(7492), new DateTime(2025, 12, 10, 18, 4, 9, 337, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-01",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-02",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-03",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-04",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-01",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-02",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-03",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-04",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-05",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-06",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-07",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-08",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-09",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-10",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-phar-01",
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-phar-02",
                column: "IsActive",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 16, 23, 26, 189, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 21, 23, 26, 189, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 17, 23, 26, 189, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 16, 23, 26, 189, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 21, 23, 26, 189, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 9, 23, 26, 189, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 18, 23, 26, 189, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 23, 23, 26, 189, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 20, 23, 26, 189, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 17, 23, 26, 189, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 21, 23, 26, 189, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 16, 23, 26, 189, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 3, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 12, 11, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7758), new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7761), new DateTime(2025, 12, 3, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 12, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7769), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7773), new DateTime(2025, 12, 16, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7780), new DateTime(2025, 12, 18, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 20, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7526), new DateTime(2025, 12, 12, 16, 38, 26, 189, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7530), new DateTime(2025, 12, 11, 21, 53, 26, 189, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 27, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7537), new DateTime(2025, 12, 8, 17, 53, 26, 189, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 16, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7539), new DateTime(2025, 12, 3, 22, 23, 26, 189, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 12, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7542), new DateTime(2025, 12, 10, 18, 43, 26, 189, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 27, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7544), new DateTime(2025, 12, 6, 23, 48, 26, 189, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 3, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7547), new DateTime(2025, 11, 29, 20, 53, 26, 189, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 20, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7549), new DateTime(2025, 12, 9, 17, 38, 26, 189, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 13, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 13, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 17, 8, 26, 189, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 17, 8, 26, 189, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 23, 8, 26, 189, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 18, 53, 26, 189, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 18, 53, 26, 189, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 13, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 13, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 19, 38, 26, 189, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 0, 43, 26, 189, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 7, 23, 26, 189, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 18, 48, 26, 189, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 12, 16, 53, 26, 189, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 23, 8, 26, 189, DateTimeKind.Utc).AddTicks(7647), new DateTime(2025, 12, 11, 22, 23, 26, 189, DateTimeKind.Utc).AddTicks(7640), new DateTime(2025, 12, 11, 22, 53, 26, 189, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 23, 26, 189, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 12, 8, 18, 38, 26, 189, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 3, 23, 23, 26, 189, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 12, 3, 22, 53, 26, 189, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 19, 38, 26, 189, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 12, 10, 19, 8, 26, 189, DateTimeKind.Utc).AddTicks(7656), new DateTime(2025, 12, 10, 19, 23, 26, 189, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 7, 0, 8, 26, 189, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 23, 26, 189, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 11, 29, 21, 53, 26, 189, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 33, 26, 189, DateTimeKind.Utc).AddTicks(7668), new DateTime(2025, 12, 9, 17, 53, 26, 189, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 12, 9, 18, 23, 26, 189, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-01",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-02",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-03",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-doc-04",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-01",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-02",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-03",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-04",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-05",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-06",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-07",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-08",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-09",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-pat-10",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-phar-01",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "user-phar-02",
                column: "IsActive",
                value: true);
        }
    }
}

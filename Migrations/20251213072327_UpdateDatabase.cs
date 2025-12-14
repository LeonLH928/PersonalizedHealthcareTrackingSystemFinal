using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDatetime",
                table: "DoctorSchedules",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDatetime",
                table: "DoctorSchedules",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDatetime",
                table: "DoctorSchedules");

            migrationBuilder.DropColumn(
                name: "UpdatedDatetime",
                table: "DoctorSchedules");

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
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 2, 48, 39, 328, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 7, 48, 39, 328, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 25, 4, 48, 39, 328, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 1, 48, 39, 328, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 5, 48, 39, 328, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 0, 48, 39, 328, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 6, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 7, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 11, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 13, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc) });

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

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 7, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(881), new DateTime(2025, 12, 6, 3, 8, 39, 328, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(886), new DateTime(2025, 12, 2, 8, 13, 39, 328, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(893), new DateTime(2025, 11, 25, 5, 18, 39, 328, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 15, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(899), new DateTime(2025, 12, 5, 2, 3, 39, 328, DateTimeKind.Utc).AddTicks(896) });

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

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 4, 3, 39, 328, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 9, 8, 39, 328, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 15, 48, 39, 328, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 3, 13, 39, 328, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 8, 1, 18, 39, 328, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 7, 33, 39, 328, DateTimeKind.Utc).AddTicks(1080), new DateTime(2025, 12, 7, 6, 48, 39, 328, DateTimeKind.Utc).AddTicks(1070), new DateTime(2025, 12, 7, 7, 18, 39, 328, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 2, 48, 39, 328, DateTimeKind.Utc).AddTicks(1085), new DateTime(2025, 12, 4, 3, 3, 39, 328, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 11, 29, 7, 48, 39, 328, DateTimeKind.Utc).AddTicks(1096), new DateTime(2025, 11, 29, 7, 18, 39, 328, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 4, 3, 39, 328, DateTimeKind.Utc).AddTicks(1104), new DateTime(2025, 12, 6, 3, 33, 39, 328, DateTimeKind.Utc).AddTicks(1100), new DateTime(2025, 12, 6, 3, 48, 39, 328, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 2, 8, 33, 39, 328, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 5, 48, 39, 328, DateTimeKind.Utc).AddTicks(1116), new DateTime(2025, 11, 25, 6, 18, 39, 328, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 2, 58, 39, 328, DateTimeKind.Utc).AddTicks(1183), new DateTime(2025, 12, 5, 2, 18, 39, 328, DateTimeKind.Utc).AddTicks(1178), new DateTime(2025, 12, 5, 2, 48, 39, 328, DateTimeKind.Utc).AddTicks(1180) });
        }
    }
}

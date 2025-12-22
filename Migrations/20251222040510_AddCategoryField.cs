using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Medications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 23, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 6, 5, 9, 297, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 17, 5, 9, 297, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 24, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 25, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 17, 5, 9, 297, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 12, 5, 9, 297, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 26, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 27, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 12, 5, 9, 297, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 17, 5, 9, 297, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 28, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 29, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8470), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8474), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 12, 20, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8482), new DateTime(2025, 12, 17, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8486), new DateTime(2025, 12, 12, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8489), new DateTime(2025, 12, 22, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8493), new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 19, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8497), new DateTime(2025, 12, 25, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 20, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8500), new DateTime(2025, 12, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8504), new DateTime(2025, 12, 27, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8508), new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8511), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8515), new DateTime(2025, 12, 16, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8519), new DateTime(2025, 12, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8523), new DateTime(2025, 12, 11, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8526), new DateTime(2025, 12, 10, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8530), new DateTime(2025, 12, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8533), new DateTime(2025, 12, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8537), new DateTime(2025, 12, 28, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 28, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8541), new DateTime(2025, 12, 29, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 29, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8544), new DateTime(2025, 12, 30, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 30, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8548), new DateTime(2025, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 31, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 19, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8551), new DateTime(2026, 1, 1, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 20, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8555), new DateTime(2026, 1, 2, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8559), new DateTime(2026, 1, 3, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8562), new DateTime(2026, 1, 4, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 4, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8566), new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8570), new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8573), new DateTime(2025, 12, 7, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8577), new DateTime(2025, 12, 6, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7692), new DateTime(2025, 12, 21, 13, 20, 9, 297, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 12, 20, 18, 35, 9, 297, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 12, 17, 14, 35, 9, 297, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 25, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 12, 12, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 12, 19, 15, 25, 9, 297, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 12, 15, 20, 30, 9, 297, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 12, 8, 17, 35, 9, 297, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7746), new DateTime(2025, 12, 18, 14, 20, 9, 297, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 1, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 12, 14, 19, 25, 9, 297, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 27, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 12, 16, 15, 20, 9, 297, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7753), new DateTime(2025, 12, 10, 13, 30, 9, 297, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7756), new DateTime(2025, 12, 13, 18, 35, 9, 297, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 25, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7758), new DateTime(2025, 12, 11, 20, 25, 9, 297, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 12, 7, 14, 20, 9, 297, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 12, 9, 17, 45, 9, 297, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 12, 15, 12, 30, 9, 297, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7769), new DateTime(2025, 12, 6, 13, 35, 9, 297, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 12, 5, 18, 50, 9, 297, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7774), new DateTime(2025, 12, 4, 14, 25, 9, 297, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 12, 3, 20, 20, 9, 297, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7779), new DateTime(2025, 12, 2, 12, 35, 9, 297, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 12, 1, 17, 30, 9, 297, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7784), new DateTime(2025, 11, 30, 15, 40, 9, 297, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7786), new DateTime(2025, 11, 29, 19, 25, 9, 297, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7789), new DateTime(2025, 11, 28, 13, 20, 9, 297, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7791), new DateTime(2025, 11, 27, 18, 45, 9, 297, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 21, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7793), new DateTime(2025, 11, 26, 15, 30, 9, 297, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 12, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(7796), new DateTime(2025, 11, 25, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-001",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-002",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 13, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-003",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-004",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-005",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 14, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-006",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-007",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-008",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 20, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-009",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 21, 45, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-010",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-011",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 7, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-012",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 2, 5, 9, 297, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 12, 22, 2, 11, 9, 297, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-013",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 8, 5, 9, 297, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-014",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 23, 5, 9, 297, DateTimeKind.Utc).AddTicks(8318), new DateTime(2025, 12, 21, 23, 17, 9, 297, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-015",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 22, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-016",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-017",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 1, 5, 9, 297, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-018",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 7, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-019",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 3, 5, 9, 297, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-020",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-021",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 22, 5, 9, 297, DateTimeKind.Utc).AddTicks(8332), new DateTime(2025, 12, 21, 22, 35, 9, 297, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-022",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-023",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-024",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-025",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-026",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 2, 5, 9, 297, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-027",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 0, 5, 9, 297, DateTimeKind.Utc).AddTicks(8343), new DateTime(2025, 12, 22, 0, 11, 9, 297, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-028",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 19, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-029",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-030",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 9, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-031",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 2, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-032",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 3, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-033",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-034",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 6, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 6, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-035",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 23, 5, 9, 297, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-036",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 3, 5, 9, 297, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-037",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 0, 5, 9, 297, DateTimeKind.Utc).AddTicks(8382), new DateTime(2025, 12, 22, 0, 17, 9, 297, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-038",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 8, 5, 9, 297, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-039",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 7, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-040",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 7, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-041",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 2, 5, 9, 297, DateTimeKind.Utc).AddTicks(8389), new DateTime(2025, 12, 22, 2, 11, 9, 297, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-042",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 8, 5, 9, 297, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-043",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 9, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-044",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-045",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 20, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-046",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 19, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-047",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-048",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 9, 1, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-049",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-050",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-051",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 22, 5, 9, 297, DateTimeKind.Utc).AddTicks(8407), new DateTime(2025, 12, 21, 22, 35, 9, 297, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-052",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 22, 10, 5, 9, 297, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 21, 13, 50, 9, 297, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 21, 13, 50, 9, 297, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 20, 19, 50, 9, 297, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 17, 15, 35, 9, 297, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 17, 15, 35, 9, 297, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 19, 16, 20, 9, 297, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 15, 21, 25, 9, 297, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 15, 30, 9, 297, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-14",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-15",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-16",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-17",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-18",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-19",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 22, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-20",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-21",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-22",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-23",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-24",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 21, 5, 9, 297, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-25",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 21, 5, 9, 297, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-26",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-27",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-28",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-29",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 15, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-30",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-31",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-32",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 21, 5, 9, 297, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-34",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-35",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 28, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-36",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-37",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 26, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-39",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 17, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-40",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 19, 4, 5, 9, 297, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-41",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 21, 5, 9, 297, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-42",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 17, 5, 9, 297, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-43",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 17, 5, 9, 297, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-44",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-45",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-albuterol-syrup",
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-allopurinol-100",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-alprazolam-0-5",
                column: "Category",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-amlodipine-5",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-amox-500",
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-aspirin-100",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ator-20",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-azithromycin-250",
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-cefdinir-300",
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-cet-10",
                column: "Category",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-clonazepam-0-5",
                column: "Category",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-clopidogrel-75",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-contrast-iodine",
                column: "Category",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-digoxin-125",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-digoxin-250",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-diltiazem-60",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-duloxetine-30",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-epinephrine-pen",
                column: "Category",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ferrous-sulfate-325",
                column: "Category",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-fluoxetine-20",
                column: "Category",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-furosemide-40",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-gabapentin-300",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-hydrochlorothiazide-25",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-hydroxychloroquine-200",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ibu-400",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-insulin-glargine",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-levothyroxine-50",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-lisinopril-10",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-losartan-50",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-met-850",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-metoprolol-25",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-nitro-sublingual",
                column: "Category",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-omep-20",
                column: "Category",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ondansetron-4",
                column: "Category",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-para-500",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-prednisone-5",
                column: "Category",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-pregabalin-75",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-salb-inhaler",
                column: "Category",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-simvastatin-20",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-spironolactone-25",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-tramadol-50",
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vancomycin-500",
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vf-500",
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vit-c-500",
                column: "Category",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-warfarin-5",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "metformin-500",
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 21, 13, 35, 9, 297, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 20, 19, 50, 9, 297, DateTimeKind.Utc).AddTicks(8001), new DateTime(2025, 12, 20, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(7996), new DateTime(2025, 12, 20, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 17, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8004), new DateTime(2025, 12, 17, 15, 20, 9, 297, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 12, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8009), new DateTime(2025, 12, 12, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 19, 16, 20, 9, 297, DateTimeKind.Utc).AddTicks(8012), new DateTime(2025, 12, 19, 15, 50, 9, 297, DateTimeKind.Utc).AddTicks(8011), new DateTime(2025, 12, 19, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 15, 20, 50, 9, 297, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(8017), new DateTime(2025, 12, 8, 18, 35, 9, 297, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 15, 9, 297, DateTimeKind.Utc).AddTicks(8022), new DateTime(2025, 12, 18, 14, 35, 9, 297, DateTimeKind.Utc).AddTicks(8020), new DateTime(2025, 12, 18, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-09",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 12, 14, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(8024), new DateTime(2025, 12, 14, 19, 50, 9, 297, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-10",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 16, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8031), new DateTime(2025, 12, 16, 15, 35, 9, 297, DateTimeKind.Utc).AddTicks(8029), new DateTime(2025, 12, 16, 15, 50, 9, 297, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-11",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(8034), new DateTime(2025, 12, 10, 13, 35, 9, 297, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 12, 10, 13, 50, 9, 297, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-12",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 5, 9, 297, DateTimeKind.Utc).AddTicks(8038), new DateTime(2025, 12, 8, 16, 35, 9, 297, DateTimeKind.Utc).AddTicks(8037), new DateTime(2025, 12, 8, 16, 50, 9, 297, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-13",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 21, 5, 9, 297, DateTimeKind.Utc).AddTicks(8042), new DateTime(2025, 12, 11, 20, 35, 9, 297, DateTimeKind.Utc).AddTicks(8040), new DateTime(2025, 12, 11, 20, 50, 9, 297, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-14",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8048), new DateTime(2025, 12, 7, 14, 35, 9, 297, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 12, 7, 14, 50, 9, 297, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-15",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(8053), new DateTime(2025, 12, 9, 17, 35, 9, 297, DateTimeKind.Utc).AddTicks(8051), new DateTime(2025, 12, 9, 17, 50, 9, 297, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-16",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 5, 9, 297, DateTimeKind.Utc).AddTicks(8057), new DateTime(2025, 12, 15, 12, 35, 9, 297, DateTimeKind.Utc).AddTicks(8055), new DateTime(2025, 12, 15, 12, 50, 9, 297, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-17",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 6, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(8060), new DateTime(2025, 12, 6, 18, 35, 9, 297, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-18",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8064), new DateTime(2025, 12, 5, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(8062), new DateTime(2025, 12, 5, 19, 50, 9, 297, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-19",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8067), new DateTime(2025, 12, 4, 14, 35, 9, 297, DateTimeKind.Utc).AddTicks(8066), new DateTime(2025, 12, 4, 14, 50, 9, 297, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-20",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 21, 5, 9, 297, DateTimeKind.Utc).AddTicks(8072), new DateTime(2025, 12, 3, 20, 35, 9, 297, DateTimeKind.Utc).AddTicks(8069), new DateTime(2025, 12, 3, 20, 50, 9, 297, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-21",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 18, 5, 9, 297, DateTimeKind.Utc).AddTicks(8076), new DateTime(2025, 12, 2, 17, 35, 9, 297, DateTimeKind.Utc).AddTicks(8074), new DateTime(2025, 12, 2, 17, 50, 9, 297, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-22",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 5, 9, 297, DateTimeKind.Utc).AddTicks(8079), new DateTime(2025, 12, 1, 14, 35, 9, 297, DateTimeKind.Utc).AddTicks(8078), new DateTime(2025, 12, 1, 14, 50, 9, 297, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-23",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 30, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8083), new DateTime(2025, 11, 30, 15, 35, 9, 297, DateTimeKind.Utc).AddTicks(8081), new DateTime(2025, 11, 30, 15, 50, 9, 297, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-24",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 11, 29, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(8085), new DateTime(2025, 11, 29, 19, 50, 9, 297, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-25",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 14, 5, 9, 297, DateTimeKind.Utc).AddTicks(8091), new DateTime(2025, 11, 28, 13, 35, 9, 297, DateTimeKind.Utc).AddTicks(8089), new DateTime(2025, 11, 28, 13, 50, 9, 297, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-26",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 20, 5, 9, 297, DateTimeKind.Utc).AddTicks(8094), new DateTime(2025, 11, 27, 19, 35, 9, 297, DateTimeKind.Utc).AddTicks(8093), new DateTime(2025, 11, 27, 19, 50, 9, 297, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-27",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 26, 16, 5, 9, 297, DateTimeKind.Utc).AddTicks(8098), new DateTime(2025, 11, 26, 15, 35, 9, 297, DateTimeKind.Utc).AddTicks(8096), new DateTime(2025, 11, 26, 15, 50, 9, 297, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-28",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 19, 5, 9, 297, DateTimeKind.Utc).AddTicks(8102), new DateTime(2025, 11, 25, 18, 35, 9, 297, DateTimeKind.Utc).AddTicks(8100), new DateTime(2025, 11, 25, 18, 50, 9, 297, DateTimeKind.Utc).AddTicks(8101) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Medications");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 5, 44, 30, 172, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 16, 44, 30, 172, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 23, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 24, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 16, 44, 30, 172, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 11, 44, 30, 172, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 25, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 26, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 11, 44, 30, 172, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 16, 44, 30, 172, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 28, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 27, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 28, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4110), new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4117), new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4122), new DateTime(2025, 12, 19, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4128), new DateTime(2025, 12, 16, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4133), new DateTime(2025, 12, 11, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4140), new DateTime(2025, 12, 21, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4145), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4155), new DateTime(2025, 12, 24, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 19, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4160), new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 12, 26, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4171), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4176), new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4181), new DateTime(2025, 12, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4186), new DateTime(2025, 12, 14, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4191), new DateTime(2025, 12, 10, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4203), new DateTime(2025, 12, 9, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 12, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4213), new DateTime(2025, 12, 12, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4219), new DateTime(2025, 12, 27, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4224), new DateTime(2025, 12, 28, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 28, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4229), new DateTime(2025, 12, 29, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 29, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4234), new DateTime(2025, 12, 30, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 30, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4240), new DateTime(2025, 12, 31, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 19, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4246), new DateTime(2026, 1, 1, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4251), new DateTime(2026, 1, 2, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 2, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4256), new DateTime(2026, 1, 3, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 1, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4261), new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4267), new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 3, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 12, 6, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4277), new DateTime(2025, 12, 5, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2089), new DateTime(2025, 12, 20, 12, 59, 30, 172, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2098), new DateTime(2025, 12, 19, 18, 14, 30, 172, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2106), new DateTime(2025, 12, 16, 14, 14, 30, 172, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2109), new DateTime(2025, 12, 11, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2112), new DateTime(2025, 12, 18, 15, 4, 30, 172, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2115), new DateTime(2025, 12, 14, 20, 9, 30, 172, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2122), new DateTime(2025, 12, 7, 17, 14, 30, 172, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2125), new DateTime(2025, 12, 17, 13, 59, 30, 172, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2128), new DateTime(2025, 12, 13, 19, 4, 30, 172, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2131), new DateTime(2025, 12, 15, 14, 59, 30, 172, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2134), new DateTime(2025, 12, 9, 13, 9, 30, 172, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 12, 12, 18, 14, 30, 172, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2140), new DateTime(2025, 12, 10, 20, 4, 30, 172, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2143), new DateTime(2025, 12, 6, 13, 59, 30, 172, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 12, 8, 17, 24, 30, 172, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2149), new DateTime(2025, 12, 14, 12, 9, 30, 172, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 23, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2156), new DateTime(2025, 12, 5, 13, 14, 30, 172, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2159), new DateTime(2025, 12, 4, 18, 29, 30, 172, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2162), new DateTime(2025, 12, 3, 14, 4, 30, 172, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2165), new DateTime(2025, 12, 2, 19, 59, 30, 172, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 23, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2217), new DateTime(2025, 12, 1, 12, 14, 30, 172, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2221), new DateTime(2025, 11, 30, 17, 9, 30, 172, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2224), new DateTime(2025, 11, 29, 15, 19, 30, 172, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 11, 28, 19, 4, 30, 172, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2231), new DateTime(2025, 11, 27, 12, 59, 30, 172, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2234), new DateTime(2025, 11, 26, 18, 24, 30, 172, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 20, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2237), new DateTime(2025, 11, 25, 15, 9, 30, 172, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 11, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(2240), new DateTime(2025, 11, 24, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-001",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-002",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 13, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-003",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-004",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-005",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 14, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-006",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-007",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-008",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 20, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-009",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 21, 45, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-010",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-011",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 7, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-012",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 1, 44, 30, 172, DateTimeKind.Utc).AddTicks(3871), new DateTime(2025, 12, 21, 1, 50, 30, 172, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-013",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 7, 44, 30, 172, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-014",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 22, 44, 30, 172, DateTimeKind.Utc).AddTicks(3879), new DateTime(2025, 12, 20, 22, 56, 30, 172, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-015",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 22, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-016",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-017",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 0, 44, 30, 172, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-018",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 7, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-019",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 2, 44, 30, 172, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-020",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-021",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 21, 44, 30, 172, DateTimeKind.Utc).AddTicks(3896), new DateTime(2025, 12, 20, 22, 14, 30, 172, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-022",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-023",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-024",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-025",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-026",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 1, 44, 30, 172, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-027",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 23, 44, 30, 172, DateTimeKind.Utc).AddTicks(3915), new DateTime(2025, 12, 20, 23, 50, 30, 172, DateTimeKind.Utc).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-028",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 19, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-029",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-030",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-031",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 2, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-032",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 3, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-033",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-034",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 6, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 6, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-035",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 22, 44, 30, 172, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-036",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 2, 44, 30, 172, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-037",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 23, 44, 30, 172, DateTimeKind.Utc).AddTicks(3942), new DateTime(2025, 12, 20, 23, 56, 30, 172, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-038",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 7, 44, 30, 172, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-039",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 7, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-040",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 7, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-041",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 1, 44, 30, 172, DateTimeKind.Utc).AddTicks(3951), new DateTime(2025, 12, 21, 1, 50, 30, 172, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-042",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 7, 44, 30, 172, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-043",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-044",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-045",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 20, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-046",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 20, 19, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-047",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-048",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 1, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-049",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-050",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-051",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 20, 21, 44, 30, 172, DateTimeKind.Utc).AddTicks(4017), new DateTime(2025, 12, 20, 22, 14, 30, 172, DateTimeKind.Utc).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-052",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 21, 9, 44, 30, 172, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 20, 13, 29, 30, 172, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 20, 13, 29, 30, 172, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 19, 19, 29, 30, 172, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 15, 14, 30, 172, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 15, 14, 30, 172, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 15, 59, 30, 172, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 21, 4, 30, 172, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 17, 15, 9, 30, 172, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-14",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-15",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-16",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-17",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-18",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-19",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 21, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-20",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-21",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-22",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 15, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-23",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-24",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 20, 44, 30, 172, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-25",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 20, 44, 30, 172, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-26",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-27",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-28",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-29",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-30",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-31",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-32",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 20, 44, 30, 172, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-34",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 28, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-35",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-36",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 26, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-37",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 24, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-39",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-40",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 3, 44, 30, 172, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-41",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 20, 44, 30, 172, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-42",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 16, 44, 30, 172, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-43",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 16, 44, 30, 172, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-44",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-45",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 30, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 20, 13, 14, 30, 172, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 19, 19, 29, 30, 172, DateTimeKind.Utc).AddTicks(2996), new DateTime(2025, 12, 19, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(2984), new DateTime(2025, 12, 19, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 16, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(3001), new DateTime(2025, 12, 16, 14, 59, 30, 172, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 11, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 12, 11, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 59, 30, 172, DateTimeKind.Utc).AddTicks(3169), new DateTime(2025, 12, 18, 15, 29, 30, 172, DateTimeKind.Utc).AddTicks(3158), new DateTime(2025, 12, 18, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 14, 20, 29, 30, 172, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 12, 7, 18, 14, 30, 172, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 17, 14, 54, 30, 172, DateTimeKind.Utc).AddTicks(3221), new DateTime(2025, 12, 17, 14, 14, 30, 172, DateTimeKind.Utc).AddTicks(3218), new DateTime(2025, 12, 17, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-09",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(3226), new DateTime(2025, 12, 13, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(3223), new DateTime(2025, 12, 13, 19, 29, 30, 172, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-10",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(3232), new DateTime(2025, 12, 15, 15, 14, 30, 172, DateTimeKind.Utc).AddTicks(3229), new DateTime(2025, 12, 15, 15, 29, 30, 172, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-11",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 9, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(3241), new DateTime(2025, 12, 9, 13, 14, 30, 172, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 12, 9, 13, 29, 30, 172, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-12",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 16, 44, 30, 172, DateTimeKind.Utc).AddTicks(3247), new DateTime(2025, 12, 7, 16, 14, 30, 172, DateTimeKind.Utc).AddTicks(3244), new DateTime(2025, 12, 7, 16, 29, 30, 172, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-13",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 20, 44, 30, 172, DateTimeKind.Utc).AddTicks(3252), new DateTime(2025, 12, 10, 20, 14, 30, 172, DateTimeKind.Utc).AddTicks(3249), new DateTime(2025, 12, 10, 20, 29, 30, 172, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-14",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(3258), new DateTime(2025, 12, 6, 14, 14, 30, 172, DateTimeKind.Utc).AddTicks(3255), new DateTime(2025, 12, 6, 14, 29, 30, 172, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-15",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 12, 8, 17, 14, 30, 172, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 12, 8, 17, 29, 30, 172, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-16",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 44, 30, 172, DateTimeKind.Utc).AddTicks(3272), new DateTime(2025, 12, 14, 12, 14, 30, 172, DateTimeKind.Utc).AddTicks(3266), new DateTime(2025, 12, 14, 12, 29, 30, 172, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-17",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(3277), new DateTime(2025, 12, 5, 18, 14, 30, 172, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-18",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(3282), new DateTime(2025, 12, 4, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 12, 4, 19, 29, 30, 172, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-19",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(3287), new DateTime(2025, 12, 3, 14, 14, 30, 172, DateTimeKind.Utc).AddTicks(3285), new DateTime(2025, 12, 3, 14, 29, 30, 172, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-20",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 20, 44, 30, 172, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 12, 2, 20, 14, 30, 172, DateTimeKind.Utc).AddTicks(3290), new DateTime(2025, 12, 2, 20, 29, 30, 172, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-21",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 17, 44, 30, 172, DateTimeKind.Utc).AddTicks(3298), new DateTime(2025, 12, 1, 17, 14, 30, 172, DateTimeKind.Utc).AddTicks(3295), new DateTime(2025, 12, 1, 17, 29, 30, 172, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-22",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 30, 14, 44, 30, 172, DateTimeKind.Utc).AddTicks(3307), new DateTime(2025, 11, 30, 14, 14, 30, 172, DateTimeKind.Utc).AddTicks(3305), new DateTime(2025, 11, 30, 14, 29, 30, 172, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-23",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(3312), new DateTime(2025, 11, 29, 15, 14, 30, 172, DateTimeKind.Utc).AddTicks(3310), new DateTime(2025, 11, 29, 15, 29, 30, 172, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-24",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(3317), new DateTime(2025, 11, 28, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(3315), new DateTime(2025, 11, 28, 19, 29, 30, 172, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-25",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 44, 30, 172, DateTimeKind.Utc).AddTicks(3322), new DateTime(2025, 11, 27, 13, 14, 30, 172, DateTimeKind.Utc).AddTicks(3320), new DateTime(2025, 11, 27, 13, 29, 30, 172, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-26",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 26, 19, 44, 30, 172, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 11, 26, 19, 14, 30, 172, DateTimeKind.Utc).AddTicks(3325), new DateTime(2025, 11, 26, 19, 29, 30, 172, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-27",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 15, 44, 30, 172, DateTimeKind.Utc).AddTicks(3335), new DateTime(2025, 11, 25, 15, 14, 30, 172, DateTimeKind.Utc).AddTicks(3333), new DateTime(2025, 11, 25, 15, 29, 30, 172, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-28",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 24, 18, 44, 30, 172, DateTimeKind.Utc).AddTicks(3340), new DateTime(2025, 11, 24, 18, 14, 30, 172, DateTimeKind.Utc).AddTicks(3338), new DateTime(2025, 11, 24, 18, 29, 30, 172, DateTimeKind.Utc).AddTicks(3339) });
        }
    }
}

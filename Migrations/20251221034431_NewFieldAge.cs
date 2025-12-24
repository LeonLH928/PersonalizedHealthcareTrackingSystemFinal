using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class NewFieldAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Patients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-01",
                column: "Age",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-02",
                column: "Age",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-03",
                column: "Age",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-04",
                column: "Age",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-05",
                column: "Age",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-06",
                column: "Age",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-07",
                column: "Age",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-08",
                column: "Age",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-09",
                column: "Age",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: "pat-10",
                column: "Age",
                value: 37);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 11, 38, 36, 752, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 22, 38, 36, 752, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 22, 38, 36, 752, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 17, 38, 36, 752, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 23, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 25, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 17, 38, 36, 752, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 28, 22, 38, 36, 752, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 25, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 26, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4884), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4893), new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4898), new DateTime(2025, 12, 17, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4904), new DateTime(2025, 12, 14, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4909), new DateTime(2025, 12, 9, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4914), new DateTime(2025, 12, 19, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4922), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4927), new DateTime(2025, 12, 22, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4931), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4937), new DateTime(2025, 12, 24, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4941), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4947), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4952), new DateTime(2025, 12, 13, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4956), new DateTime(2025, 12, 12, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4961), new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4966), new DateTime(2025, 12, 7, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4971), new DateTime(2025, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4976), new DateTime(2025, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4981), new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4986), new DateTime(2025, 12, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 12, 27, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4995), new DateTime(2025, 12, 28, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 28, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5003), new DateTime(2025, 12, 29, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 29, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 12, 30, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 12, 31, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 31, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5019), new DateTime(2026, 1, 1, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 29, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5023), new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 30, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5027), new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 1, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5032), new DateTime(2025, 12, 4, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5037), new DateTime(2025, 12, 3, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3735), new DateTime(2025, 12, 18, 18, 53, 36, 752, DateTimeKind.Utc).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3741), new DateTime(2025, 12, 18, 0, 8, 36, 752, DateTimeKind.Utc).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3756), new DateTime(2025, 12, 14, 20, 8, 36, 752, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3758), new DateTime(2025, 12, 10, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3761), new DateTime(2025, 12, 16, 20, 58, 36, 752, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3765), new DateTime(2025, 12, 13, 2, 3, 36, 752, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3768), new DateTime(2025, 12, 5, 23, 8, 36, 752, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3771), new DateTime(2025, 12, 15, 19, 53, 36, 752, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3774), new DateTime(2025, 12, 12, 0, 58, 36, 752, DateTimeKind.Utc).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3778), new DateTime(2025, 12, 13, 20, 53, 36, 752, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3781), new DateTime(2025, 12, 7, 19, 3, 36, 752, DateTimeKind.Utc).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3784), new DateTime(2025, 12, 11, 0, 8, 36, 752, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3787), new DateTime(2025, 12, 9, 1, 58, 36, 752, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 12, 4, 19, 53, 36, 752, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3793), new DateTime(2025, 12, 6, 23, 18, 36, 752, DateTimeKind.Utc).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3797), new DateTime(2025, 12, 12, 18, 3, 36, 752, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3800), new DateTime(2025, 12, 3, 19, 8, 36, 752, DateTimeKind.Utc).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3803), new DateTime(2025, 12, 3, 0, 23, 36, 752, DateTimeKind.Utc).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3806), new DateTime(2025, 12, 1, 19, 58, 36, 752, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3809), new DateTime(2025, 12, 1, 1, 53, 36, 752, DateTimeKind.Utc).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3812), new DateTime(2025, 11, 29, 18, 8, 36, 752, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3816), new DateTime(2025, 11, 28, 23, 3, 36, 752, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3819), new DateTime(2025, 11, 27, 21, 13, 36, 752, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3822), new DateTime(2025, 11, 27, 0, 58, 36, 752, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3827), new DateTime(2025, 11, 25, 18, 53, 36, 752, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3830), new DateTime(2025, 11, 25, 0, 18, 36, 752, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3833), new DateTime(2025, 11, 23, 21, 3, 36, 752, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(3836), new DateTime(2025, 11, 23, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-001",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-002",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 13, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-003",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-004",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-005",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 14, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-006",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-007",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-008",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 20, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-009",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 18, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 21, 45, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-010",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-011",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 7, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-012",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 7, 38, 36, 752, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 12, 19, 7, 44, 36, 752, DateTimeKind.Utc).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-013",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 13, 38, 36, 752, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-014",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 4, 38, 36, 752, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 12, 19, 4, 50, 36, 752, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-015",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 18, 22, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 22, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-016",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-017",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 6, 38, 36, 752, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-018",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 7, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-019",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 8, 38, 36, 752, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-020",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-021",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 3, 38, 36, 752, DateTimeKind.Utc).AddTicks(4706), new DateTime(2025, 12, 19, 4, 8, 36, 752, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-022",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-023",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-024",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-025",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-026",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 7, 38, 36, 752, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-027",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 5, 38, 36, 752, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 12, 19, 5, 44, 36, 752, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-028",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 19, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-029",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-030",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-031",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 2, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-032",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 3, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-033",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-034",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 6, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 6, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-035",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 4, 38, 36, 752, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-036",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 8, 38, 36, 752, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-037",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 5, 38, 36, 752, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 12, 19, 5, 50, 36, 752, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-038",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 13, 38, 36, 752, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-039",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 7, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-040",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 7, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-041",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 7, 38, 36, 752, DateTimeKind.Utc).AddTicks(4754), new DateTime(2025, 12, 19, 7, 44, 36, 752, DateTimeKind.Utc).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-042",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 13, 38, 36, 752, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-043",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-044",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 21, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-045",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 20, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-046",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 18, 19, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-047",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-048",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 1, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-049",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 5, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-050",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 18, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-051",
                columns: new[] { "ScheduledDateTime", "TakenDateTime" },
                values: new object[] { new DateTime(2025, 12, 19, 3, 38, 36, 752, DateTimeKind.Utc).AddTicks(4780), new DateTime(2025, 12, 19, 4, 8, 36, 752, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "MedicationAdherences",
                keyColumn: "AdherenceID",
                keyValue: "ma-052",
                column: "ScheduledDateTime",
                value: new DateTime(2025, 12, 19, 15, 38, 36, 752, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 19, 23, 36, 752, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 19, 23, 36, 752, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 1, 23, 36, 752, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 21, 8, 36, 752, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 21, 8, 36, 752, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 21, 53, 36, 752, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 2, 58, 36, 752, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 15, 21, 3, 36, 752, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-14",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-15",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-16",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-17",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-18",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-19",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-20",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-21",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-22",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-23",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-24",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 2, 38, 36, 752, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-25",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 2, 38, 36, 752, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-26",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-27",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-28",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-29",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-30",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-31",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-32",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 2, 38, 36, 752, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-34",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-35",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-36",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-37",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-39",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-40",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 9, 38, 36, 752, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-41",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 2, 38, 36, 752, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-42",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 22, 38, 36, 752, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-43",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 22, 38, 36, 752, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-44",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-45",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 28, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 18, 19, 8, 36, 752, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 1, 23, 36, 752, DateTimeKind.Utc).AddTicks(4144), new DateTime(2025, 12, 18, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(4131), new DateTime(2025, 12, 18, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 12, 14, 20, 53, 36, 752, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 10, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(4154), new DateTime(2025, 12, 10, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 16, 21, 53, 36, 752, DateTimeKind.Utc).AddTicks(4158), new DateTime(2025, 12, 16, 21, 23, 36, 752, DateTimeKind.Utc).AddTicks(4156), new DateTime(2025, 12, 16, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 13, 2, 23, 36, 752, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(4164), new DateTime(2025, 12, 6, 0, 8, 36, 752, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 48, 36, 752, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 12, 15, 20, 8, 36, 752, DateTimeKind.Utc).AddTicks(4168), new DateTime(2025, 12, 15, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-09",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(4178), new DateTime(2025, 12, 12, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(4175), new DateTime(2025, 12, 12, 1, 23, 36, 752, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-10",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(4183), new DateTime(2025, 12, 13, 21, 8, 36, 752, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 12, 13, 21, 23, 36, 752, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-11",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(4188), new DateTime(2025, 12, 7, 19, 8, 36, 752, DateTimeKind.Utc).AddTicks(4185), new DateTime(2025, 12, 7, 19, 23, 36, 752, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-12",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 22, 38, 36, 752, DateTimeKind.Utc).AddTicks(4194), new DateTime(2025, 12, 5, 22, 8, 36, 752, DateTimeKind.Utc).AddTicks(4191), new DateTime(2025, 12, 5, 22, 23, 36, 752, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-13",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 9, 2, 38, 36, 752, DateTimeKind.Utc).AddTicks(4199), new DateTime(2025, 12, 9, 2, 8, 36, 752, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 12, 9, 2, 23, 36, 752, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-14",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(4205), new DateTime(2025, 12, 4, 20, 8, 36, 752, DateTimeKind.Utc).AddTicks(4203), new DateTime(2025, 12, 4, 20, 23, 36, 752, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-15",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(4210), new DateTime(2025, 12, 6, 23, 8, 36, 752, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 12, 6, 23, 23, 36, 752, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-16",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 38, 36, 752, DateTimeKind.Utc).AddTicks(4219), new DateTime(2025, 12, 12, 18, 8, 36, 752, DateTimeKind.Utc).AddTicks(4213), new DateTime(2025, 12, 12, 18, 23, 36, 752, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-17",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(4224), new DateTime(2025, 12, 4, 0, 8, 36, 752, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-18",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(4229), new DateTime(2025, 12, 3, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(4226), new DateTime(2025, 12, 3, 1, 23, 36, 752, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-19",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(4233), new DateTime(2025, 12, 1, 20, 8, 36, 752, DateTimeKind.Utc).AddTicks(4231), new DateTime(2025, 12, 1, 20, 23, 36, 752, DateTimeKind.Utc).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-20",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 2, 38, 36, 752, DateTimeKind.Utc).AddTicks(4239), new DateTime(2025, 12, 1, 2, 8, 36, 752, DateTimeKind.Utc).AddTicks(4236), new DateTime(2025, 12, 1, 2, 23, 36, 752, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-21",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 23, 38, 36, 752, DateTimeKind.Utc).AddTicks(4243), new DateTime(2025, 11, 29, 23, 8, 36, 752, DateTimeKind.Utc).AddTicks(4241), new DateTime(2025, 11, 29, 23, 23, 36, 752, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-22",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 20, 38, 36, 752, DateTimeKind.Utc).AddTicks(4248), new DateTime(2025, 11, 28, 20, 8, 36, 752, DateTimeKind.Utc).AddTicks(4246), new DateTime(2025, 11, 28, 20, 23, 36, 752, DateTimeKind.Utc).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-23",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(4253), new DateTime(2025, 11, 27, 21, 8, 36, 752, DateTimeKind.Utc).AddTicks(4251), new DateTime(2025, 11, 27, 21, 23, 36, 752, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-24",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(4259), new DateTime(2025, 11, 27, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 11, 27, 1, 23, 36, 752, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-25",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 19, 38, 36, 752, DateTimeKind.Utc).AddTicks(4265), new DateTime(2025, 11, 25, 19, 8, 36, 752, DateTimeKind.Utc).AddTicks(4261), new DateTime(2025, 11, 25, 19, 23, 36, 752, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-26",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 1, 38, 36, 752, DateTimeKind.Utc).AddTicks(4270), new DateTime(2025, 11, 25, 1, 8, 36, 752, DateTimeKind.Utc).AddTicks(4268), new DateTime(2025, 11, 25, 1, 23, 36, 752, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-27",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 21, 38, 36, 752, DateTimeKind.Utc).AddTicks(4275), new DateTime(2025, 11, 23, 21, 8, 36, 752, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 11, 23, 21, 23, 36, 752, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-28",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 38, 36, 752, DateTimeKind.Utc).AddTicks(4280), new DateTime(2025, 11, 23, 0, 8, 36, 752, DateTimeKind.Utc).AddTicks(4277), new DateTime(2025, 11, 23, 0, 23, 36, 752, DateTimeKind.Utc).AddTicks(4278) });
        }
    }
}

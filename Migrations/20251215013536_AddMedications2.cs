using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddMedications2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-clarithromycin-500");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-09");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-10");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-11");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-12");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-13");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-14");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-15");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-16");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-17");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-18");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-19");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-20");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-21");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-22");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-23");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-24");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-25");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-26");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-27");

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-28");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 10, 35, 34, 980, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 11, 35, 34, 980, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 10, 35, 34, 980, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 3, 35, 34, 980, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 12, 35, 34, 980, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 17, 35, 34, 980, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 14, 35, 34, 980, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 11, 35, 34, 980, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 10, 35, 34, 980, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 16, 35, 34, 980, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 12, 35, 34, 980, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 10, 35, 34, 980, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 17, 35, 34, 980, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 11, 35, 34, 980, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 14, 35, 34, 980, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 9, 35, 34, 980, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 12, 35, 34, 980, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 16, 35, 34, 980, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 10, 35, 34, 980, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 28, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 11, 35, 34, 980, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 26, 17, 35, 34, 980, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 25, 9, 35, 34, 980, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 24, 14, 35, 34, 980, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 23, 12, 35, 34, 980, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 22, 16, 35, 34, 980, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 10, 35, 34, 980, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 12, 13, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4026), new DateTime(2025, 12, 10, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4032), new DateTime(2025, 12, 5, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 12, 15, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4042), new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 12, 18, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4052), new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4057), new DateTime(2025, 12, 20, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 30, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4061), new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 1, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4066), new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4071), new DateTime(2025, 12, 9, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 3, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4076), new DateTime(2025, 12, 8, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4081), new DateTime(2025, 12, 4, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4085), new DateTime(2025, 12, 3, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4090), new DateTime(2025, 12, 7, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4095), new DateTime(2025, 12, 6, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4102), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4109), new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4113), new DateTime(2025, 12, 23, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4120), new DateTime(2025, 12, 24, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4124), new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4128), new DateTime(2025, 12, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4132), new DateTime(2025, 12, 27, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4136), new DateTime(2025, 12, 28, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 28, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 25, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4140), new DateTime(2025, 12, 2, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 26, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4144), new DateTime(2025, 12, 1, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 27, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4148), new DateTime(2025, 11, 30, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 28, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4152), new DateTime(2025, 11, 29, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3417), new DateTime(2025, 12, 14, 10, 50, 34, 980, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3492), new DateTime(2025, 12, 13, 16, 5, 34, 980, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3501), new DateTime(2025, 12, 10, 12, 5, 34, 980, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 18, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3504), new DateTime(2025, 12, 5, 16, 35, 34, 980, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 12, 12, 12, 55, 34, 980, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3511), new DateTime(2025, 12, 8, 18, 0, 34, 980, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3514), new DateTime(2025, 12, 1, 15, 5, 34, 980, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3517), new DateTime(2025, 12, 11, 11, 50, 34, 980, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 25, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3520), new DateTime(2025, 12, 7, 16, 55, 34, 980, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 20, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3523), new DateTime(2025, 12, 9, 12, 50, 34, 980, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 12, 3, 11, 0, 34, 980, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3530), new DateTime(2025, 12, 6, 16, 5, 34, 980, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 18, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3533), new DateTime(2025, 12, 4, 17, 55, 34, 980, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3536), new DateTime(2025, 11, 30, 11, 50, 34, 980, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3539), new DateTime(2025, 12, 2, 15, 15, 34, 980, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3542), new DateTime(2025, 12, 8, 10, 0, 34, 980, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3545), new DateTime(2025, 11, 29, 11, 5, 34, 980, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3548), new DateTime(2025, 11, 28, 16, 20, 34, 980, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 11, 27, 11, 55, 34, 980, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3557), new DateTime(2025, 11, 26, 17, 50, 34, 980, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3560), new DateTime(2025, 11, 25, 10, 5, 34, 980, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3562), new DateTime(2025, 11, 24, 15, 0, 34, 980, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3566), new DateTime(2025, 11, 23, 13, 10, 34, 980, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3569), new DateTime(2025, 11, 22, 16, 55, 34, 980, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3572), new DateTime(2025, 11, 21, 10, 50, 34, 980, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3575), new DateTime(2025, 11, 20, 16, 15, 34, 980, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3578), new DateTime(2025, 11, 19, 13, 0, 34, 980, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 5, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(3581), new DateTime(2025, 11, 18, 17, 5, 34, 980, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 11, 20, 34, 980, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 11, 20, 34, 980, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 17, 20, 34, 980, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 13, 5, 34, 980, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 13, 5, 34, 980, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 13, 50, 34, 980, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 18, 55, 34, 980, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 15, 1, 35, 34, 980, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 13, 0, 34, 980, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-contrast-iodine",
                columns: new[] { "ActiveIngredient", "Name", "PackingDescription", "Price", "SideEffect", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Iohexol", "Iodinated Contrast Medium", "Vial of 100ml injection solution", 350000, "Allergic reactions, nausea, kidney damage risk", "Store at room temperature, protect from light", 100 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-digoxin-125",
                columns: new[] { "BaseUnit", "Name", "PackingDescription", "Price", "SideEffect", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "mg", "Digoxin 0.125mg", "Bottle of 60 tablets", 85000, "Nausea, vomiting, visual disturbances, arrhythmias", "Store at room temperature, protect from light", 60 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-diltiazem-60",
                columns: new[] { "Price", "SideEffect", "StockTotalQuantity" },
                values: new object[] { 145000, "Dizziness, headache, ankle swelling, constipation", 600 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-duloxetine-30",
                columns: new[] { "ActiveIngredient", "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "UnitsPerPack" },
                values: new object[] { "Duloxetine Hydrochloride", "Bottle of 30 delayed-release capsules", "bottle", 190000, "Nausea, dry mouth, drowsiness, dizziness, constipation", 400, 30 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-hydroxychloroquine-200",
                columns: new[] { "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Bottle of 60 tablets", "bottle", 210000, "Nausea, headache, dizziness, retinal toxicity (long-term)", 500, "Store at room temperature, protect from light", 60 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-pregabalin-75",
                columns: new[] { "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Bottle of 60 capsules", "bottle", 185000, "Dizziness, drowsiness, dry mouth, weight gain, blurred vision", 600, "Store at room temperature", 60 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vancomycin-500",
                columns: new[] { "PackingDescription", "Price", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Vial for IV injection 500mg", 280000, 100, "Refrigerate, protect from light", 500 });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "ActiveIngredient", "BaseUnit", "Form", "Name", "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[,]
                {
                    { "med-ferrous-sulfate-325", "Ferrous Sulfate", "mg", 0, "Ferrous Sulfate 325mg", "Bottle of 100 tablets", "bottle", 70000, "Constipation, dark stools, stomach upset, nausea", 1000, "Store at room temperature, keep tightly closed", 100 },
                    { "med-vf-500", "Clarithromycin", "mg", 0, "Clarithromycin 500mg", "Box of 14 tablets", "box", 195000, "Nausea, altered taste, diarrhea, liver enzyme changes", 400, "Store at room temperature", 14 }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 14, 11, 5, 34, 980, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 17, 20, 34, 980, DateTimeKind.Utc).AddTicks(3858), new DateTime(2025, 12, 13, 16, 35, 34, 980, DateTimeKind.Utc).AddTicks(3850), new DateTime(2025, 12, 13, 17, 5, 34, 980, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 12, 35, 34, 980, DateTimeKind.Utc).AddTicks(3862), new DateTime(2025, 12, 10, 12, 50, 34, 980, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 35, 34, 980, DateTimeKind.Utc).AddTicks(3868), new DateTime(2025, 12, 5, 17, 5, 34, 980, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 13, 50, 34, 980, DateTimeKind.Utc).AddTicks(3873), new DateTime(2025, 12, 12, 13, 20, 34, 980, DateTimeKind.Utc).AddTicks(3870), new DateTime(2025, 12, 12, 13, 35, 34, 980, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 8, 18, 20, 34, 980, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 35, 34, 980, DateTimeKind.Utc).AddTicks(3879), new DateTime(2025, 12, 1, 16, 5, 34, 980, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 12, 45, 34, 980, DateTimeKind.Utc).AddTicks(3885), new DateTime(2025, 12, 11, 12, 5, 34, 980, DateTimeKind.Utc).AddTicks(3883), new DateTime(2025, 12, 11, 12, 35, 34, 980, DateTimeKind.Utc).AddTicks(3884) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ferrous-sulfate-325");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vf-500");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 4, 32, 51, 605, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 20, 32, 51, 605, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 7, 32, 51, 605, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 4, 32, 51, 605, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 9, 32, 51, 605, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 4, 32, 51, 605, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 7, 32, 51, 605, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 2, 32, 51, 605, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 9, 32, 51, 605, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 28, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 4, 32, 51, 605, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 26, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 25, 2, 32, 51, 605, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 24, 7, 32, 51, 605, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 23, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 22, 9, 32, 51, 605, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7455), new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7460), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7465), new DateTime(2025, 12, 12, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7469), new DateTime(2025, 12, 9, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 12, 4, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7477), new DateTime(2025, 12, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7481), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7485), new DateTime(2025, 12, 17, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7489), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7493), new DateTime(2025, 12, 19, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 29, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7498), new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 30, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7502), new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 1, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7505), new DateTime(2025, 12, 8, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7509), new DateTime(2025, 12, 7, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7514), new DateTime(2025, 12, 3, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 12, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 12, 6, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7527), new DateTime(2025, 12, 5, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7531), new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7535), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7539), new DateTime(2025, 12, 22, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7543), new DateTime(2025, 12, 23, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7546), new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7550), new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7554), new DateTime(2025, 12, 26, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7558), new DateTime(2025, 12, 27, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 24, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7562), new DateTime(2025, 12, 1, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 25, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 11, 30, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 26, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7570), new DateTime(2025, 11, 29, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7574), new DateTime(2025, 11, 28, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6779), new DateTime(2025, 12, 14, 3, 47, 51, 605, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6783), new DateTime(2025, 12, 13, 9, 2, 51, 605, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6790), new DateTime(2025, 12, 10, 5, 2, 51, 605, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6793), new DateTime(2025, 12, 5, 9, 32, 51, 605, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6797), new DateTime(2025, 12, 12, 5, 52, 51, 605, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6800), new DateTime(2025, 12, 8, 10, 57, 51, 605, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6804), new DateTime(2025, 12, 1, 8, 2, 51, 605, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6807), new DateTime(2025, 12, 11, 4, 47, 51, 605, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6810), new DateTime(2025, 12, 7, 9, 52, 51, 605, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 19, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6813), new DateTime(2025, 12, 9, 5, 47, 51, 605, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6817), new DateTime(2025, 12, 3, 3, 57, 51, 605, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6820), new DateTime(2025, 12, 6, 9, 2, 51, 605, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6824), new DateTime(2025, 12, 4, 10, 52, 51, 605, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6828), new DateTime(2025, 11, 30, 4, 47, 51, 605, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6831), new DateTime(2025, 12, 2, 8, 12, 51, 605, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6834), new DateTime(2025, 12, 8, 2, 57, 51, 605, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 16, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6837), new DateTime(2025, 11, 29, 4, 2, 51, 605, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6840), new DateTime(2025, 11, 28, 9, 17, 51, 605, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6844), new DateTime(2025, 11, 27, 4, 52, 51, 605, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6847), new DateTime(2025, 11, 26, 10, 47, 51, 605, DateTimeKind.Utc).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 16, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6850), new DateTime(2025, 11, 25, 3, 2, 51, 605, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6854), new DateTime(2025, 11, 24, 7, 57, 51, 605, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6857), new DateTime(2025, 11, 23, 6, 7, 51, 605, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6861), new DateTime(2025, 11, 22, 9, 52, 51, 605, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6864), new DateTime(2025, 11, 21, 3, 47, 51, 605, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6867), new DateTime(2025, 11, 20, 9, 12, 51, 605, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6870), new DateTime(2025, 11, 19, 5, 57, 51, 605, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(6874), new DateTime(2025, 11, 18, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 4, 17, 51, 605, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 4, 17, 51, 605, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 10, 17, 51, 605, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 6, 2, 51, 605, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 6, 2, 51, 605, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 6, 47, 51, 605, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 11, 52, 51, 605, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 18, 32, 51, 605, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 5, 57, 51, 605, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-contrast-iodine",
                columns: new[] { "ActiveIngredient", "Name", "PackingDescription", "Price", "SideEffect", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Iodine", "Iodinated Contrast Media", "100ml Vial", 500000, "Allergic reaction, kidney strain", "Store away from light", 1 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-digoxin-125",
                columns: new[] { "BaseUnit", "Name", "PackingDescription", "Price", "SideEffect", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "mcg", "Digoxin 125mcg", "Bottle of 100 tablets", 90000, "Nausea, dizziness, vision changes", "Store at room temperature", 100 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-diltiazem-60",
                columns: new[] { "Price", "SideEffect", "StockTotalQuantity" },
                values: new object[] { 110000, "Edema, headache, dizziness", 400 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-duloxetine-30",
                columns: new[] { "ActiveIngredient", "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "UnitsPerPack" },
                values: new object[] { "Duloxetine", "Box of 28 capsules", "box", 250000, "Nausea, dry mouth, drowsiness", 500, 28 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-hydroxychloroquine-200",
                columns: new[] { "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Box of 30 tablets", "box", 180000, "Retinopathy, nausea, skin rash", 600, "Store at room temperature", 30 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-pregabalin-75",
                columns: new[] { "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Blister pack of 14 capsules", "blister", 210000, "Dizziness, weight gain, swelling", 400, "Store away from moisture", 14 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vancomycin-500",
                columns: new[] { "PackingDescription", "Price", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Single dose vial", 350000, 200, "Store below 25°C", 1 });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "ActiveIngredient", "BaseUnit", "Form", "Name", "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "med-clarithromycin-500", "Clarithromycin", "mg", 0, "Clarithromycin 500mg", "Box of 14 tablets", "box", 200000, "Metallic taste, stomach upset", 400, "Store at room temperature", 14 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 14, 4, 2, 51, 605, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 10, 17, 51, 605, DateTimeKind.Utc).AddTicks(7154), new DateTime(2025, 12, 13, 9, 32, 51, 605, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 12, 13, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(7157), new DateTime(2025, 12, 10, 5, 47, 51, 605, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 12, 5, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 47, 51, 605, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 12, 12, 6, 17, 51, 605, DateTimeKind.Utc).AddTicks(7167), new DateTime(2025, 12, 12, 6, 32, 51, 605, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 8, 11, 17, 51, 605, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 8, 32, 51, 605, DateTimeKind.Utc).AddTicks(7176), new DateTime(2025, 12, 1, 9, 2, 51, 605, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 5, 42, 51, 605, DateTimeKind.Utc).AddTicks(7183), new DateTime(2025, 12, 11, 5, 2, 51, 605, DateTimeKind.Utc).AddTicks(7180), new DateTime(2025, 12, 11, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionID", "CancelledAt", "DispensedAt", "PharmacistID", "PrescriptionDateTime", "Priority", "Reason", "RecordID", "Status", "VerifiedAt" },
                values: new object[,]
                {
                    { "presc-09", null, new DateTime(2025, 12, 7, 10, 52, 51, 605, DateTimeKind.Utc).AddTicks(7188), "phar-01", new DateTime(2025, 12, 7, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(7185), 0, null, "rec-09", 2, new DateTime(2025, 12, 7, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(7187) },
                    { "presc-10", null, new DateTime(2025, 12, 9, 6, 32, 51, 605, DateTimeKind.Utc).AddTicks(7193), "phar-02", new DateTime(2025, 12, 9, 5, 47, 51, 605, DateTimeKind.Utc).AddTicks(7191), 1, null, "rec-10", 2, new DateTime(2025, 12, 9, 6, 17, 51, 605, DateTimeKind.Utc).AddTicks(7192) },
                    { "presc-11", null, null, "phar-01", new DateTime(2025, 12, 3, 3, 57, 51, 605, DateTimeKind.Utc).AddTicks(7196), 2, null, "rec-11", 1, new DateTime(2025, 12, 3, 4, 32, 51, 605, DateTimeKind.Utc).AddTicks(7197) },
                    { "presc-12", null, null, null, new DateTime(2025, 12, 6, 9, 2, 51, 605, DateTimeKind.Utc).AddTicks(7200), 0, null, "rec-12", 0, null },
                    { "presc-13", null, new DateTime(2025, 12, 4, 12, 2, 51, 605, DateTimeKind.Utc).AddTicks(7208), "phar-02", new DateTime(2025, 12, 4, 10, 52, 51, 605, DateTimeKind.Utc).AddTicks(7203), 2, null, "rec-13", 2, new DateTime(2025, 12, 4, 11, 32, 51, 605, DateTimeKind.Utc).AddTicks(7204) },
                    { "presc-14", null, null, "phar-01", new DateTime(2025, 11, 30, 4, 47, 51, 605, DateTimeKind.Utc).AddTicks(7211), 0, null, "rec-14", 1, new DateTime(2025, 11, 30, 5, 17, 51, 605, DateTimeKind.Utc).AddTicks(7212) },
                    { "presc-15", null, null, null, new DateTime(2025, 12, 2, 8, 12, 51, 605, DateTimeKind.Utc).AddTicks(7215), 0, null, "rec-15", 0, null },
                    { "presc-16", null, new DateTime(2025, 12, 8, 3, 47, 51, 605, DateTimeKind.Utc).AddTicks(7220), "phar-02", new DateTime(2025, 12, 8, 2, 57, 51, 605, DateTimeKind.Utc).AddTicks(7218), 0, null, "rec-16", 2, new DateTime(2025, 12, 8, 3, 32, 51, 605, DateTimeKind.Utc).AddTicks(7219) },
                    { "presc-17", new DateTime(2025, 11, 29, 4, 32, 51, 605, DateTimeKind.Utc).AddTicks(7225), null, null, new DateTime(2025, 11, 29, 4, 2, 51, 605, DateTimeKind.Utc).AddTicks(7223), 0, "Patient allergic to prescribed medication.", "rec-17", 3, null },
                    { "presc-18", null, null, "phar-01", new DateTime(2025, 11, 28, 9, 17, 51, 605, DateTimeKind.Utc).AddTicks(7227), 0, null, "rec-18", 1, new DateTime(2025, 11, 28, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(7229) },
                    { "presc-19", null, new DateTime(2025, 11, 27, 5, 57, 51, 605, DateTimeKind.Utc).AddTicks(7234), "phar-02", new DateTime(2025, 11, 27, 4, 52, 51, 605, DateTimeKind.Utc).AddTicks(7232), 1, null, "rec-19", 2, new DateTime(2025, 11, 27, 5, 32, 51, 605, DateTimeKind.Utc).AddTicks(7233) },
                    { "presc-20", null, new DateTime(2025, 11, 26, 12, 2, 51, 605, DateTimeKind.Utc).AddTicks(7238), "phar-01", new DateTime(2025, 11, 26, 10, 47, 51, 605, DateTimeKind.Utc).AddTicks(7236), 2, null, "rec-20", 2, new DateTime(2025, 11, 26, 11, 32, 51, 605, DateTimeKind.Utc).AddTicks(7237) },
                    { "presc-21", null, null, "phar-02", new DateTime(2025, 11, 25, 3, 2, 51, 605, DateTimeKind.Utc).AddTicks(7242), 1, null, "rec-21", 1, new DateTime(2025, 11, 25, 3, 47, 51, 605, DateTimeKind.Utc).AddTicks(7243) },
                    { "presc-22", null, null, null, new DateTime(2025, 11, 24, 7, 57, 51, 605, DateTimeKind.Utc).AddTicks(7246), 0, null, "rec-22", 0, null },
                    { "presc-23", null, new DateTime(2025, 11, 23, 6, 52, 51, 605, DateTimeKind.Utc).AddTicks(7252), "phar-01", new DateTime(2025, 11, 23, 6, 7, 51, 605, DateTimeKind.Utc).AddTicks(7250), 0, null, "rec-23", 2, new DateTime(2025, 11, 23, 6, 32, 51, 605, DateTimeKind.Utc).AddTicks(7251) },
                    { "presc-24", null, null, "phar-02", new DateTime(2025, 11, 22, 9, 52, 51, 605, DateTimeKind.Utc).AddTicks(7255), 0, null, "rec-24", 1, new DateTime(2025, 11, 22, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(7256) },
                    { "presc-25", null, null, null, new DateTime(2025, 11, 21, 3, 47, 51, 605, DateTimeKind.Utc).AddTicks(7259), 0, null, "rec-25", 0, null },
                    { "presc-26", null, new DateTime(2025, 11, 20, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(7264), "phar-01", new DateTime(2025, 11, 20, 9, 12, 51, 605, DateTimeKind.Utc).AddTicks(7262), 1, null, "rec-26", 2, new DateTime(2025, 11, 20, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(7263) },
                    { "presc-27", null, null, "phar-02", new DateTime(2025, 11, 19, 5, 57, 51, 605, DateTimeKind.Utc).AddTicks(7267), 0, null, "rec-27", 1, new DateTime(2025, 11, 19, 6, 32, 51, 605, DateTimeKind.Utc).AddTicks(7268) },
                    { "presc-28", new DateTime(2025, 11, 18, 10, 32, 51, 605, DateTimeKind.Utc).AddTicks(7273), null, null, new DateTime(2025, 11, 18, 10, 2, 51, 605, DateTimeKind.Utc).AddTicks(7271), 0, "Insurance pre-authorization required.", "rec-28", 3, null }
                });
        }
    }
}

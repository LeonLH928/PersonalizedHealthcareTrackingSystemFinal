using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddTwenty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 4, 10, 1, 577, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 20, 10, 1, 577, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 7, 10, 1, 577, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 4, 10, 1, 577, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentDateTime", "ChiefComplaint", "DoctorID", "Location", "Note", "PatientID", "Priority", "Status", "VisitNumber" },
                values: new object[,]
                {
                    { "appt-13", new DateTime(2025, 12, 7, 9, 10, 1, 577, DateTimeKind.Utc).AddTicks(6716), "Persistent cough and fatigue.", "doc-01", "Room 105", "", "pat-03", 0, 2, 2 },
                    { "appt-14", new DateTime(2025, 12, 9, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(6718), "Fever and ear pain.", "doc-02", "Room 208", "", "pat-04", 1, 2, 2 },
                    { "appt-15", new DateTime(2025, 12, 3, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(6720), "Dizziness and occasional fainting.", "doc-03", "Room 305", "", "pat-05", 2, 2, 2 },
                    { "appt-16", new DateTime(2025, 12, 6, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(6723), "Joint pain and swelling.", "doc-04", "Room 403", "", "pat-06", 0, 2, 2 },
                    { "appt-17", new DateTime(2025, 12, 4, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(6726), "Severe abdominal pain.", "doc-01", "Room 106", "", "pat-07", 1, 2, 2 },
                    { "appt-18", new DateTime(2025, 11, 30, 4, 10, 1, 577, DateTimeKind.Utc).AddTicks(6728), "Eye irritation and redness.", "doc-02", "Room 209", "", "pat-08", 0, 2, 2 },
                    { "appt-19", new DateTime(2025, 12, 2, 7, 10, 1, 577, DateTimeKind.Utc).AddTicks(6730), "Memory problems and confusion.", "doc-03", "Room 306", "", "pat-09", 2, 2, 2 },
                    { "appt-20", new DateTime(2025, 12, 8, 2, 10, 1, 577, DateTimeKind.Utc).AddTicks(6732), "Thyroid medication follow-up.", "doc-04", "Room 404", "", "pat-10", 0, 2, 2 },
                    { "appt-21", new DateTime(2025, 12, 19, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(6734), "Cardiac evaluation clearance.", "doc-02", "Room 210", "", "pat-01", 0, 0, 3 },
                    { "appt-22", new DateTime(2025, 12, 20, 9, 10, 1, 577, DateTimeKind.Utc).AddTicks(6736), "Diabetes management review.", "doc-01", "Room 107", "", "pat-02", 0, 0, 3 },
                    { "appt-23", new DateTime(2025, 11, 29, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(6739), "Pre-operative assessment.", "doc-04", "Room 405", "", "pat-03", 0, 2, 3 },
                    { "appt-24", new DateTime(2025, 11, 28, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(6741), "Behavioral issues evaluation.", "doc-03", "Room 307", "", "pat-04", 0, 2, 3 },
                    { "appt-25", new DateTime(2025, 11, 27, 4, 10, 1, 577, DateTimeKind.Utc).AddTicks(6743), "Neurological symptoms assessment.", "doc-02", "Room 211", "", "pat-05", 1, 2, 3 },
                    { "appt-26", new DateTime(2025, 11, 26, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(6745), "Blood disorder investigation.", "doc-01", "Room 108", "", "pat-06", 1, 2, 3 },
                    { "appt-27", new DateTime(2025, 11, 25, 2, 10, 1, 577, DateTimeKind.Utc).AddTicks(6747), "Post-operative follow-up.", "doc-04", "Room 406", "", "pat-07", 0, 2, 3 },
                    { "appt-28", new DateTime(2025, 11, 24, 7, 10, 1, 577, DateTimeKind.Utc).AddTicks(6749), "Autoimmune disease consultation.", "doc-03", "Room 308", "", "pat-08", 0, 2, 3 },
                    { "appt-29", new DateTime(2025, 11, 23, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(6751), "Kidney function evaluation.", "doc-02", "Room 212", "", "pat-09", 0, 2, 3 },
                    { "appt-30", new DateTime(2025, 11, 22, 9, 10, 1, 577, DateTimeKind.Utc).AddTicks(6790), "Endocrine system assessment.", "doc-01", "Room 109", "", "pat-10", 0, 2, 3 },
                    { "appt-31", new DateTime(2025, 12, 21, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(6793), "Surgical consultation second opinion.", "doc-04", "Room 407", "", "pat-01", 0, 0, 4 },
                    { "appt-32", new DateTime(2025, 12, 22, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(6795), "Complex case review.", "doc-03", "Room 309", "", "pat-02", 0, 0, 4 }
                });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7379), new DateTime(2025, 12, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7383), new DateTime(2025, 12, 5, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7387), new DateTime(2025, 12, 6, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7391), new DateTime(2025, 12, 7, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7395), new DateTime(2025, 12, 8, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7399), new DateTime(2025, 12, 9, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7403), new DateTime(2025, 12, 10, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7408), new DateTime(2025, 12, 11, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7412), new DateTime(2025, 12, 12, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7416), new DateTime(2025, 12, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.InsertData(
                table: "DoctorSchedules",
                columns: new[] { "ScheduleID", "CreatedDatetime", "DoctorID", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[,]
                {
                    { "sch-11", new DateTime(2025, 11, 29, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7419), "doc-01", new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7420) },
                    { "sch-12", new DateTime(2025, 11, 30, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7423), "doc-01", new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7424) },
                    { "sch-13", new DateTime(2025, 12, 1, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7427), "doc-02", new DateTime(2025, 12, 8, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7428) },
                    { "sch-14", new DateTime(2025, 12, 2, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7431), "doc-02", new DateTime(2025, 12, 7, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7432) },
                    { "sch-15", new DateTime(2025, 12, 3, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7435), "doc-03", new DateTime(2025, 12, 3, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7435) },
                    { "sch-16", new DateTime(2025, 12, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7439), "doc-03", new DateTime(2025, 12, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7439) },
                    { "sch-17", new DateTime(2025, 12, 5, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7442), "doc-04", new DateTime(2025, 12, 6, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7443) },
                    { "sch-18", new DateTime(2025, 12, 6, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7446), "doc-04", new DateTime(2025, 12, 5, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7447) },
                    { "sch-19", new DateTime(2025, 12, 7, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7450), "doc-01", new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7450) },
                    { "sch-20", new DateTime(2025, 12, 8, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7454), "doc-01", new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7454) },
                    { "sch-21", new DateTime(2025, 12, 9, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7458), "doc-02", new DateTime(2025, 12, 22, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7458) },
                    { "sch-22", new DateTime(2025, 12, 10, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7461), "doc-02", new DateTime(2025, 12, 23, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7462) },
                    { "sch-23", new DateTime(2025, 12, 11, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7465), "doc-03", new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7470) },
                    { "sch-24", new DateTime(2025, 12, 12, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7473), "doc-03", new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7473) },
                    { "sch-25", new DateTime(2025, 12, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7476), "doc-04", new DateTime(2025, 12, 26, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7477) },
                    { "sch-26", new DateTime(2025, 12, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7480), "doc-04", new DateTime(2025, 12, 27, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7481) },
                    { "sch-27", new DateTime(2025, 11, 24, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7484), "doc-01", new DateTime(2025, 12, 1, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 24, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7484) },
                    { "sch-28", new DateTime(2025, 11, 25, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7488), "doc-01", new DateTime(2025, 11, 30, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 25, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7488) },
                    { "sch-29", new DateTime(2025, 11, 26, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7491), "doc-02", new DateTime(2025, 11, 29, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 26, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7492) },
                    { "sch-30", new DateTime(2025, 11, 27, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7495), "doc-02", new DateTime(2025, 11, 28, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7496) }
                });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6850), new DateTime(2025, 12, 14, 3, 25, 1, 577, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6853), new DateTime(2025, 12, 13, 8, 40, 1, 577, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6858), new DateTime(2025, 12, 10, 4, 40, 1, 577, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 17, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6861), new DateTime(2025, 12, 5, 9, 10, 1, 577, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6863), new DateTime(2025, 12, 12, 5, 30, 1, 577, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6866), new DateTime(2025, 12, 8, 10, 35, 1, 577, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6868), new DateTime(2025, 12, 1, 7, 40, 1, 577, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6871), new DateTime(2025, 12, 11, 4, 25, 1, 577, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 3, 55, 1, 577, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 3, 55, 1, 577, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 9, 55, 1, 577, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 5, 40, 1, 577, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 5, 40, 1, 577, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 6, 25, 1, 577, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 8, 11, 30, 1, 577, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 5, 35, 1, 577, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "ActiveIngredient", "BaseUnit", "Form", "Name", "PackingDescription", "PackingUnit", "Price", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[,]
                {
                    { "med-albuterol-syrup", "Albuterol Sulfate", "ml", 2, "Albuterol Syrup 2mg/5ml", "Bottle of 120ml syrup", "bottle", 95000, "Tremor, nervousness, increased heart rate", 200, "Store at room temperature, protect from light", 120 },
                    { "med-amlodipine-5", "Amlodipine Besylate", "mg", 0, "Amlodipine 5mg", "Bottle of 30 tablets", "bottle", 120000, "Swelling in ankles, flushing, headache", 700, "Store at room temperature", 30 },
                    { "med-aspirin-100", "Acetylsalicylic Acid", "mg", 0, "Aspirin 100mg", "Bottle of 100 enteric-coated tablets", "bottle", 75000, "Stomach irritation, bleeding risk", 1500, "Store at room temperature, keep dry", 100 },
                    { "med-azithromycin-250", "Azithromycin", "mg", 0, "Azithromycin 250mg", "Blister pack of 6 tablets", "blister", 180000, "Nausea, diarrhea, abdominal pain", 500, "Store at room temperature", 6 },
                    { "med-clonazepam-0-5", "Clonazepam", "mg", 0, "Clonazepam 0.5mg", "Bottle of 30 tablets", "bottle", 95000, "Drowsiness, dizziness, dependence risk", 150, "Store at room temperature", 30 },
                    { "med-fluoxetine-20", "Fluoxetine Hydrochloride", "mg", 1, "Fluoxetine 20mg", "Bottle of 20 capsules", "bottle", 175000, "Insomnia, headache, sexual dysfunction", 500, "Store at room temperature", 20 },
                    { "med-gabapentin-300", "Gabapentin", "mg", 1, "Gabapentin 300mg", "Bottle of 90 capsules", "bottle", 160000, "Dizziness, drowsiness, coordination problems", 800, "Store at room temperature", 90 },
                    { "med-hydrochlorothiazide-25", "Hydrochlorothiazide", "mg", 0, "Hydrochlorothiazide 25mg", "Bottle of 100 tablets", "bottle", 55000, "Increased urination, dizziness, potassium loss", 600, "Store at room temperature", 100 },
                    { "med-insulin-glargine", "Insulin Glargine", "U", 3, "Insulin Glargine 100U/ml", "Prefilled pen injector 3ml (100U/ml)", "pen", 450000, "Hypoglycemia, weight gain, injection site reactions", 100, "Refrigerate until use, then room temperature for 28 days", 3000 },
                    { "med-levothyroxine-50", "Levothyroxine Sodium", "mcg", 0, "Levothyroxine 50mcg", "Bottle of 100 tablets", "bottle", 110000, "Palpitations, anxiety, weight loss", 1000, "Store at room temperature", 100 },
                    { "med-lisinopril-10", "Lisinopril", "mg", 0, "Lisinopril 10mg", "Bottle of 30 tablets", "bottle", 95000, "Dry cough, dizziness, fatigue", 600, "Store at controlled room temperature", 30 },
                    { "med-losartan-50", "Losartan Potassium", "mg", 0, "Losartan 50mg", "Bottle of 30 tablets", "bottle", 130000, "Dizziness, hyperkalemia, cough", 750, "Store at room temperature", 30 },
                    { "med-metoprolol-25", "Metoprolol Tartrate", "mg", 0, "Metoprolol 25mg", "Bottle of 60 tablets", "bottle", 85000, "Fatigue, dizziness, slow heartbeat", 800, "Store at room temperature", 60 },
                    { "med-ondansetron-4", "Ondansetron Hydrochloride", "mg", 0, "Ondansetron 4mg", "Bottle of 10 orally disintegrating tablets", "bottle", 220000, "Headache, constipation, dizziness", 400, "Store at room temperature", 10 },
                    { "med-prednisone-5", "Prednisone", "mg", 0, "Prednisone 5mg", "Bottle of 20 tablets", "bottle", 65000, "Weight gain, mood changes, increased appetite", 400, "Store at room temperature", 20 },
                    { "med-simvastatin-20", "Simvastatin", "mg", 0, "Simvastatin 20mg", "Bottle of 30 tablets", "bottle", 140000, "Muscle pain, liver enzyme elevation", 900, "Store below 30°C, protect from light", 30 },
                    { "med-tramadol-50", "Tramadol Hydrochloride", "mg", 0, "Tramadol 50mg", "Blister pack of 20 tablets", "blister", 140000, "Dizziness, nausea, constipation, dependence risk", 300, "Store at room temperature", 20 },
                    { "med-warfarin-5", "Warfarin Sodium", "mg", 0, "Warfarin 5mg", "Bottle of 30 scored tablets", "bottle", 95000, "Bleeding risk, bruising, nosebleeds", 200, "Store at room temperature, protected from light", 30 },
                    { "metformin-500", "Metformin Hydrochloride", "mg", 0, "Metformin 500mg", "Bottle of 60 tablets", "bottle", 85000, "Gastrointestinal upset, lactic acidosis risk", 1200, "Store at room temperature", 60 }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 14, 3, 40, 1, 577, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 9, 55, 1, 577, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 12, 13, 9, 10, 1, 577, DateTimeKind.Utc).AddTicks(7114), new DateTime(2025, 12, 13, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 12, 10, 5, 25, 1, 577, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 5, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 12, 5, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 6, 25, 1, 577, DateTimeKind.Utc).AddTicks(7131), new DateTime(2025, 12, 12, 5, 55, 1, 577, DateTimeKind.Utc).AddTicks(7129), new DateTime(2025, 12, 12, 6, 10, 1, 577, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 8, 10, 55, 1, 577, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 8, 10, 1, 577, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 12, 1, 8, 40, 1, 577, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 5, 20, 1, 577, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 12, 11, 4, 40, 1, 577, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 12, 11, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "RecordID", "AppointmentID", "Diagnosis", "DoctorNotes", "NextVisitDate", "TreatmentPlan", "VisitTime" },
                values: new object[,]
                {
                    { "rec-09", "appt-13", "Chronic Bronchitis", "Patient needs pulmonary function tests.", new DateTime(2025, 12, 24, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6874), "Bronchodilators and antibiotics. Smoking cessation counseling.", new DateTime(2025, 12, 7, 9, 30, 1, 577, DateTimeKind.Utc).AddTicks(6873) },
                    { "rec-10", "appt-14", "Acute Otitis Media", "Monitor for hearing changes.", new DateTime(2025, 12, 19, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6876), "Antibiotic ear drops and pain management.", new DateTime(2025, 12, 9, 5, 25, 1, 577, DateTimeKind.Utc).AddTicks(6875) },
                    { "rec-11", "appt-15", "Orthostatic Hypotension", "Cardiac monitoring recommended.", new DateTime(2025, 12, 21, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6878), "Fluid replacement and medication adjustment.", new DateTime(2025, 12, 3, 3, 35, 1, 577, DateTimeKind.Utc).AddTicks(6877) },
                    { "rec-12", "appt-16", "Rheumatoid Arthritis", "Rheumatology referral needed.", new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6881), "Anti-inflammatory medication and physical therapy.", new DateTime(2025, 12, 6, 8, 40, 1, 577, DateTimeKind.Utc).AddTicks(6880) },
                    { "rec-13", "appt-17", "Acute Pancreatitis", "CT scan abdomen ordered. Admit for observation.", new DateTime(2025, 12, 17, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6883), "NPO status, IV fluids, and pain management.", new DateTime(2025, 12, 4, 10, 30, 1, 577, DateTimeKind.Utc).AddTicks(6882) },
                    { "rec-14", "appt-18", "Allergic Conjunctivitis", "Avoid allergens when possible.", new DateTime(2025, 12, 21, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6886), "Antihistamine eye drops and cool compresses.", new DateTime(2025, 11, 30, 4, 25, 1, 577, DateTimeKind.Utc).AddTicks(6885) },
                    { "rec-15", "appt-19", "Mild Cognitive Impairment", "Neurology consultation recommended.", new DateTime(2026, 1, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6888), "Cognitive exercises and regular monitoring.", new DateTime(2025, 12, 2, 7, 50, 1, 577, DateTimeKind.Utc).AddTicks(6887) },
                    { "rec-16", "appt-20", "Hypothyroidism (Controlled)", "TSH levels within normal range.", new DateTime(2026, 3, 14, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6891), "Continue current levothyroxine dosage.", new DateTime(2025, 12, 8, 2, 35, 1, 577, DateTimeKind.Utc).AddTicks(6890) },
                    { "rec-17", "appt-23", "Cholecystitis", "Ultrasound confirms gallbladder inflammation.", new DateTime(2025, 12, 16, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6893), "Surgical consultation for cholecystectomy.", new DateTime(2025, 11, 29, 3, 40, 1, 577, DateTimeKind.Utc).AddTicks(6892) },
                    { "rec-18", "appt-24", "Attention Deficit Hyperactivity Disorder", "School evaluation needed.", new DateTime(2026, 1, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6896), "Behavioral therapy and medication management.", new DateTime(2025, 11, 28, 8, 55, 1, 577, DateTimeKind.Utc).AddTicks(6895) },
                    { "rec-19", "appt-25", "Peripheral Neuropathy", "EMG study ordered.", new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6898), "Neuropathic pain medication and B vitamin supplements.", new DateTime(2025, 11, 27, 4, 30, 1, 577, DateTimeKind.Utc).AddTicks(6897) },
                    { "rec-20", "appt-26", "Iron Deficiency Anemia", "Hemoglobin critically low.", new DateTime(2025, 12, 21, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6901), "Iron infusion and dietary modifications.", new DateTime(2025, 11, 26, 10, 25, 1, 577, DateTimeKind.Utc).AddTicks(6900) },
                    { "rec-21", "appt-27", "Post-operative Infection", "Culture and sensitivity sent.", new DateTime(2025, 12, 16, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6903), "IV antibiotics and wound care.", new DateTime(2025, 11, 25, 2, 40, 1, 577, DateTimeKind.Utc).AddTicks(6902) },
                    { "rec-22", "appt-28", "Systemic Lupus Erythematosus", "Rheumatology follow-up essential.", new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6905), "Immunosuppressants and regular monitoring.", new DateTime(2025, 11, 24, 7, 35, 1, 577, DateTimeKind.Utc).AddTicks(6904) },
                    { "rec-23", "appt-29", "Chronic Kidney Disease Stage 3", "Nephrology referral made.", new DateTime(2026, 1, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6908), "Blood pressure control and dietary protein restriction.", new DateTime(2025, 11, 23, 5, 45, 1, 577, DateTimeKind.Utc).AddTicks(6907) },
                    { "rec-24", "appt-30", "Diabetes Mellitus Type 2", "HbA1c elevated. Dietitian referral needed.", new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6910), "Metformin therapy and lifestyle modifications.", new DateTime(2025, 11, 22, 9, 30, 1, 577, DateTimeKind.Utc).AddTicks(6909) },
                    { "rec-25", "appt-31", "Herniated Disc C6-C7", "Consider surgical intervention if no improvement.", new DateTime(2026, 1, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6913), "Conservative management with physical therapy.", new DateTime(2025, 11, 21, 3, 25, 1, 577, DateTimeKind.Utc).AddTicks(6912) },
                    { "rec-26", "appt-32", "Complex Regional Pain Syndrome", "Specialized pain clinic referral required.", new DateTime(2025, 12, 28, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6915), "Multidisciplinary pain management approach.", new DateTime(2025, 11, 20, 8, 50, 1, 577, DateTimeKind.Utc).AddTicks(6914) },
                    { "rec-27", "appt-21", "Atrial Fibrillation (Controlled)", "Regular ECG monitoring needed.", new DateTime(2026, 1, 13, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6917), "Continue anticoagulation and rate control.", new DateTime(2025, 11, 19, 5, 35, 1, 577, DateTimeKind.Utc).AddTicks(6916) },
                    { "rec-28", "appt-22", "Diabetic Peripheral Neuropathy", "Foot care education provided.", new DateTime(2026, 1, 4, 18, 10, 1, 577, DateTimeKind.Utc).AddTicks(6920), "Glycemic control and neuropathic pain management.", new DateTime(2025, 11, 18, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(6919) }
                });

            migrationBuilder.InsertData(
                table: "ClinicalExaminations",
                columns: new[] { "ClinicalID", "Allergies", "BMI", "BloodPressure", "FamilyHistory", "Height", "LifestyleHabits", "MedicalHistory", "OxygenSaturation", "Pulse", "RecordID", "RespiratoryRate", "StatusBMI", "Symptoms", "Temperature", "Weight" },
                values: new object[,]
                {
                    { "clin-09", "", 23.5, "140/90", "Father had COPD.", 175.0, "Current smoker, 1 pack/day.", "40 pack-year smoking history.", 93.0, 94.0, "rec-09", 22.0, 1, "Productive cough, wheezing, shortness of breath.", 37.799999999999997, 72.0 },
                    { "clin-10", "", 17.899999999999999, "100/65", "", 140.0, "", "Recurrent ear infections.", 99.0, 98.0, "rec-10", 20.0, 1, "Ear pain, decreased hearing, fever.", 38.5, 35.0 },
                    { "clin-11", "Sulfa drugs.", 23.0, "110/70", "", 168.0, "Regular exercise.", "Hypertension on multiple medications.", 98.0, 72.0, "rec-11", 16.0, 1, "Dizziness on standing, lightheadedness.", 36.700000000000003, 65.0 },
                    { "clin-12", "", 22.699999999999999, "125/80", "Mother has rheumatoid arthritis.", 160.0, "Former smoker, quit 5 years ago.", "Family history of autoimmune disease.", 99.0, 80.0, "rec-12", 18.0, 1, "Joint swelling, morning stiffness, limited motion.", 37.200000000000003, 58.0 },
                    { "clin-13", "Penicillin.", 28.600000000000001, "150/95", "Gallbladder disease in family.", 165.0, "High-fat diet.", "Gallstones diagnosed 2 years ago.", 96.0, 110.0, "rec-13", 24.0, 2, "Severe abdominal pain, nausea, vomiting.", 38.799999999999997, 78.0 },
                    { "clin-14", "Pollen, dust mites.", 22.199999999999999, "118/75", "Father has hay fever.", 175.0, "", "Seasonal allergies.", 99.0, 75.0, "rec-14", 16.0, 1, "Itchy eyes, watery discharge, redness.", 36.5, 68.0 },
                    { "clin-15", "", 25.899999999999999, "135/85", "Alzheimer's disease in mother.", 170.0, "Retired teacher, mentally active.", "Mild cognitive decline over 6 months.", 98.0, 78.0, "rec-15", 16.0, 2, "Memory lapses, confusion, difficulty concentrating.", 36.799999999999997, 75.0 },
                    { "clin-16", "", 26.600000000000001, "115/75", "", 162.0, "Light exercise routine.", "Thyroidectomy 10 years ago.", 99.0, 65.0, "rec-16", 16.0, 2, "Fatigue, weight gain, cold intolerance.", 36.200000000000003, 70.0 },
                    { "clin-17", "", 27.699999999999999, "145/90", "", 172.0, "Moderate alcohol use.", "Gallstones, previous cholecystitis attacks.", 97.0, 105.0, "rec-17", 20.0, 2, "Right upper quadrant pain, fever, jaundice.", 39.0, 82.0 },
                    { "clin-18", "", 17.399999999999999, "100/65", "ADHD in older sibling.", 120.0, "High sugar intake.", "Developmental delays noted in school.", 99.0, 85.0, "rec-18", 18.0, 1, "Hyperactivity, inattention, impulsivity.", 36.600000000000001, 25.0 },
                    { "clin-19", "", 26.800000000000001, "140/85", "Neuropathy in father.", 178.0, "Sedentary lifestyle.", "Diabetes for 15 years, poor control.", 98.0, 78.0, "rec-19", 16.0, 2, "Burning feet, tingling sensations, numbness.", 36.700000000000003, 85.0 },
                    { "clin-20", "", 20.0, "105/65", "Iron deficiency anemia in mother.", 155.0, "Vegetarian diet.", "Heavy menstrual bleeding for 6 months.", 97.0, 98.0, "rec-20", 20.0, 1, "Extreme fatigue, pale skin, shortness of breath.", 36.399999999999999, 48.0 },
                    { "clin-21", "Latex.", 24.899999999999999, "130/80", "", 170.0, "", "Appendectomy 2 weeks ago.", 98.0, 95.0, "rec-21", 18.0, 1, "Surgical site redness, drainage, fever.", 38.899999999999999, 72.0 },
                    { "clin-22", "", 20.199999999999999, "125/75", "Lupus in maternal aunt.", 165.0, "Limited sun exposure due to symptoms.", "Autoimmune symptoms for 2 years.", 99.0, 82.0, "rec-22", 16.0, 1, "Joint pain, butterfly rash, photosensitivity.", 37.299999999999997, 55.0 },
                    { "clin-23", "", 28.300000000000001, "160/100", "Kidney disease in father.", 168.0, "High sodium diet.", "Hypertension, diabetes for 10 years.", 97.0, 88.0, "rec-23", 18.0, 2, "Swelling in legs, decreased urine output.", 36.600000000000001, 80.0 },
                    { "clin-24", "", 31.0, "150/95", "Type 2 diabetes in both parents.", 175.0, "Sedentary, high carbohydrate diet.", "Borderline diabetes for 3 years.", 98.0, 85.0, "rec-24", 16.0, 3, "Increased thirst, frequent urination, weight loss.", 36.799999999999997, 95.0 },
                    { "clin-25", "", 27.199999999999999, "130/85", "Cervical spine issues in father.", 180.0, "Poor posture, limited exercise.", "Desk job for 20 years.", 99.0, 76.0, "rec-25", 16.0, 2, "Neck pain, arm weakness, hand numbness.", 36.700000000000003, 88.0 },
                    { "clin-26", "", 22.0, "140/85", "", 165.0, "Limited due to pain.", "Arm fracture 6 months ago.", 98.0, 90.0, "rec-26", 18.0, 1, "Severe burning pain, swelling, skin changes.", 37.100000000000001, 60.0 },
                    { "clin-27", "", 26.399999999999999, "135/80", "Heart disease in father.", 172.0, "Moderate exercise.", "Atrial fibrillation diagnosed 1 year ago.", 98.0, 85.0, "rec-27", 16.0, 2, "Irregular heartbeat, occasional palpitations.", 36.5, 78.0 },
                    { "clin-28", "", 25.899999999999999, "140/85", "Diabetic complications in mother.", 162.0, "Limited mobility due to pain.", "Poorly controlled diabetes for 12 years.", 98.0, 78.0, "rec-28", 16.0, 2, "Foot numbness, burning sensation, difficulty walking.", 36.600000000000001, 68.0 }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionID", "CancelledAt", "DispensedAt", "PharmacistID", "PrescriptionDateTime", "Priority", "Reason", "RecordID", "Status", "VerifiedAt" },
                values: new object[,]
                {
                    { "presc-09", null, new DateTime(2025, 12, 7, 10, 30, 1, 577, DateTimeKind.Utc).AddTicks(7146), "phar-01", new DateTime(2025, 12, 7, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(7144), 0, null, "rec-09", 2, new DateTime(2025, 12, 7, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(7145) },
                    { "presc-10", null, new DateTime(2025, 12, 9, 6, 10, 1, 577, DateTimeKind.Utc).AddTicks(7150), "phar-02", new DateTime(2025, 12, 9, 5, 25, 1, 577, DateTimeKind.Utc).AddTicks(7148), 1, null, "rec-10", 2, new DateTime(2025, 12, 9, 5, 55, 1, 577, DateTimeKind.Utc).AddTicks(7150) },
                    { "presc-11", null, null, "phar-01", new DateTime(2025, 12, 3, 3, 35, 1, 577, DateTimeKind.Utc).AddTicks(7153), 2, null, "rec-11", 1, new DateTime(2025, 12, 3, 4, 10, 1, 577, DateTimeKind.Utc).AddTicks(7154) },
                    { "presc-12", null, null, null, new DateTime(2025, 12, 6, 8, 40, 1, 577, DateTimeKind.Utc).AddTicks(7157), 0, null, "rec-12", 0, null },
                    { "presc-13", null, new DateTime(2025, 12, 4, 11, 40, 1, 577, DateTimeKind.Utc).AddTicks(7163), "phar-02", new DateTime(2025, 12, 4, 10, 30, 1, 577, DateTimeKind.Utc).AddTicks(7160), 2, null, "rec-13", 2, new DateTime(2025, 12, 4, 11, 10, 1, 577, DateTimeKind.Utc).AddTicks(7161) },
                    { "presc-14", null, null, "phar-01", new DateTime(2025, 11, 30, 4, 25, 1, 577, DateTimeKind.Utc).AddTicks(7165), 0, null, "rec-14", 1, new DateTime(2025, 11, 30, 4, 55, 1, 577, DateTimeKind.Utc).AddTicks(7166) },
                    { "presc-15", null, null, null, new DateTime(2025, 12, 2, 7, 50, 1, 577, DateTimeKind.Utc).AddTicks(7169), 0, null, "rec-15", 0, null },
                    { "presc-16", null, new DateTime(2025, 12, 8, 3, 25, 1, 577, DateTimeKind.Utc).AddTicks(7174), "phar-02", new DateTime(2025, 12, 8, 2, 35, 1, 577, DateTimeKind.Utc).AddTicks(7172), 0, null, "rec-16", 2, new DateTime(2025, 12, 8, 3, 10, 1, 577, DateTimeKind.Utc).AddTicks(7173) },
                    { "presc-17", new DateTime(2025, 11, 29, 4, 10, 1, 577, DateTimeKind.Utc).AddTicks(7178), null, null, new DateTime(2025, 11, 29, 3, 40, 1, 577, DateTimeKind.Utc).AddTicks(7176), 0, "Patient allergic to prescribed medication.", "rec-17", 3, null },
                    { "presc-18", null, null, "phar-01", new DateTime(2025, 11, 28, 8, 55, 1, 577, DateTimeKind.Utc).AddTicks(7180), 0, null, "rec-18", 1, new DateTime(2025, 11, 28, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(7181) },
                    { "presc-19", null, new DateTime(2025, 11, 27, 5, 35, 1, 577, DateTimeKind.Utc).AddTicks(7186), "phar-02", new DateTime(2025, 11, 27, 4, 30, 1, 577, DateTimeKind.Utc).AddTicks(7183), 1, null, "rec-19", 2, new DateTime(2025, 11, 27, 5, 10, 1, 577, DateTimeKind.Utc).AddTicks(7184) },
                    { "presc-20", null, new DateTime(2025, 11, 26, 11, 40, 1, 577, DateTimeKind.Utc).AddTicks(7190), "phar-01", new DateTime(2025, 11, 26, 10, 25, 1, 577, DateTimeKind.Utc).AddTicks(7188), 2, null, "rec-20", 2, new DateTime(2025, 11, 26, 11, 10, 1, 577, DateTimeKind.Utc).AddTicks(7189) },
                    { "presc-21", null, null, "phar-02", new DateTime(2025, 11, 25, 2, 40, 1, 577, DateTimeKind.Utc).AddTicks(7192), 1, null, "rec-21", 1, new DateTime(2025, 11, 25, 3, 25, 1, 577, DateTimeKind.Utc).AddTicks(7193) },
                    { "presc-22", null, null, null, new DateTime(2025, 11, 24, 7, 35, 1, 577, DateTimeKind.Utc).AddTicks(7196), 0, null, "rec-22", 0, null },
                    { "presc-23", null, new DateTime(2025, 11, 23, 6, 30, 1, 577, DateTimeKind.Utc).AddTicks(7200), "phar-01", new DateTime(2025, 11, 23, 5, 45, 1, 577, DateTimeKind.Utc).AddTicks(7199), 0, null, "rec-23", 2, new DateTime(2025, 11, 23, 6, 10, 1, 577, DateTimeKind.Utc).AddTicks(7200) },
                    { "presc-24", null, null, "phar-02", new DateTime(2025, 11, 22, 9, 30, 1, 577, DateTimeKind.Utc).AddTicks(7203), 0, null, "rec-24", 1, new DateTime(2025, 11, 22, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(7204) },
                    { "presc-25", null, null, null, new DateTime(2025, 11, 21, 3, 25, 1, 577, DateTimeKind.Utc).AddTicks(7206), 0, null, "rec-25", 0, null },
                    { "presc-26", null, new DateTime(2025, 11, 20, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(7211), "phar-01", new DateTime(2025, 11, 20, 8, 50, 1, 577, DateTimeKind.Utc).AddTicks(7209), 1, null, "rec-26", 2, new DateTime(2025, 11, 20, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(7210) },
                    { "presc-27", null, null, "phar-02", new DateTime(2025, 11, 19, 5, 35, 1, 577, DateTimeKind.Utc).AddTicks(7213), 0, null, "rec-27", 1, new DateTime(2025, 11, 19, 6, 10, 1, 577, DateTimeKind.Utc).AddTicks(7214) },
                    { "presc-28", new DateTime(2025, 11, 18, 10, 10, 1, 577, DateTimeKind.Utc).AddTicks(7217), null, null, new DateTime(2025, 11, 18, 9, 40, 1, 577, DateTimeKind.Utc).AddTicks(7216), 0, "Insurance pre-authorization required.", "rec-28", 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-09");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-10");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-11");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-12");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-13");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-14");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-15");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-16");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-17");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-18");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-19");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-20");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-21");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-22");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-23");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-24");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-25");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-26");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-27");

            migrationBuilder.DeleteData(
                table: "ClinicalExaminations",
                keyColumn: "ClinicalID",
                keyValue: "clin-28");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29");

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-albuterol-syrup");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-amlodipine-5");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-aspirin-100");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-azithromycin-250");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-clonazepam-0-5");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-fluoxetine-20");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-gabapentin-300");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-hydrochlorothiazide-25");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-insulin-glargine");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-levothyroxine-50");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-lisinopril-10");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-losartan-50");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-metoprolol-25");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ondansetron-4");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-prednisone-5");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-simvastatin-20");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-tramadol-50");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-warfarin-5");

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "metformin-500");

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

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27");

            migrationBuilder.DeleteData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32");

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
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7581), new DateTime(2025, 12, 4, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7586), new DateTime(2025, 12, 5, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7590), new DateTime(2025, 12, 6, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7594), new DateTime(2025, 12, 7, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7598), new DateTime(2025, 12, 8, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7602), new DateTime(2025, 12, 9, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7605), new DateTime(2025, 12, 10, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 12, 11, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7613), new DateTime(2025, 12, 12, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7617), new DateTime(2025, 12, 13, 7, 4, 9, 337, DateTimeKind.Utc).AddTicks(7618) });

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
        }
    }
}

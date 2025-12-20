using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class NewModelMedicationAdherence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicationAdherences",
                columns: table => new
                {
                    AdherenceID = table.Column<string>(type: "text", nullable: false),
                    PrescriptionItemID = table.Column<string>(type: "text", nullable: false),
                    ScheduledDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TakenDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationAdherences", x => x.AdherenceID);
                    table.ForeignKey(
                        name: "FK_MedicationAdherences_PrescriptionItems_PrescriptionItemID",
                        column: x => x.PrescriptionItemID,
                        principalTable: "PrescriptionItems",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 11, 36, 30, 568, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 22, 36, 30, 568, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 6, 22, 36, 30, 568, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 17, 36, 30, 568, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 23, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 25, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 17, 36, 30, 568, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 28, 22, 36, 30, 568, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 25, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 26, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8119), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8130), new DateTime(2025, 12, 17, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8134), new DateTime(2025, 12, 14, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8138), new DateTime(2025, 12, 9, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 12, 19, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8148), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8152), new DateTime(2025, 12, 22, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8157), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8162), new DateTime(2025, 12, 24, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8175), new DateTime(2025, 12, 13, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 12, 12, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8185), new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8189), new DateTime(2025, 12, 7, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8194), new DateTime(2025, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8198), new DateTime(2025, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8203), new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8207), new DateTime(2025, 12, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8211), new DateTime(2025, 12, 27, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8216), new DateTime(2025, 12, 28, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 28, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 12, 29, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 29, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 17, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8225), new DateTime(2025, 12, 30, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8229), new DateTime(2025, 12, 31, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 31, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8234), new DateTime(2026, 1, 1, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 29, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8238), new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 30, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 1, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 12, 4, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 12, 3, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 12, 18, 18, 51, 30, 568, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7229), new DateTime(2025, 12, 18, 0, 6, 30, 568, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7236), new DateTime(2025, 12, 14, 20, 6, 30, 568, DateTimeKind.Utc).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7239), new DateTime(2025, 12, 10, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7243), new DateTime(2025, 12, 16, 20, 56, 30, 568, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 12, 13, 2, 1, 30, 568, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7249), new DateTime(2025, 12, 5, 23, 6, 30, 568, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 12, 15, 19, 51, 30, 568, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 29, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 12, 12, 0, 56, 30, 568, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7259), new DateTime(2025, 12, 13, 20, 51, 30, 568, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7262), new DateTime(2025, 12, 7, 19, 1, 30, 568, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7266), new DateTime(2025, 12, 11, 0, 6, 30, 568, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7270), new DateTime(2025, 12, 9, 1, 56, 30, 568, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7273), new DateTime(2025, 12, 4, 19, 51, 30, 568, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7276), new DateTime(2025, 12, 6, 23, 16, 30, 568, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7279), new DateTime(2025, 12, 12, 18, 1, 30, 568, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7282), new DateTime(2025, 12, 3, 19, 6, 30, 568, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7285), new DateTime(2025, 12, 3, 0, 21, 30, 568, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7288), new DateTime(2025, 12, 1, 19, 56, 30, 568, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 26, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7291), new DateTime(2025, 12, 1, 1, 51, 30, 568, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 21, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7294), new DateTime(2025, 11, 29, 18, 6, 30, 568, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7298), new DateTime(2025, 11, 28, 23, 1, 30, 568, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 11, 27, 21, 11, 30, 568, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 11, 27, 0, 56, 30, 568, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7307), new DateTime(2025, 11, 25, 18, 51, 30, 568, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 2, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 11, 25, 0, 16, 30, 568, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 18, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 11, 23, 21, 1, 30, 568, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 9, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(7316), new DateTime(2025, 11, 23, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 19, 21, 30, 568, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 19, 21, 30, 568, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 18, 1, 21, 30, 568, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 21, 6, 30, 568, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 21, 6, 30, 568, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 21, 51, 30, 568, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 2, 56, 30, 568, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 15, 21, 1, 30, 568, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-14",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-15",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-16",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-17",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-18",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-19",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 19, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-20",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-21",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-22",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-23",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-24",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 2, 36, 30, 568, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-25",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 9, 2, 36, 30, 568, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-26",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-27",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-28",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 6, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-29",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-30",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-31",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-32",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 2, 36, 30, 568, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-34",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-35",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-36",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-37",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-39",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-40",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 9, 36, 30, 568, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-41",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 2, 36, 30, 568, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-42",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 22, 36, 30, 568, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-43",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 22, 36, 30, 568, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-44",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-45",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 28, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 18, 19, 6, 30, 568, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 1, 21, 30, 568, DateTimeKind.Utc).AddTicks(7608), new DateTime(2025, 12, 18, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7601), new DateTime(2025, 12, 18, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7611), new DateTime(2025, 12, 14, 20, 51, 30, 568, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 10, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7617), new DateTime(2025, 12, 10, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 16, 21, 51, 30, 568, DateTimeKind.Utc).AddTicks(7621), new DateTime(2025, 12, 16, 21, 21, 30, 568, DateTimeKind.Utc).AddTicks(7619), new DateTime(2025, 12, 16, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 13, 2, 21, 30, 568, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7627), new DateTime(2025, 12, 6, 0, 6, 30, 568, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 15, 20, 46, 30, 568, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 12, 15, 20, 6, 30, 568, DateTimeKind.Utc).AddTicks(7631), new DateTime(2025, 12, 15, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-09",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7639), new DateTime(2025, 12, 12, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7637), new DateTime(2025, 12, 12, 1, 21, 30, 568, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-10",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 12, 13, 21, 6, 30, 568, DateTimeKind.Utc).AddTicks(7684), new DateTime(2025, 12, 13, 21, 21, 30, 568, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-11",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 12, 7, 19, 6, 30, 568, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 12, 7, 19, 21, 30, 568, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-12",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 22, 36, 30, 568, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 12, 5, 22, 6, 30, 568, DateTimeKind.Utc).AddTicks(7694), new DateTime(2025, 12, 5, 22, 21, 30, 568, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-13",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 9, 2, 36, 30, 568, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 12, 9, 2, 6, 30, 568, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 12, 9, 2, 21, 30, 568, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-14",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 12, 4, 20, 6, 30, 568, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 12, 4, 20, 21, 30, 568, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-15",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 6, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 12, 6, 23, 6, 30, 568, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 12, 6, 23, 21, 30, 568, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-16",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 36, 30, 568, DateTimeKind.Utc).AddTicks(7715), new DateTime(2025, 12, 12, 18, 6, 30, 568, DateTimeKind.Utc).AddTicks(7713), new DateTime(2025, 12, 12, 18, 21, 30, 568, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-17",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7720), new DateTime(2025, 12, 4, 0, 6, 30, 568, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-18",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 12, 3, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7722), new DateTime(2025, 12, 3, 1, 21, 30, 568, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-19",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 12, 1, 20, 6, 30, 568, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 12, 1, 20, 21, 30, 568, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-20",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 2, 36, 30, 568, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 12, 1, 2, 6, 30, 568, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 12, 1, 2, 21, 30, 568, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-21",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 23, 36, 30, 568, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 11, 29, 23, 6, 30, 568, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 11, 29, 23, 21, 30, 568, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-22",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 28, 20, 36, 30, 568, DateTimeKind.Utc).AddTicks(7749), new DateTime(2025, 11, 28, 20, 6, 30, 568, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 11, 28, 20, 21, 30, 568, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-23",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(7755), new DateTime(2025, 11, 27, 21, 6, 30, 568, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 11, 27, 21, 21, 30, 568, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-24",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7760), new DateTime(2025, 11, 27, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7758), new DateTime(2025, 11, 27, 1, 21, 30, 568, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-25",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 19, 36, 30, 568, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 11, 25, 19, 6, 30, 568, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 11, 25, 19, 21, 30, 568, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-26",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 1, 36, 30, 568, DateTimeKind.Utc).AddTicks(7772), new DateTime(2025, 11, 25, 1, 6, 30, 568, DateTimeKind.Utc).AddTicks(7769), new DateTime(2025, 11, 25, 1, 21, 30, 568, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-27",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 21, 36, 30, 568, DateTimeKind.Utc).AddTicks(7778), new DateTime(2025, 11, 23, 21, 6, 30, 568, DateTimeKind.Utc).AddTicks(7775), new DateTime(2025, 11, 23, 21, 21, 30, 568, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-28",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 36, 30, 568, DateTimeKind.Utc).AddTicks(7783), new DateTime(2025, 11, 23, 0, 6, 30, 568, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 11, 23, 0, 21, 30, 568, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.CreateIndex(
                name: "IX_MedicationAdherences_PrescriptionItemID",
                table: "MedicationAdherences",
                column: "PrescriptionItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicationAdherences");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 16, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 15, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 12, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 18, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 17, 10, 59, 16, 27, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-07",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 14, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-08",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-09",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 21, 59, 16, 27, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-10",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 13, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-11",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 19, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-12",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 20, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-13",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-14",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 11, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-15",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 5, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-16",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-17",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-18",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 2, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-19",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 4, 21, 59, 16, 27, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-20",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 10, 16, 59, 16, 27, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-21",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 21, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-22",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 22, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-23",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 1, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-24",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 30, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-25",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-26",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-27",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 27, 16, 59, 16, 27, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-28",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 26, 21, 59, 16, 27, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-29",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 25, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-30",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 24, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-31",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 23, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-32",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 24, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-01",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6325), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-02",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6330), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-03",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 12, 15, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-04",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6338), new DateTime(2025, 12, 12, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-05",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6342), new DateTime(2025, 12, 7, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-06",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6345), new DateTime(2025, 12, 17, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-07",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-08",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6354), new DateTime(2025, 12, 20, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-09",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6358), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-10",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6361), new DateTime(2025, 12, 22, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-11",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 2, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6365), new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-12",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 3, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6369), new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-13",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 4, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6373), new DateTime(2025, 12, 11, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-14",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 5, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6377), new DateTime(2025, 12, 10, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-15",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 6, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6380), new DateTime(2025, 12, 6, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-16",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6385), new DateTime(2025, 12, 5, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-17",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 8, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6389), new DateTime(2025, 12, 9, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-18",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 9, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6393), new DateTime(2025, 12, 8, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 7, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-19",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 10, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6396), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-20",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 11, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6400), new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-21",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 12, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6404), new DateTime(2025, 12, 25, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-22",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 13, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6408), new DateTime(2025, 12, 26, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-23",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 14, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 12, 27, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-24",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 15, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6415), new DateTime(2025, 12, 28, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 28, 9, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-25",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6418), new DateTime(2025, 12, 29, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 29, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-26",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 12, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6422), new DateTime(2025, 12, 30, 16, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 30, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-27",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 27, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6426), new DateTime(2025, 12, 4, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 27, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-28",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 28, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6429), new DateTime(2025, 12, 3, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 3, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 28, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-29",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 29, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6433), new DateTime(2025, 12, 2, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 2, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 29, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "DoctorSchedules",
                keyColumn: "ScheduleID",
                keyValue: "sch-30",
                columns: new[] { "CreatedDatetime", "EndTime", "StartTime", "UpdatedDatetime" },
                values: new object[] { new DateTime(2025, 11, 30, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6436), new DateTime(2025, 12, 1, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 1, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 11, 30, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5709), new DateTime(2025, 12, 16, 18, 14, 16, 27, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5712), new DateTime(2025, 12, 15, 23, 29, 16, 27, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5718), new DateTime(2025, 12, 12, 19, 29, 16, 27, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 20, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5720), new DateTime(2025, 12, 7, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-05",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5723), new DateTime(2025, 12, 14, 20, 19, 16, 27, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-06",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 11, 1, 24, 16, 27, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-07",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5728), new DateTime(2025, 12, 3, 22, 29, 16, 27, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-08",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5730), new DateTime(2025, 12, 13, 19, 14, 16, 27, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-09",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 27, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5734), new DateTime(2025, 12, 10, 0, 19, 16, 27, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-10",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5736), new DateTime(2025, 12, 11, 20, 14, 16, 27, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-11",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5739), new DateTime(2025, 12, 5, 18, 24, 16, 27, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-12",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5742), new DateTime(2025, 12, 8, 23, 29, 16, 27, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-13",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 20, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5745), new DateTime(2025, 12, 7, 1, 19, 16, 27, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-14",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5747), new DateTime(2025, 12, 2, 19, 14, 16, 27, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-15",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5750), new DateTime(2025, 12, 4, 22, 39, 16, 27, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-16",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5752), new DateTime(2025, 12, 10, 17, 24, 16, 27, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-17",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5755), new DateTime(2025, 12, 1, 18, 29, 16, 27, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-18",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5757), new DateTime(2025, 11, 30, 23, 44, 16, 27, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-19",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5760), new DateTime(2025, 11, 29, 19, 19, 16, 27, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-20",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 24, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5762), new DateTime(2025, 11, 29, 1, 14, 16, 27, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-21",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 19, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5765), new DateTime(2025, 11, 27, 17, 29, 16, 27, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-22",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5767), new DateTime(2025, 11, 26, 22, 24, 16, 27, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-23",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5770), new DateTime(2025, 11, 25, 20, 34, 16, 27, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-24",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5772), new DateTime(2025, 11, 25, 0, 19, 16, 27, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-25",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5775), new DateTime(2025, 11, 23, 18, 14, 16, 27, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-26",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 31, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5777), new DateTime(2025, 11, 22, 23, 39, 16, 27, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-27",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 16, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5780), new DateTime(2025, 11, 21, 20, 24, 16, 27, DateTimeKind.Utc).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-28",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 7, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(5782), new DateTime(2025, 11, 21, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 18, 44, 16, 27, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 18, 44, 16, 27, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 16, 0, 44, 16, 27, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 20, 29, 16, 27, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 20, 29, 16, 27, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-08",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-10",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 21, 14, 16, 27, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-11",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 2, 19, 16, 27, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-12",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-13",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 13, 20, 24, 16, 27, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-14",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-15",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-16",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-17",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-18",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-19",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 17, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-20",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-21",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-22",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 11, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-23",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 5, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-24",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 1, 59, 16, 27, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-25",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 1, 59, 16, 27, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-26",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 2, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-27",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-28",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-29",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 10, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-30",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 1, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-31",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-32",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 1, 59, 16, 27, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-34",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 25, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-35",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-36",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 23, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-37",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 21, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 20, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-39",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 12, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-40",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 14, 8, 59, 16, 27, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-41",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 29, 1, 59, 16, 27, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-42",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 21, 59, 16, 27, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-43",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 3, 21, 59, 16, 27, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-44",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 27, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-45",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 26, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 16, 18, 29, 16, 27, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 16, 0, 44, 16, 27, DateTimeKind.Utc).AddTicks(5988), new DateTime(2025, 12, 15, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(5982), new DateTime(2025, 12, 16, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(5990), new DateTime(2025, 12, 12, 20, 14, 16, 27, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 8, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(5995), new DateTime(2025, 12, 8, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-05",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 21, 14, 16, 27, DateTimeKind.Utc).AddTicks(5999), new DateTime(2025, 12, 14, 20, 44, 16, 27, DateTimeKind.Utc).AddTicks(5997), new DateTime(2025, 12, 14, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-06",
                column: "PrescriptionDateTime",
                value: new DateTime(2025, 12, 11, 1, 44, 16, 27, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-07",
                columns: new[] { "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(6004), new DateTime(2025, 12, 3, 23, 29, 16, 27, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-08",
                columns: new[] { "CancelledAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 20, 9, 16, 27, DateTimeKind.Utc).AddTicks(6009), new DateTime(2025, 12, 13, 19, 29, 16, 27, DateTimeKind.Utc).AddTicks(6007), new DateTime(2025, 12, 13, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-09",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6014), new DateTime(2025, 12, 10, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(6012), new DateTime(2025, 12, 10, 0, 44, 16, 27, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-10",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 11, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(6019), new DateTime(2025, 12, 11, 20, 29, 16, 27, DateTimeKind.Utc).AddTicks(6017), new DateTime(2025, 12, 11, 20, 44, 16, 27, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-11",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(6023), new DateTime(2025, 12, 5, 18, 29, 16, 27, DateTimeKind.Utc).AddTicks(6021), new DateTime(2025, 12, 5, 18, 44, 16, 27, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-12",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 3, 21, 59, 16, 27, DateTimeKind.Utc).AddTicks(6027), new DateTime(2025, 12, 3, 21, 29, 16, 27, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 12, 3, 21, 44, 16, 27, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-13",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 1, 59, 16, 27, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 12, 7, 1, 29, 16, 27, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 12, 7, 1, 44, 16, 27, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-14",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 2, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6058), new DateTime(2025, 12, 2, 19, 29, 16, 27, DateTimeKind.Utc).AddTicks(6056), new DateTime(2025, 12, 2, 19, 44, 16, 27, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-15",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(6063), new DateTime(2025, 12, 4, 22, 29, 16, 27, DateTimeKind.Utc).AddTicks(6061), new DateTime(2025, 12, 4, 22, 44, 16, 27, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-16",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 59, 16, 27, DateTimeKind.Utc).AddTicks(6067), new DateTime(2025, 12, 10, 17, 29, 16, 27, DateTimeKind.Utc).AddTicks(6065), new DateTime(2025, 12, 10, 17, 44, 16, 27, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-17",
                columns: new[] { "CancelledAt", "PrescriptionDateTime" },
                values: new object[] { new DateTime(2025, 12, 1, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 12, 1, 23, 29, 16, 27, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-18",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 12, 1, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(6072), new DateTime(2025, 12, 1, 0, 44, 16, 27, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-19",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6078), new DateTime(2025, 11, 29, 19, 29, 16, 27, DateTimeKind.Utc).AddTicks(6076), new DateTime(2025, 11, 29, 19, 44, 16, 27, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-20",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 29, 1, 59, 16, 27, DateTimeKind.Utc).AddTicks(6083), new DateTime(2025, 11, 29, 1, 29, 16, 27, DateTimeKind.Utc).AddTicks(6080), new DateTime(2025, 11, 29, 1, 44, 16, 27, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-21",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 59, 16, 27, DateTimeKind.Utc).AddTicks(6087), new DateTime(2025, 11, 27, 22, 29, 16, 27, DateTimeKind.Utc).AddTicks(6085), new DateTime(2025, 11, 27, 22, 44, 16, 27, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-22",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 26, 19, 59, 16, 27, DateTimeKind.Utc).AddTicks(6091), new DateTime(2025, 11, 26, 19, 29, 16, 27, DateTimeKind.Utc).AddTicks(6089), new DateTime(2025, 11, 26, 19, 44, 16, 27, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-23",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(6095), new DateTime(2025, 11, 25, 20, 29, 16, 27, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 11, 25, 20, 44, 16, 27, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-24",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 25, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6099), new DateTime(2025, 11, 25, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(6097), new DateTime(2025, 11, 25, 0, 44, 16, 27, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-25",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 59, 16, 27, DateTimeKind.Utc).AddTicks(6103), new DateTime(2025, 11, 23, 18, 29, 16, 27, DateTimeKind.Utc).AddTicks(6101), new DateTime(2025, 11, 23, 18, 44, 16, 27, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-26",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 23, 0, 59, 16, 27, DateTimeKind.Utc).AddTicks(6107), new DateTime(2025, 11, 23, 0, 29, 16, 27, DateTimeKind.Utc).AddTicks(6105), new DateTime(2025, 11, 23, 0, 44, 16, 27, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-27",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 21, 20, 59, 16, 27, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 11, 21, 20, 29, 16, 27, DateTimeKind.Utc).AddTicks(6109), new DateTime(2025, 11, 21, 20, 44, 16, 27, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-28",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 11, 20, 23, 59, 16, 27, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 11, 20, 23, 29, 16, 27, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 11, 20, 23, 44, 16, 27, DateTimeKind.Utc).AddTicks(6114) });
        }
    }
}

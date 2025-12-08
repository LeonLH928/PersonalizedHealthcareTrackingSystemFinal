using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsAndFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Medications",
                newName: "PackingUnit");

            migrationBuilder.RenameColumn(
                name: "StockQuantityUnit",
                table: "Medications",
                newName: "PackingDescription");

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Medications",
                newName: "UnitsPerPack");

            migrationBuilder.AddColumn<string>(
                name: "ActiveIngredient",
                table: "Medications",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BaseUnit",
                table: "Medications",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StockTotalQuantity",
                table: "Medications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-01",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 22, 12, 9, 224, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-02",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 7, 3, 12, 9, 224, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-03",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 3, 23, 12, 9, 224, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-04",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 9, 22, 12, 9, 224, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-05",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 11, 29, 3, 12, 9, 224, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: "appt-06",
                column: "AppointmentDateTime",
                value: new DateTime(2025, 12, 8, 15, 12, 9, 224, DateTimeKind.Utc).AddTicks(1697));

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
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-01",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1740), new DateTime(2025, 12, 7, 22, 27, 9, 224, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-02",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2026, 1, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1744), new DateTime(2025, 12, 7, 3, 42, 9, 224, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-03",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 22, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1750), new DateTime(2025, 12, 3, 23, 42, 9, 224, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "RecordID",
                keyValue: "rec-04",
                columns: new[] { "NextVisitDate", "VisitTime" },
                values: new object[] { new DateTime(2025, 12, 11, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1753), new DateTime(2025, 11, 29, 4, 12, 9, 224, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-01",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-02",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-03",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 22, 57, 9, 224, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-04",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 22, 57, 9, 224, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-05",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 7, 4, 57, 9, 224, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-06",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 0, 42, 9, 224, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "MedicationStockLogs",
                keyColumn: "LogID",
                keyValue: "log-07",
                column: "CreatedAt",
                value: new DateTime(2025, 12, 4, 0, 42, 9, 224, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-amox-500",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Amoxicillin", "mg", "Box of 20 tablets", "box", "Nausea, rash, diarrhea", 1000, "Store at room temperature, away from moisture", 20 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ator-20",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "UnitsPerPack" },
                values: new object[] { "Atorvastatin Calcium", "mg", "Box of 30 tablets", "box", "Muscle pain, digestive issues, liver enzyme changes", 800, 30 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-cet-10",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Cetirizine Dihydrochloride", "mg", "Blister pack of 10 tablets", "blister", "Drowsiness, dry mouth, fatigue", 2000, "Store in a dry place, protected from light", 10 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ibu-400",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Ibuprofen", "mg", "Bottle of 50 tablets", "bottle", "Stomach upset, heartburn, dizziness", 500, "Keep dry, store below 30°C", 50 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-met-850",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "UnitsPerPack" },
                values: new object[] { "Metformin Hydrochloride", "mg", "Box of 60 tablets", "box", "Nausea, gastrointestinal disturbance, metallic taste", 800, 60 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-omep-20",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Omeprazole", "mg", "Bottle of 28 capsules", "bottle", "Headache, nausea, diarrhea, stomach pain", 1200, "Keep away from light and moisture", 28 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-para-500",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Paracetamol", "mg", "Box of 10 blisters x 10 tablets", "box", "Liver toxicity (high dose or long-term use)", 2000, "Store in a cool, dry place", 100 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-salb-inhaler",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Salbutamol Sulfate", "mcg", "Canister with 200 metered doses", "canister", "Tremors, nervousness, increased heart rate", 300, "Store below 30°C, away from direct sunlight and heat", 200 });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vit-c-500",
                columns: new[] { "ActiveIngredient", "BaseUnit", "PackingDescription", "PackingUnit", "SideEffect", "StockTotalQuantity", "StorageInstruction", "UnitsPerPack" },
                values: new object[] { "Ascorbic Acid", "mg", "Bottle of 100 chewable tablets", "bottle", "Stomach cramps, nausea (high dose)", 5000, "Keep tightly closed in a cool, dry place", 100 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-01",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1840), new DateTime(2025, 12, 7, 22, 42, 9, 224, DateTimeKind.Utc).AddTicks(1831), new DateTime(2025, 12, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-02",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 7, 4, 57, 9, 224, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 12, 7, 4, 12, 9, 224, DateTimeKind.Utc).AddTicks(1843), new DateTime(2025, 12, 7, 4, 42, 9, 224, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-03",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 0, 42, 9, 224, DateTimeKind.Utc).AddTicks(1849), new DateTime(2025, 12, 4, 0, 12, 9, 224, DateTimeKind.Utc).AddTicks(1847), new DateTime(2025, 12, 4, 0, 27, 9, 224, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: "presc-04",
                columns: new[] { "DispensedAt", "PrescriptionDateTime", "VerifiedAt" },
                values: new object[] { new DateTime(2025, 12, 8, 13, 12, 9, 224, DateTimeKind.Utc).AddTicks(1853), new DateTime(2025, 11, 29, 4, 42, 9, 224, DateTimeKind.Utc).AddTicks(1851), new DateTime(2025, 11, 29, 5, 12, 9, 224, DateTimeKind.Utc).AddTicks(1852) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveIngredient",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "BaseUnit",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "StockTotalQuantity",
                table: "Medications");

            migrationBuilder.RenameColumn(
                name: "UnitsPerPack",
                table: "Medications",
                newName: "StockQuantity");

            migrationBuilder.RenameColumn(
                name: "PackingUnit",
                table: "Medications",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "PackingDescription",
                table: "Medications",
                newName: "StockQuantityUnit");

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
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-amox-500",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Nausea, rash", 1000, "box", "Store at room temperature", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ator-20",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "Unit" },
                values: new object[] { "Muscle pain, digestive issues", 800, "box", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-cet-10",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Drowsiness, dry mouth", 2000, "blister", "Store in dry place", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-ibu-400",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Stomach upset", 500, "bottle", "Keep dry", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-met-850",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "Unit" },
                values: new object[] { "Nausea, gastrointestinal disturbance", 800, "box", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-omep-20",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Headache, nausea", 1200, "bottle", "Keep away from light", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-para-500",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Liver toxicity (high dose)", 2000, "box", "Store in cool place", "mg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-salb-inhaler",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Tremors, nervousness", 300, "canister", "Store below 30°C", "mcg" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: "med-vit-c-500",
                columns: new[] { "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[] { "Stomach cramps (high dose)", 5000, "bottle", "Keep tightly closed", "mg" });

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalizedHealthcareTrackingSystemFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    MedicationID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Form = table.Column<int>(type: "integer", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    SideEffect = table.Column<string>(type: "text", nullable: false),
                    StorageInstruction = table.Column<string>(type: "text", nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false),
                    StockQuantityUnit = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.MedicationID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "MedicationInteractions",
                columns: table => new
                {
                    InteractionId = table.Column<string>(type: "text", nullable: false),
                    Severity = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ClinicalEffects = table.Column<string>(type: "text", nullable: false),
                    Management = table.Column<string>(type: "text", nullable: false),
                    MedicationID1 = table.Column<string>(type: "text", nullable: false),
                    MedicationID2 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationInteractions", x => x.InteractionId);
                    table.ForeignKey(
                        name: "FK_MedicationInteractions_Medications_MedicationID1",
                        column: x => x.MedicationID1,
                        principalTable: "Medications",
                        principalColumn: "MedicationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicationInteractions_Medications_MedicationID2",
                        column: x => x.MedicationID2,
                        principalTable: "Medications",
                        principalColumn: "MedicationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<string>(type: "text", nullable: false),
                    Specialization = table.Column<string>(type: "text", nullable: false),
                    ConsultationFee = table.Column<double>(type: "double precision", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    InsuranceNumber = table.Column<string>(type: "text", nullable: false),
                    BloodType = table.Column<string>(type: "text", nullable: false),
                    UserID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patients_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacists",
                columns: table => new
                {
                    PharmacistID = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: false),
                    UserID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacists", x => x.PharmacistID);
                    table.ForeignKey(
                        name: "FK_Pharmacists_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSchedules",
                columns: table => new
                {
                    ScheduleID = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DoctorID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSchedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_DoctorSchedules_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<string>(type: "text", nullable: false),
                    AppointmentDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ChiefComplaint = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    VisitNumber = table.Column<int>(type: "integer", nullable: false),
                    PatientID = table.Column<string>(type: "text", nullable: false),
                    DoctorID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    RecordID = table.Column<string>(type: "text", nullable: false),
                    VisitTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Diagnosis = table.Column<string>(type: "text", nullable: false),
                    TreatmentPlan = table.Column<string>(type: "text", nullable: false),
                    DoctorNotes = table.Column<string>(type: "text", nullable: false),
                    NextVisitDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AppointmentID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Appointments_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClinicalExaminations",
                columns: table => new
                {
                    ClinicalID = table.Column<string>(type: "text", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: false),
                    MedicalHistory = table.Column<string>(type: "text", nullable: false),
                    FamilyHistory = table.Column<string>(type: "text", nullable: false),
                    LifestyleHabits = table.Column<string>(type: "text", nullable: false),
                    Allergies = table.Column<string>(type: "text", nullable: false),
                    Temperature = table.Column<double>(type: "double precision", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    Pulse = table.Column<double>(type: "double precision", nullable: false),
                    BloodPressure = table.Column<string>(type: "text", nullable: false),
                    RespiratoryRate = table.Column<double>(type: "double precision", nullable: false),
                    OxygenSaturation = table.Column<double>(type: "double precision", nullable: false),
                    RecordID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicalExaminations", x => x.ClinicalID);
                    table.ForeignKey(
                        name: "FK_ClinicalExaminations_MedicalRecords_RecordID",
                        column: x => x.RecordID,
                        principalTable: "MedicalRecords",
                        principalColumn: "RecordID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    PrescriptionID = table.Column<string>(type: "text", nullable: false),
                    PrescriptionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    VerifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DispensedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    RecordID = table.Column<string>(type: "text", nullable: false),
                    PharmacistID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.PrescriptionID);
                    table.ForeignKey(
                        name: "FK_Prescriptions_MedicalRecords_RecordID",
                        column: x => x.RecordID,
                        principalTable: "MedicalRecords",
                        principalColumn: "RecordID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Pharmacists_PharmacistID",
                        column: x => x.PharmacistID,
                        principalTable: "Pharmacists",
                        principalColumn: "PharmacistID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "MedicationStockLogs",
                columns: table => new
                {
                    LogID = table.Column<string>(type: "text", nullable: false),
                    QuantityChange = table.Column<int>(type: "integer", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MedicationID = table.Column<string>(type: "text", nullable: false),
                    RelatedPrescriptionID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationStockLogs", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_MedicationStockLogs_Medications_MedicationID",
                        column: x => x.MedicationID,
                        principalTable: "Medications",
                        principalColumn: "MedicationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicationStockLogs_Prescriptions_RelatedPrescriptionID",
                        column: x => x.RelatedPrescriptionID,
                        principalTable: "Prescriptions",
                        principalColumn: "PrescriptionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionItems",
                columns: table => new
                {
                    ItemID = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Dosage = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<string>(type: "text", nullable: false),
                    DurationDays = table.Column<int>(type: "integer", nullable: false),
                    Instruction = table.Column<string>(type: "text", nullable: false),
                    Indication = table.Column<string>(type: "text", nullable: false),
                    DoseScheduleJSON = table.Column<string>(type: "text", nullable: false),
                    PrescriptionID = table.Column<string>(type: "text", nullable: false),
                    MedicationID = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionItems", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_PrescriptionItems_Medications_MedicationID",
                        column: x => x.MedicationID,
                        principalTable: "Medications",
                        principalColumn: "MedicationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrescriptionItems_Prescriptions_PrescriptionID",
                        column: x => x.PrescriptionID,
                        principalTable: "Prescriptions",
                        principalColumn: "PrescriptionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "Form", "Name", "Price", "SideEffect", "StockQuantity", "StockQuantityUnit", "StorageInstruction", "Unit" },
                values: new object[,]
                {
                    { "med-amox-500", 0, "Amoxicillin 500mg", 150000, "Nausea, rash", 1000, "box", "Store at room temperature", "mg" },
                    { "med-ibu-400", 0, "Ibuprofen 400mg", 80000, "Stomach upset", 500, "bottle", "Keep dry", "mg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { "user-doc-01", "sarah.smith@clinic.com", "Sarah", true, "Smith", "Password123!", "0909998887", 1, "dr.sarah" },
                    { "user-pat-01", "john@example.com", "John", true, "Doe", "Password123!", "0901234567", 0, "john.doe" },
                    { "user-phar-01", "david.chen@pharmacy.com", "David", true, "Chen", "Password123!", "0905554443", 2, "phar.david" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorID", "ConsultationFee", "Rating", "Specialization", "UserID", "YearsOfExperience" },
                values: new object[] { "doc-01", 300000.0, 4.7999999999999998, "General Practitioner", "user-doc-01", 10 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "BloodType", "DateOfBirth", "Gender", "InsuranceNumber", "UserID" },
                values: new object[] { "pat-01", "A+", new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), 0, "INS-123456", "user-pat-01" });

            migrationBuilder.InsertData(
                table: "Pharmacists",
                columns: new[] { "PharmacistID", "Department", "UserID" },
                values: new object[] { "phar-01", "Main Dispensary", "user-phar-01" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentDateTime", "ChiefComplaint", "DoctorID", "Location", "Note", "PatientID", "Priority", "Status", "VisitNumber" },
                values: new object[] { "appt-01", new DateTime(2025, 12, 1, 17, 42, 24, 502, DateTimeKind.Utc).AddTicks(8859), "Sore throat and mild fever lasting 2 days.", "doc-01", "Room 101", "", "pat-01", 0, 2, 1 });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "RecordID", "AppointmentID", "Diagnosis", "DoctorNotes", "NextVisitDate", "TreatmentPlan", "VisitTime" },
                values: new object[] { "rec-01", "appt-01", "Acute Pharyngitis (Strep Throat)", "Patient advised to finish full course of medication.", new DateTime(2025, 12, 9, 8, 42, 24, 502, DateTimeKind.Utc).AddTicks(8893), "Antibiotics course and rest.", new DateTime(2025, 12, 1, 17, 57, 24, 502, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.InsertData(
                table: "ClinicalExaminations",
                columns: new[] { "ClinicalID", "Allergies", "BloodPressure", "FamilyHistory", "Height", "LifestyleHabits", "MedicalHistory", "OxygenSaturation", "Pulse", "RecordID", "RespiratoryRate", "Symptoms", "Temperature", "Weight" },
                values: new object[] { "clin-01", "No known allergies.", "120/80", "Father has hypertension.", 175.0, "Non-smoker.", "None relevant.", 98.0, 85.0, "rec-01", 16.0, "Throat pain, difficulty swallowing, low-grade fever.", 38.200000000000003, 70.0 });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionID", "DispensedAt", "PharmacistID", "PrescriptionDateTime", "Priority", "RecordID", "Status", "VerifiedAt" },
                values: new object[] { "presc-01", new DateTime(2025, 12, 2, 8, 42, 24, 502, DateTimeKind.Utc).AddTicks(8941), null, new DateTime(2025, 12, 1, 18, 12, 24, 502, DateTimeKind.Utc).AddTicks(8939), 0, "rec-01", 0, new DateTime(2025, 12, 2, 8, 42, 24, 502, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.InsertData(
                table: "PrescriptionItems",
                columns: new[] { "ItemID", "Dosage", "DoseScheduleJSON", "DurationDays", "Frequency", "Indication", "Instruction", "MedicationID", "PrescriptionID", "Quantity" },
                values: new object[,]
                {
                    { "pi-01", "500mg", "{\"morning\": 1, \"afternoon\": 1, \"evening\": 1}", 7, "3 times a day (every 8 hours)", "For bacterial infection.", "Take after meals.", "med-amox-500", "presc-01", 21 },
                    { "pi-02", "400mg", "{\"as_needed\": true}", 5, "As needed for pain/fever, max 3 times daily", "For pain and fever management.", "Do not take on an empty stomach.", "med-ibu-400", "presc-01", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorID",
                table: "Appointments",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientID",
                table: "Appointments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalExaminations_RecordID",
                table: "ClinicalExaminations",
                column: "RecordID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserID",
                table: "Doctors",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSchedules_DoctorID",
                table: "DoctorSchedules",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_AppointmentID",
                table: "MedicalRecords",
                column: "AppointmentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicationInteractions_MedicationID1",
                table: "MedicationInteractions",
                column: "MedicationID1");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationInteractions_MedicationID2",
                table: "MedicationInteractions",
                column: "MedicationID2");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationStockLogs_MedicationID",
                table: "MedicationStockLogs",
                column: "MedicationID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationStockLogs_RelatedPrescriptionID",
                table: "MedicationStockLogs",
                column: "RelatedPrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserID",
                table: "Patients",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacists_UserID",
                table: "Pharmacists",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionItems_MedicationID",
                table: "PrescriptionItems",
                column: "MedicationID");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionItems_PrescriptionID",
                table: "PrescriptionItems",
                column: "PrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PharmacistID",
                table: "Prescriptions",
                column: "PharmacistID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_RecordID",
                table: "Prescriptions",
                column: "RecordID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicalExaminations");

            migrationBuilder.DropTable(
                name: "DoctorSchedules");

            migrationBuilder.DropTable(
                name: "MedicationInteractions");

            migrationBuilder.DropTable(
                name: "MedicationStockLogs");

            migrationBuilder.DropTable(
                name: "PrescriptionItems");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Pharmacists");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

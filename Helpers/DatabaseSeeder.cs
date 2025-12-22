using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Helpers;

public static class DatabaseSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        SeedMedications(modelBuilder);
        SeedUsers(modelBuilder);
        SeedPatients(modelBuilder);
        SeedDoctors(modelBuilder);
        SeedPharmacists(modelBuilder);
        SeedAppointments(modelBuilder);
        SeedMedicalRecords(modelBuilder);
        SeedClinicalExaminations(modelBuilder);
        SeedPrescriptions(modelBuilder);
        SeedPrescriptionItems(modelBuilder);
        SeedMedicationAdherence(modelBuilder);
        SeedDoctorSchedules(modelBuilder);
        SeedMedicationInteractions(modelBuilder);
        SeedMedicationStockLogs(modelBuilder);
    }

    public static void SeedMedications(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationModel>().HasData(
            // Original 9 medications
            new MedicationModel
            {
                MedicationID = "med-amox-500",
                Name = "Amoxicillin 500mg",
                ActiveIngredient = "Amoxicillin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 1000,
                PackingUnit = "box",
                UnitsPerPack = 20,
                PackingDescription = "Box of 20 tablets",
                SideEffect = "Nausea, rash, diarrhea",
                StorageInstruction = "Store at room temperature, away from moisture",
                Price = 150000,
                Category = MedicationCategory.Antibiotic
            },
            new MedicationModel
            {
                MedicationID = "med-ibu-400",
                Name = "Ibuprofen 400mg",
                ActiveIngredient = "Ibuprofen",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 500,
                PackingUnit = "bottle",
                UnitsPerPack = 50,
                PackingDescription = "Bottle of 50 tablets",
                SideEffect = "Stomach upset, heartburn, dizziness",
                StorageInstruction = "Keep dry, store below 30°C",
                Price = 80000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-para-500",
                Name = "Paracetamol 500mg",
                ActiveIngredient = "Paracetamol",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 2000,
                PackingUnit = "box",
                UnitsPerPack = 100,
                PackingDescription = "Box of 10 blisters x 10 tablets",
                SideEffect = "Liver toxicity (high dose or long-term use)",
                StorageInstruction = "Store in a cool, dry place",
                Price = 50000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-met-850",
                Name = "Metformin 850mg",
                ActiveIngredient = "Metformin Hydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 800,
                PackingUnit = "box",
                UnitsPerPack = 60,
                PackingDescription = "Box of 60 tablets",
                SideEffect = "Nausea, gastrointestinal disturbance, metallic taste",
                StorageInstruction = "Store at room temperature",
                Price = 120000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-cet-10",
                Name = "Cetirizine 10mg",
                ActiveIngredient = "Cetirizine Dihydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 2000,
                PackingUnit = "blister",
                UnitsPerPack = 10,
                PackingDescription = "Blister pack of 10 tablets",
                SideEffect = "Drowsiness, dry mouth, fatigue",
                StorageInstruction = "Store in a dry place, protected from light",
                Price = 45000,
                Category = MedicationCategory.Allergy
            },
            new MedicationModel
            {
                MedicationID = "med-ator-20",
                Name = "Atorvastatin 20mg",
                ActiveIngredient = "Atorvastatin Calcium",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 800,
                PackingUnit = "box",
                UnitsPerPack = 30,
                PackingDescription = "Box of 30 tablets",
                SideEffect = "Muscle pain, digestive issues, liver enzyme changes",
                StorageInstruction = "Store at room temperature",
                Price = 180000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-omep-20",
                Name = "Omeprazole 20mg",
                ActiveIngredient = "Omeprazole",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 1200,
                PackingUnit = "bottle",
                UnitsPerPack = 28,
                PackingDescription = "Bottle of 28 capsules",
                SideEffect = "Headache, nausea, diarrhea, stomach pain",
                StorageInstruction = "Keep away from light and moisture",
                Price = 95000,
                Category = MedicationCategory.Other
            },
            new MedicationModel
            {
                MedicationID = "med-salb-inhaler",
                Name = "Salbutamol Inhaler",
                ActiveIngredient = "Salbutamol Sulfate",
                Form = Form.Inhaler,
                BaseUnit = "mcg",
                StockTotalQuantity = 300,
                PackingUnit = "canister",
                UnitsPerPack = 200,
                PackingDescription = "Canister with 200 metered doses",
                SideEffect = "Tremors, nervousness, increased heart rate",
                StorageInstruction = "Store below 30°C, away from direct sunlight and heat",
                Price = 110000,
                Category = MedicationCategory.Respiratory
            },
            new MedicationModel
            {
                MedicationID = "med-vit-c-500",
                Name = "Vitamin C 500mg",
                ActiveIngredient = "Ascorbic Acid",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 5000,
                PackingUnit = "bottle",
                UnitsPerPack = 100,
                PackingDescription = "Bottle of 100 chewable tablets",
                SideEffect = "Stomach cramps, nausea (high dose)",
                StorageInstruction = "Keep tightly closed in a cool, dry place",
                Price = 60000,
                Category = MedicationCategory.Supplement
            },
            // Additional 20 medications
            new MedicationModel
            {
                MedicationID = "med-aspirin-100",
                Name = "Aspirin 100mg",
                ActiveIngredient = "Acetylsalicylic Acid",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 1500,
                PackingUnit = "bottle",
                UnitsPerPack = 100,
                PackingDescription = "Bottle of 100 enteric-coated tablets",
                SideEffect = "Stomach irritation, bleeding risk",
                StorageInstruction = "Store at room temperature, keep dry",
                Price = 75000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-lisinopril-10",
                Name = "Lisinopril 10mg",
                ActiveIngredient = "Lisinopril",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 600,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 tablets",
                SideEffect = "Dry cough, dizziness, fatigue",
                StorageInstruction = "Store at controlled room temperature",
                Price = 95000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "metformin-500",
                Name = "Metformin 500mg",
                ActiveIngredient = "Metformin Hydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 1200,
                PackingUnit = "bottle",
                UnitsPerPack = 60,
                PackingDescription = "Bottle of 60 tablets",
                SideEffect = "Gastrointestinal upset, lactic acidosis risk",
                StorageInstruction = "Store at room temperature",
                Price = 85000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-simvastatin-20",
                Name = "Simvastatin 20mg",
                ActiveIngredient = "Simvastatin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 900,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 tablets",
                SideEffect = "Muscle pain, liver enzyme elevation",
                StorageInstruction = "Store below 30°C, protect from light",
                Price = 140000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-amlodipine-5",
                Name = "Amlodipine 5mg",
                ActiveIngredient = "Amlodipine Besylate",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 700,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 tablets",
                SideEffect = "Swelling in ankles, flushing, headache",
                StorageInstruction = "Store at room temperature",
                Price = 120000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-prednisone-5",
                Name = "Prednisone 5mg",
                ActiveIngredient = "Prednisone",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 400,
                PackingUnit = "bottle",
                UnitsPerPack = 20,
                PackingDescription = "Bottle of 20 tablets",
                SideEffect = "Weight gain, mood changes, increased appetite",
                StorageInstruction = "Store at room temperature",
                Price = 65000,
                Category = MedicationCategory.Other
            },
            new MedicationModel
            {
                MedicationID = "med-azithromycin-250",
                Name = "Azithromycin 250mg",
                ActiveIngredient = "Azithromycin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 500,
                PackingUnit = "blister",
                UnitsPerPack = 6,
                PackingDescription = "Blister pack of 6 tablets",
                SideEffect = "Nausea, diarrhea, abdominal pain",
                StorageInstruction = "Store at room temperature",
                Price = 180000,
                Category = MedicationCategory.Antibiotic
            },
            new MedicationModel
            {
                MedicationID = "med-gabapentin-300",
                Name = "Gabapentin 300mg",
                ActiveIngredient = "Gabapentin",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 800,
                PackingUnit = "bottle",
                UnitsPerPack = 90,
                PackingDescription = "Bottle of 90 capsules",
                SideEffect = "Dizziness, drowsiness, coordination problems",
                StorageInstruction = "Store at room temperature",
                Price = 160000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-warfarin-5",
                Name = "Warfarin 5mg",
                ActiveIngredient = "Warfarin Sodium",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 200,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 scored tablets",
                SideEffect = "Bleeding risk, bruising, nosebleeds",
                StorageInstruction = "Store at room temperature, protected from light",
                Price = 95000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-levothyroxine-50",
                Name = "Levothyroxine 50mcg",
                ActiveIngredient = "Levothyroxine Sodium",
                Form = Form.Tablet,
                BaseUnit = "mcg",
                StockTotalQuantity = 1000,
                PackingUnit = "bottle",
                UnitsPerPack = 100,
                PackingDescription = "Bottle of 100 tablets",
                SideEffect = "Palpitations, anxiety, weight loss",
                StorageInstruction = "Store at room temperature",
                Price = 110000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-albuterol-syrup",
                Name = "Albuterol Syrup 2mg/5ml",
                ActiveIngredient = "Albuterol Sulfate",
                Form = Form.Syrup,
                BaseUnit = "ml",
                StockTotalQuantity = 200,
                PackingUnit = "bottle",
                UnitsPerPack = 120,
                PackingDescription = "Bottle of 120ml syrup",
                SideEffect = "Tremor, nervousness, increased heart rate",
                StorageInstruction = "Store at room temperature, protect from light",
                Price = 95000,
                Category = MedicationCategory.Respiratory
            },
            new MedicationModel
            {
                MedicationID = "med-hydrochlorothiazide-25",
                Name = "Hydrochlorothiazide 25mg",
                ActiveIngredient = "Hydrochlorothiazide",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 600,
                PackingUnit = "bottle",
                UnitsPerPack = 100,
                PackingDescription = "Bottle of 100 tablets",
                SideEffect = "Increased urination, dizziness, potassium loss",
                StorageInstruction = "Store at room temperature",
                Price = 55000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-tramadol-50",
                Name = "Tramadol 50mg",
                ActiveIngredient = "Tramadol Hydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 300,
                PackingUnit = "blister",
                UnitsPerPack = 20,
                PackingDescription = "Blister pack of 20 tablets",
                SideEffect = "Dizziness, nausea, constipation, dependence risk",
                StorageInstruction = "Store at room temperature",
                Price = 140000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-ondansetron-4",
                Name = "Ondansetron 4mg",
                ActiveIngredient = "Ondansetron Hydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 400,
                PackingUnit = "bottle",
                UnitsPerPack = 10,
                PackingDescription = "Bottle of 10 orally disintegrating tablets",
                SideEffect = "Headache, constipation, dizziness",
                StorageInstruction = "Store at room temperature",
                Price = 220000,
                Category = MedicationCategory.Other
            },
            new MedicationModel
            {
                MedicationID = "med-losartan-50",
                Name = "Losartan 50mg",
                ActiveIngredient = "Losartan Potassium",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 750,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 tablets",
                SideEffect = "Dizziness, hyperkalemia, cough",
                StorageInstruction = "Store at room temperature",
                Price = 130000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-fluoxetine-20",
                Name = "Fluoxetine 20mg",
                ActiveIngredient = "Fluoxetine Hydrochloride",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 500,
                PackingUnit = "bottle",
                UnitsPerPack = 20,
                PackingDescription = "Bottle of 20 capsules",
                SideEffect = "Insomnia, headache, sexual dysfunction",
                StorageInstruction = "Store at room temperature",
                Price = 175000,
                Category = MedicationCategory.MentalHealth
            },
            new MedicationModel
            {
                MedicationID = "med-metoprolol-25",
                Name = "Metoprolol 25mg",
                ActiveIngredient = "Metoprolol Tartrate",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 800,
                PackingUnit = "bottle",
                UnitsPerPack = 60,
                PackingDescription = "Bottle of 60 tablets",
                SideEffect = "Fatigue, dizziness, slow heartbeat",
                StorageInstruction = "Store at room temperature",
                Price = 85000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-clonazepam-0-5",
                Name = "Clonazepam 0.5mg",
                ActiveIngredient = "Clonazepam",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 150,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 tablets",
                SideEffect = "Drowsiness, dizziness, dependence risk",
                StorageInstruction = "Store at room temperature",
                Price = 95000,
                Category = MedicationCategory.MentalHealth
            },
            new MedicationModel
            {
                MedicationID = "med-insulin-glargine",
                Name = "Insulin Glargine 100U/ml",
                ActiveIngredient = "Insulin Glargine",
                Form = Form.Injection,
                BaseUnit = "U",
                StockTotalQuantity = 100,
                PackingUnit = "pen",
                UnitsPerPack = 3000,
                PackingDescription = "Prefilled pen injector 3ml (100U/ml)",
                SideEffect = "Hypoglycemia, weight gain, injection site reactions",
                StorageInstruction = "Refrigerate until use, then room temperature for 28 days",
                Price = 450000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-vf-500",
                Name = "Clarithromycin 500mg",
                ActiveIngredient = "Clarithromycin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 400,
                PackingUnit = "box",
                UnitsPerPack = 14,
                PackingDescription = "Box of 14 tablets",
                SideEffect = "Nausea, altered taste, diarrhea, liver enzyme changes",
                StorageInstruction = "Store at room temperature",
                Price = 195000,
                Category = MedicationCategory.Antibiotic
            },
            new MedicationModel
            {
                MedicationID = "med-diltiazem-60",
                Name = "Diltiazem 60mg",
                ActiveIngredient = "Diltiazem Hydrochloride",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 600,
                PackingUnit = "bottle",
                UnitsPerPack = 60,
                PackingDescription = "Bottle of 60 tablets",
                SideEffect = "Dizziness, headache, ankle swelling, constipation",
                StorageInstruction = "Store at room temperature",
                Price = 145000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-digoxin-125",
                Name = "Digoxin 0.125mg",
                ActiveIngredient = "Digoxin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 300,
                PackingUnit = "bottle",
                UnitsPerPack = 60,
                PackingDescription = "Bottle of 60 tablets",
                SideEffect = "Nausea, vomiting, visual disturbances, arrhythmias",
                StorageInstruction = "Store at room temperature, protect from light",
                Price = 85000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-contrast-iodine",
                Name = "Iodinated Contrast Medium",
                ActiveIngredient = "Iohexol",
                Form = Form.Injection,
                BaseUnit = "ml",
                StockTotalQuantity = 50,
                PackingUnit = "vial",
                UnitsPerPack = 100,
                PackingDescription = "Vial of 100ml injection solution",
                SideEffect = "Allergic reactions, nausea, kidney damage risk",
                StorageInstruction = "Store at room temperature, protect from light",
                Price = 350000,
                Category = MedicationCategory.Other
            },
            new MedicationModel
            {
                MedicationID = "med-ferrous-sulfate-325",
                Name = "Ferrous Sulfate 325mg",
                ActiveIngredient = "Ferrous Sulfate",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 1000,
                PackingUnit = "bottle",
                UnitsPerPack = 100,
                PackingDescription = "Bottle of 100 tablets",
                SideEffect = "Constipation, dark stools, stomach upset, nausea",
                StorageInstruction = "Store at room temperature, keep tightly closed",
                Price = 70000,
                Category = MedicationCategory.Supplement
            },
            new MedicationModel
            {
                MedicationID = "med-vancomycin-500",
                Name = "Vancomycin 500mg",
                ActiveIngredient = "Vancomycin Hydrochloride",
                Form = Form.Injection,
                BaseUnit = "mg",
                StockTotalQuantity = 100,
                PackingUnit = "vial",
                UnitsPerPack = 500,
                PackingDescription = "Vial for IV injection 500mg",
                SideEffect = "Red man syndrome, nephrotoxicity, ototoxicity",
                StorageInstruction = "Refrigerate, protect from light",
                Price = 280000,
                Category = MedicationCategory.Antibiotic
            },
            new MedicationModel
            {
                MedicationID = "med-hydroxychloroquine-200",
                Name = "Hydroxychloroquine 200mg",
                ActiveIngredient = "Hydroxychloroquine Sulfate",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 500,
                PackingUnit = "bottle",
                UnitsPerPack = 60,
                PackingDescription = "Bottle of 60 tablets",
                SideEffect = "Nausea, headache, dizziness, retinal toxicity (long-term)",
                StorageInstruction = "Store at room temperature, protect from light",
                Price = 210000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-duloxetine-30",
                Name = "Duloxetine 30mg",
                ActiveIngredient = "Duloxetine Hydrochloride",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 400,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 delayed-release capsules",
                SideEffect = "Nausea, dry mouth, drowsiness, dizziness, constipation",
                StorageInstruction = "Store at room temperature",
                Price = 190000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-pregabalin-75",
                Name = "Pregabalin 75mg",
                ActiveIngredient = "Pregabalin",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 600,
                PackingUnit = "bottle",
                UnitsPerPack = 60,
                PackingDescription = "Bottle of 60 capsules",
                SideEffect = "Dizziness, drowsiness, dry mouth, weight gain, blurred vision",
                StorageInstruction = "Store at room temperature",
                Price = 185000,
                Category = MedicationCategory.PainReliever
            },
            new MedicationModel
            {
                MedicationID = "med-alprazolam-0-5",
                Name = "Alprazolam 0.5mg",
                ActiveIngredient = "Alprazolam",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 15,
                PackingUnit = "blister",
                UnitsPerPack = 10,
                PackingDescription = "Blister of 10 tablets",
                SideEffect = "Drowsiness, dizziness",
                StorageInstruction = "Store at room temperature",
                Price = 85000,
                Category = MedicationCategory.MentalHealth
            },
            new MedicationModel
            {
                MedicationID = "med-furosemide-40",
                Name = "Furosemide 40mg",
                ActiveIngredient = "Furosemide",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 8,
                PackingUnit = "bottle",
                UnitsPerPack = 50,
                PackingDescription = "Bottle of 50 tablets",
                SideEffect = "Dehydration, electrolyte imbalance",
                StorageInstruction = "Protect from light",
                Price = 40000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-clopidogrel-75",
                Name = "Clopidogrel 75mg",
                ActiveIngredient = "Clopidogrel Bisulfate",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 12,
                PackingUnit = "box",
                UnitsPerPack = 28,
                PackingDescription = "Box of 28 tablets",
                SideEffect = "Bleeding, bruising",
                StorageInstruction = "Store in a dry place",
                Price = 320000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-spironolactone-25",
                Name = "Spironolactone 25mg",
                ActiveIngredient = "Spironolactone",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 5,
                PackingUnit = "bottle",
                UnitsPerPack = 30,
                PackingDescription = "Bottle of 30 tablets",
                SideEffect = "Hyperkalemia, dizziness",
                StorageInstruction = "Store below 25°C",
                Price = 75000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-allopurinol-100",
                Name = "Allopurinol 100mg",
                ActiveIngredient = "Allopurinol",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 18,
                PackingUnit = "box",
                UnitsPerPack = 50,
                PackingDescription = "Box of 5 blisters",
                SideEffect = "Rash, nausea",
                StorageInstruction = "Store at room temperature",
                Price = 60000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-digoxin-250",
                Name = "Digoxin 250mcg",
                ActiveIngredient = "Digoxin",
                Form = Form.Tablet,
                BaseUnit = "mcg",
                StockTotalQuantity = 9,
                PackingUnit = "bottle",
                UnitsPerPack = 100,
                PackingDescription = "Bottle of 100 tablets",
                SideEffect = "Nausea, dizziness, vision changes",
                StorageInstruction = "Store at room temperature",
                Price = 95000,
                Category = MedicationCategory.ChronicCondition
            },
            new MedicationModel
            {
                MedicationID = "med-nitro-sublingual",
                Name = "Nitroglycerin 0.5mg",
                ActiveIngredient = "Nitroglycerin",
                Form = Form.Tablet,
                BaseUnit = "mg",
                StockTotalQuantity = 4,
                PackingUnit = "bottle",
                UnitsPerPack = 25,
                PackingDescription = "Glass bottle of 25 sublingual tablets",
                SideEffect = "Headache, hypotension",
                StorageInstruction = "Keep tightly closed",
                Price = 110000,
                Category = MedicationCategory.Other
            },
            new MedicationModel
            {
                MedicationID = "med-cefdinir-300",
                Name = "Cefdinir 300mg",
                ActiveIngredient = "Cefdinir",
                Form = Form.Capsule,
                BaseUnit = "mg",
                StockTotalQuantity = 10,
                PackingUnit = "box",
                UnitsPerPack = 10,
                PackingDescription = "Box of 10 capsules",
                SideEffect = "Diarrhea, nausea",
                StorageInstruction = "Store at room temperature",
                Price = 250000,
                Category = MedicationCategory.Antibiotic
            },
            new MedicationModel
            {
                MedicationID = "med-epinephrine-pen",
                Name = "Epinephrine Auto-Injector",
                ActiveIngredient = "Epinephrine",
                Form = Form.Injection,
                BaseUnit = "mg",
                StockTotalQuantity = 2,
                PackingUnit = "pen",
                UnitsPerPack = 2,
                PackingDescription = "Pack of 2 auto-injectors",
                SideEffect = "Palpitations, anxiety",
                StorageInstruction = "Do not refrigerate, protect from light",
                Price = 1200000,
                Category = MedicationCategory.Other
            }
        );
    }
    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>().HasData(
            // Original users (keeping same count)
            new UserModel
            {
                UserID = "user-pat-01",
                FirstName = "John",
                LastName = "Doe",
                Username = "john.doe",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "john@example.com",
                PhoneNumber = "0901234567",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-doc-01",
                FirstName = "Sarah",
                LastName = "Smith",
                Username = "dr.sarah",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "sarah.smith@clinic.com",
                PhoneNumber = "0909998887",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-phar-01",
                FirstName = "David",
                LastName = "Chen",
                Username = "phar.david",
                PasswordHash = "Password123!",
                Role = UserRole.Pharmacist,
                Email = "david.chen@pharmacy.com",
                PhoneNumber = "0905554443",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-02",
                FirstName = "Alice",
                LastName = "Brown",
                Username = "alice.brown",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "alice.b@example.com",
                PhoneNumber = "0908887776",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-doc-02",
                FirstName = "James",
                LastName = "Wilson",
                Username = "dr.james",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "james.wilson@clinic.com",
                PhoneNumber = "0901112223",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-03",
                FirstName = "Michael",
                LastName = "Jordan",
                Username = "mike.j",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "mike.j@example.com",
                PhoneNumber = "0901122334",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-04",
                FirstName = "Emily",
                LastName = "Clark",
                Username = "emily.c",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "emily.c@example.com",
                PhoneNumber = "0909988776",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-doc-03",
                FirstName = "Gregory",
                LastName = "House",
                Username = "dr.house",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "house@clinic.com",
                PhoneNumber = "0906666666",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-doc-04",
                FirstName = "Meredith",
                LastName = "Grey",
                Username = "dr.grey",
                PasswordHash = "Password123!",
                Role = UserRole.Doctor,
                Email = "grey@clinic.com",
                PhoneNumber = "0907777777",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-phar-02",
                FirstName = "Lisa",
                LastName = "Wong",
                Username = "phar.lisa",
                PasswordHash = "Password123!",
                Role = UserRole.Pharmacist,
                Email = "lisa.w@pharmacy.com",
                PhoneNumber = "0904443332",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-05",
                FirstName = "Robert",
                LastName = "Taylor",
                Username = "robert.t",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "robert.t@example.com",
                PhoneNumber = "0903322110",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-06",
                FirstName = "Jennifer",
                LastName = "Martinez",
                Username = "jennifer.m",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "jennifer.m@example.com",
                PhoneNumber = "0902233445",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-07",
                FirstName = "William",
                LastName = "Anderson",
                Username = "william.a",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "william.a@example.com",
                PhoneNumber = "0901122558",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-08",
                FirstName = "Sophia",
                LastName = "Thomas",
                Username = "sophia.t",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "sophia.t@example.com",
                PhoneNumber = "0909988765",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-09",
                FirstName = "Daniel",
                LastName = "Jackson",
                Username = "daniel.j",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "daniel.j@example.com",
                PhoneNumber = "0908877654",
                IsActive = false
            },
            new UserModel
            {
                UserID = "user-pat-10",
                FirstName = "Olivia",
                LastName = "White",
                Username = "olivia.w",
                PasswordHash = "Password123!",
                Role = UserRole.Patient,
                Email = "olivia.w@example.com",
                PhoneNumber = "0907766543",
                IsActive = false
            }
        );
    }

    private static void SeedPatients(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PatientModel>().HasData(
            new PatientModel
            {
                PatientID = "pat-01",
                UserID = "user-pat-01",
                DateOfBirth = new DateTime(1985, 5, 20, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1985, 5, 20, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Male,
                InsuranceNumber = "INS-123456",
                BloodType = "A+"
            },
            new PatientModel
            {
                PatientID = "pat-02",
                UserID = "user-pat-02",
                DateOfBirth = new DateTime(1990, 8, 15, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1990, 8, 15, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Female,
                InsuranceNumber = "INS-987654",
                BloodType = "O-"
            },
            new PatientModel
            {
                PatientID = "pat-03",
                UserID = "user-pat-03",
                DateOfBirth = new DateTime(1975, 2, 14, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1975, 2, 14, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Male,
                InsuranceNumber = "INS-555666",
                BloodType = "AB-"
            },
            new PatientModel
            {
                PatientID = "pat-04",
                UserID = "user-pat-04",
                DateOfBirth = new DateTime(2015, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(2015, 6, 1, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Female,
                InsuranceNumber = "INS-CHILD-01",
                BloodType = "B+"
            },
            new PatientModel
            {
                PatientID = "pat-05",
                UserID = "user-pat-05",
                DateOfBirth = new DateTime(1982, 11, 8, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1982, 11, 8, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Male,
                InsuranceNumber = "INS-777888",
                BloodType = "O+"
            },
            new PatientModel
            {
                PatientID = "pat-06",
                UserID = "user-pat-06",
                DateOfBirth = new DateTime(1995, 3, 22, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1995, 3, 22, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Female,
                InsuranceNumber = "INS-666555",
                BloodType = "A-"
            },
            new PatientModel
            {
                PatientID = "pat-07",
                UserID = "user-pat-07",
                DateOfBirth = new DateTime(1968, 7, 15, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1968, 7, 15, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Male,
                InsuranceNumber = "INS-444333",
                BloodType = "AB+"
            },
            new PatientModel
            {
                PatientID = "pat-08",
                UserID = "user-pat-08",
                DateOfBirth = new DateTime(2001, 9, 30, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(2001, 9, 30, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Female,
                InsuranceNumber = "INS-222111",
                BloodType = "B-"
            },
            new PatientModel
            {
                PatientID = "pat-09",
                UserID = "user-pat-09",
                DateOfBirth = new DateTime(1978, 12, 5, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1978, 12, 5, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Male,
                InsuranceNumber = "INS-999000",
                BloodType = "O-"
            },
            new PatientModel
            {
                PatientID = "pat-10",
                UserID = "user-pat-10",
                DateOfBirth = new DateTime(1988, 4, 18, 0, 0, 0, DateTimeKind.Utc),
                Age = (int)((DateTime.UtcNow - new DateTime(1988, 4, 18, 0, 0, 0, DateTimeKind.Utc)).TotalDays / 365.25),
                Gender = Gender.Female,
                InsuranceNumber = "INS-111222",
                BloodType = "A+"
            }
        );
    }

    private static void SeedDoctors(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorModel>().HasData(
            new DoctorModel
            {
                DoctorID = "doc-01",
                UserID = "user-doc-01",
                Specialization = "General Practitioner",
                ConsultationFee = 300000,
                Rating = 4.8,
                YearsOfExperience = 10
            },
            new DoctorModel
            {
                DoctorID = "doc-02",
                UserID = "user-doc-02",
                Specialization = "Cardiologist",
                ConsultationFee = 500000,
                Rating = 4.9,
                YearsOfExperience = 15
            },
            new DoctorModel
            {
                DoctorID = "doc-03",
                UserID = "user-doc-03",
                Specialization = "Diagnostician",
                ConsultationFee = 1000000,
                Rating = 3.5,
                YearsOfExperience = 20
            },
            new DoctorModel
            {
                DoctorID = "doc-04",
                UserID = "user-doc-04",
                Specialization = "General Surgery",
                ConsultationFee = 600000,
                Rating = 4.9,
                YearsOfExperience = 8
            }
        );
    }

    private static void SeedPharmacists(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PharmacistModel>().HasData(
            new PharmacistModel
            {
                PharmacistID = "phar-01",
                UserID = "user-phar-01",
                Department = "Main Dispensary"
            },
            new PharmacistModel
            {
                PharmacistID = "phar-02",
                UserID = "user-phar-02",
                Department = "Inpatient Pharmacy"
            }
        );
    }

    private static void SeedAppointments(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppointmentModel>().HasData(
            // Original 12 appointments
            new AppointmentModel
            {
                AppointmentID = "appt-01",
                PatientID = "pat-01",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-1).AddHours(9),
                ChiefComplaint = "Sore throat and mild fever lasting 2 days.",
                Location = "Room 101",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-02",
                PatientID = "pat-02",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-2).AddHours(14),
                ChiefComplaint = "Regular checkup for hypertension.",
                Location = "Room 205",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-03",
                PatientID = "pat-03",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-5).AddHours(10),
                ChiefComplaint = "Chest pain after exercise.",
                Location = "Room 205",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-04",
                PatientID = "pat-04",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(1).AddHours(9),
                ChiefComplaint = "Vaccination schedule.",
                Location = "Room 102",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-05",
                PatientID = "pat-01",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-10).AddHours(14),
                ChiefComplaint = "Unexplained leg pain.",
                Location = "Room 303",
                Status = StatusAppointment.Completed,
                Priority = Priority.Stat,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-06",
                PatientID = "pat-02",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddHours(2),
                ChiefComplaint = "Follow up on surgical scar.",
                Location = "Room 401",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-07",
                PatientID = "pat-05",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-3).AddHours(11),
                ChiefComplaint = "Migraine headaches for the past week.",
                Location = "Room 103",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-08",
                PatientID = "pat-06",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-7).AddHours(16),
                ChiefComplaint = "Shortness of breath and fatigue.",
                Location = "Room 206",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-09",
                PatientID = "pat-07",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-14).AddHours(13),
                ChiefComplaint = "Chronic back pain radiating to legs.",
                Location = "Room 304",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-10",
                PatientID = "pat-08",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-4).AddHours(10),
                ChiefComplaint = "Skin rash and itching.",
                Location = "Room 402",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-11",
                PatientID = "pat-09",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(2).AddHours(14),
                ChiefComplaint = "Annual health checkup.",
                Location = "Room 104",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            new AppointmentModel
            {
                AppointmentID = "appt-12",
                PatientID = "pat-10",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(3).AddHours(9),
                ChiefComplaint = "Abdominal pain and bloating.",
                Location = "Room 207",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 1
            },
            // Additional 20 appointments
            new AppointmentModel
            {
                AppointmentID = "appt-13",
                PatientID = "pat-03",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-8).AddHours(15),
                ChiefComplaint = "Persistent cough and fatigue.",
                Location = "Room 105",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-14",
                PatientID = "pat-04",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-6).AddHours(11),
                ChiefComplaint = "Fever and ear pain.",
                Location = "Room 208",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-15",
                PatientID = "pat-05",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-12).AddHours(9),
                ChiefComplaint = "Dizziness and occasional fainting.",
                Location = "Room 305",
                Status = StatusAppointment.Completed,
                Priority = Priority.Stat,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-16",
                PatientID = "pat-06",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-9).AddHours(14),
                ChiefComplaint = "Joint pain and swelling.",
                Location = "Room 403",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-17",
                PatientID = "pat-07",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-11).AddHours(16),
                ChiefComplaint = "Severe abdominal pain.",
                Location = "Room 106",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-18",
                PatientID = "pat-08",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-15).AddHours(10),
                ChiefComplaint = "Eye irritation and redness.",
                Location = "Room 209",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-19",
                PatientID = "pat-09",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-13).AddHours(13),
                ChiefComplaint = "Memory problems and confusion.",
                Location = "Room 306",
                Status = StatusAppointment.Completed,
                Priority = Priority.Stat,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-20",
                PatientID = "pat-10",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-7).AddHours(8),
                ChiefComplaint = "Thyroid medication follow-up.",
                Location = "Room 404",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 2
            },
            new AppointmentModel
            {
                AppointmentID = "appt-21",
                PatientID = "pat-01",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(4).AddHours(11),
                ChiefComplaint = "Cardiac evaluation clearance.",
                Location = "Room 210",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-22",
                PatientID = "pat-02",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(5).AddHours(15),
                ChiefComplaint = "Diabetes management review.",
                Location = "Room 107",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-23",
                PatientID = "pat-03",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-16).AddHours(9),
                ChiefComplaint = "Pre-operative assessment.",
                Location = "Room 405",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-24",
                PatientID = "pat-04",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-17).AddHours(14),
                ChiefComplaint = "Behavioral issues evaluation.",
                Location = "Room 307",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-25",
                PatientID = "pat-05",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-18).AddHours(10),
                ChiefComplaint = "Neurological symptoms assessment.",
                Location = "Room 211",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-26",
                PatientID = "pat-06",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-19).AddHours(16),
                ChiefComplaint = "Blood disorder investigation.",
                Location = "Room 108",
                Status = StatusAppointment.Completed,
                Priority = Priority.Urgent,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-27",
                PatientID = "pat-07",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-20).AddHours(8),
                ChiefComplaint = "Post-operative follow-up.",
                Location = "Room 406",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-28",
                PatientID = "pat-08",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-21).AddHours(13),
                ChiefComplaint = "Autoimmune disease consultation.",
                Location = "Room 308",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-29",
                PatientID = "pat-09",
                DoctorID = "doc-02",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-22).AddHours(11),
                ChiefComplaint = "Kidney function evaluation.",
                Location = "Room 212",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-30",
                PatientID = "pat-10",
                DoctorID = "doc-01",
                AppointmentDateTime = DateTime.UtcNow.AddDays(-23).AddHours(15),
                ChiefComplaint = "Endocrine system assessment.",
                Location = "Room 109",
                Status = StatusAppointment.Completed,
                Priority = Priority.Routine,
                VisitNumber = 3
            },
            new AppointmentModel
            {
                AppointmentID = "appt-31",
                PatientID = "pat-01",
                DoctorID = "doc-04",
                AppointmentDateTime = DateTime.UtcNow.AddDays(6).AddHours(9),
                ChiefComplaint = "Surgical consultation second opinion.",
                Location = "Room 407",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 4
            },
            new AppointmentModel
            {
                AppointmentID = "appt-32",
                PatientID = "pat-02",
                DoctorID = "doc-03",
                AppointmentDateTime = DateTime.UtcNow.AddDays(7).AddHours(14),
                ChiefComplaint = "Complex case review.",
                Location = "Room 309",
                Status = StatusAppointment.Scheduled,
                Priority = Priority.Routine,
                VisitNumber = 4
            }
        );
    }

    private static void SeedMedicalRecords(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicalRecordModel>().HasData(
            // Original 8 medical records
            new MedicalRecordModel
            {
                RecordID = "rec-01",
                AppointmentID = "appt-01",
                VisitTime = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(15),
                Diagnosis = "Acute Pharyngitis (Strep Throat)",
                TreatmentPlan = "Antibiotics course and rest.",
                DoctorNotes = "Patient advised to finish full course of medication.",
                NextVisitDate = DateTime.UtcNow.AddDays(7)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-02",
                AppointmentID = "appt-02",
                VisitTime = DateTime.UtcNow.AddDays(-2).AddHours(14).AddMinutes(30),
                Diagnosis = "Essential Hypertension",
                TreatmentPlan = "Lifestyle modification and daily medication.",
                DoctorNotes = "BP slightly elevated. Monitoring required.",
                NextVisitDate = DateTime.UtcNow.AddMonths(1)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-03",
                AppointmentID = "appt-03",
                VisitTime = DateTime.UtcNow.AddDays(-5).AddHours(10).AddMinutes(30),
                Diagnosis = "Stable Angina",
                TreatmentPlan = "Prescribed statins and nitroglycerin. Cardiac stress test ordered.",
                DoctorNotes = "Patient needs to monitor heart rate.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-04",
                AppointmentID = "appt-05",
                VisitTime = DateTime.UtcNow.AddDays(-10).AddHours(15),
                Diagnosis = "Deep Vein Thrombosis (DVT)",
                TreatmentPlan = "Anticoagulant therapy immediately.",
                DoctorNotes = "Confirmed via Ultrasound.",
                NextVisitDate = DateTime.UtcNow.AddDays(3)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-05",
                AppointmentID = "appt-07",
                VisitTime = DateTime.UtcNow.AddDays(-3).AddHours(11).AddMinutes(20),
                Diagnosis = "Migraine with Aura",
                TreatmentPlan = "Triptan medication and lifestyle modifications.",
                DoctorNotes = "Patient advised to identify triggers.",
                NextVisitDate = DateTime.UtcNow.AddDays(30)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-06",
                AppointmentID = "appt-08",
                VisitTime = DateTime.UtcNow.AddDays(-7).AddHours(16).AddMinutes(25),
                Diagnosis = "Anemia",
                TreatmentPlan = "Iron supplements and dietary changes.",
                DoctorNotes = "Blood test shows low hemoglobin.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-07",
                AppointmentID = "appt-09",
                VisitTime = DateTime.UtcNow.AddDays(-14).AddHours(13).AddMinutes(30),
                Diagnosis = "Lumbar Disc Herniation",
                TreatmentPlan = "Physical therapy and pain management.",
                DoctorNotes = "MRI recommended if symptoms persist.",
                NextVisitDate = DateTime.UtcNow.AddDays(21)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-08",
                AppointmentID = "appt-10",
                VisitTime = DateTime.UtcNow.AddDays(-4).AddHours(10).AddMinutes(15),
                Diagnosis = "Contact Dermatitis",
                TreatmentPlan = "Topical corticosteroids and antihistamines.",
                DoctorNotes = "Avoid known irritants.",
                NextVisitDate = DateTime.UtcNow.AddDays(7)
            },
            // Additional 20 medical records
            new MedicalRecordModel
            {
                RecordID = "rec-09",
                AppointmentID = "appt-13",
                VisitTime = DateTime.UtcNow.AddDays(-8).AddHours(15).AddMinutes(20),
                Diagnosis = "Chronic Bronchitis",
                TreatmentPlan = "Bronchodilators and antibiotics. Smoking cessation counseling.",
                DoctorNotes = "Patient needs pulmonary function tests.",
                NextVisitDate = DateTime.UtcNow.AddDays(10)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-10",
                AppointmentID = "appt-14",
                VisitTime = DateTime.UtcNow.AddDays(-6).AddHours(11).AddMinutes(15),
                Diagnosis = "Acute Otitis Media",
                TreatmentPlan = "Antibiotic ear drops and pain management.",
                DoctorNotes = "Monitor for hearing changes.",
                NextVisitDate = DateTime.UtcNow.AddDays(5)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-11",
                AppointmentID = "appt-15",
                VisitTime = DateTime.UtcNow.AddDays(-12).AddHours(9).AddMinutes(25),
                Diagnosis = "Orthostatic Hypotension",
                TreatmentPlan = "Fluid replacement and medication adjustment.",
                DoctorNotes = "Cardiac monitoring recommended.",
                NextVisitDate = DateTime.UtcNow.AddDays(7)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-12",
                AppointmentID = "appt-16",
                VisitTime = DateTime.UtcNow.AddDays(-9).AddHours(14).AddMinutes(30),
                Diagnosis = "Rheumatoid Arthritis",
                TreatmentPlan = "Anti-inflammatory medication and physical therapy.",
                DoctorNotes = "Rheumatology referral needed.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-13",
                AppointmentID = "appt-17",
                VisitTime = DateTime.UtcNow.AddDays(-11).AddHours(16).AddMinutes(20),
                Diagnosis = "Acute Pancreatitis",
                TreatmentPlan = "NPO status, IV fluids, and pain management.",
                DoctorNotes = "CT scan abdomen ordered. Admit for observation.",
                NextVisitDate = DateTime.UtcNow.AddDays(3)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-14",
                AppointmentID = "appt-18",
                VisitTime = DateTime.UtcNow.AddDays(-15).AddHours(10).AddMinutes(15),
                Diagnosis = "Allergic Conjunctivitis",
                TreatmentPlan = "Antihistamine eye drops and cool compresses.",
                DoctorNotes = "Avoid allergens when possible.",
                NextVisitDate = DateTime.UtcNow.AddDays(7)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-15",
                AppointmentID = "appt-19",
                VisitTime = DateTime.UtcNow.AddDays(-13).AddHours(13).AddMinutes(40),
                Diagnosis = "Mild Cognitive Impairment",
                TreatmentPlan = "Cognitive exercises and regular monitoring.",
                DoctorNotes = "Neurology consultation recommended.",
                NextVisitDate = DateTime.UtcNow.AddDays(30)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-16",
                AppointmentID = "appt-20",
                VisitTime = DateTime.UtcNow.AddDays(-7).AddHours(8).AddMinutes(25),
                Diagnosis = "Hypothyroidism (Controlled)",
                TreatmentPlan = "Continue current levothyroxine dosage.",
                DoctorNotes = "TSH levels within normal range.",
                NextVisitDate = DateTime.UtcNow.AddDays(90)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-17",
                AppointmentID = "appt-23",
                VisitTime = DateTime.UtcNow.AddDays(-16).AddHours(9).AddMinutes(30),
                Diagnosis = "Cholecystitis",
                TreatmentPlan = "Surgical consultation for cholecystectomy.",
                DoctorNotes = "Ultrasound confirms gallbladder inflammation.",
                NextVisitDate = DateTime.UtcNow.AddDays(2)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-18",
                AppointmentID = "appt-24",
                VisitTime = DateTime.UtcNow.AddDays(-17).AddHours(14).AddMinutes(45),
                Diagnosis = "Attention Deficit Hyperactivity Disorder",
                TreatmentPlan = "Behavioral therapy and medication management.",
                DoctorNotes = "School evaluation needed.",
                NextVisitDate = DateTime.UtcNow.AddDays(21)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-19",
                AppointmentID = "appt-25",
                VisitTime = DateTime.UtcNow.AddDays(-18).AddHours(10).AddMinutes(20),
                Diagnosis = "Peripheral Neuropathy",
                TreatmentPlan = "Neuropathic pain medication and B vitamin supplements.",
                DoctorNotes = "EMG study ordered.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-20",
                AppointmentID = "appt-26",
                VisitTime = DateTime.UtcNow.AddDays(-19).AddHours(16).AddMinutes(15),
                Diagnosis = "Iron Deficiency Anemia",
                TreatmentPlan = "Iron infusion and dietary modifications.",
                DoctorNotes = "Hemoglobin critically low.",
                NextVisitDate = DateTime.UtcNow.AddDays(7)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-21",
                AppointmentID = "appt-27",
                VisitTime = DateTime.UtcNow.AddDays(-20).AddHours(8).AddMinutes(30),
                Diagnosis = "Post-operative Infection",
                TreatmentPlan = "IV antibiotics and wound care.",
                DoctorNotes = "Culture and sensitivity sent.",
                NextVisitDate = DateTime.UtcNow.AddDays(2)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-22",
                AppointmentID = "appt-28",
                VisitTime = DateTime.UtcNow.AddDays(-21).AddHours(13).AddMinutes(25),
                Diagnosis = "Systemic Lupus Erythematosus",
                TreatmentPlan = "Immunosuppressants and regular monitoring.",
                DoctorNotes = "Rheumatology follow-up essential.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-23",
                AppointmentID = "appt-29",
                VisitTime = DateTime.UtcNow.AddDays(-22).AddHours(11).AddMinutes(35),
                Diagnosis = "Chronic Kidney Disease Stage 3",
                TreatmentPlan = "Blood pressure control and dietary protein restriction.",
                DoctorNotes = "Nephrology referral made.",
                NextVisitDate = DateTime.UtcNow.AddDays(30)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-24",
                AppointmentID = "appt-30",
                VisitTime = DateTime.UtcNow.AddDays(-23).AddHours(15).AddMinutes(20),
                Diagnosis = "Diabetes Mellitus Type 2",
                TreatmentPlan = "Metformin therapy and lifestyle modifications.",
                DoctorNotes = "HbA1c elevated. Dietitian referral needed.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-25",
                AppointmentID = "appt-31",
                VisitTime = DateTime.UtcNow.AddDays(-24).AddHours(9).AddMinutes(15),
                Diagnosis = "Herniated Disc C6-C7",
                TreatmentPlan = "Conservative management with physical therapy.",
                DoctorNotes = "Consider surgical intervention if no improvement.",
                NextVisitDate = DateTime.UtcNow.AddDays(21)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-26",
                AppointmentID = "appt-32",
                VisitTime = DateTime.UtcNow.AddDays(-25).AddHours(14).AddMinutes(40),
                Diagnosis = "Complex Regional Pain Syndrome",
                TreatmentPlan = "Multidisciplinary pain management approach.",
                DoctorNotes = "Specialized pain clinic referral required.",
                NextVisitDate = DateTime.UtcNow.AddDays(14)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-27",
                AppointmentID = "appt-21",
                VisitTime = DateTime.UtcNow.AddDays(-26).AddHours(11).AddMinutes(25),
                Diagnosis = "Atrial Fibrillation (Controlled)",
                TreatmentPlan = "Continue anticoagulation and rate control.",
                DoctorNotes = "Regular ECG monitoring needed.",
                NextVisitDate = DateTime.UtcNow.AddDays(30)
            },
            new MedicalRecordModel
            {
                RecordID = "rec-28",
                AppointmentID = "appt-22",
                VisitTime = DateTime.UtcNow.AddDays(-27).AddHours(15).AddMinutes(30),
                Diagnosis = "Diabetic Peripheral Neuropathy",
                TreatmentPlan = "Glycemic control and neuropathic pain management.",
                DoctorNotes = "Foot care education provided.",
                NextVisitDate = DateTime.UtcNow.AddDays(21)
            }
        );
    }

    private static void SeedClinicalExaminations(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClinicalExaminationModel>().HasData(
            // Original 8 clinical examinations (with corrected blank fields)
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-01",
                RecordID = "rec-01",
                Symptoms = "Throat pain, difficulty swallowing, low-grade fever.",
                MedicalHistory = "",
                FamilyHistory = "Father has hypertension.",
                LifestyleHabits = "Non-smoker.",
                Allergies = "",
                Temperature = 38.2,
                Height = 175,
                Weight = 70,
                BMI = 23,
                StatusBMI = StatusBMI.Normal,
                Pulse = 85,
                BloodPressure = "120/80",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-02",
                RecordID = "rec-02",
                Symptoms = "Occasional headaches, dizziness.",
                MedicalHistory = "Diagnosed with hypertension 2 years ago.",
                FamilyHistory = "Mother has diabetes.",
                LifestyleHabits = "Sedentary lifestyle.",
                Allergies = "Penicillin.",
                Temperature = 36.8,
                Height = 162,
                Weight = 65,
                BMI = 24.8,
                StatusBMI = StatusBMI.Normal,
                Pulse = 78,
                BloodPressure = "145/95",
                RespiratoryRate = 18,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-03",
                RecordID = "rec-03",
                Symptoms = "Tightness in chest, shortness of breath on exertion.",
                MedicalHistory = "High cholesterol.",
                FamilyHistory = "Brother died of MI at 50.",
                LifestyleHabits = "Social smoker.",
                Allergies = "",
                Temperature = 37.0,
                Height = 198,
                Weight = 100,
                BMI = 25.4,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 92,
                BloodPressure = "150/95",
                RespiratoryRate = 20,
                OxygenSaturation = 96
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-04",
                RecordID = "rec-04",
                Symptoms = "Swelling in right calf, warm to touch.",
                MedicalHistory = "Recent long-haul flight.",
                FamilyHistory = "",
                LifestyleHabits = "Active.",
                Allergies = "Latex.",
                Temperature = 37.5,
                Height = 180,
                Weight = 80,
                BMI = 24.7,
                StatusBMI = StatusBMI.Normal,
                Pulse = 88,
                BloodPressure = "130/85",
                RespiratoryRate = 18,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-05",
                RecordID = "rec-05",
                Symptoms = "Severe headache with visual disturbances, nausea.",
                MedicalHistory = "History of occasional headaches.",
                FamilyHistory = "Mother has migraines.",
                LifestyleHabits = "High stress job.",
                Allergies = "",
                Temperature = 36.9,
                Height = 178,
                Weight = 75,
                BMI = 23.7,
                StatusBMI = StatusBMI.Normal,
                Pulse = 82,
                BloodPressure = "125/82",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-06",
                RecordID = "rec-06",
                Symptoms = "Fatigue, pale skin, shortness of breath on exertion.",
                MedicalHistory = "Heavy menstrual bleeding.",
                FamilyHistory = "",
                LifestyleHabits = "Vegetarian diet.",
                Allergies = "Shellfish.",
                Temperature = 36.5,
                Height = 165,
                Weight = 55,
                BMI = 20.2,
                StatusBMI = StatusBMI.Normal,
                Pulse = 95,
                BloodPressure = "110/70",
                RespiratoryRate = 18,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-07",
                RecordID = "rec-07",
                Symptoms = "Lower back pain, numbness in right leg.",
                MedicalHistory = "Previous back injury 5 years ago.",
                FamilyHistory = "Father has back problems.",
                LifestyleHabits = "Sedentary work, occasional exercise.",
                Allergies = "",
                Temperature = 37.1,
                Height = 172,
                Weight = 85,
                BMI = 28.7,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 76,
                BloodPressure = "135/88",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-08",
                RecordID = "rec-08",
                Symptoms = "Red rash on arms, itching, mild swelling.",
                MedicalHistory = "History of sensitive skin.",
                FamilyHistory = "",
                LifestyleHabits = "",
                Allergies = "Nickel, certain cosmetics.",
                Temperature = 36.8,
                Height = 170,
                Weight = 60,
                BMI = 20.8,
                StatusBMI = StatusBMI.Normal,
                Pulse = 78,
                BloodPressure = "118/75",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            // Additional 20 clinical examinations
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-09",
                RecordID = "rec-09",
                Symptoms = "Productive cough, wheezing, shortness of breath.",
                MedicalHistory = "40 pack-year smoking history.",
                FamilyHistory = "Father had COPD.",
                LifestyleHabits = "Current smoker, 1 pack/day.",
                Allergies = "",
                Temperature = 37.8,
                Height = 175,
                Weight = 72,
                BMI = 23.5,
                StatusBMI = StatusBMI.Normal,
                Pulse = 94,
                BloodPressure = "140/90",
                RespiratoryRate = 22,
                OxygenSaturation = 93
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-10",
                RecordID = "rec-10",
                Symptoms = "Ear pain, decreased hearing, fever.",
                MedicalHistory = "Recurrent ear infections.",
                FamilyHistory = "",
                LifestyleHabits = "",
                Allergies = "",
                Temperature = 38.5,
                Height = 140,
                Weight = 35,
                BMI = 17.9,
                StatusBMI = StatusBMI.Normal,
                Pulse = 98,
                BloodPressure = "100/65",
                RespiratoryRate = 20,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-11",
                RecordID = "rec-11",
                Symptoms = "Dizziness on standing, lightheadedness.",
                MedicalHistory = "Hypertension on multiple medications.",
                FamilyHistory = "",
                LifestyleHabits = "Regular exercise.",
                Allergies = "Sulfa drugs.",
                Temperature = 36.7,
                Height = 168,
                Weight = 65,
                BMI = 23.0,
                StatusBMI = StatusBMI.Normal,
                Pulse = 72,
                BloodPressure = "110/70",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-12",
                RecordID = "rec-12",
                Symptoms = "Joint swelling, morning stiffness, limited motion.",
                MedicalHistory = "Family history of autoimmune disease.",
                FamilyHistory = "Mother has rheumatoid arthritis.",
                LifestyleHabits = "Former smoker, quit 5 years ago.",
                Allergies = "",
                Temperature = 37.2,
                Height = 160,
                Weight = 58,
                BMI = 22.7,
                StatusBMI = StatusBMI.Normal,
                Pulse = 80,
                BloodPressure = "125/80",
                RespiratoryRate = 18,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-13",
                RecordID = "rec-13",
                Symptoms = "Severe abdominal pain, nausea, vomiting.",
                MedicalHistory = "Gallstones diagnosed 2 years ago.",
                FamilyHistory = "Gallbladder disease in family.",
                LifestyleHabits = "High-fat diet.",
                Allergies = "Penicillin.",
                Temperature = 38.8,
                Height = 165,
                Weight = 78,
                BMI = 28.6,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 110,
                BloodPressure = "150/95",
                RespiratoryRate = 24,
                OxygenSaturation = 96
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-14",
                RecordID = "rec-14",
                Symptoms = "Itchy eyes, watery discharge, redness.",
                MedicalHistory = "Seasonal allergies.",
                FamilyHistory = "Father has hay fever.",
                LifestyleHabits = "",
                Allergies = "Pollen, dust mites.",
                Temperature = 36.5,
                Height = 175,
                Weight = 68,
                BMI = 22.2,
                StatusBMI = StatusBMI.Normal,
                Pulse = 75,
                BloodPressure = "118/75",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-15",
                RecordID = "rec-15",
                Symptoms = "Memory lapses, confusion, difficulty concentrating.",
                MedicalHistory = "Mild cognitive decline over 6 months.",
                FamilyHistory = "Alzheimer's disease in mother.",
                LifestyleHabits = "Retired teacher, mentally active.",
                Allergies = "",
                Temperature = 36.8,
                Height = 170,
                Weight = 75,
                BMI = 25.9,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 78,
                BloodPressure = "135/85",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-16",
                RecordID = "rec-16",
                Symptoms = "Fatigue, weight gain, cold intolerance.",
                MedicalHistory = "Thyroidectomy 10 years ago.",
                FamilyHistory = "",
                LifestyleHabits = "Light exercise routine.",
                Allergies = "",
                Temperature = 36.2,
                Height = 162,
                Weight = 70,
                BMI = 26.6,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 65,
                BloodPressure = "115/75",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-17",
                RecordID = "rec-17",
                Symptoms = "Right upper quadrant pain, fever, jaundice.",
                MedicalHistory = "Gallstones, previous cholecystitis attacks.",
                FamilyHistory = "",
                LifestyleHabits = "Moderate alcohol use.",
                Allergies = "",
                Temperature = 39.0,
                Height = 172,
                Weight = 82,
                BMI = 27.7,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 105,
                BloodPressure = "145/90",
                RespiratoryRate = 20,
                OxygenSaturation = 97
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-18",
                RecordID = "rec-18",
                Symptoms = "Hyperactivity, inattention, impulsivity.",
                MedicalHistory = "Developmental delays noted in school.",
                FamilyHistory = "ADHD in older sibling.",
                LifestyleHabits = "High sugar intake.",
                Allergies = "",
                Temperature = 36.6,
                Height = 120,
                Weight = 25,
                BMI = 17.4,
                StatusBMI = StatusBMI.Normal,
                Pulse = 85,
                BloodPressure = "100/65",
                RespiratoryRate = 18,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-19",
                RecordID = "rec-19",
                Symptoms = "Burning feet, tingling sensations, numbness.",
                MedicalHistory = "Diabetes for 15 years, poor control.",
                FamilyHistory = "Neuropathy in father.",
                LifestyleHabits = "Sedentary lifestyle.",
                Allergies = "",
                Temperature = 36.7,
                Height = 178,
                Weight = 85,
                BMI = 26.8,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 78,
                BloodPressure = "140/85",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-20",
                RecordID = "rec-20",
                Symptoms = "Extreme fatigue, pale skin, shortness of breath.",
                MedicalHistory = "Heavy menstrual bleeding for 6 months.",
                FamilyHistory = "Iron deficiency anemia in mother.",
                LifestyleHabits = "Vegetarian diet.",
                Allergies = "",
                Temperature = 36.4,
                Height = 155,
                Weight = 48,
                BMI = 20.0,
                StatusBMI = StatusBMI.Normal,
                Pulse = 98,
                BloodPressure = "105/65",
                RespiratoryRate = 20,
                OxygenSaturation = 97
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-21",
                RecordID = "rec-21",
                Symptoms = "Surgical site redness, drainage, fever.",
                MedicalHistory = "Appendectomy 2 weeks ago.",
                FamilyHistory = "",
                LifestyleHabits = "",
                Allergies = "Latex.",
                Temperature = 38.9,
                Height = 170,
                Weight = 72,
                BMI = 24.9,
                StatusBMI = StatusBMI.Normal,
                Pulse = 95,
                BloodPressure = "130/80",
                RespiratoryRate = 18,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-22",
                RecordID = "rec-22",
                Symptoms = "Joint pain, butterfly rash, photosensitivity.",
                MedicalHistory = "Autoimmune symptoms for 2 years.",
                FamilyHistory = "Lupus in maternal aunt.",
                LifestyleHabits = "Limited sun exposure due to symptoms.",
                Allergies = "",
                Temperature = 37.3,
                Height = 165,
                Weight = 55,
                BMI = 20.2,
                StatusBMI = StatusBMI.Normal,
                Pulse = 82,
                BloodPressure = "125/75",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-23",
                RecordID = "rec-23",
                Symptoms = "Swelling in legs, decreased urine output.",
                MedicalHistory = "Hypertension, diabetes for 10 years.",
                FamilyHistory = "Kidney disease in father.",
                LifestyleHabits = "High sodium diet.",
                Allergies = "",
                Temperature = 36.6,
                Height = 168,
                Weight = 80,
                BMI = 28.3,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 88,
                BloodPressure = "160/100",
                RespiratoryRate = 18,
                OxygenSaturation = 97
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-24",
                RecordID = "rec-24",
                Symptoms = "Increased thirst, frequent urination, weight loss.",
                MedicalHistory = "Borderline diabetes for 3 years.",
                FamilyHistory = "Type 2 diabetes in both parents.",
                LifestyleHabits = "Sedentary, high carbohydrate diet.",
                Allergies = "",
                Temperature = 36.8,
                Height = 175,
                Weight = 95,
                BMI = 31.0,
                StatusBMI = StatusBMI.Obese,
                Pulse = 85,
                BloodPressure = "150/95",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-25",
                RecordID = "rec-25",
                Symptoms = "Neck pain, arm weakness, hand numbness.",
                MedicalHistory = "Desk job for 20 years.",
                FamilyHistory = "Cervical spine issues in father.",
                LifestyleHabits = "Poor posture, limited exercise.",
                Allergies = "",
                Temperature = 36.7,
                Height = 180,
                Weight = 88,
                BMI = 27.2,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 76,
                BloodPressure = "130/85",
                RespiratoryRate = 16,
                OxygenSaturation = 99
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-26",
                RecordID = "rec-26",
                Symptoms = "Severe burning pain, swelling, skin changes.",
                MedicalHistory = "Arm fracture 6 months ago.",
                FamilyHistory = "",
                LifestyleHabits = "Limited due to pain.",
                Allergies = "",
                Temperature = 37.1,
                Height = 165,
                Weight = 60,
                BMI = 22.0,
                StatusBMI = StatusBMI.Normal,
                Pulse = 90,
                BloodPressure = "140/85",
                RespiratoryRate = 18,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-27",
                RecordID = "rec-27",
                Symptoms = "Irregular heartbeat, occasional palpitations.",
                MedicalHistory = "Atrial fibrillation diagnosed 1 year ago.",
                FamilyHistory = "Heart disease in father.",
                LifestyleHabits = "Moderate exercise.",
                Allergies = "",
                Temperature = 36.5,
                Height = 172,
                Weight = 78,
                BMI = 26.4,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 85,
                BloodPressure = "135/80",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            },
            new ClinicalExaminationModel
            {
                ClinicalID = "clin-28",
                RecordID = "rec-28",
                Symptoms = "Foot numbness, burning sensation, difficulty walking.",
                MedicalHistory = "Poorly controlled diabetes for 12 years.",
                FamilyHistory = "Diabetic complications in mother.",
                LifestyleHabits = "Limited mobility due to pain.",
                Allergies = "",
                Temperature = 36.6,
                Height = 162,
                Weight = 68,
                BMI = 25.9,
                StatusBMI = StatusBMI.Overweight,
                Pulse = 78,
                BloodPressure = "140/85",
                RespiratoryRate = 16,
                OxygenSaturation = 98
            }
        );
    }

    private static void SeedPrescriptions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrescriptionModel>().HasData(
            // Original 8 prescriptions
            new PrescriptionModel
            {
                PrescriptionID = "presc-01",
                RecordID = "rec-01",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(30),
                Status = PrescriptionStatus.Pending,
                PharmacistID = null!,
                VerifiedAt = null!,
                Priority = Priority.Routine,
                DispensedAt = null!,
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-02",
                RecordID = "rec-02",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-2).AddHours(15),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(30),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(45),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-03",
                RecordID = "rec-03",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-5).AddHours(11),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(15),
                Priority = Priority.Urgent,
                DispensedAt = null!,
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-04",
                RecordID = "rec-04",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-10).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Cancelled,
                PharmacistID = null!,
                VerifiedAt = null!,
                Priority = Priority.Stat,
                DispensedAt = null!,
                Reason = "Duplicate prescription detected.",
                CancelledAt = DateTime.UtcNow.AddDays(-10).AddHours(16)
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-05",
                RecordID = "rec-05",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-3).AddHours(11).AddMinutes(45),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-3).AddHours(12),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-3).AddHours(12).AddMinutes(15),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-06",
                RecordID = "rec-06",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-7).AddHours(16).AddMinutes(45),
                Status = PrescriptionStatus.Pending,
                PharmacistID = null!,
                VerifiedAt = null!,
                Priority = Priority.Urgent,
                DispensedAt = null!,
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-07",
                RecordID = "rec-07",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-14).AddHours(14),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-14).AddHours(14).AddMinutes(30),
                Priority = Priority.Routine,
                DispensedAt = null!,
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-08",
                RecordID = "rec-08",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-4).AddHours(10).AddMinutes(30),
                Status = PrescriptionStatus.Cancelled,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-4).AddHours(11),
                Priority = Priority.Routine,
                DispensedAt = null!,
                Reason = "Patient refused medication due to cost.",
                CancelledAt = DateTime.UtcNow.AddDays(-4).AddHours(11).AddMinutes(10)
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-09",
                RecordID = "rec-09",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-8).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-8).AddHours(15).AddMinutes(45),
                Priority = Priority.Urgent,
                DispensedAt = DateTime.UtcNow.AddDays(-8).AddHours(16),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-10",
                RecordID = "rec-10",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-6).AddHours(11).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-6).AddHours(11).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-6).AddHours(12),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-11",
                RecordID = "rec-11",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-12).AddHours(9).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-12).AddHours(9).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-12).AddHours(10),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-12",
                RecordID = "rec-12",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-14).AddHours(12).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-14).AddHours(12).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-14).AddHours(13),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-13",
                RecordID = "rec-13",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-11).AddHours(16).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-11).AddHours(16).AddMinutes(45),
                Priority = Priority.Urgent,
                DispensedAt = DateTime.UtcNow.AddDays(-11).AddHours(17),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-14",
                RecordID = "rec-14",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-15).AddHours(10).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-15).AddHours(10).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-15).AddHours(11),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-15",
                RecordID = "rec-15",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-13).AddHours(13).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-13).AddHours(13).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-13).AddHours(14),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-16",
                RecordID = "rec-16",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-7).AddHours(8).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-7).AddHours(8).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-7).AddHours(9),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-17",
                RecordID = "rec-17",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-16).AddHours(14).AddMinutes(30),
                Status = PrescriptionStatus.Cancelled,
                PharmacistID = null!,
                VerifiedAt = null!,
                Priority = Priority.Routine,
                DispensedAt = null!,
                Reason = "Medication discontinued by physician.",
                CancelledAt = DateTime.UtcNow.AddDays(-16).AddHours(15)
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-18",
                RecordID = "rec-18",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-17).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-17).AddHours(15).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-17).AddHours(16),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-19",
                RecordID = "rec-19",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-18).AddHours(10).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-18).AddHours(10).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-18).AddHours(11),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-20",
                RecordID = "rec-20",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-19).AddHours(16).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-19).AddHours(16).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-19).AddHours(17),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-21",
                RecordID = "rec-21",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-20).AddHours(13).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-20).AddHours(13).AddMinutes(45),
                Priority = Priority.Stat,
                DispensedAt = DateTime.UtcNow.AddDays(-20).AddHours(14),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-22",
                RecordID = "rec-22",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-21).AddHours(10).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-21).AddHours(10).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-21).AddHours(11),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-23",
                RecordID = "rec-23",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-22).AddHours(11).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-22).AddHours(11).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-22).AddHours(12),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-24",
                RecordID = "rec-24",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-23).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-23).AddHours(15).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-23).AddHours(16),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-25",
                RecordID = "rec-25",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-24).AddHours(9).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-24).AddHours(9).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-24).AddHours(10),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-26",
                RecordID = "rec-26",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-25).AddHours(15).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-25).AddHours(15).AddMinutes(45),
                Priority = Priority.Urgent,
                DispensedAt = DateTime.UtcNow.AddDays(-25).AddHours(16),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-27",
                RecordID = "rec-27",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-26).AddHours(11).AddMinutes(30),
                Status = PrescriptionStatus.Dispensed,
                PharmacistID = "phar-02",
                VerifiedAt = DateTime.UtcNow.AddDays(-26).AddHours(11).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-26).AddHours(12),
                Reason = null!,
                CancelledAt = null!
            },
            new PrescriptionModel
            {
                PrescriptionID = "presc-28",
                RecordID = "rec-28",
                PrescriptionDateTime = DateTime.UtcNow.AddDays(-27).AddHours(14).AddMinutes(30),
                Status = PrescriptionStatus.Completed,
                PharmacistID = "phar-01",
                VerifiedAt = DateTime.UtcNow.AddDays(-27).AddHours(14).AddMinutes(45),
                Priority = Priority.Routine,
                DispensedAt = DateTime.UtcNow.AddDays(-27).AddHours(15),
                Reason = null!,
                CancelledAt = null!
            }
        );
    }

    private static void SeedPrescriptionItems(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PrescriptionItemModel>().HasData(
            // Original 10 prescription items
            new PrescriptionItemModel
            {
                ItemID = "pi-01",
                PrescriptionID = "presc-01",
                MedicationID = "med-amox-500",
                Quantity = 21,
                Dosage = "500mg",
                Frequency = "3 times a day (every 8 hours)",
                DurationDays = 7,
                Instruction = "Take after meals.",
                Indication = "For bacterial infection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-02",
                PrescriptionID = "presc-01",
                MedicationID = "med-ibu-400",
                Quantity = 10,
                Dosage = "400mg",
                Frequency = "As needed for pain/fever, max 3 times daily",
                DurationDays = 5,
                Instruction = "Do not take on an empty stomach.",
                Indication = "For pain and fever management.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-03",
                PrescriptionID = "presc-02",
                MedicationID = "med-met-850",
                Quantity = 60,
                Dosage = "850mg",
                Frequency = "Twice a day",
                DurationDays = 30,
                Instruction = "Take with meals to reduce stomach upset.",
                Indication = "Diabetes management.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-04",
                PrescriptionID = "presc-03",
                MedicationID = "med-ator-20",
                Quantity = 30,
                Dosage = "20mg",
                Frequency = "Once daily at night",
                DurationDays = 30,
                Instruction = "Avoid grapefruit juice.",
                Indication = "Cholesterol management.",
                DoseScheduleJSON = "{&quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-05",
                PrescriptionID = "presc-03",
                MedicationID = "med-omep-20",
                Quantity = 14,
                Dosage = "20mg",
                Frequency = "Once daily before breakfast",
                DurationDays = 14,
                Instruction = "Take 30 mins before food.",
                Indication = "Gastric protection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-06",
                PrescriptionID = "presc-04",
                MedicationID = "med-ibu-400",
                Quantity = 20,
                Dosage = "400mg",
                Frequency = "Every 6 hours",
                DurationDays = 5,
                Instruction = "Take with food.",
                Indication = "Pain relief.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1, &quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-07",
                PrescriptionID = "presc-05",
                MedicationID = "med-para-500",
                Quantity = 15,
                Dosage = "500mg",
                Frequency = "Every 6 hours as needed",
                DurationDays = 7,
                Instruction = "Take at onset of headache.",
                Indication = "Migraine pain relief.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-08",
                PrescriptionID = "presc-06",
                MedicationID = "med-cet-10",
                Quantity = 30,
                Dosage = "10mg",
                Frequency = "Once daily at night",
                DurationDays = 30,
                Instruction = "May cause drowsiness.",
                Indication = "Allergy management.",
                DoseScheduleJSON = "{&quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-09",
                PrescriptionID = "presc-07",
                MedicationID = "med-ibu-400",
                Quantity = 40,
                Dosage = "400mg",
                Frequency = "Every 8 hours as needed",
                DurationDays = 14,
                Instruction = "Take with meals.",
                Indication = "Back pain management.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-10",
                PrescriptionID = "presc-08",
                MedicationID = "med-omep-20",
                Quantity = 30,
                Dosage = "20mg",
                Frequency = "Once daily before breakfast",
                DurationDays = 30,
                Instruction = "Take 30 mins before food.",
                Indication = "Gastric protection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            // Additional 20 prescription items
            new PrescriptionItemModel
            {
                ItemID = "pi-11",
                PrescriptionID = "presc-09",
                MedicationID = "med-albuterol-syrup",
                Quantity = 120,
                Dosage = "5ml",
                Frequency = "3 times a day",
                DurationDays = 10,
                Instruction = "Shake well before use.",
                Indication = "Bronchodilator for COPD.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-12",
                PrescriptionID = "presc-09",
                MedicationID = "med-azithromycin-250",
                Quantity = 30,
                Dosage = "500mg",
                Frequency = "Once daily",
                DurationDays = 3,
                Instruction = "Take with food.",
                Indication = "Antibiotic for respiratory infection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-13",
                PrescriptionID = "presc-10",
                MedicationID = "med-aspirin-100",
                Quantity = 20,
                Dosage = "100mg",
                Frequency = "3 times daily",
                DurationDays = 5,
                Instruction = "Take with food.",
                Indication = "Pain and fever relief.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-14",
                PrescriptionID = "presc-10",
                MedicationID = "med-cet-10",
                Quantity = 10,
                Dosage = "10mg",
                Frequency = "Once daily",
                DurationDays = 5,
                Instruction = "May cause drowsiness.",
                Indication = "Allergy relief.",
                DoseScheduleJSON = "{&quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-15",
                PrescriptionID = "presc-11",
                MedicationID = "med-lisinopril-10",
                Quantity = 30,
                Dosage = "10mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Take in the morning.",
                Indication = "Blood pressure control.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-16",
                PrescriptionID = "presc-12",
                MedicationID = "med-metoprolol-25",
                Quantity = 60,
                Dosage = "25mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "Take with food.",
                Indication = "RA treatment.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-17",
                PrescriptionID = "presc-12",
                MedicationID = "med-para-500",
                Quantity = 30,
                Dosage = "500mg",
                Frequency = "Every 6 hours as needed",
                DurationDays = 14,
                Instruction = "Do not exceed 4g per day.",
                Indication = "Pain management.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-18",
                PrescriptionID = "presc-13",
                MedicationID = "med-ondansetron-4",
                Quantity = 10,
                Dosage = "4mg",
                Frequency = "Every 8 hours as needed",
                DurationDays = 3,
                Instruction = "Dissolve under tongue.",
                Indication = "Nausea and vomiting.",
                DoseScheduleJSON = "{&quot;as_needed&quot;: true}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-19",
                PrescriptionID = "presc-13",
                MedicationID = "metformin-500",
                Quantity = 60,
                Dosage = "500mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "Take with meals.",
                Indication = "Diabetes management.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-20",
                PrescriptionID = "presc-14",
                MedicationID = "med-prednisone-5",
                Quantity = 20,
                Dosage = "5mg",
                Frequency = "Once daily",
                DurationDays = 5,
                Instruction = "Take with food.",
                Indication = "Inflammation reduction.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-21",
                PrescriptionID = "presc-15",
                MedicationID = "med-fluoxetine-20",
                Quantity = 30,
                Dosage = "20mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Take in the morning.",
                Indication = "Cognitive function.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-22",
                PrescriptionID = "presc-15",
                MedicationID = "med-vit-c-500",
                Quantity = 60,
                Dosage = "500mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "Take with food.",
                Indication = "Antioxidant support.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-23",
                PrescriptionID = "presc-16",
                MedicationID = "med-levothyroxine-50",
                Quantity = 90,
                Dosage = "50mcg",
                Frequency = "Once daily",
                DurationDays = 90,
                Instruction = "Take on empty stomach.",
                Indication = "Thyroid hormone replacement.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-24",
                PrescriptionID = "presc-18",
                MedicationID = "med-clonazepam-0-5",
                Quantity = 30,
                Dosage = "0.5mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "May cause drowsiness.",
                Indication = "ADHD management.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-25",
                PrescriptionID = "presc-19",
                MedicationID = "med-gabapentin-300",
                Quantity = 90,
                Dosage = "300mg",
                Frequency = "Three times daily",
                DurationDays = 30,
                Instruction = "Take with food.",
                Indication = "Neuropathic pain.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-26",
                PrescriptionID = "presc-20",
                MedicationID = "med-ferrous-sulfate-325",  
                Quantity = 90,
                Dosage = "325mg",
                Frequency = "Three times daily",
                DurationDays = 30,
                Instruction = "Take with food.",
                Indication = "Iron deficiency anemia.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-27",
                PrescriptionID = "presc-20",
                MedicationID = "med-omep-20",
                Quantity = 30,
                Dosage = "20mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Take 30 mins before food.",
                Indication = "Stomach protection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-28",
                PrescriptionID = "presc-21",
                MedicationID = "med-vancomycin-500",
                Quantity = 40,
                Dosage = "500mg",
                Frequency = "Every 6 hours",
                DurationDays = 10,
                Instruction = "IV administration only.",
                Indication = "Post-operative infection.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;afternoon&quot;: 1, &quot;evening&quot;: 1, &quot;night&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-29",
                PrescriptionID = "presc-22",
                MedicationID = "med-hydroxychloroquine-200",
                Quantity = 60,
                Dosage = "200mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "Take with food or milk.",
                Indication = "Autoimmune disease.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-30",
                PrescriptionID = "presc-23",
                MedicationID = "med-losartan-50",
                Quantity = 30,
                Dosage = "50mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Take with or without food.",
                Indication = "Blood pressure control.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-31",
                PrescriptionID = "presc-24",
                MedicationID = "metformin-500",
                Quantity = 60,
                Dosage = "500mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "Take with meals.",
                Indication = "Blood sugar control.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-32",
                PrescriptionID = "presc-25",
                MedicationID = "med-amlodipine-5",
                Quantity = 30,
                Dosage = "5mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Take at same time each day.",
                Indication = "Blood pressure control.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-33",
                PrescriptionID = "presc-26",
                MedicationID = "med-duloxetine-30",
                Quantity = 30,
                Dosage = "30mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Take with food.",
                Indication = "Neuropathic pain management.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-34",
                PrescriptionID = "presc-27",
                MedicationID = "med-warfarin-5",
                Quantity = 30,
                Dosage = "5mg",
                Frequency = "Once daily",
                DurationDays = 30,
                Instruction = "Regular INR monitoring required.",
                Indication = "Anticoagulation.",
                DoseScheduleJSON = "{&quot;evening&quot;: 1}"
            },
            new PrescriptionItemModel
            {
                ItemID = "pi-35",
                PrescriptionID = "presc-28",
                MedicationID = "med-pregabalin-75",
                Quantity = 60,
                Dosage = "75mg",
                Frequency = "Twice daily",
                DurationDays = 30,
                Instruction = "May cause dizziness.",
                Indication = "Diabetic neuropathy.",
                DoseScheduleJSON = "{&quot;morning&quot;: 1, &quot;evening&quot;: 1}"
            }
        );
    }
    private static void SeedMedicationAdherence(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationAdherenceModel>().HasData(
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-001",
                PrescriptionItemID = "pi-01",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(8).AddMinutes(15),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-002",
                PrescriptionItemID = "pi-01",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(13),
                TakenDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(13).AddMinutes(30),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-003",
                PrescriptionItemID = "pi-01",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-004",
                PrescriptionItemID = "pi-01",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(13),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-005",
                PrescriptionItemID = "pi-02",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(14),
                TakenDateTime = null,
                Status = AdherenceStatus.Skipped,
                Notes = "Stomach pain"
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-006",
                PrescriptionItemID = "pi-03",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(8).AddMinutes(10),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-007",
                PrescriptionItemID = "pi-03",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(20),
                TakenDateTime = null,
                Status = AdherenceStatus.Missed,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-008",
                PrescriptionItemID = "pi-03",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(20),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-009",
                PrescriptionItemID = "pi-04",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(21),
                TakenDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(21).AddMinutes(45),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-010",
                PrescriptionItemID = "pi-04",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(21),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-011",
                PrescriptionItemID = "pi-05",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(7),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(7).AddMinutes(5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-012",
                PrescriptionItemID = "pi-06",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-2),
                TakenDateTime = DateTime.UtcNow.AddHours(-1.9),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-013",
                PrescriptionItemID = "pi-06",
                ScheduledDateTime = DateTime.UtcNow.AddHours(4),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-014",
                PrescriptionItemID = "pi-07",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-5),
                TakenDateTime = DateTime.UtcNow.AddHours(-4.8),
                Status = AdherenceStatus.Taken,
                Notes = "Headache"
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-015",
                PrescriptionItemID = "pi-08",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(22),
                TakenDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(22).AddMinutes(10),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-016",
                PrescriptionItemID = "pi-08",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(22),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-017",
                PrescriptionItemID = "pi-09",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-3),
                TakenDateTime = null,
                Status = AdherenceStatus.Skipped,
                Notes = "Pain improved"
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-018",
                PrescriptionItemID = "pi-10",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(7),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(7).AddMinutes(15),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-019",
                PrescriptionItemID = "pi-11",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-1),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-020",
                PrescriptionItemID = "pi-12",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(9),
                TakenDateTime = null,
                Status = AdherenceStatus.Missed,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-021",
                PrescriptionItemID = "pi-13",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-6),
                TakenDateTime = DateTime.UtcNow.AddHours(-5.5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-022",
                PrescriptionItemID = "pi-14",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(21),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-023",
                PrescriptionItemID = "pi-15",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(30),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-024",
                PrescriptionItemID = "pi-16",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(8).AddMinutes(5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-025",
                PrescriptionItemID = "pi-16",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(20),
                TakenDateTime = null,
                Status = AdherenceStatus.Skipped,
                Notes = "Felt dizzy"
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-026",
                PrescriptionItemID = "pi-17",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-2),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-027",
                PrescriptionItemID = "pi-18",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-4),
                TakenDateTime = DateTime.UtcNow.AddHours(-3.9),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-028",
                PrescriptionItemID = "pi-19",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(19),
                TakenDateTime = null,
                Status = AdherenceStatus.Missed,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-029",
                PrescriptionItemID = "pi-19",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(10),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-030",
                PrescriptionItemID = "pi-20",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(9),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(9).AddMinutes(5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-031",
                PrescriptionItemID = "pi-21",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(2),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-032",
                PrescriptionItemID = "pi-22",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(3),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-033",
                PrescriptionItemID = "pi-22",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(20),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-034",
                PrescriptionItemID = "pi-23",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(6),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(6).AddMinutes(10),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-035",
                PrescriptionItemID = "pi-24",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-5),
                TakenDateTime = null,
                Status = AdherenceStatus.Missed,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-036",
                PrescriptionItemID = "pi-25",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-1),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-037",
                PrescriptionItemID = "pi-26",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-4),
                TakenDateTime = DateTime.UtcNow.AddHours(-3.8),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-038",
                PrescriptionItemID = "pi-26",
                ScheduledDateTime = DateTime.UtcNow.AddHours(4),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-039",
                PrescriptionItemID = "pi-27",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(7),
                TakenDateTime = null,
                Status = AdherenceStatus.Skipped,
                Notes = "Ran out of water"
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-040",
                PrescriptionItemID = "pi-27",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(7),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(7).AddMinutes(15),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-041",
                PrescriptionItemID = "pi-28",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-2),
                TakenDateTime = DateTime.UtcNow.AddHours(-1.9),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-042",
                PrescriptionItemID = "pi-28",
                ScheduledDateTime = DateTime.UtcNow.AddHours(4),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-043",
                PrescriptionItemID = "pi-29",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(9),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(9).AddMinutes(5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-044",
                PrescriptionItemID = "pi-29",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(21),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-045",
                PrescriptionItemID = "pi-30",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(20),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-046",
                PrescriptionItemID = "pi-31",
                ScheduledDateTime = DateTime.UtcNow.Date.AddDays(-1).AddHours(19),
                TakenDateTime = null,
                Status = AdherenceStatus.Missed,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-047",
                PrescriptionItemID = "pi-31",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(10),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-048",
                PrescriptionItemID = "pi-32",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(9),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(9).AddMinutes(1),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-049",
                PrescriptionItemID = "pi-33",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(8),
                TakenDateTime = DateTime.UtcNow.Date.AddHours(8).AddMinutes(5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-050",
                PrescriptionItemID = "pi-34",
                ScheduledDateTime = DateTime.UtcNow.Date.AddHours(18),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-051",
                PrescriptionItemID = "pi-35",
                ScheduledDateTime = DateTime.UtcNow.AddHours(-6),
                TakenDateTime = DateTime.UtcNow.AddHours(-5.5),
                Status = AdherenceStatus.Taken,
                Notes = null
            },
            new MedicationAdherenceModel
            {
                AdherenceID = "ma-052",
                PrescriptionItemID = "pi-35",
                ScheduledDateTime = DateTime.UtcNow.AddHours(6),
                TakenDateTime = null,
                Status = AdherenceStatus.Pending,
                Notes = null
            }
        );
    }
    private static void SeedDoctorSchedules(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorScheduleModel>().HasData(
            // Original 10 doctor schedules
            new DoctorScheduleModel
            {
                ScheduleID = "sch-01",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(-1).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-1).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-10),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-10)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-02",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(1).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(1).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-9),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-9)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-03",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-2).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(-2).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-8),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-8)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-04",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-5).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-5).Date.AddHours(16),
                CreatedDatetime = DateTime.UtcNow.AddDays(-7),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-7)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-05",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(-10).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(-10).Date.AddHours(18),
                CreatedDatetime = DateTime.UtcNow.AddDays(-6),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-6)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-06",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.Date.AddHours(7),
                EndTime = DateTime.UtcNow.Date.AddHours(19),
                CreatedDatetime = DateTime.UtcNow.AddDays(-5),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-5)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-07",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(2).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(2).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-4),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-4)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-08",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.AddDays(3).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(3).Date.AddHours(16),
                CreatedDatetime = DateTime.UtcNow.AddDays(-3),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-3)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-09",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(4).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(4).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-2),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-2)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-10",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(5).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(5).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-1),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-1)
            },
            // Additional 20 doctor schedules
            new DoctorScheduleModel
            {
                ScheduleID = "sch-11",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(-3).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-3).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-15),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-15)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-12",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(-4).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-4).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-14),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-14)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-13",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-6).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(-6).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-13),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-13)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-14",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-7).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(-7).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-12),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-12)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-15",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(-11).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(-11).Date.AddHours(18),
                CreatedDatetime = DateTime.UtcNow.AddDays(-11),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-11)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-16",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(-12).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(-12).Date.AddHours(18),
                CreatedDatetime = DateTime.UtcNow.AddDays(-10),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-10)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-17",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.AddDays(-8).Date.AddHours(7),
                EndTime = DateTime.UtcNow.AddDays(-8).Date.AddHours(19),
                CreatedDatetime = DateTime.UtcNow.AddDays(-9),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-9)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-18",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.AddDays(-9).Date.AddHours(7),
                EndTime = DateTime.UtcNow.AddDays(-9).Date.AddHours(19),
                CreatedDatetime = DateTime.UtcNow.AddDays(-8),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-8)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-19",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(6).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(6).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-7),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-7)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-20",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(7).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(7).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-6),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-6)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-21",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(8).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(8).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-5),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-5)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-22",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(9).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(9).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-4),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-4)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-23",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(10).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(10).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-3),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-3)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-24",
                DoctorID = "doc-03",
                StartTime = DateTime.UtcNow.AddDays(11).Date.AddHours(9),
                EndTime = DateTime.UtcNow.AddDays(11).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-2),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-2)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-25",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.AddDays(12).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(12).Date.AddHours(16),
                CreatedDatetime = DateTime.UtcNow.AddDays(-1),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-1)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-26",
                DoctorID = "doc-04",
                StartTime = DateTime.UtcNow.AddDays(13).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(13).Date.AddHours(16),
                CreatedDatetime = DateTime.UtcNow.AddDays(-1),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-1)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-27",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(-13).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-13).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-20),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-20)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-28",
                DoctorID = "doc-01",
                StartTime = DateTime.UtcNow.AddDays(-14).Date.AddHours(8),
                EndTime = DateTime.UtcNow.AddDays(-14).Date.AddHours(17),
                CreatedDatetime = DateTime.UtcNow.AddDays(-19),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-19)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-29",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-15).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(-15).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-18),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-18)
            },
            new DoctorScheduleModel
            {
                ScheduleID = "sch-30",
                DoctorID = "doc-02",
                StartTime = DateTime.UtcNow.AddDays(-16).Date.AddHours(13),
                EndTime = DateTime.UtcNow.AddDays(-16).Date.AddHours(21),
                CreatedDatetime = DateTime.UtcNow.AddDays(-17),
                UpdatedDatetime = DateTime.UtcNow.AddDays(-17)
            }
        );
    }

    private static void SeedMedicationInteractions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationInteractionModel>().HasData(
            // Original 10 medication interactions
            new MedicationInteractionModel
            {
                InteractionID = "int-01",
                Medication1ID = "med-ibu-400",
                Medication2ID = "med-met-850",
                Severity = Severity.Moderate,
                Description = "Potential reduction in renal function.",
                ClinicalEffects = "NSAIDs may impair renal function, increasing the risk of metformin-associated lactic acidosis.",
                Management = "Monitor renal function periodically."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-02",
                Medication1ID = "med-ator-20",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Altered absorption.",
                ClinicalEffects = "Omeprazole may slightly increase the serum concentration of Atorvastatin.",
                Management = "Monitor for statin-related side effects like muscle pain."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-03",
                Medication1ID = "med-ibu-400",
                Medication2ID = "med-ator-20",
                Severity = Severity.Mild,
                Description = "Potential reduced antihypertensive effect.",
                ClinicalEffects = "NSAIDs may reduce the cardiovascular protection of statins in high risk patients.",
                Management = "Use lowest effective dose of NSAID."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-04",
                Medication1ID = "med-amox-500",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Reduced antibiotic absorption.",
                ClinicalEffects = "Omeprazole may decrease the absorption of amoxicillin.",
                Management = "Separate administration by 2 hours if possible."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-05",
                Medication1ID = "med-para-500",
                Medication2ID = "med-ibu-400",
                Severity = Severity.Moderate,
                Description = "Increased risk of kidney damage.",
                ClinicalEffects = "Combined use may increase risk of renal toxicity.",
                Management = "Monitor kidney function, avoid prolonged use."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-06",
                Medication1ID = "med-cet-10",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Altered drug metabolism.",
                ClinicalEffects = "Omeprazole may increase cetirizine levels slightly.",
                Management = "Monitor for increased drowsiness."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-07",
                Medication1ID = "med-met-850",
                Medication2ID = "med-ator-20",
                Severity = Severity.Mild,
                Description = "Potential muscle effects.",
                ClinicalEffects = "Rare cases of increased muscle pain when combined.",
                Management = "Monitor for muscle symptoms."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-08",
                Medication1ID = "med-vit-c-500",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Reduced vitamin C absorption.",
                ClinicalEffects = "Omeprazole may decrease vitamin C absorption.",
                Management = "Take vitamin C supplements separately."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-09",
                Medication1ID = "med-amox-500",
                Medication2ID = "med-cet-10",
                Severity = Severity.Mild,
                Description = "No significant interaction.",
                ClinicalEffects = "Generally safe to use together.",
                Management = "No special precautions needed."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-10",
                Medication1ID = "med-met-850",
                Medication2ID = "med-ibu-400",
                Severity = Severity.Severe,
                Description = "High risk of lactic acidosis.",
                ClinicalEffects = "NSAIDs may significantly increase metformin levels.",
                Management = "Avoid combination if possible, monitor closely."
            },
            // Additional 20 medication interactions
            new MedicationInteractionModel
            {
                InteractionID = "int-11",
                Medication1ID = "med-aspirin-100",
                Medication2ID = "med-warfarin-5",
                Severity = Severity.Severe,
                Description = "Increased bleeding risk.",
                ClinicalEffects = "Aspirin potentiates anticoagulant effect of warfarin.",
                Management = "Monitor INR closely, consider dose adjustment."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-12",
                Medication1ID = "med-lisinopril-10",
                Medication2ID = "med-amlodipine-5",
                Severity = Severity.Mild,
                Description = "Additive blood pressure reduction.",
                ClinicalEffects = "Enhanced antihypertensive effect may cause hypotension.",
                Management = "Monitor blood pressure, adjust doses if needed."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-13",
                Medication1ID = "med-simvastatin-20",
                Medication2ID = "med-vf-500",
                Severity = Severity.Severe,
                Description = "Increased risk of rhabdomyolysis.",
                ClinicalEffects = "Clarithromycin inhibits simvastatin metabolism.",
                Management = "Avoid combination, use alternative antibiotics."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-14",
                Medication1ID = "med-prednisone-5",
                Medication2ID = "metformin-500",
                Severity = Severity.Moderate,
                Description = "Increased blood glucose levels.",
                ClinicalEffects = "Steroids may reduce metformin effectiveness.",
                Management = "Monitor blood glucose, consider dose adjustment."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-15",
                Medication1ID = "med-azithromycin-250",
                Medication2ID = "med-warfarin-5",
                Severity = Severity.Moderate,
                Description = "Enhanced anticoagulant effect.",
                ClinicalEffects = "Azithromycin may increase warfarin levels.",
                Management = "Monitor INR closely during therapy."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-16",
                Medication1ID = "med-gabapentin-300",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Reduced gabapentin absorption.",
                ClinicalEffects = "Antacids may decrease gabapentin bioavailability.",
                Management = "Separate administration by 2 hours."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-17",
                Medication1ID = "med-levothyroxine-50",
                Medication2ID = "med-omep-20",
                Severity = Severity.Moderate,
                Description = "Reduced thyroid hormone absorption.",
                ClinicalEffects = "PPIs may decrease levothyroxine absorption.",
                Management = "Separate administration by 4 hours."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-18",
                Medication1ID = "med-albuterol-syrup",
                Medication2ID = "med-metoprolol-25",
                Severity = Severity.Moderate,
                Description = "Potential bronchospasm.",
                ClinicalEffects = "Beta-blockers may reduce albuterol effectiveness.",
                Management = "Use cardioselective beta-blockers, monitor respiratory function."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-19",
                Medication1ID = "med-hydrochlorothiazide-25",
                Medication2ID = "med-lisinopril-10",
                Severity = Severity.Mild,
                Description = "Enhanced potassium depletion.",
                ClinicalEffects = "Combined diuretic and ACE inhibitor effects.",
                Management = "Monitor electrolytes, particularly potassium."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-20",
                Medication1ID = "med-tramadol-50",
                Medication2ID = "med-fluoxetine-20",
                Severity = Severity.Severe,
                Description = "Serotonin syndrome risk.",
                ClinicalEffects = "SSRI may increase tramadol serotonergic effects.",
                Management = "Avoid combination or use alternative analgesics."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-21",
                Medication1ID = "med-ondansetron-4",
                Medication2ID = "med-ondansetron-4",
                Severity = Severity.Moderate,
                Description = "QT prolongation risk.",
                ClinicalEffects = "Combined QT prolonging medications may cause arrhythmias.",
                Management = "Monitor ECG, avoid in patients with cardiac issues."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-22",
                Medication1ID = "med-losartan-50",
                Medication2ID = "med-hydrochlorothiazide-25",
                Severity = Severity.Mild,
                Description = "Enhanced antihypertensive effect.",
                ClinicalEffects = "Additive blood pressure reduction.",
                Management = "Monitor blood pressure, adjust doses as needed."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-23",
                Medication1ID = "med-fluoxetine-20",
                Medication2ID = "med-tramadol-50",
                Severity = Severity.Severe,
                Description = "Increased seizure risk.",
                ClinicalEffects = "Combined serotonergic effects may lower seizure threshold.",
                Management = "Avoid combination, use alternative antidepressants."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-24",
                Medication1ID = "med-metoprolol-25",
                Medication2ID = "med-amlodipine-5",
                Severity = Severity.Mild,
                Description = "Enhanced bradycardia risk.",
                ClinicalEffects = "Combined negative chronotropic effects.",
                Management = "Monitor heart rate, consider dose reduction."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-25",
                Medication1ID = "med-clonazepam-0-5",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Increased sedation.",
                ClinicalEffects = "Omeprazole may increase clonazepam levels.",
                Management = "Monitor for increased drowsiness, adjust dose if needed."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-26",
                Medication1ID = "med-insulin-glargine",
                Medication2ID = "med-prednisone-5",
                Severity = Severity.Moderate,
                Description = "Increased insulin requirements.",
                ClinicalEffects = "Steroids increase insulin resistance.",
                Management = "Monitor blood glucose, adjust insulin dose."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-27",
                Medication1ID = "med-aspirin-100",
                Medication2ID = "med-omep-20",
                Severity = Severity.Mild,
                Description = "Reduced aspirin effectiveness.",
                ClinicalEffects = "PPIs may interfere with aspirin antiplatelet effect.",
                Management = "Consider alternative acid suppression therapy."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-28",
                Medication1ID = "med-simvastatin-20",
                Medication2ID = "med-diltiazem-60",
                Severity = Severity.Severe,
                Description = "Increased myopathy risk.",
                ClinicalEffects = "Diltiazem inhibits simvastatin metabolism.",
                Management = "Reduce simvastatin dose or use alternative statin."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-29",
                Medication1ID = "med-azithromycin-250",
                Medication2ID = "med-digoxin-125",
                Severity = Severity.Moderate,
                Description = "Increased digoxin levels.",
                ClinicalEffects = "Azithromycin may reduce digoxin clearance.",
                Management = "Monitor digoxin levels, adjust dose if needed."
            },
            new MedicationInteractionModel
            {
                InteractionID = "int-30",
                Medication1ID = "metformin-500",
                Medication2ID = "med-contrast-iodine",
                Severity = Severity.Severe,
                Description = "Increased lactic acidosis risk.",
                ClinicalEffects = "Contrast media with metformin may cause renal failure.",
                Management = "Stop metformin before contrast studies, resume after renal function confirmed."
            }
        );
    }

    private static void SeedMedicationStockLogs(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicationStockLogModel>().HasData(
            // Original 13 medication stock logs
            new MedicationStockLogModel
            {
                LogID = "log-01",
                MedicationID = "med-amox-500",
                QuantityChange = 1000,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-02",
                MedicationID = "med-ibu-400",
                QuantityChange = 500,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-03",
                MedicationID = "med-amox-500",
                QuantityChange = -21,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-01",
                CreatedAt = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(45)
            },
            new MedicationStockLogModel
            {
                LogID = "log-04",
                MedicationID = "med-ibu-400",
                QuantityChange = -10,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-01",
                CreatedAt = DateTime.UtcNow.AddDays(-1).AddHours(9).AddMinutes(45)
            },
            new MedicationStockLogModel
            {
                LogID = "log-05",
                MedicationID = "med-met-850",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-02",
                CreatedAt = DateTime.UtcNow.AddDays(-2).AddHours(15).AddMinutes(45)
            },
            new MedicationStockLogModel
            {
                LogID = "log-06",
                MedicationID = "med-ator-20",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-03",
                CreatedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(30)
            },
            new MedicationStockLogModel
            {
                LogID = "log-07",
                MedicationID = "med-omep-20",
                QuantityChange = -14,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-03",
                CreatedAt = DateTime.UtcNow.AddDays(-5).AddHours(11).AddMinutes(30)
            },
            new MedicationStockLogModel
            {
                LogID = "log-08",
                MedicationID = "med-para-500",
                QuantityChange = 2000,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-09",
                MedicationID = "med-cet-10",
                QuantityChange = 2000,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-1)
            },
            new MedicationStockLogModel
            {
                LogID = "log-10",
                MedicationID = "med-para-500",
                QuantityChange = -15,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-05",
                CreatedAt = DateTime.UtcNow.AddDays(-3).AddHours(12).AddMinutes(15)
            },
            new MedicationStockLogModel
            {
                LogID = "log-11",
                MedicationID = "med-cet-10",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-06",
                CreatedAt = DateTime.UtcNow.AddDays(-7).AddHours(17).AddMinutes(20)
            },
            new MedicationStockLogModel
            {
                LogID = "log-12",
                MedicationID = "med-ibu-400",
                QuantityChange = -40,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-07",
                CreatedAt = DateTime.UtcNow
            },
            new MedicationStockLogModel
            {
                LogID = "log-13",
                MedicationID = "med-omep-20",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-08",
                CreatedAt = DateTime.UtcNow.AddDays(-4).AddHours(11).AddMinutes(25)
            },
            // Additional 20 medication stock logs
            new MedicationStockLogModel
            {
                LogID = "log-14",
                MedicationID = "med-aspirin-100",
                QuantityChange = 1500,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-2)
            },
            new MedicationStockLogModel
            {
                LogID = "log-15",
                MedicationID = "med-lisinopril-10",
                QuantityChange = 600,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-2)
            },
            new MedicationStockLogModel
            {
                LogID = "log-16",
                MedicationID = "metformin-500",
                QuantityChange = 1200,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-2)
            },
            new MedicationStockLogModel
            {
                LogID = "log-17",
                MedicationID = "med-simvastatin-20",
                QuantityChange = 900,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-2)
            },
            new MedicationStockLogModel
            {
                LogID = "log-18",
                MedicationID = "med-amlodipine-5",
                QuantityChange = 700,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-2)
            },
            new MedicationStockLogModel
            {
                LogID = "log-19",
                MedicationID = "med-prednisone-5",
                QuantityChange = 400,
                Reason = "Initial Stock Import",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddMonths(-2)
            },
            new MedicationStockLogModel
            {
                LogID = "log-20",
                MedicationID = "med-azithromycin-250",
                QuantityChange = -6,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-09",
                CreatedAt = DateTime.UtcNow.AddDays(-8).AddHours(16)
            },
            new MedicationStockLogModel
            {
                LogID = "log-21",
                MedicationID = "med-albuterol-syrup",
                QuantityChange = -120,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-09",
                CreatedAt = DateTime.UtcNow.AddDays(-8).AddHours(16)
            },
            new MedicationStockLogModel
            {
                LogID = "log-22",
                MedicationID = "med-aspirin-100",
                QuantityChange = -20,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-10",
                CreatedAt = DateTime.UtcNow.AddDays(-6).AddHours(12)
            },
            new MedicationStockLogModel
            {
                LogID = "log-23",
                MedicationID = "med-lisinopril-10",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-11",
                CreatedAt = DateTime.UtcNow.AddDays(-12).AddHours(10)
            },
            new MedicationStockLogModel
            {
                LogID = "log-24",
                MedicationID = "metformin-500",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-13",
                CreatedAt = DateTime.UtcNow.AddDays(-11).AddHours(17)
            },
            new MedicationStockLogModel
            {
                LogID = "log-25",
                MedicationID = "med-ondansetron-4",
                QuantityChange = -10,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-13",
                CreatedAt = DateTime.UtcNow.AddDays(-11).AddHours(17)
            },
            new MedicationStockLogModel
            {
                LogID = "log-26",
                MedicationID = "med-prednisone-5",
                QuantityChange = -20,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-14",
                CreatedAt = DateTime.UtcNow.AddDays(-15).AddHours(11)
            },
            new MedicationStockLogModel
            {
                LogID = "log-27",
                MedicationID = "med-fluoxetine-20",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-15",
                CreatedAt = DateTime.UtcNow.AddDays(-13).AddHours(14)
            },
            new MedicationStockLogModel
            {
                LogID = "log-28",
                MedicationID = "med-vit-c-500",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-15",
                CreatedAt = DateTime.UtcNow.AddDays(-13).AddHours(14)
            },
            new MedicationStockLogModel
            {
                LogID = "log-29",
                MedicationID = "med-levothyroxine-50",
                QuantityChange = -90,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-16",
                CreatedAt = DateTime.UtcNow.AddDays(-7).AddHours(9)
            },
            new MedicationStockLogModel
            {
                LogID = "log-30",
                MedicationID = "med-clonazepam-0-5",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-18",
                CreatedAt = DateTime.UtcNow.AddDays(-17).AddHours(16)
            },
            new MedicationStockLogModel
            {
                LogID = "log-31",
                MedicationID = "med-gabapentin-300",
                QuantityChange = -90,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-19",
                CreatedAt = DateTime.UtcNow.AddDays(-18).AddHours(11)
            },
            new MedicationStockLogModel
            {
                LogID = "log-32",
                MedicationID = "med-omep-20",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-20",
                CreatedAt = DateTime.UtcNow.AddDays(-19).AddHours(17)
            },
            new MedicationStockLogModel
            {
                LogID = "log-33",
                MedicationID = "med-losartan-50",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-23",
                CreatedAt = DateTime.UtcNow.AddDays(-22).AddHours(12)
            },
            new MedicationStockLogModel
            {
                LogID = "log-34",
                MedicationID = "metformin-500",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-24",
                CreatedAt = DateTime.UtcNow.AddDays(-23).AddHours(16)
            },
            new MedicationStockLogModel
            {
                LogID = "log-35",
                MedicationID = "med-amlodipine-5",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-25",
                CreatedAt = DateTime.UtcNow.AddDays(-24).AddHours(10)
            },
            new MedicationStockLogModel
            {
                LogID = "log-36",
                MedicationID = "med-duloxetine-30",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-26",
                CreatedAt = DateTime.UtcNow.AddDays(-25).AddHours(16)
            },
            new MedicationStockLogModel
            {
                LogID = "log-37",
                MedicationID = "med-warfarin-5",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-27",
                CreatedAt = DateTime.UtcNow.AddDays(-26).AddHours(12)
            },
            new MedicationStockLogModel
            {
                LogID = "log-38",
                MedicationID = "med-pregabalin-75",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-28",
                CreatedAt = DateTime.UtcNow.AddDays(-27).AddHours(15)
            },
            new MedicationStockLogModel
            {
                LogID = "log-39",
                MedicationID = "med-amox-500",
                QuantityChange = 500,
                Reason = "Restock Order",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddDays(-5)
            },
            new MedicationStockLogModel
            {
                LogID = "log-40",
                MedicationID = "med-ibu-400",
                QuantityChange = 300,
                Reason = "Restock Order",
                RelatedPrescriptionID = null!,
                CreatedAt = DateTime.UtcNow.AddDays(-3)
            },
            new MedicationStockLogModel
            {
                LogID = "log-41",
                MedicationID = "med-ferrous-sulfate-325",
                QuantityChange = -90,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-20",
                CreatedAt = DateTime.UtcNow.AddDays(-19).AddHours(17)
            },
            new MedicationStockLogModel
            {
                LogID = "log-42",
                MedicationID = "med-metoprolol-25",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-12",
                CreatedAt = DateTime.UtcNow.AddDays(-14).AddHours(13)
            },
            new MedicationStockLogModel
            {
                LogID = "log-43",
                MedicationID = "med-para-500",
                QuantityChange = -30,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-12",
                CreatedAt = DateTime.UtcNow.AddDays(-14).AddHours(13)
            },
            new MedicationStockLogModel
            {
                LogID = "log-44",
                MedicationID = "med-vancomycin-500",
                QuantityChange = -40,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-21",
                CreatedAt = DateTime.UtcNow.AddDays(-20).AddHours(14)
            },
            new MedicationStockLogModel
            {
                LogID = "log-45",
                MedicationID = "med-hydroxychloroquine-200",
                QuantityChange = -60,
                Reason = "Dispensed to Patient",
                RelatedPrescriptionID = "presc-22",
                CreatedAt = DateTime.UtcNow.AddDays(-21).AddHours(11)
            }
        );
    }
}
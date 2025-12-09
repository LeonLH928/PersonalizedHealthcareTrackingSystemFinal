using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using PersonalizedHealthcareTrackingSystemFinal.Configs;
using PersonalizedHealthcareTrackingSystemFinal.Data;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Repositories;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using Supabase;
using System.Security.Policy;

namespace PersonalizedHealthcareTrackingSystemFinal.DI;
public static class AppModule
{
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        // ----------- Dead code
        // Register Database
        //services.AddSingleton<DatabaseConfig>();

        // Register Data context
        //services.AddDbContext<DataContext>(options =>
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //                                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //                                            .AddUserSecrets<DataContextFactory>()
        //                                            .Build();

        //    string dbPassword = configuration["Supabase:DbPassword"] ?? throw new InvalidOperationException("Could not find 'Supabase:DbPassword' in User Secrets. Did you run 'dotnet user-secrets set...'?");

        //    var builder = new NpgsqlConnectionStringBuilder("User Id=postgres.acrsnysomjcvidbbadac;Server=aws-1-ap-south-1.pooler.supabase.com;Port=5432;Database=postgres");

        //    builder.Password = dbPassword;

        //    options.UseNpgsql(builder.ConnectionString);      
        //});
        // -----------

        // Register Client
        services.AddSingleton<Client>(provider =>
        {
           var SUPABASE_URL = "https://acrsnysomjcvidbbadac.supabase.co"; 
           var SUPABASE_KEY = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFjcnNueXNvbWpjdmlkYmJhZGFjIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjQxNzU1MDAsImV4cCI6MjA3OTc1MTUwMH0.8NL3tECh1ZMQBI_H7gFz0ecFqPFMrznTGk95oGO1Dg8";
           var options = new SupabaseOptions
           {
               AutoRefreshToken = false,
               AutoConnectRealtime = false
           };

            var client = new Supabase.Client(SUPABASE_URL, SUPABASE_KEY, options);

            return client;
        });

        // Register Views
        services.AddTransient<IntroductionWindow>();
        services.AddTransient<LoginWindow>();
        services.AddTransient<SignUpWindow>();

        services.AddTransient<Views.PatientView.PatientMainWindow>();
        services.AddTransient<Views.PatientView.PatientHomePage>();
        services.AddTransient<Views.PatientView.PatientBookingPage>();
        services.AddTransient<Views.PatientView.PatientSetting>();

        services.AddTransient<Views.DoctorView.DoctorMainWindow>();
        services.AddTransient<Views.DoctorView.DoctorDashboardPage>();
        services.AddTransient<Views.DoctorView.DoctorConsultationWindow>();
        services.AddTransient<Views.DoctorView.DoctorUpcomingsPage>();
        services.AddTransient<Views.DoctorView.AddDrugWindow>();

        services.AddTransient<Views.PharmacistView.PharmacistMainWindow>();
        services.AddTransient<Views.PharmacistView.PharmacistQueuePage>();
        services.AddTransient<Views.PharmacistView.PharmacistDashboard>();

        // Register ViewModels
        services.AddTransient<IntroductionWindowViewModel>();
        services.AddTransient<LoginWindowViewModel>();
        services.AddTransient<SignUpWindowViewModel>();

        services.AddTransient<ViewModels.DoctorViewModel.DoctorDashboardPageViewModel>();
        services.AddTransient<ViewModels.DoctorViewModel.DoctorConsultationWindowViewModel>();
        services.AddTransient<ViewModels.DoctorViewModel.AddDrugWindowViewModel>();
     
        services.AddTransient<ViewModels.PharmacistViewModel.PharmacistQueuePageViewModel>();

        // Register Repositories
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<ICurrentUserStoreRepository, CurrentUserStoreRepository>();
        services.AddScoped<IRoleRepository<SupabaseModels.PatientModel>, RoleRepository<SupabaseModels.PatientModel>>();
        services.AddScoped<IRoleRepository<SupabaseModels.DoctorModel>, RoleRepository<SupabaseModels.DoctorModel>>();
        services.AddScoped<IRoleRepository<SupabaseModels.PharmacistModel>, RoleRepository<SupabaseModels.PharmacistModel>>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IClinicalExaminationRepository, ClinicalExaminationRepository>();
        services.AddScoped<IMedicalRecordRepository, MedicalRecordRepository>();
        services.AddScoped<IMedicationRepository, MedicationRepository>();
        services.AddScoped<IMedicationInteractionRepository, MedicationInteractionRepository>();
        services.AddScoped<IMedicalRecordRepository, MedicalRecordRepository>();
        services.AddScoped<IPrescriptionItemRepository, PrescriptionItemRepository>();
        services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();

        // Register Services
        services.AddScoped<IAppointmentService, AppointmentService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPatientService, PatientService>();
        services.AddScoped<IClinicalExaminationService, ClinicalExaminationService>();
        services.AddScoped<IMedicalRecordService, MedicalRecordService>();
        services.AddScoped<IMedicationService, MedicationService>();
        services.AddScoped<IMedicationInteractionService, MedicationInteractionService>();
        services.AddScoped<IPrescriptionItemService, PrescriptionItemService>();
        services.AddScoped<IPrescriptionService, PrescriptionService>();
        services.AddScoped<IDoctorService, DoctorService>();
        services.AddScoped<ICurrentUserStoreService, CurrentUserStoreService>();

        return services;
    }
}
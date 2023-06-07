
using Ap2.Domain.Entities;
using Ap2.Data.Repository;
using Ap2.Data;
using Ap2.Menus;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{

    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<DataContext>() // Registro da dependência DataContext
            .AddTransient<MedicalAppoimentRepository>() // Registro da dependência MedicalAppoimentRepository
            .AddTransient<DoctorRepository>() // Registro da dependência DoctorRepository
            .AddTransient<PatientRepository>() // Registro da dependência PatientRepository
            .AddTransient<MenuDoctor>() // Registro da dependência MenuDoctor
            .AddTransient<MenuPatient>() // Registro da dependência MenuPatient
            .AddTransient<MenuMedicalAppoiment>() // Registro da dependência MenuMedicalAppoiment
            .AddTransient<IndexMenu>() // Registro da dependência IndexMenu
            .BuildServiceProvider();

        var menuIndex = serviceProvider.GetRequiredService<IndexMenu>();


        menuIndex.MenuIndex();


    }

}


// Doctor doctor = new Doctor(){Name = "Adalberto", CPF = "033033033-02", Phone = "51 989898989", CRM = "098767/RS", OccupationArea = "Cardiologia"};
// Doctor doctor02 = new Doctor(){Name = "João", CPF = "033033033-02", Phone = "51 989898989", CRM = "098767/RS", OccupationArea = "Clinico geral"};
// Doctor doctor03 = new Doctor(){Name = "João", CPF = "345345354543-02", Phone = "51 808080080", CRM = "453453/RS", OccupationArea = "Geriatra"};


// doctorRepository.Save(doctor);
// doctorRepository.Save(doctor02);
// doctorRepository.Save(doctor03);

// Patient patient = new Patient(){Name = "João", CPF = "345345354543-02", Phone = "51 808080080", Illness = "Cirrose"};
// Patient patient02 = new Patient(){Name = "Pedro", CPF = "345345354543-02", Phone = "51 2020202020", Illness = "Dor de cabeça"};


// patientRepository.Save(patient);
// patientRepository.Save(patient02);



// MedicalAppoiment medicalAppoimentTest = new MedicalAppoiment(){AppoimentDate = new DateTime(2023, 04, 06, 14, 30, 0), Doctor = doctor03, Patient = patient02};
// MedicalAppoiment medicalAppoimentTest02 = new MedicalAppoiment(){AppoimentDate = new DateTime(2023, 05, 12, 11, 30, 0), Doctor = doctor02, Patient = patient};
// medicalAppoimentRepository.Save(medicalAppoimentTest);
// medicalAppoimentRepository.Save(medicalAppoimentTest02);
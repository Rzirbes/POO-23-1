using Ap2.Data.Repository;
using Ap2.Data;
using Ap2.Menus;
using Ap2.Domain.Interfaces;
using Ap2WebApi.Models.Entities;

var builder = WebApplication.CreateBuilder(args);
var db = new DataContext();
var patientRepository = new PatientRepository(db);
// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register your dependencies
builder.Services.AddTransient<DataContext>(); // DataContext dependency registration
builder.Services.AddTransient<MedicalAppoimentRepository>(); // MedicalAppoimentRepository dependency registration
builder.Services.AddTransient<IAppoimentRepository, MedicalAppoimentRepository>();
builder.Services.AddTransient<DoctorRepository>(); // DoctorRepository dependency registration
builder.Services.AddTransient<IDoctorRepository, DoctorRepository>();
builder.Services.AddTransient<PatientRepository>();// PatientRepository dependency registration
builder.Services.AddTransient<IPatientRepository, PatientRepository>(); // IPatientRepository dependency registration
builder.Services.AddTransient<MenuDoctor>(); // MenuDoctor dependency registration
builder.Services.AddTransient<MenuPatient>(); // MenuPatient dependency registration
builder.Services.AddTransient<MenuMedicalAppoiment>(); // MenuMedicalAppoiment dependency registration
builder.Services.AddTransient<IndexMenu>(); // IndexMenu dependency registration

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

// Resolve the required services from the service provider.
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;

    // Continue with your application logic here...
    var menuIndex = serviceProvider.GetRequiredService<IndexMenu>();
    menuIndex.MenuIndex();
}

// Resto do código...





using AS_2.Data.Context;
using AS_2.Data.Repositories;
using AS_2.Data.Repositories.Interfaces;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesRepository;
using AS_2.Domain.Interfaces.InterfacesServices;
using AS_2.Service;
using AS_2.Service.Interfaces;
using AS_2.Service.Interfaces.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// Register services and repositories
builder.Services.AddScoped<DataContext>(); // DataContext

// Repositories
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBookLoanRepository, BookLoanRepository>();
// builder.Services.AddScoped<IBaseRepository<Loan>, LoanRepository>();
// builder.Services.AddScoped<IBaseRepository<Publisher>, PublisherRepository>();

// Services
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IUserService ,UserService>();
builder.Services.AddScoped<IBookLoanService ,BookLoanService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using AS.Data.Context;
using AS.Data.Repositories;
using AS.Data.Repostirories;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;
using AS.Service;
using AS.Services;
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
builder.Services.AddScoped<IBaseRepository<Author>, AuthorRepository>();
builder.Services.AddScoped<IBaseRepository<Book>, BookRepository>();
builder.Services.AddScoped<IBaseRepository<User>, UserRepository>();
builder.Services.AddScoped<IBaseRepository<Loan>, LoanRepository>();
builder.Services.AddScoped<IBaseRepository<Publisher>, PublisherRepository>();

// Services
builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<LoanService>();
builder.Services.AddScoped<ILoanService, LoanService>();
builder.Services.AddScoped<ILoanRepository, LoanRepository>();
builder.Services.AddScoped<PublisherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

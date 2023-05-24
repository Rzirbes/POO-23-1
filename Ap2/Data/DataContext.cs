using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ap2.Data
{

    public class DataContext : DbContext
    {
        public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "Ap2EfQuarta.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalAppoiment> MedicalAppoiments { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}

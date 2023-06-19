using aula_16_ef_test.Model.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aula12_ef_test.Model.Data
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = Path.Join(path, "TestEFQuarta.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testeORM.Domain.Entities;

namespace testeORM.Data.Context
{
    public class MeuContexto : DbContext
    {
        protected string DbPath { get; }

        public MeuContexto()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "testandoORM.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
            
    
        public DbSet<Person> Pessoas { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
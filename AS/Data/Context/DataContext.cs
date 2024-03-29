using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Data.Types;
using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace AS.Data.Context
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }
        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestEFQuarta.db");
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Author> DbSetAuthor { get; set; }
        public DbSet<Book> DbSetBook { get; set; }
        public DbSet<User> DbSetUser { get; set; }
        public DbSet<Loan> DbSetLoan { get; set; }
        public DbSet<Publisher> DbSetPublisher { get; set; }
        public DbSet<UserBook> DbSetUserBook { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PublisherMap());
        }
    }
}
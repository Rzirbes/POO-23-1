using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Data.Types;
using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AS.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Author> DbSetAuthor { get; set; }
        public DbSet<Book> DbSetBook { get; set; }
        public DbSet<User> DbSetUser { get; set; }
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
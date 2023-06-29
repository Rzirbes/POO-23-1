using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS.Data.Types
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");

            builder.Property(b => b.Title)
                .HasColumnName("title")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.PublicationYear)
                .HasColumnName("publication_year")
                .IsRequired();

            builder.Property(b => b.ISBN)
                .HasColumnName("isbn")
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(b => b.Price)
                .HasColumnName("price")
                .IsRequired();

            builder.HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId)
                .IsRequired();

            builder.HasMany(a => a.Authors)
                .WithMany(b => b.Books)
                .UsingEntity(j => j.ToTable("author_book"));
        }
    }
   }



using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS.Data.Types
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Nationality)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.DateOfBirth)
                .IsRequired();

            // Configurar relacionamento com a tabela Books
            builder.HasMany(a => a.Books)
                .WithMany(b => b.Authors)
                .UsingEntity(j => j.ToTable("AuthorBook"));
        }
    }
}

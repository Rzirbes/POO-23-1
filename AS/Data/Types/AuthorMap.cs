using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS.Data.Types
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("authors");

            builder.Property(a => a.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Nationality)
                .HasColumnName("nationality")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.DateOfBirth)
                .HasColumnName("date_of_birth")
                .IsRequired();

            // Configurar relacionamento com a tabela Books
        }   
    }
}

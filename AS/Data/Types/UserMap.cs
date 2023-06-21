using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS.Data.Types
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.RegistrationDate)
                .IsRequired();

            // Configurar relacionamento com a tabela Books
            builder
                .HasMany(u => u.BorrowedBooks)
                .WithMany()
                .UsingEntity<UserBook>(
                    j => j
                        .HasOne(ub => ub.Book)
                        .WithMany()
                        .HasForeignKey(ub => ub.BookId),
                    j => j
                        .HasOne(ub => ub.User)
                        .WithMany()
                        .HasForeignKey(ub => ub.UserId),
                    j =>
                    {
                        j.ToTable("UserBook");
                        j.HasKey(ub => new { ub.UserId, ub.BookId });
                    }
                );
        }
    }
}

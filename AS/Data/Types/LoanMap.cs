using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AS.Domain.Entities;

namespace AS.Data.Types
{
    public class LoanMap : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("loans");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder.Property(l => l.BookId)
                .HasColumnName("book_id")
                .IsRequired();

            builder.Property(l => l.LoanDate)
                .HasColumnName("loan_date")
                .IsRequired();

            // Configurar relacionamento com a tabela Users
            builder.HasOne(l => l.User)
                .WithMany(u => u.Loans)
                .HasForeignKey(l => l.UserId)
                .IsRequired();

            // Configurar relacionamento com a tabela Books
            builder.HasOne(l => l.Book)
                .WithMany()
                .HasForeignKey(l => l.BookId)
                .IsRequired();
        }
    }
}
namespace AS.Domain.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}

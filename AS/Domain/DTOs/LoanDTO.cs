namespace AS.Domain.DTOs
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }
        public UserDTO User { get; set; }
        public BookDTO Book { get; set; }
    }
}

namespace AS.Domain.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public ICollection<BookDTO> BorrowedBooks { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<LoanDTO> Loans { get; set; }
    }
}

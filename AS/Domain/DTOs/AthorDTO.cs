namespace AS.Domain.DTOs
{
    public class AuthorDTO
    {
        public string Name { get; set; }
        public ICollection<BookDTO> Books { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

namespace AS.Domain.DTOs
{
    public class PublisherDTO
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<BookDTO> Books { get; set; }
    }
}

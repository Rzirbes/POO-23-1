namespace AS.Domain.DTOs
{
    public class BookDTO
    {
        public string Title { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; }
        public PublisherDTO Publisher { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}

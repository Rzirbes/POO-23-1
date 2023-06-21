using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.Domain.Entities
{
    public class Book : Entity
    {
    public string Title { get; set; }
    public ICollection<Author> Authors { get; set; }
    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; } // Propriedade de referência à editora do livro
    public int PublicationYear { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }

    }
}
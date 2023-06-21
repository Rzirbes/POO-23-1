using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.Domain.Entities
{
    public class Publisher : Entity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Book> Books { get; set; } // Propriedade de navegação para os livros da editora/publisher
    }
}
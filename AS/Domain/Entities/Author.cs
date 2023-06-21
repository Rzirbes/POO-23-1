using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.Domain.Entities
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
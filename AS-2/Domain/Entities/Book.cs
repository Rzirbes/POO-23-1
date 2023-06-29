using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_2.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_2.Domain.Entities
{
    public class BookLoan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public decimal FineAmount { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
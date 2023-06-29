using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.ViewModels;

namespace AS_2.Domain.DTOs
{
    public class BookLoanDTO
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
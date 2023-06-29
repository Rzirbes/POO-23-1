using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_2.Domain.ViewModels
{
    public class BookLoanViewModel
    {
        public int Id { get; set; }
        // public BookViewModel Book { get; set; }
        public UserViewModel User { get; set; }
        public DateTime DueDate { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
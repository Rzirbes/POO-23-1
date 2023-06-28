using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public ICollection<Book> BorrowedBooks { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.Entities;

namespace AS_2.Service.Interfaces.InterfacesRepository
{
    public interface IBookLoanService
    {
        Task<BookLoan> GetById(int id);
        Task<IEnumerable<BookLoan>> GetAll();
        Task<BookLoan> CreateBookLoan(BookLoan bookLoan);
        Task UpdateBookLoan(BookLoan bookLoan);
        Task DeleteBookLoan(int id);
    }
}
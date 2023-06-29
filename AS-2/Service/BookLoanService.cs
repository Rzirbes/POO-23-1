using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Data.Repositories.Interfaces;
using AS_2.Domain.Entities;
using AS_2.Service.Interfaces.InterfacesRepository;

namespace AS_2.Service
{
    public class BookLoanService : IBookLoanService
    {
        private readonly IBookLoanRepository _bookLoanRepository;

        public BookLoanService(IBookLoanRepository bookLoanRepository)
        {
            _bookLoanRepository = bookLoanRepository;
        }

        public async Task<BookLoan> GetById(int id)
        {
            return await _bookLoanRepository.GetById(id);
        }

        public async Task<IEnumerable<BookLoan>> GetAll()
        {
            return await _bookLoanRepository.GetAll();
        }

        public async Task<BookLoan> CreateBookLoan(BookLoan bookLoan)
        {
            await _bookLoanRepository.Create(bookLoan);
            return bookLoan;
        }

        public async Task UpdateBookLoan(BookLoan bookLoan)
        {
            await _bookLoanRepository.Update(bookLoan);
        }

        public async Task DeleteBookLoan(int id)
        {
            var bookLoan = await _bookLoanRepository.GetById(id);
            if (bookLoan != null)
            {
                await _bookLoanRepository.Delete(bookLoan);
            }
        }
    }
}
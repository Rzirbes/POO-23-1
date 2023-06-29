using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Data.Context;
using AS_2.Data.Repositories.Interfaces;
using AS_2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AS_2.Data.Repositories
{
    public class BookLoanRepository : IBookLoanRepository
    {
        private readonly DataContext _context;

        public BookLoanRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<BookLoan> GetById(int id)
        {
            return await _context.Set<BookLoan>().FindAsync(id);
        }

        public async Task<IEnumerable<BookLoan>> GetAll()
        {
            return await _context.Set<BookLoan>().ToListAsync();
        }

        public async Task Create(BookLoan bookLoan)
        {
            _context.Set<BookLoan>().Add(bookLoan);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BookLoan bookLoan)
        {
            _context.Entry(bookLoan).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(BookLoan bookLoan)
        {
            if (bookLoan != null)
            {
                _context.Set<BookLoan>().Remove(bookLoan);
                await _context.SaveChangesAsync();
            }
        }

    }
}
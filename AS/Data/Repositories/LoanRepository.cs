using AS.Data.Context;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AS.Data.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly DataContext _context;

        public LoanRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Loan> GetByIdAsync(int id)
        {
            return await _context.Set<Loan>().FindAsync(id);
        }

        public async Task<List<Loan>> GetAllAsync()
        {
            return await _context.Set<Loan>().ToListAsync();
        }

        public async Task AddAsync(Loan loan)
        {
            await _context.Set<Loan>().AddAsync(loan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Loan loan)
        {
            _context.Set<Loan>().Update(loan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var loan = await _context.Set<Loan>().FindAsync(id);
            _context.Set<Loan>().Remove(loan);
            await _context.SaveChangesAsync();
        }

        public async Task<Loan> GetLoanByUserAndBook(int userId, int bookId)
        {
            return await _context.Set<Loan>()
                .FirstOrDefaultAsync(loan => loan.UserId == userId && loan.BookId == bookId);
        }
    }
}

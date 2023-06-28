using AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AS.Domain.Interfaces.RepositoryInterfaces
{
    public interface ILoanRepository : IBaseRepository<Loan>
    {
        Task<Loan> GetLoanByUserAndBook(int userId, int bookId);
    }
}

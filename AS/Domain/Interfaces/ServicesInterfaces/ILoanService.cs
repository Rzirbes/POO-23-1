using AS.Domain.Entities;
using System.Threading.Tasks;

namespace AS.Services
{
    public interface ILoanService
    {
        Task LoanBook(int userId, int bookId);
        Task<List<Loan>> GetAllAsync();
    }
}
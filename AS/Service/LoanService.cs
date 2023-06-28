using System;
using System.Threading.Tasks;
using AS.Data.Repostirories;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;

namespace AS.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Book> _bookRepository;

        public LoanService(ILoanRepository loanRepository, IBaseRepository<User> userRepository, IBaseRepository<Book> bookRepository)
        {
            _loanRepository = loanRepository;
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

        public async Task LoanBook(int userId, int bookId, DateTime loanDate)
        {
            // Verificar se o usuário existe
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new Exception("Usuário não encontrado.");
            }

            // Verificar se o livro existe
            var book = await _bookRepository.GetByIdAsync(bookId);
            if (book == null)
            {
                throw new Exception("Livro não encontrado.");
            }

            // Verificar se o livro já está emprestado
            var existingLoan = await _loanRepository.GetLoanByUserAndBook(userId, bookId);
            if (existingLoan != null)
            {
                throw new Exception("Este livro já foi emprestado para este usuário.");
            }

            var loan = new Loan
            {
                UserId = userId,
                BookId = bookId,
                LoanDate = loanDate
            };

            await _loanRepository.AddAsync(loan);
        }
        public async Task<List<Loan>> GetAllAsync()
        {
            return await _loanRepository.GetAllAsync();
        }
    }
}

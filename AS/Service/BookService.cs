using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;

namespace AS.Service
{
    public class BookService
    {
        private readonly IBaseRepository<Book> _bookRepository;

        public BookService(IBaseRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _bookRepository.GetByIdAsync(id);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _bookRepository.AddAsync(book);
        }

        public async Task UpdateAsync(Book book)
        {
            await _bookRepository.UpdateAsync(book);
        }

        public async Task DeleteAsync(int id)
        {
            await _bookRepository.DeleteAsync(id);
        }
    }
}

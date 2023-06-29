using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesRepository;
using AS_2.Domain.Interfaces.InterfacesServices;

namespace AS_2.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _bookRepository.GetById(id);
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAll();
        }

        public async Task<Book> CreateBook(Book book)
        {
            await _bookRepository.Create(book);
            return book;
        }

        public async Task UpdateBook(Book book)
        {
            await _bookRepository.Update(book);
        }

        public async Task DeleteBook(Book book)
        {
            await _bookRepository.Delete(book);
        }
    }
}
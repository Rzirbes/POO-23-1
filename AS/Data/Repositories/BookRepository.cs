using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Data.Context;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace AS.Data.Repostirories
{
    public class BookRepository : IBaseRepository<Book>
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Set<Book>().FindAsync(id);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Set<Book>().ToListAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _context.Set<Book>().AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _context.Set<Book>().Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await _context.Set<Book>().FindAsync(id);
            _context.Set<Book>().Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
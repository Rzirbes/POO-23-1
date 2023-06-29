using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Data.Context;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

namespace AS_2.Data.Repositories
{
    public class BookRepository : IBookRepository
{
    private readonly DataContext _context;

    public BookRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Book> GetById(int id)
    {
        return await _context.Set<Book>().FindAsync(id);
    }

    public async Task<IEnumerable<Book>> GetAll()
    {
        return await _context.Set<Book>().ToListAsync();
    }

    public async Task Create(Book book)
    {
        _context.Set<Book>().Add(book);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Book book)
    {
        _context.Set<Book>().Update(book);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Book book)
    {
        if (book != null)
        {
            _context.Set<Book>().Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
}
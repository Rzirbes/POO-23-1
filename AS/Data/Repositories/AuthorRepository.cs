using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace AS.Data.Repostirories
{
    public class AuthorRepository : IBaseRepository<Author>
    {
    private readonly DbContext _context;

    public AuthorRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<Author> GetByIdAsync(int id)
    {
        return await _context.Set<Author>().FindAsync(id);
    }

    public async Task<List<Author>> GetAllAsync()
    {
        return await _context.Set<Author>().ToListAsync();
    }

    public async Task AddAsync(Author author)
    {
        await _context.Set<Author>().AddAsync(author);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Author author)
    {
        _context.Set<Author>().Update(author);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var author = await _context.Set<Author>().FindAsync(id);
        _context.Set<Author>().Remove(author);
        await _context.SaveChangesAsync();
    }
    }
}
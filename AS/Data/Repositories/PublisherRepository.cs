using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace AS.Data.Repostirories
{
    public class PublisherRepository : IBaseRepository<Publisher>
    {
        private readonly DbContext _context;

    public PublisherRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<Publisher> GetByIdAsync(int id)
    {
        return await _context.Set<Publisher>().FindAsync(id);
    }

    public async Task<List<Publisher>> GetAllAsync()
    {
        return await _context.Set<Publisher>().ToListAsync();
    }

    public async Task AddAsync(Publisher publisher)
    {
        await _context.Set<Publisher>().AddAsync(publisher);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Publisher publisher)
    {
        _context.Set<Publisher>().Update(publisher);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var publisher = await _context.Set<Publisher>().FindAsync(id);
        _context.Set<Publisher>().Remove(publisher);
        await _context.SaveChangesAsync();
    }
    }
}
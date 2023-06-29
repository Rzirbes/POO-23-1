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
    public class AuthorRepository : IAuthorRepository
{
    private readonly DataContext _context;

    public AuthorRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Author> GetById(int id)
    {
        return await _context.Set<Author>().FindAsync(id);
    }

    public async Task<IEnumerable<Author>> GetAll()
    {
        return await _context.Set<Author>().ToListAsync();
    }

    public async Task Create(Author author)
    {
        _context.Set<Author>().Add(author);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Author author)
    {
        _context.Set<Author>().Update(author);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Author author)
    {
        if (author != null)
        {
            _context.Set<Author>().Remove(author);
            await _context.SaveChangesAsync();
        }
    }


    }
}
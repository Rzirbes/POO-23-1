using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Domain.Interfaces.RepositoryInterfaces;

namespace AS.Services
{
    public class AuthorService
    {
        private readonly IBaseRepository<Author> _authorRepository;

        public AuthorService(IBaseRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await _authorRepository.GetByIdAsync(id);
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            return await _authorRepository.GetAllAsync();
        }

        public async Task CreateAuthorAsync(Author author)
        {
            await _authorRepository.AddAsync(author);
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            await _authorRepository.UpdateAsync(author);
        }

        public async Task DeleteAuthorAsync(int id)
        {
            await _authorRepository.DeleteAsync(id);
        }
    }
}

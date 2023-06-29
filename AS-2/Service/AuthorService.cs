using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesRepository;
using AS_2.Domain.Interfaces.InterfacesServices;

namespace AS_2.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _authorRepository.GetById(id);
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _authorRepository.GetAll();
        }

        public async Task<Author> CreateAuthor(Author author)
        {
           await _authorRepository.Create(author);
            return author;
        }

        public async Task UpdateAuthor(Author author)
        {
            await _authorRepository.Update(author);
        }

        public async Task DeleteAuthor(Author author)
        {
            await _authorRepository.Delete(author);
        }

    }
}
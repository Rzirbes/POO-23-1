using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.Entities;

namespace AS_2.Domain.Interfaces.InterfacesServices
{
    public interface IAuthorService
    {
         Task<Author> GetAuthorById(int id);
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> CreateAuthor(Author author);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(Author author);  
    }
}
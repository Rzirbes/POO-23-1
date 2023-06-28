using AS.Domain.DTOs;
using AS.Domain.Entities;
using AS.Service;
using AS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AS.Domain.Interfaces.ServicesInterfaces
{
    public interface IBookService
    {
        Task<IList<BookDTO>> GetAllAsync();

        Task<BookDTO> GetByIdAsync(int id);

        Task<BookDTO> AddAsync(BookDTO bookDTO);

        Task<IActionResult> UpdateAsync(int id, BookDTO bookDTO);

        Task<IActionResult> DeleteAsync(int id);
    }
}

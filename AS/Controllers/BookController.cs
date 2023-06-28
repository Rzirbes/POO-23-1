using System.Collections.Generic;
using System.Threading.Tasks;
using AS.Domain.DTOs;
using AS.Domain.Entities;
using AS.Domain.Interfaces.ServicesInterfaces;
using AS.Domain.ViewModels;
using AS.Service;
using AS.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly AuthorService _authorService;
        private readonly IMapper _mapper;

        public BooksController(BookService bookService, AuthorService authorService, IMapper mapper)
        {
            _bookService = bookService;
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllAsync();
            var bookDTOs = _mapper.Map<List<BookDTO>>(books);
            return Ok(bookDTOs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookService.GetByIdAsync(id);

            if (book == null)
                return NotFound();

            var bookDTO = _mapper.Map<BookDTO>(book);
            return Ok(bookDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados incorretos");

            var book = _mapper.Map<Book>(bookViewModel);

            if (book.Authors != null && book.Authors.Any())
            {
                foreach (var author in book.Authors)
                {
                    var existingAuthor = await _authorService.GetAuthorByIdAsync(author.Id);
                    if (existingAuthor != null)
                    {
                        // Adicione o autor existente ao livro
                        book.Authors.Add(existingAuthor);
                    }
                }
            }

            await _bookService.AddAsync(book);
            var createdBookDTO = _mapper.Map<BookDTO>(book);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, createdBookDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados incorretos");

            var book = _mapper.Map<Book>(bookViewModel);
            await _bookService.UpdateAsync(book);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookService.DeleteAsync(id);
            return NoContent();
        }

        private IActionResult HttpMessageError(string message = "")
        {
            return BadRequest(new
            {
                message
            });
        }
    }
}

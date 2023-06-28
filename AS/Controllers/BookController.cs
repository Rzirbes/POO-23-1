using System.Collections.Generic;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Service;
using AS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly AuthorService _authorService;

        public BooksController(BookService bookService, AuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = await _bookService.GetAllAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _bookService.GetByIdAsync(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
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
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            if (id != book.Id)
                return BadRequest();

            await _bookService.UpdateAsync(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookService.DeleteAsync(id);
            return NoContent();
        }
    }
}

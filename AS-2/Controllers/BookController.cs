using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.DTOs;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesServices;
using AS_2.Domain.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS_2.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IMapper _imapper;
        public BookController(IBookService bookService, IMapper imapper, IAuthorService authorService)
        {
            _bookService = bookService;
            _imapper = imapper;
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetAllBooks()
        {
            var books = await _bookService.GetAllBooks();
            var bookDTOs = _imapper.Map<List<BookDTO>>(books);
            return Ok(bookDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDTO>> GetBookById(int id)
        {
            var book = await _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            var bookDTO = _imapper.Map<BookDTO>(book);
            return Ok(bookDTO);
        }

        [HttpPost]
        public async Task<ActionResult<BookViewModel>> AddBook(BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados incorretos");

            var book = _imapper.Map<Book>(bookViewModel);

            // Verifique se os autores já existem no banco de dados
            var existingAuthors = new List<Author>();
            foreach (var authorViewModel in bookViewModel.Authors)
            {
                var existingAuthor = await _authorService.GetAuthorById(authorViewModel.Id);
                if (existingAuthor != null)
                    existingAuthors.Add(existingAuthor);
            }

            Book newBookBook = new Book
            {
                Title = book.Title,
            };

            // Atribua os autores existentes ao livro
            newBookBook.Authors = existingAuthors;

            var newBook = await _bookService.CreateBook(newBookBook);
            var newBookViewModel = _imapper.Map<BookViewModel>(newBookBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBookViewModel.Id }, newBookViewModel);
        }   

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, BookViewModel bookViewModel)
        {
            if (id != bookViewModel.Id)
            {
                return BadRequest();
            }
            var book = _imapper.Map<Book>(bookViewModel);
            await _bookService.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            await _bookService.DeleteBook(book);
            return NoContent();
        }
    }
}
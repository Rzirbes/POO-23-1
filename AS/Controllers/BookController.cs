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
using Microsoft.EntityFrameworkCore;

namespace AS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly AuthorService _authorService;
        private readonly PublisherService _publisherService;
        private readonly IMapper _mapper;

        public BooksController(BookService bookService, AuthorService authorService, PublisherService publisherService, IMapper mapper)
        {
            _bookService = bookService;
            _authorService = authorService;
            _publisherService = publisherService;
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
        public async Task<IActionResult> AddBook([FromBody] BookViewModel bookRequest)
        {
            try
            {
                // Verifica se a publisher existe no banco de dados
                Publisher publisher = await _publisherService.GetPublisherByIdAsync(bookRequest.PublisherId);
                if (publisher == null)
                {
                    return BadRequest("Publisher not found.");
                }

                // Restante do código

                // Cria um novo objeto Book a partir dos dados recebidos
                Book book = new Book
                {
                    Title = bookRequest.Title,
                    PublicationYear = bookRequest.PublicationYear,
                    ISBN = bookRequest.ISBN,
                    Price = bookRequest.Price,
                    PublisherId = publisher.Id,
                    Publisher = publisher // Associa a editora ao livro
                };

                // Restante do código

                // Chama o serviço para adicionar o livro ao banco de dados
                await _bookService.AddAsync(book);

                // Restante do código

                return Ok("Book added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
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

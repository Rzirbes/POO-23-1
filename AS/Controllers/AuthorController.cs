using System.Threading.Tasks;
using AS.Domain.DTOs;
using AS.Domain.Entities;
using AS.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(AuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            var authorDTOs = _mapper.Map<List<AuthorDTO>>(authors);
            return Ok(authorDTOs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);

            if (author == null)
                return NotFound();

            var authorDTO = _mapper.Map<AuthorDTO>(author);
            return Ok(authorDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");
            var author = _mapper.Map<Author>(authorDTO);
            await _authorService.CreateAuthorAsync(author);
            var createdAuthorDTO = _mapper.Map<AuthorDTO>(author);
            return CreatedAtAction(nameof(GetAuthorById), new { id = author.Id }, createdAuthorDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(int id, [FromBody] AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var author = _mapper.Map<Author>(authorDTO);
            await _authorService.UpdateAuthorAsync(author);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
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

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
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorDTO>>> GetAllAuthors()
        {
            var authors = await _authorService.GetAllAuthors();
            var authorDTOs = _mapper.Map<List<AuthorDTO>>(authors);
            return Ok(authorDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorDTO>> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            var authorDTO = _mapper.Map<AuthorDTO>(author);
            return Ok(authorDTO);
        }

        [HttpPost]
        public async Task<ActionResult<AuthorViewModel>> AddAuthor(AuthorViewModel authorViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados incorretos");
            var author = _mapper.Map<Author>(authorViewModel);
            var newAuthor = await _authorService.CreateAuthor(author);
            var newAuthorViewModel = _mapper.Map<AuthorViewModel>(newAuthor);
            return CreatedAtAction(nameof(GetAuthorById), new { id = newAuthorViewModel.Id }, newAuthorViewModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(int id, AuthorViewModel authorViewModel)
        {
            if (id != authorViewModel.Id)
            {
                return BadRequest();
            }
            var author = _mapper.Map<Author>(authorViewModel);
            await _authorService.UpdateAuthor(author);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var author = await _authorService.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            await _authorService.DeleteAuthor(author);
            return NoContent();
        }
    }
}
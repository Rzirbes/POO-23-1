using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesServices;
using AS_2.Domain.ViewModels;
using AS_2.Service.Interfaces;
using AS_2.Service.Interfaces.InterfacesRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS_2.Controllers
{
    namespace AS_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookLoanController : ControllerBase
    {
        private readonly IBookLoanService _bookLoanService;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public BookLoanController(IBookLoanService bookLoanService, IMapper mapper, IUserService userService, IBookService bookService)
        {
            _bookLoanService = bookLoanService;
            _mapper = mapper;
            _userService = userService;
            _bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookLoanViewModel>> Get(int id)
        {
            var bookLoan = await _bookLoanService.GetById(id);
            if (bookLoan == null)
            {
                return NotFound();
            }
            var bookLoanViewModel = _mapper.Map<BookLoanViewModel>(bookLoan);
            return bookLoanViewModel;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookLoanViewModel>>> GetAll()
        {
            var bookLoans = await _bookLoanService.GetAll();
            var bookLoanViewModels = _mapper.Map<IEnumerable<BookLoanViewModel>>(bookLoans);
            return Ok(bookLoanViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookLoanViewModel bookLoanViewModel)
        {

            if (!ModelState.IsValid)
                return BadRequest("Dados incorretos");
            var bookLoan = _mapper.Map<BookLoan>(bookLoanViewModel);

            var existingUser = _userService.GetUserById(bookLoanViewModel.User.Id);

            var existingBooks = new List<Book>();
            foreach (var item in bookLoanViewModel.Books)
            {//linha 66
                var existingBook = await _bookService.GetBookById(item.Id);
                if(existingBook != null)
                    existingBooks.Add(existingBook);
            }

            BookLoan newBookLoan = new BookLoan
            {
                UserId = bookLoanViewModel.Id,
                StartDate = bookLoanViewModel.DueDate,
                IsReturned = false,
            };

            newBookLoan.Books = existingBooks;
            newBookLoan.UserId = existingUser.Id;
            var newBook = await _bookLoanService.CreateBookLoan(newBookLoan);
            var newBookLoanViewModel = _mapper.Map<BookLoanViewModel>(newBookLoan);
            return CreatedAtAction("Get", new { id = newBookLoanViewModel.Id }, newBookLoanViewModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BookLoanViewModel bookLoanUpdateViewModel)
        {
            if (id != bookLoanUpdateViewModel.Id)
            {
                return BadRequest();
            }

            try
            {
                var bookLoan = _mapper.Map<BookLoan>(bookLoanUpdateViewModel);
                await _bookLoanService.UpdateBookLoan(bookLoan);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _bookLoanService.DeleteBookLoan(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
}
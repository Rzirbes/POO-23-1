using AS.Domain.DTOs;
using AS.Domain.Entities;
using AS.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoansController : ControllerBase
    {
        private readonly ILoanService _loanService;
        private readonly IMapper _mapper;

        public LoansController(ILoanService loanService, IMapper mapper)
        {
            _loanService = loanService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> LoanBook(int userId, int bookId)
        {
            try
            {
                await _loanService.LoanBook(userId, bookId);
                return Ok("Book loaned successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLoans()
        {
            try
            {
                var loans = await _loanService.GetAllAsync();
                var loanDTOs = _mapper.Map<List<LoanDTO>>(loans);
                return Ok(loanDTOs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetLoanById(int id)
        //{
        //    try
        //    {
        //        var loan = await _loanService.GetLoanById(id);
        //        if (loan == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(loan);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateLoan(int id, Loan loan)
        //{
        //    try
        //    {
        //        if (id != loan.Id)
        //        {
        //            return BadRequest("Loan ID mismatch.");
        //        }

        //        await _loanService.UpdateLoan(loan);
        //        return Ok("Loan updated successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLoan(int id)
        //{
        //    try
        //    {
        //        await _loanService.DeleteLoan(id);
        //        return Ok("Loan deleted successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}

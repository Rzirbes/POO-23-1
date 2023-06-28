using System.Collections.Generic;
using System.Threading.Tasks;
using AS.Domain.DTOs;
using AS.Domain.Entities;
using AS.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly PublisherService _publisherService;
        private readonly IMapper _mapper;

        public PublisherController(PublisherService publisherService, IMapper mapper)
        {
            _publisherService = publisherService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPublishers()
        {
            var publishers = await _publisherService.GetAllPublishersAsync();
            var publisherDTOs = _mapper.Map<List<PublisherDTO>>(publishers);
            return Ok(publisherDTOs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPublisherById(int id)
        {
            var publisher = await _publisherService.GetPublisherByIdAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            var publisherDTO = _mapper.Map<PublisherDTO>(publisher);
            return Ok(publisherDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePublisher([FromBody] PublisherDTO publisherDTO)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");
            var publisher = _mapper.Map<Publisher>(publisherDTO);
            await _publisherService.CreatePublisherAsync(publisher);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePublisher(int id, [FromBody] PublisherDTO publisherDTO)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var publisher = _mapper.Map<Publisher>(publisherDTO);
            await _publisherService.UpdatePublisherAsync(publisher);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePublisher(int id)
        {
            await _publisherService.DeletePublisherAsync(id);
            return Ok();
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

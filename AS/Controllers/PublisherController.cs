using System.Collections.Generic;
using System.Threading.Tasks;
using AS.Domain.Entities;
using AS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AS.Controllers
{
    [ApiController]
    [Route("api/publishers")]
    public class PublisherController : ControllerBase
    {
        private readonly PublisherService _publisherService;

        public PublisherController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Publisher>>> GetAllPublishers()
        {
            var publishers = await _publisherService.GetAllPublishersAsync();
            return Ok(publishers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetPublisherById(int id)
        {
            var publisher = await _publisherService.GetPublisherByIdAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return Ok(publisher);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePublisher([FromBody] Publisher publisher)
        {
            await _publisherService.CreatePublisherAsync(publisher);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePublisher(int id, [FromBody] Publisher publisher)
        {
            if (id != publisher.Id)
            {
                return BadRequest();
            }

            await _publisherService.UpdatePublisherAsync(publisher);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePublisher(int id)
        {
            await _publisherService.DeletePublisherAsync(id);
            return Ok();
        }
    }
}

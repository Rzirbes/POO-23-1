using Ap2.Data.Repository;
using Ap2.Domain.Interfaces;
using Ap2WebApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ap2WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class MedicalAppoimentController : ControllerBase
{
    private IAppoimentRepository _appoimentRepository;

    public MedicalAppoimentController(IAppoimentRepository appoimentRepository)
    {
        _appoimentRepository = appoimentRepository;
    }


    [HttpPost]
    public IActionResult AddDoctor([FromBody] MedicalAppoiment medicalAppoiment)
    {
        _appoimentRepository.Save(medicalAppoiment);
        return CreatedAtAction(nameof(GetById), new { id = medicalAppoiment.Id }, medicalAppoiment);
    }

    [HttpGet]
    public IEnumerable<MedicalAppoiment> GetAll()
    {
        return _appoimentRepository.GetAll();
    }

    [HttpGet("{id}")]
    public IActionResult? GetById(int id)
    {
        var medicalAppoiment = _appoimentRepository.GetById(id);
        if (medicalAppoiment == null) return NotFound();
        return Ok(medicalAppoiment);

    }

    [HttpPut("{id}")]
    public IActionResult UpdateAppoiment(int id, [FromBody] MedicalAppoiment medicalAppoimentUpdate)
    {
        var medicalAppoimentOld = _appoimentRepository.GetById(id);
        if (medicalAppoimentOld == null) return NotFound();
        _appoimentRepository.Update(id, medicalAppoimentUpdate);
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult DeleteFilme(int id)
    {
        var filme = _appoimentRepository.GetById(id);
        if (filme == null) return NotFound();
        _appoimentRepository.Delete(filme);
        return NoContent();
    }
}

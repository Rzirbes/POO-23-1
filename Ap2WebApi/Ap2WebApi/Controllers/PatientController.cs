
using Ap2.Data.Repository;
using Ap2.Domain.Interfaces;
using Ap2WebApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ap2WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class PatientController : ControllerBase
{
    private IPatientRepository _patientRepository;

    public PatientController(IPatientRepository patientRepository)
    { 
        _patientRepository = patientRepository; 
    }


    [HttpPost]
    public IActionResult AddPatient([FromBody] Patient patient)
    {
        _patientRepository.Save(patient);
        return CreatedAtAction(nameof(GetById), new {id = patient.Id}, patient);
    }

    [HttpGet]
    public IEnumerable<Patient> GetAll()
    {
        return _patientRepository.GetAll();
    }

    [HttpGet("{id}")]
    public IActionResult? GetById(int id)
    {
        var patient = _patientRepository.GetById(id);
        if (patient == null) return NotFound();
        return Ok(patient);

    }

    [HttpPut("{id}")]
    public IActionResult UpdatePatient(int id, [FromBody] Patient patientUpdate)
    {
        var patientOld = _patientRepository.GetById(id);
        if (patientOld == null) return NotFound();
        _patientRepository.Update(id, patientUpdate);
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult DeletePatient(int id)
    {
        var filme = _patientRepository.GetById(id);
        if (filme == null) return NotFound();
        _patientRepository.Delete(filme);
        return NoContent();
    }
}

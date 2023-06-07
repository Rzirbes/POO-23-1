using Ap2.Domain.Interfaces;
using Ap2WebApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Ap2WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private IDoctorRepository _doctorRepository;

    public DoctorController(IDoctorRepository patientRepository)
    {
        _doctorRepository = patientRepository;
    }


    [HttpPost]
    public IActionResult AddPatient([FromBody] Doctor doctor)
    {
        _doctorRepository.Save(doctor);
        return CreatedAtAction(nameof(GetById), new { id = doctor.Id }, doctor);
    }

    [HttpGet]
    public IEnumerable<Doctor> GetAll()
    {
        return _doctorRepository.GetAll();
    }

    [HttpGet("{id}")]
    public IActionResult? GetById(int id)
    {
        var doctor = _doctorRepository.GetById(id);
        if (doctor == null) return NotFound();
        return Ok(doctor);

    }

    [HttpPut("{id}")]
    public IActionResult UpdateDoctor(int id, [FromBody] Doctor doctor)
    {
        var filme = _doctorRepository.GetById(id);
        if (filme == null) return NotFound();
        _doctorRepository.Update(id, doctor);
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult DeleteDoctor(int id)
    {
        var doctor = _doctorRepository.GetById(id);
        if (doctor == null) return NotFound();
        _doctorRepository.Delete(doctor);
        return NoContent();
    }
}

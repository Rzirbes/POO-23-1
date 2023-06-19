using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_11_inicio.Data.Repositories;
using aula_11_inicio.Domain.Entities;
using aula_11_inicio.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula_16.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private  IPersonRepository _personRepository;
    public PersonController()
    {
        _personRepository = new PersonRespository();
    }

    [HttpGet]
    public IEnumerable<Person> Get()
    {
        return _personRepository.GetAll();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Person item)
    {
        _personRepository.Save(item);
        return Ok(new {
                statusCode = 200,
                message = "Cadastrado com sucesso.",
                item
            }
        );
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var person = _personRepository.GetById(id);
        if (person == null) return NotFound();
        return Ok(new {
                statusCode = 200,
                message = "Cliente encontrado com sucesso.",
                person
            }
        );
    }

    [HttpPut]
    public IActionResult Update([FromBody] Person item)
    {
        _personRepository.Update(item);
        return Ok(new {
                statusCode = 200,
                message = "Person Atualizado com sucesso.",
                item
            }
        );
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var person = _personRepository.GetById(id);
        if (person == null) return NotFound();
        _personRepository.Delete(id);
        var response = new {
                statusCode = 200,
                message = "Cliente deletado com sucesso.",
            };
        return Ok(response);
    }
}
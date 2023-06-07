using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace aula_16_crud_people_web_api.Controllers;
[ApiController]
[Route("[controller]")]

public class PersonController : ControllerBase
{

    private IPersonRepository _personRepository;

    public PersonController(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    [HttpGet]
    public IList<Person> Get()
    {
        return _personRepository.GetAll();
    }
}
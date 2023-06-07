using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aula_16_crud_people_web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController
{
    [HttpGet]
    public string Get()
    {
        return "Tá funcioando";
    }
}
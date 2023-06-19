using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_16_ef_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    internal class PersonController : ControllerBase
    {
        [HttpGet]
        public string Get() 
        {
            return "Tá Funcionado";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_16_ef_test.Model.Domain.Entities;

namespace aula_16_ef_test.Model.Domain.Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person>
    {

    }
}
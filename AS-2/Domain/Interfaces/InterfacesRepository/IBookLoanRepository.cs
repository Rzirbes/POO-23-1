using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.Entities;
using AS_2.Domain.Interfaces.InterfacesRepository;

namespace AS_2.Data.Repositories.Interfaces
{
    public interface IBookLoanRepository : IBaseRepository<BookLoan>
    {
    }
}
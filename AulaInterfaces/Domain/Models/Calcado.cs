using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaInterfaces.Interface;

namespace AulaInterfaces.Domain.Models
{
    public class Calcado : IItemEstoque
    {
        void IItemEstoque.Devolver()
        {
            throw new NotImplementedException();
        }

        void IItemEstoque.Vender()
        {
            throw new NotImplementedException();
        }
    }
}
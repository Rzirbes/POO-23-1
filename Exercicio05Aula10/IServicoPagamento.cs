using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05Aula10
{
    public interface IServicoPagamento
    {
        public void EfetuarPagamento();
        public void EstornarPagamento();

    }
}
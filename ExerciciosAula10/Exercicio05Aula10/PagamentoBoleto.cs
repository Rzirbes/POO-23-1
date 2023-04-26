using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05Aula10
{
    public class PagamentoBoleto : IServicoPagamento
    {
        public void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento com boleto");
        }

        public void EstornarPagamento()
        {
            Console.WriteLine("Pagamento estornado com boleto");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05Aula10
{
    public class PagamentoPaypal : IServicoPagamento
    {
        public void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento com Paypal");
        }

        public void EstornarPagamento()
        {
            Console.WriteLine("Pagamento estornado com Paypal");
        }
    }
}
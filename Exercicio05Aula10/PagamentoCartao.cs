using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05Aula10
{
    public class PagamentoCartao : IServicoPagamento
    {
        public void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento com Cartao");
        }

        public void EstornarPagamento()
        {
            Console.WriteLine("Pagamento estornado com Cartao");
        }
    }
}
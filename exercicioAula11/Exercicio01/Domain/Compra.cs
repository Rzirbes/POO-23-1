using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio01.Interface;

namespace Exercicio1.Domain
{
    public class Compra
    {
        

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public IServicoPagamento ServicoPagamentos { get; set; }

        public Compra(int id, Cliente cliente, IServicoPagamento servicoPagamentos)
        {
            Id = id;
            Cliente = cliente;
            ServicoPagamentos = servicoPagamentos;
        }

        
    }
}
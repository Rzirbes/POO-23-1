using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03.Domain
{
    public class Produto
    {

        public int Id { get; set; }
        public string CodBarras { get; set; }
        public double Preco { get; set; }
        
        public Produto(int id, string codBarras, double preco)
        {
            Id = id;
            CodBarras = codBarras;
            Preco = preco;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Domain
{
    public class Cliente
    {
        

        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
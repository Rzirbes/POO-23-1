using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Interface
{
    public interface IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio02.Interface;

namespace Exercicio02.Domain
{
    public class Escola
    {

        public IPessoa Aluno { get; set; }
        public IPessoa Professor { get; set; }

        public Escola(IPessoa professor, IPessoa aluno)
        {
            Professor = professor;
            Aluno = aluno;
        }
    }
}
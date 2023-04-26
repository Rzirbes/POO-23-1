using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03Aula10
{
    public class Cachorro : IAnimalEstimacao
    {
        public string Nome { get ; set ; }
        public string Dono { get ; set ; }

        public Cachorro(string nome, string dono)
        {
            Nome = nome;
            Dono = dono;
        }
    }
}
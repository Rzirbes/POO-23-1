using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03Aula10
{
    public class Gato : IAnimalEstimacao
    {
        
        public string Nome { get ; set ; }
        public string Dono { get ; set ; }

        public Gato(string nome, string dono)
        {
            Nome = nome;
            Dono = dono;
        }
    }
}
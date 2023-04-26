using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01Aula10
{
    public class Papagaio : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("Falando");
        }
    }
}
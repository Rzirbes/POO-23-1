using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Miau");
        }
    }
}
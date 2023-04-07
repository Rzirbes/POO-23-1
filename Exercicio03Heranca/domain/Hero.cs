using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03Heranca.domain
{
    public class Hero : Character
    {
        public Hero(string name, int strength, int intelligence, string[] powers) : base(name, strength, intelligence, powers)
        {
        }

        public void toFight(Villain opponent)
        {
            base.toFight(opponent);
            if(opponent is SuperVillain)
            {
                Console.WriteLine($"{this.Name} é um herói corajoso e enfrenta seu inimigo com bravura.");
            }
        }
    }
}
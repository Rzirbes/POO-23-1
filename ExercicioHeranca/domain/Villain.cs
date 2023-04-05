using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public class Villain : Character
    {
        public Villain(string name, int strength, int intelligence, string[] powers) : base(name, strength, intelligence, powers)
        {
        }

        public void toFight(Hero opponent)
        {
            base.toFight(opponent);
            if(opponent is SuperHero)
            {
                Console.WriteLine($"{this.Name} é um herói corajoso e enfrenta seu inimigo com bravura.");
            }
        }
    }
}
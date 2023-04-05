using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public class Character
    {
        
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public string[] Powers { get; set; }

        public Character(string name, int strength, int intelligence, string[] powers)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Powers = powers;
        }

        public void toFight(Character opponent)
        {
            Console.WriteLine($"{this.Name} está lutando contra {opponent.Name}");


            int myStrength = this.Strength + this.Powers.Length + this.Intelligence;

            int opponentStrength = opponent.Strength + opponent.Powers.Length + opponent.Intelligence;


            if(myStrength > opponentStrength)
            {
                Console.WriteLine($"{this.Name} venceu a luta");
                Console.WriteLine("==============");
            }
            else if(myStrength < opponentStrength)
            {
                Console.WriteLine($"{this.Name} perdeu a luta");
                Console.WriteLine("==============");
            } 
            else
            {
                Console.WriteLine("A luta terminou em empate!");
                Console.WriteLine("==============");
            }
            Console.WriteLine($"A força do Herói era {myStrength}");
            Console.WriteLine($"A força do Vilão era {opponentStrength}");

        }

    }
}
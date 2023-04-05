using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public class SuperVillain : Villain
    {
        public string SuperPower { get; set; }
        public int StrengthSuperPower { get; set; }
        public SuperVillain(string name, int strength, int intelligence, string[] powers, string SuperPower, int strengthSuperPower) : base(name, strength, intelligence, powers)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Powers = powers;
            this.StrengthSuperPower = strengthSuperPower;
            this.SuperPower = SuperPower;
            
        }

        public void UseSuperPower()
        {
            Console.WriteLine($"{this.Name} usa o seu super poder {this.SuperPower}");
            this.Strength += this.StrengthSuperPower;
        }
    }
}
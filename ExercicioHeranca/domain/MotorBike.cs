using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public class MotorBike : Vehicle
    {
       
        public int MaxSpeed { get; set; }
        public MotorBike(string modelo, int maxSpeed) : base(modelo)
        {
            this.MaxSpeed = maxSpeed;
            this.Modelo = modelo;
        }

        public new void speedUp(int maxSpeed)
        {
            base.speedUp(maxSpeed);
        }

        public override void breakVehicle()
        {
            Console.WriteLine($"A {this.Modelo} está freando até parar");
            Console.WriteLine("=============");
        }  
    }
}
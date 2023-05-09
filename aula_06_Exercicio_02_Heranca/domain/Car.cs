using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02Heranca.domain
{
    public class Car : Vehicle
    {
      public int MaxSpeed { get; set; }
        public Car(string modelo, int maxSpeed) : base(modelo)
        {
            this.MaxSpeed = maxSpeed;
        }

        public new void speedUp(int maxSpeed)
        {
            base.speedUp(maxSpeed);
        }

        public override void breakVehicle()
        {
            Console.WriteLine($"O {this.Modelo} está freando até parar");
            Console.WriteLine("=============");
        }  
    }
}
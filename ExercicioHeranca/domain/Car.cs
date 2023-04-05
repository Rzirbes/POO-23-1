using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public class Car : Vehicle
    {
        public int MaxSpeed { get; set; }
        public Car(string modelo, int maxSpeed) : base(modelo)
        {
            this.MaxSpeed = maxSpeed;
        }

        public override void speedUp()
        {
            int speedLimit = MaxSpeed;
            string modelo = Modelo;
            Console.WriteLine($"O {modelo} está acelerando até sua velocidade máxima que é {speedLimit}km/h");
        }

        public override void breakVehicle()
        {
            Console.WriteLine("freando até para");
        }
    }
}
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

        public override void speedUp()
        {
            int speedLimit = MaxSpeed;
            string modelo = Modelo;
            Console.WriteLine($"O {modelo} está acelerando até sua velocidade máxima que é {speedLimit}km/h");
        }

        public override void breakVehicle()
        {
            Console.WriteLine("O carro está freando até para");
        }  
    }
}
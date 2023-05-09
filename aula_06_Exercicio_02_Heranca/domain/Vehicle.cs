using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02Heranca.domain
{
    public abstract class Vehicle
    {
        public string Modelo { get; protected set; }

        protected Vehicle(string modelo)
        {
            Modelo = modelo;
        }

        public void speedUp(int maxSpeed)
        {
            
            int speedLimit = maxSpeed;
            string modelo = Modelo;
           
            Console.WriteLine($"O {modelo} Está acelerando até chgegar seu limite de velocidade {speedLimit}km/h");
        }
        public abstract void breakVehicle();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
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
            int currentSpeed = 0;
            int speedLimit = maxSpeed;
            string modelo = Modelo;
            while(currentSpeed < speedLimit)
            {
                Console.WriteLine("Velocidade: " + currentSpeed + " km/h");
                currentSpeed += 5;
            }
            Console.WriteLine($"O {modelo} chegou ao seu limite de velocidade {speedLimit}km/h");
            Console.WriteLine("=============");
        }
        public abstract void breakVehicle();
    }
}
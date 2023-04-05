using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHeranca.domain
{
    public abstract class Vehicle
    {
        public string Modelo { get; set; }

        protected Vehicle(string modelo)
        {
            Modelo = modelo;
        }

        public abstract void speedUp();
        public abstract void breakVehicle();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_encapsulamento
{
    public class City
    {
        

        public int Id {get; set;}
        public string Name {get; set;}

        public City(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
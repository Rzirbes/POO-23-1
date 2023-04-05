using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCrudPessoa02.domain
{
    public class City
    {
        private static int idAtual = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public City(string name)
        {
            this.Id = ++idAtual;
            this.Name = name;
        }
    }
}
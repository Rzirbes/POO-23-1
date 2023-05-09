using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCrudPessoa02
{
    public class Address
    {
        private static int idAtual = 0;
        public int Id { get; set; }
        public string StreetAddress { get; set; }

        public Address (string streetAddress)
        {
            this.Id = ++idAtual;
            this.StreetAddress = streetAddress;
        }
    }
}
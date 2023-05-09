using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_encapsulamento
{
    public class Address
    {
        

        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public People People { get; set; }

        public Address(int id, string streetAddress)
        {
            this.Id = id;
            this.StreetAddress = streetAddress;
        }

        public Address(int id, string streetAddress, People people)
        {
            this.Id = id;
            this.StreetAddress = streetAddress;
            this.People = people;
        }
    }
}
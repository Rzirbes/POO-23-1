using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_encapsulamento
{
    public abstract class People
    {
        public int Id {get; set;}
        public string Name {get; protected set;}
        public City City { get; set; }
        public List<Address> Address {get; set;}

        public People(int id, string name, City city)
        {
            this.Id = id;
            this.Name = name;
            this.City = city;
        }

        public void AddAddress(Address address){
            this.Address.Add(address);
        }
    }
}
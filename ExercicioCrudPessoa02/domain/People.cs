using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioCrudPessoa02;
using ExercicioCrudPessoa02.domain;

namespace ExercicioCrudPessoa02
{
    public abstract class People
    {
        private static int idAtual = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public City City { get; set; }
        public List<Address> Addresses { get; set; }

        public People( string name, string phone, City city)
        {
            this.Id = ++idAtual;
            this.Name = name;
            this.Phone = phone;
            this.City = city;
            this.Addresses = new List<Address>();
        }

        public void AddAddress(Address address)
        {
            this.Addresses.Add(address);
        }

        public List<Address> GetAllAddress()
        {
            return Addresses.ToList();
        }
    }

    
}
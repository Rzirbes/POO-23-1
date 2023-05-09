using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_encapsulamento
{
    public class PhysicalPerson : People
    {
        
        public string CPF { get; set; }

        public PhysicalPerson(int id, string name, City city, string cpf) : base(id, name, city)
        {
            this.CPF = cpf;
        }

       public void testName()
       {
            this.Name = "asdasdas";
       }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCrudPessoa02.domain
{
    public class NaturalPerson : People
    {
        public string CPF { get; set; }

        public NaturalPerson(string name, string phone, City city, string cpf) : base(name, phone, city)
        {
            this.CPF = cpf;
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1.domain.models
{
    public abstract class People
    {
        
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }

        public People( string name, string cpf, string phone)
        {
            Name = name;
            CPF = cpf;
            Phone = phone;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1.domain.models
{
    public class Patient : People
    {
        private static int idAtual = 0;
        public int Id { get; set; }
        public string Illness { get; set; }
        public Patient(string name, string cpf, string phone, string illness) : base(name, cpf, phone)
        {
            Id = ++idAtual;
            Illness = illness;
        }
    }
}
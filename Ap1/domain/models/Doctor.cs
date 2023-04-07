using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1.domain.models
{
    public class Doctor : People
    {
        private static int idAtual = 0;
        public int Id { get; set; }
        public string CRM { get; set; }
        public string OccupationArea { get; set; }
        public string? Specialization { get; set; }
        public Doctor(string name, string cpf, string phone, string crm, string occupationArea, string specialization) 
            : base(name, cpf, phone)
        {
            Id = ++idAtual;
            CRM = crm;
            OccupationArea = occupationArea;
            Specialization = specialization;
        }

        public Doctor(string name, string cpf, string phone, string crm, string occupationArea) 
            : base(name, cpf, phone)
        {
            Id = ++idAtual;
            CRM = crm;
            OccupationArea = occupationArea;
        }
    }
}
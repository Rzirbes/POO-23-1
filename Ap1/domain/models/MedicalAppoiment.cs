using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1.domain.models
{
    public class MedicalAppoiment
    {
        private static int idAtual = 0;
        public int Id { get; set; }
        public DateTime AppoimentDate { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public MedicalAppoiment(DateTime appoimentDate, Doctor doctor, Patient patient)
        {
            Id = ++idAtual;
            AppoimentDate = appoimentDate;
            Doctor = doctor;
            Patient = patient;
        }
    }
}
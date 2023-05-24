using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap2.Domain.Entities
{
    public class MedicalAppoiment
    {
        public int Id { get; set; }
        public DateTime AppoimentDate { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        
    }
}
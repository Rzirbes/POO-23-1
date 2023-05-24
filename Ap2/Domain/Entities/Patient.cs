using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap2.Domain.Entities
{
    public class Patient : Person
    {
        public int Id { get; set; }
        public string Illness { get; set; }
        
    }
}
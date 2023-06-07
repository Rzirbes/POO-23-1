using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap2WebApi.Models.Entities
{
    public class Patient : Person
    {
        public int Id { get; set; }
        public string Illness { get; set; }

    }
}
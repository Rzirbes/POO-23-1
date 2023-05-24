using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_11_inicio.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int? CityId { get; set; }
        public virtual City City { get; set; } 
        
    }
}
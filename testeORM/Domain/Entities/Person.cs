using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeORM.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime Age { get; set; }
        public string phoneNumber { get; set; }
    }
}
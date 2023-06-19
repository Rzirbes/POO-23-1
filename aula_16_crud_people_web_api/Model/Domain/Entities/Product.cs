using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_16_ef_test.Model.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Person Person { get; set; }
    }
}
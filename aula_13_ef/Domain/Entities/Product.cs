using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_11_inicio.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
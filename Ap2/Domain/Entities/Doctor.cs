using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ap2.Domain.Entities
{
    public class Doctor : Person
    {
        public int Id { get; set; }

        
        public string CRM { get; set; }

        
        public string OccupationArea { get; set; }

        public string Specialization { get; set; }

        
    }
}
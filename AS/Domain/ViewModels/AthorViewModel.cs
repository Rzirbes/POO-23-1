using System.ComponentModel.DataAnnotations;

namespace AS.Domain.ViewModels
{
    public class AuthorViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}

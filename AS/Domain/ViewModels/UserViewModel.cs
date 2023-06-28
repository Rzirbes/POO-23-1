using System.ComponentModel.DataAnnotations;

namespace AS.Domain.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
    }
}

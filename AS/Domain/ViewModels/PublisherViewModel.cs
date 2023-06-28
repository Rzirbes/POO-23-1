using System.ComponentModel.DataAnnotations;

namespace AS.Domain.ViewModels
{
    public class PublisherViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Location { get; set; }
    }
}

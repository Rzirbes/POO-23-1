using System.ComponentModel.DataAnnotations;

namespace AS.Domain.ViewModels
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int PublisherId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int PublicationYear { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O campo {0} precisa ser maior ou igual a 0")]
        public decimal Price { get; set; }
    }
}

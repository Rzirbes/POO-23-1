using System.ComponentModel.DataAnnotations;

namespace AS.Domain.ViewModels
{
    public class LoanViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime LoanDate { get; set; }
    }
}

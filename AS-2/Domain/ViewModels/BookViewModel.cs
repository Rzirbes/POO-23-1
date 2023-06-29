using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_2.Domain.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<AuthorViewModel> Authors { get; set; }
        
    }
}
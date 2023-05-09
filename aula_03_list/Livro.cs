using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula03_list
{
    public class Livro
    {
 
        public int Id{get; set;}
        public string Isbn{get; set;} = "";
        public string Titulo { get; set; } = "";
        public double Preco { get; set; }

        // public Livro(int id, string isbn, string titulo, double preco = 0)
        // {
        //     this.Id = id;
        //     this.Isbn = isbn;
        //     this.Titulo = titulo;
        //     this.Preco = preco;
        // }

        

        
    }
}
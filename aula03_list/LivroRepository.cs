using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula03_list
{
    public class LivroRepository
    {

        public static List<Livro> books = new List<Livro>();

        
        public void Create(Livro book)
        {
            books.Add(book);
            
        }

        public void Deletar(int id)
        { 

            Livro livro = books.Find(li => li.Id == id);

            if(livro == null)
            {
                Console.WriteLine("Livro não encontrado!");
            }
            else
            {
                books.Remove(livro);
                Console.WriteLine("Livro Excluído");
            }
        }

        public void Update(int id)
        {
            Livro livro = books.Find(li => li.Id == id);

            if(livro == null)
            {
                Console.WriteLine("Livro não encontrado!");
            }
            else
            {
                Console.WriteLine("Digite o novo título do livro");
                livro.Titulo = Console.ReadLine();
                Console.WriteLine("Digite o novo ISBN do livro");
                livro.Isbn = Console.ReadLine();
                Console.WriteLine("Digite o novo preco do livro");
                livro.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Livro Atualizado");
            }

        }

        public List<Livro> GetAll()
        {
            return books;
        }

        public Livro GetById(int id)
        {
            return books.Find(li => li.Id == id)!;
        } 
        public List<Livro> GetByContainName(string text)
        {
            return books.FindAll(x=>x.Titulo.Contains(text));
        }
    }
}
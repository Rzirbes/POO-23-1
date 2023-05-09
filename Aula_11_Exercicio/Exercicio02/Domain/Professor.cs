using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio02.Interface;

namespace Exercicio02.Domain
{
    public class Professor : IPessoa
    {
        public string Nome { get ; set ; }
        public int Idade { get ; set ; }

        public Professor(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Falar()
        {
            Console.WriteLine($"Meu nome é {this.Nome} e tenho {this.Idade} anos, sou professor");
        }
    }
}
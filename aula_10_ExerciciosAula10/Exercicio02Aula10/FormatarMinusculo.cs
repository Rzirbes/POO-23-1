using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02Aula10
{
    public class FormatarMinusculo : IFormatadorTexto
    {
        public string FormatarTexto(string texto)
        {
            var textoMinusculo = texto.ToLower();
            Console.WriteLine(textoMinusculo);
            return textoMinusculo;
        }
    }
}
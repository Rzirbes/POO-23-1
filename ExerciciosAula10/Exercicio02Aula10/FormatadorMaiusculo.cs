using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02Aula10
{
    public class FormatadorMaiusculo : IFormatadorTexto
    {
        public string FormatarTexto(string texto)
        {
            var textoMaiusculo = texto.ToUpper();
            Console.WriteLine(textoMaiusculo);
            return textoMaiusculo;
        }
    }
}
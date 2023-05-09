using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02Aula10
{
    public class FormatarInvertido
    {
        public string FormatarTexto(string texto)
        {   
            char[] caracter = texto.ToCharArray();
            Array.Reverse(caracter);
            var textoInvertido = new string(caracter);
            Console.WriteLine(textoInvertido);
            return textoInvertido;
        }
    }
}
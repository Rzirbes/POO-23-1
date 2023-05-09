using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio03.Interfaces;

namespace Exercicio03.Domain
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        private const int Resolucao = 300;
        private const string TamanhoEtiqueta = "10cm x 5cm";
        private const string TipoEtiqueta = "Papel adesivo";
        private const string Marca = "Elgin";

        public void ImprimirEtiqueta(Produto produto)
        {
            Console.WriteLine($"Imprimindo etiqueta na impressora {Marca}...");
            Console.WriteLine($"Resolução: {Resolucao}dpi");
            Console.WriteLine($"Tamanho da etiqueta: {TamanhoEtiqueta}");
            Console.WriteLine($"Tipo de etiqueta: {TipoEtiqueta}");
            Console.WriteLine($"Código de barras: {produto.CodBarras}");
            Console.WriteLine("Etiqueta impressa com sucesso!");
        }
    }
}
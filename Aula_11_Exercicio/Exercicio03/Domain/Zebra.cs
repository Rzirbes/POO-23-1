using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio03.Interfaces;

namespace Exercicio03.Domain
{
    class Zebra : IImpressoraDeCodigoDeBarras
    {
        private const int Resolucao = 600;
        private const string TamanhoEtiqueta = "15cm x 7cm";
        private const string TipoEtiqueta = "Poliéster";
        private const string Marca = "Zebra";

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
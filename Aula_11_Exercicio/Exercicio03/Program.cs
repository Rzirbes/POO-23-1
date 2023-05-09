using Exercicio03.Domain;
using Exercicio03.Interfaces;

IImpressoraDeCodigoDeBarras elgin = new Elgin();

Produto produto = new Produto(1, "444333222111", 19.90);

elgin.ImprimirEtiqueta(produto);

// See https://aka.ms/new-console-template for more information
using Exercicio02Aula10;

Console.WriteLine("Hello, World!");

string texto = "Exemplo de string";

var maiuscula = new FormatadorMaiusculo();
var minusculo = new FormatarMinusculo();
var invertido = new FormatarInvertido();

invertido.FormatarTexto(texto);
minusculo.FormatarTexto(texto);
maiuscula.FormatarTexto(texto);


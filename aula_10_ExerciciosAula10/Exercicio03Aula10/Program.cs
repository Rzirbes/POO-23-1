
using Exercicio03Aula10;




IAnimalEstimacao cachorro = new Cachorro("Toto", "Pedro");
IAnimalEstimacao gato = new Gato("Bichano", "João");

Console.WriteLine($"Nome: {cachorro.Nome}, Dono: {cachorro.Dono}");
Console.WriteLine($"Nome: {gato.Nome}, Dono: {gato.Dono}");
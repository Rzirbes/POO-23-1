using aula02__classe_objeto_construtor_metodos;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Livro livroBD = new Livro(10, "asd", "Livro BD", 10.75);

// livroBD.nome();
// livroBD.dadosLivros();
// livroBD.SetPreco(290);

Show(livroBD.Id + " - " + livroBD.Isbn + " - " + livroBD.Preco);

Show("Digite algo");
var retorno = Console.ReadLine();

Show("o usuáruio retornbou " + retorno);




void Show(String msg){
    Console.WriteLine(msg);
}
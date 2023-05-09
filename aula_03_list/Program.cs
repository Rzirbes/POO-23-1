using aula03_list;
// See https://aka.ms/new-console-template for more information

// Livro livro = new Livro(12, "343434", "BD");
// Livro livro1 = new Livro(22, "353535", "LPO", 99);
// Livro livro2 = new Livro(22, "099999", "LPOOII", 111);
// Livro livro3 = new Livro(22, "77777", "AP1");

// Show(livro.Titulo);
// Show(livro2.Titulo);

LivroRepository repository = new LivroRepository();
int idAtual = 0;

// repository.Create(livro);
// repository.Create(livro1);
// repository.Create(livro2);
// repository.Create(livro3);

while(true)
{
    Show("Digite a opção desejada:");
    Show("1 - Inserir novo Livro");
    Show("2 - Exibir todos os livros");
    Show("3 - Alterar um livro pelo ID");
    Show("4 - Excluir um livro");
    Show("0 - Sair");

    int opcao = int.Parse(Input());

    switch(opcao)
    {
        case 1:
            InserirLivro();
        break;
        case 2:
            ExibirLivro();
        break;
        case 3:
            AlterarLivro();
        break;
        case 4:
            ExcluirLivro();
        break;
        case 0:
            Environment.Exit(0);
        break;
        default:
            Console.WriteLine("Opção inválida!");
        break;
    }
}



void InserirLivro()
{
    Livro livro = new Livro();
    livro.Id = idAtual++;
    Console.WriteLine("Digite o titulo do Livro");
    livro.Titulo = Console.ReadLine();
    Console.WriteLine("Digite o ISBN do Livro");
    livro.Isbn = Console.ReadLine();
    Console.WriteLine("Digite o preço do Livro");
    livro.Preco = double.Parse(Console.ReadLine());
    repository.Create(livro);
    Console.WriteLine("Livro Adicionado com sucesso");
}



void ExibirLivro()
{
    foreach(var item in repository.GetAll())
    {
        Show($"O livro é: {item.Titulo} e o isbn é {item.Isbn}");
    }
}

void ExcluirLivro(){
    Show("Digite o id do livro");
    int id = int.Parse(Input());

    repository.Deletar(id);
}

void AlterarLivro()
{
    Show("Digite o id do livro");
    int id = int.Parse(Input());

    repository.Update(id);
}



    







// for (int i = LivroRepository.books.Count - 1; i >= 0; i--)
// {
//     if(LivroRepository.books[i].Id == 2)
//     {
//         Show(LivroRepository.books[i].Titulo);
//     }
// }

// foreach (var item in LivroRepository.books)
// {
//     if(item.Id == 2)
//     {
//         Show(item.Titulo);
//     }
// }

// Show(LivroRepository.books.Find(x=>x.Id==2)!.Titulo);

// var result = repository.GetByContainName("fa");


void Show(string msg)
{
    Console.WriteLine(msg);
}

string Input(){
    return Console.ReadLine();
}
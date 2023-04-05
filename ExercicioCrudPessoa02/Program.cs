using ExercicioCrudPessoa02;
using ExercicioCrudPessoa02.domain;
using ExercicioCrudPessoa02.repository;

PeopleRepository repository = new PeopleRepository();

// NaturalPerson people = new NaturalPerson("Romulo", "45454545", new City("Arroio do sal"), "0909090" );
// NaturalPerson people2 = new NaturalPerson("Romulo", "565656", new City("Torres"), "909090909");
// NaturalPerson people3 = new NaturalPerson("roze", "3838383", new City("Cidreira"), "876876867");
// NaturalPerson people4 = new NaturalPerson("luis", "01010101", new City("Capão"), "2837456384");
// people2.AddAddress(new Address("Rua das Corticeiras"));
// people2.AddAddress(new Address("Rua das araucarias"));

// InsertPeople(people);
// InsertPeople(people2);
// InsertPeople(people3);
// InsertPeople(people4);
// ShowPeople();
// DeletePeople(people2.Id);
// ShowPeople();
// AlterPeople(people);
// ShowPeople();

while(true)
{
    Show("Digite a opção desejada:");
    Show("1 - Fazer cadastro");
    Show("2 - Exibir todas as pessoas");
    Show("3 - Alterar um cadastro pelo ID");
    Show("4 - Excluir um cadastro");
    Show("0 - Sair");

    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao)
    {
        case 1:
            int Insert = 1;
            InsertOrUpdatePeople(Insert);
        break;
        case 2:
            ShowPeople();
        break;
        case 3:
        int Update = 3;
            InsertOrUpdatePeople(Update);
        break;
        case 4:
            DeletePeople();
        break;
        case 0:
            Environment.Exit(0);
        break;
        default:
            Console.WriteLine("Opção inválida!");
        break;
    
    }

}


void InsertOrUpdatePeople(int insertOrUpdate)
{
    
    Show("Digite seu nome");
    string peopleName = Console.ReadLine()!;
    Show("Digite seu telefone");
    string peoplePhone = Console.ReadLine()!;
    Show("Digite seu CPF");
    string peopleCpf = Console.ReadLine()!;
    Show("Digite sua cidade");
    string nameCity = Console.ReadLine()!;
    City newCity = new City(nameCity);
    City city = newCity;

    NaturalPerson newPeople = new NaturalPerson(peopleName, peoplePhone, city, peopleCpf);

    Show("Qauntos endereços deseja inserir?");
    int numAddress = int.Parse(Console.ReadLine()!);
    List<Address> addresses = new List<Address>();

    for(int i = 0; i < numAddress; i++)
    {
        Show($"Digite o endereço {i+1}");
        string streetAddress = Console.ReadLine()!;
        Address address = new Address(streetAddress);
        addresses.Add(address);
    }
    foreach (var address in addresses)
    {
        newPeople.AddAddress(address);
    }
    if(insertOrUpdate == 1)
    {
        repository.AddPeople(newPeople);
    }
    else
    {
        Show("Digide o Id da pessoa que quer alterar o cadastro");
        int id = int.Parse(Console.ReadLine()!);

        People peopleUpdate = repository.GetPeopleById(id)!;

        repository.UpdatePeople(peopleUpdate.Id, newPeople);

    }

}

void ShowPeople()
{
    foreach (var item in repository.GetAllPeople())
    {
        Show($"Cadastro número: {item.Id}, nome: {item.Name}, telefone: {item.Phone}, cidade: {item.City.Name}");
        List<Address> addresses = item.Addresses;
    foreach (Address address in item.GetAllAddress())
    {
        Show($"com Endereço {address.StreetAddress}");
        
    }
        Show("===========");
        Show("===========");
    }
}


void DeletePeople()
{
    ShowPeople();
    Show("Digite o número de cadastro que quer excluir");
    int id = int.Parse(Console.ReadLine()!);
    repository.RemovePeople(id);
    Show($"Deletado com sucesso");
    Show("===========");
}

// void AlterPeople()
// {
//     Show("Digide o Id da pessoa que quer alterar o cadastro");
//     int id = int.Parse(Console.ReadLine()!);

//     People peopleUpdate = repository.GetPeopleById(id)!;

//     People oldPeople = peopleUpdate;
//     Show("Digite seu nome");
//     peopleUpdate.Name = Console.ReadLine()!;
//     Show("Digite seu telefone");
//     peopleUpdate.Phone = Console.ReadLine()!;
//     Show("Digite sua cidade");
//     string updateCity = Console.ReadLine()!;
//     City newCity = new City(updateCity);
//     peopleUpdate.City = newCity;

//     Show("Qauntos endereços deseja inserir no novo cadastro?");
//     int numAddressUpdate = int.Parse(Console.ReadLine()!);
//     List<Address> addresses = new List<Address>();

//     for(int i = 0; i < numAddressUpdate; i++)
//     {
//         Show($"Digite o endereço {i+1}");
//         string streetAddressUpdate = Console.ReadLine()!;
//         Address address = new Address(streetAddressUpdate);
//         addresses.Add(address);
//     }
//     foreach (var address in addresses)
//     {
//         peopleUpdate.AddAddress(address);
//     }

//     repository.UpdatePeople(oldPeople.Id, peopleUpdate);
// }



void Show(string msg)
{
    Console.WriteLine(msg);
}
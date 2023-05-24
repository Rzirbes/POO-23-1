// See https://aka.ms/new-console-template for more information
using aula_11_inicio.Domain.Entities;
using aula_11_inicio.Data;
using aula_11_inicio.Data.Repositories;

var db = new DataContext();
var cities = new CityRepository(db);

var repositoryPerson = new PersonRespository(db);


// var personFind = repositoryPerson.GetById(4);
// Console.WriteLine($"Name: {personFind.Name}, Telefone: {personFind.PhoneNumber}");

Console.WriteLine("Listando People");
ListPeople();

// var city = repositoryCity.GetById(1);

// var novoOb = repositoryPerson.GetById(3);
// novoOb.Name = "Adenilson Adenilson";
// novoOb.PhoneNumber = "48 9090909asdas09";
// novoOb.City = city;
// repositoryPerson.Update(novoOb);

Console.WriteLine("Inserting a new Person using repository person");
var person = new Person { Name = "Lui Inacio", PhoneNumber = "49 2222222222", CityId = 3 };
repositoryPerson.Save(person);

// repositoryPerson.Delete(6);

ListPeople();



void ListPeople()
{
    var people = repositoryPerson.GetAll();
    Console.WriteLine("=======");
    foreach (var item in people)
    {
        
        string cityName = item.City != null ? item.City.Name : "N/A";
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} | Telefone: {item.PhoneNumber} | Cidade: {cityName}");
    }
    Console.WriteLine("=======");
}


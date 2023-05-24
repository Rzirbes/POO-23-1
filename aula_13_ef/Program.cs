// See https://aka.ms/new-console-template for more information
using aula_11_inicio.Domain.Entities;
using aula_11_inicio.Data;
using aula_11_inicio.Data.Repositories;

var db = new DataContext();

var repositoryPerson = new PersonRespository(db);


// Console.WriteLine("Inserting a new Person using repository person");
// var person = new Person() {Id= 4, Name = "Pedro", PhoneNumber = "51 2020202020"};
// repositoryPerson.Save(person);


Console.WriteLine("Listando People");

ListPeople();



var personFind = repositoryPerson.GetById(4);
Console.WriteLine($"Name: {personFind.Name}, Telefone: {personFind.PhoneNumber}");

Console.WriteLine("delete person id 3 ...");
repositoryPerson.Delete(2);


ListPeople();


// Console.WriteLine("Inserting a new product");
// var product = new Product() {Id = 1, Description = "Caneta", Price = 12};
// db.Add(product);
// db.SaveChanges();



void ListPeople()
{
    var people = repositoryPerson.GetAll();
    Console.WriteLine("=======");
    foreach (var item in people)
    {
        Console.WriteLine($"Id: {item.Id}| Nome: {item.Name}| telefone: {item.PhoneNumber}");
    }
    Console.WriteLine("=======");
}
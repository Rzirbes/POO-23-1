// See https://aka.ms/new-console-template for more information
using testeORM.Data.Context;
using testeORM.Domain.Entities;

Console.WriteLine("Hello, World!");

using var db = new MeuContexto();

//create
Console.WriteLine("inserting a new person");
var person = new Person(){Id = 1, Name = "João", Age = DateTime.Now, phoneNumber = "51 9090909"};
db.Add(person);
db.SaveChanges();
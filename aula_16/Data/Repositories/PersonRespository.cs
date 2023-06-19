using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_11_inicio.Domain.Entities;
using aula_11_inicio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aula_11_inicio.Data.Repositories
{
    public class PersonRespository : IPersonRepository
    {

        private readonly DataContext context;

        // public List<Person> People { get; set; }
        public PersonRespository()
        {
            this.context = new DataContext();
        }

        public IList<Person> GetAll()
        {
            return context.People.ToList();
        }

        public void Save(Person entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Update(Person entity)
        {
            context.People.Update(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
            context.SaveChanges();
            return true;
        }
    }
}
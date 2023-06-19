using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_16_ef_test.Model.Domain.Entities;
using aula_16_ef_test.Model.Domain.Interfaces;
using aula12_ef_test.Model.Data;

namespace aula12_ef_test.Model.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
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
        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
            context.SaveChanges();
            return true;
        }



        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x => x.Id == entityId);
        }



        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_11_inicio.Data.Repositories;
using aula_11_inicio.Domain.Entities;
using aula_11_inicio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aula_11_inicio.Data.Repositories
{
    public class PersonRespository : IPersonRepository
    {

        private readonly DataContext context;


        // public List<Person> People { get; set; }
        public PersonRespository(DataContext context)
        {
            this.context = context;

        }


        public IList<Person> GetAll()
        {
            return context.People
                .Include(p => p.City)
                .ToList();
        }


        public void Save(Person entity)
        {
            if (entity.CityId.HasValue)
            {
                bool cityExists = context.Cities.Any(c => c.Id == entity.CityId.Value);
                if (!cityExists)
                {
                    // Adicionar a mensagem de erro a uma lista de erros ou a um log de erros
                    Console.WriteLine("A cidade não existe. O registro não será salvo.");
                    // Ou qualquer outra ação que você desejar tomar para lidar com a situação
                    return; // Retornar sem salvar o registro
                }

                entity.City = context.Cities.Find(entity.CityId.Value);
            }

            context.Add(entity);
            context.SaveChanges();
        }

        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x => x.Id == entityId);
        }

        public void Update(Person entity)
        {
            // entity.City = GetById
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
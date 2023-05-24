using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_11_inicio.Domain.Entities;
using aula_11_inicio.Domain.Interfaces;

namespace aula_11_inicio.Data.Repositories
{
    public class CityRepository : ICityRepository
    {

        private readonly DataContext context;
        public CityRepository(DataContext context)
        {
            this.context = context;
        }
        public bool Delete(int entityId)
        {
            var city = GetById(entityId);
            context.Remove(city);
            context.SaveChanges();
            return true;
        }

        public IList<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public City GetById(int entityId)
        {
            return context.Cities.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(City entity)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
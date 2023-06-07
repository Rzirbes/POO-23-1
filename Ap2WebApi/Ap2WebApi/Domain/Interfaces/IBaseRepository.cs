using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap2.Domain.Interfaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Entity GetById(int entityId);
        IList<Entity> GetAll();
        void Save(Entity entity);
        bool Delete(Entity entityId);
        void Update(int entityId, Entity entity);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Domain.Entities;
using Ap2.Domain.Interfaces;

namespace Ap2.Data.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        // private List<Doctor> _doctorList;

        private readonly DataContext context;

        public DoctorRepository(DataContext context)
        {
            // _doctorList = new List<Doctor>();
            this.context = context;
        }

        public IList<Doctor> GetAll()
        {
            return context.Doctors.ToList();
        }

        public Doctor GetById(int entityId)
        {
            return context.Doctors.SingleOrDefault(x => x.Id == entityId);
        }

        public bool Delete(Doctor doctor)
        {
            
            context.Remove(doctor);
            context.SaveChanges();
            return true;
        }

        public void Save(Doctor entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(int entityId, Doctor newEntity)
        {
           

            context.Doctors.Update(newEntity);
            context.SaveChanges();

        }
    }
}
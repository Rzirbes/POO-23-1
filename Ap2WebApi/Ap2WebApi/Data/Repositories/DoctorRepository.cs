using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Domain.Interfaces;
using Ap2WebApi.Models.Entities;

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


            var existingDoctor = context.Doctors.Find(entityId);
            if (existingDoctor == null)
            {
                throw new ArgumentException("Patient not found");
            }

            // Atualize os campos relevantes do paciente existente com base nos dados fornecidos
            existingDoctor.Name = newEntity.Name;
            existingDoctor.CPF = newEntity.CPF;
            existingDoctor.Phone = newEntity.Phone;
            existingDoctor.CRM = newEntity.CRM;
            existingDoctor.OccupationArea = newEntity.OccupationArea;
            if(newEntity.Specialization != null)
            {
                existingDoctor.Specialization = newEntity.Specialization;
            }

            context.SaveChanges();

        }
    }
}
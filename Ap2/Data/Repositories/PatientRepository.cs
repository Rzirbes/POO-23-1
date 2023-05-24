using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Domain.Entities;
using Ap2.Domain.Interfaces;

namespace Ap2.Data.Repository
{
    public class PatientRepository : IPatientRepository
    {
        // private List<Patient> _patientList;
        private readonly DataContext context;

        public PatientRepository(DataContext context)
        {
            
            this.context = context;
        }
        public void Save(Patient patient)
        {
            context.Add(patient);
            context.SaveChanges();
        }

        public IList<Patient> GetAll()
        {
            return context.Patients.ToList();
        }

        public Patient GetById(int entityId)
        {
            return context.Patients.SingleOrDefault(x => x.Id == entityId);
        }

        public bool Delete(Patient patient)
        {
            context.Remove(patient);
            context.SaveChanges();
            return true;
        }

        public void Update(int id, Patient patient)
        {
            context.Patients.Update(patient);
            context.SaveChanges();
        }
    }
}
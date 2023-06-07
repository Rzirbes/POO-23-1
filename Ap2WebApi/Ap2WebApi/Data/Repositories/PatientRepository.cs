using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Domain.Interfaces;
using Ap2WebApi.Models.Entities;

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

        public void Update(int id, Patient updatedPatient)
        {
            var existingPatient = context.Patients.Find(id);
            if (existingPatient == null)
            {
                throw new ArgumentException("Patient not found");
            }

            // Atualize os campos relevantes do paciente existente com base nos dados fornecidos
            existingPatient.Name = updatedPatient.Name;
            existingPatient.CPF = updatedPatient.CPF;
            existingPatient.Phone = updatedPatient.Phone;
            existingPatient.Illness = updatedPatient.Illness;

            context.SaveChanges();
        }
    }
}
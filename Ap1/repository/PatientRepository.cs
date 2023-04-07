using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap1.domain.interfaces;
using Ap1.domain.models;

namespace Ap1.repository
{
    public class PatientRepository : IPatientRepository
    {
        private List<Patient> _patientList;

        public PatientRepository()
        {
            _patientList = new List<Patient>();
        }
        public void AddPatient(Patient patient)
        {
            _patientList.Add(patient);
        }

        public List<Patient> GetAllPatient()
        {
            return _patientList;
        }

        public Patient GetByIdPatient(int id)
        {
            return _patientList.Find(p => p.Id == id)!;
        }

        public void RemovePatient(Patient patient)
        {
            _patientList.RemoveAll(p => p == patient);
        }

        public void UpdatePatient(int id, Patient patient)
        {
            Patient patientUpdate = _patientList.Find(d => d.Id == id)!;

            if(patientUpdate != null)
            {
                patientUpdate.Name = patient.Name;
                patientUpdate.Phone = patient.Phone;
                patientUpdate.CPF = patient.CPF;
                patientUpdate.Illness = patient.Illness;
            }
        }
    }
}
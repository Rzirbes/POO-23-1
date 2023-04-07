using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap1.domain.models;

namespace Ap1.domain.interfaces
{
    public interface IPatientRepository
    {
        Patient GetByIdPatient(int id);
        List<Patient> GetAllPatient();
        void AddPatient(Patient patient);
        void UpdatePatient(int id, Patient patient);
        void RemovePatient(Patient patient);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2WebApi.Models.Entities;

namespace Ap2.Domain.Interfaces
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {
        // Patient GetByIdPatient(int id);
        // List<Patient> GetAllPatient();
        // void AddPatient(Patient patient);
        // void UpdatePatient(int id, Patient patient);
        // void RemovePatient(Patient patient);
    }
}
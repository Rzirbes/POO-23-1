using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap1.domain.models;

namespace Ap1.domain.interfaces
{
    public interface IDoctorRepository
    {
        Doctor GetByIdDoctor(int id);
        List<Doctor> GetAll();
        void AddDoctor(Doctor doctor);
        void UpdateDoctor(int id, Doctor doctor);
        void RemoveDoctor(Doctor doctor);
    }
}
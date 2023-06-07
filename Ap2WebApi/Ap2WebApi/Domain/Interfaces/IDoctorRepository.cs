using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2WebApi.Models.Entities;

namespace Ap2.Domain.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        // Doctor GetByIdDoctor(int id);
        // List<Doctor> GetAll();
        // void AddDoctor(Doctor doctor);
        // void UpdateDoctor(int id, Doctor doctor);
        // void RemoveDoctor(Doctor doctor);
    }
}
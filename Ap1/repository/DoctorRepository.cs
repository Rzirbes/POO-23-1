using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap1.domain.interfaces;
using Ap1.domain.models;

namespace Ap1.repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private List<Doctor> _doctorList;

        public DoctorRepository()
        {
            _doctorList = new List<Doctor>();
        }
        public void AddDoctor(Doctor doctor)
        {
            _doctorList.Add(doctor);
        }

        public List<Doctor> GetAll()
        {
            return _doctorList;
        }

        public Doctor GetByIdDoctor(int id)
        {
            return _doctorList.Find(d => d.Id == id)!;
        }

        public void RemoveDoctor(Doctor doctor)
        {
            _doctorList.RemoveAll(d => d == doctor);
        }

        public void UpdateDoctor(int id, Doctor newDoctor)
        {
            Doctor doctorUpdate = _doctorList.Find(d => d.Id == id)!;

            if(doctorUpdate != null)
            {
                doctorUpdate.Name = newDoctor.Name;
                doctorUpdate.Phone = newDoctor.Phone;
                doctorUpdate.CPF = newDoctor.CPF;
                doctorUpdate.CRM = newDoctor.CRM;
                doctorUpdate.Specialization = newDoctor.Specialization;
            }
        }
    }
}
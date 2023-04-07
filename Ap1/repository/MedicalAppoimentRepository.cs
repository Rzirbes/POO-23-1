using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap1.domain.interfaces;
using Ap1.domain.models;

namespace Ap1.repository
{
    public class MedicalAppoimentRepository : IAppoimentRepository
    {
        private List<MedicalAppoiment> _medicalAppoimentList;

        public MedicalAppoimentRepository()
        {
            _medicalAppoimentList = new List<MedicalAppoiment>();
        }
        public void AddMedicalAppoiment(MedicalAppoiment medicalAppoiment)
        {
            _medicalAppoimentList.Add(medicalAppoiment);
        }

        public List<MedicalAppoiment> GetAllMedicalAppoiment()
        {
            return _medicalAppoimentList;
        }

        public MedicalAppoiment GetByIdMedicalAppoiment(int id)
        {
            return _medicalAppoimentList.Find(m => m.Id == id)!;
        }

        public void RemoveMedicalAppoiment(MedicalAppoiment medicalAppoiment)
        {
            _medicalAppoimentList.RemoveAll(m => m == medicalAppoiment);
        }

        public void UpdateMedicalAppoiment(int id, MedicalAppoiment medicalAppoiment)
        {
            MedicalAppoiment medicalAppoimentUpdate = _medicalAppoimentList.Find(d => d.Id == id)!;

            if(medicalAppoimentUpdate != null)
            {
                medicalAppoimentUpdate.AppoimentDate = medicalAppoiment.AppoimentDate;
                medicalAppoimentUpdate.Doctor = medicalAppoiment.Doctor;
                medicalAppoimentUpdate.Patient = medicalAppoiment.Patient;
            }
        }
    }
}
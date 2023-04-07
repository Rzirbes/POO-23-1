using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap1.domain.models;

namespace Ap1.domain.interfaces
{
    public interface IAppoimentRepository
    {
        MedicalAppoiment GetByIdMedicalAppoiment(int id);
        List<MedicalAppoiment> GetAllMedicalAppoiment();
        void AddMedicalAppoiment(MedicalAppoiment medicalAppoiment);
        void UpdateMedicalAppoiment(int id, MedicalAppoiment medicalAppoiment);
        void RemoveMedicalAppoiment(MedicalAppoiment medicalAppoiment);
    }
}
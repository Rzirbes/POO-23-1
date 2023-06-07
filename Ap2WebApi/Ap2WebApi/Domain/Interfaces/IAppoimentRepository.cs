using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2WebApi.Models.Entities;

namespace Ap2.Domain.Interfaces
{
    public interface IAppoimentRepository : IBaseRepository<MedicalAppoiment>
    {
        public bool CheckIfAppoimentExists(DateTime appoimentDate);
        
        // MedicalAppoiment GetByIdMedicalAppoiment(int id);
        // List<MedicalAppoiment> GetAllMedicalAppoiment();
        // void AddMedicalAppoiment(MedicalAppoiment medicalAppoiment);
        // void UpdateMedicalAppoiment(int id, MedicalAppoiment medicalAppoiment);
        // void RemoveMedicalAppoiment(MedicalAppoiment medicalAppoiment);
    }
}
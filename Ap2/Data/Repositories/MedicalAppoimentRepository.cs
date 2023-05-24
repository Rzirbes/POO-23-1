using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Domain.Entities;
using Ap2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ap2.Data.Repository
{
    public class MedicalAppoimentRepository : IAppoimentRepository
    {
        private readonly DataContext context;
        // private List<MedicalAppoiment> _medicalAppoimentList;

        public MedicalAppoimentRepository(DataContext context)
        {
            // _medicalAppoimentList = new List<MedicalAppoiment>();
            this.context = context;
        }

        public bool CheckIfAppoimentExists(DateTime appoimentDate)
        {
            var _medicalAppoimentList = GetAll();
            
            foreach (MedicalAppoiment ma in _medicalAppoimentList)
            {
                if(ma.AppoimentDate == appoimentDate)
                {
                    return true;
                }
            }
            return false;
        }

        public MedicalAppoiment GetById(int entityId)
        {
             return context.MedicalAppoiments.SingleOrDefault(x => x.Id == entityId);
        }

        public IList<MedicalAppoiment> GetAll()
        {
            return context.MedicalAppoiments.Include(x=>x.Doctor).Include(y=>y.Patient).ToList();
        }

        public void Save(MedicalAppoiment entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(MedicalAppoiment entityId)
        {
            context.Remove(entityId);
            context.SaveChanges();
            return true;
        }

        public void Update(int entityId, MedicalAppoiment entity)
        {

            context.MedicalAppoiments.Update(entity);
            context.SaveChanges();

            // MedicalAppoiment medicalAppoimentUpdate = _medicalAppoimentList.Find(d => d.Id == entityId)!;

            // if(medicalAppoimentUpdate != null)
            // {
            //     medicalAppoimentUpdate.AppoimentDate = entity.AppoimentDate;
            //     medicalAppoimentUpdate.Doctor = entity.Doctor;
            //     medicalAppoimentUpdate.Patient = entity.Patient;
            // }
        }
    }
}
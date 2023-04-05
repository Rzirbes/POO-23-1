using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCrudPessoa02.repository
{
    public class PeopleRepository
    {
        private List<People> _peopleList;

        public PeopleRepository()
        {
            _peopleList = new List<People>();
        }

        public void AddPeople(People people)
        {
            _peopleList.Add(people);
        }

        public List<People> GetAllPeople()
        {
            return _peopleList;
        }

        public void RemovePeople(int id)
        {
            _peopleList.RemoveAll(p => p.Id == id);
        }

        public People GetPeopleById(int id)
        {
            return _peopleList.Find(p => p.Id == id)!;
        }

        public void UpdatePeople(int id, People newPeople)
        {

            People peopleUpdate = _peopleList.Find(p => p.Id == id)!;

            if(peopleUpdate != null)
            {
                peopleUpdate.Name = newPeople.Name;
                peopleUpdate.Phone = newPeople.Phone;
                peopleUpdate.City = newPeople.City;
                peopleUpdate.Addresses = newPeople.Addresses;

            }           


        }


    }
}
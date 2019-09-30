using System.Collections.Generic;
using System.Linq;
using Aula08CrudPeopleEF.Models.Entities;
using Aula08CrudPeopleEF.Models.Interfaces;

namespace Aula08CrudPeopleEF.Models.Entities
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Person obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
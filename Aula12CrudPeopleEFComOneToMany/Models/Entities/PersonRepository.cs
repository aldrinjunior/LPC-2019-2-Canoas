using System.Collections.Generic;
using System.Linq;
using Aula08CrudPeopleEF.Models.Entities;
using Aula08CrudPeopleEF.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            context.People.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return context.People.Include(x=>x.city).ToList();
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
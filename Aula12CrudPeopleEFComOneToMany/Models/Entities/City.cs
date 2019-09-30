using System.Collections.Generic;
using Aula08CrudPeopleEF.Models.Entities;

namespace Aula12CrudPeopleEFComOneToMany.Models.Entities
{
    public class City
    {
        public City() {}


        public City(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public int id { get; set; }
        public string name { get; set; }
        public List<Person> people { get; set; }
    }
}
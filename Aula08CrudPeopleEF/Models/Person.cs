namespace Aula08CrudPeopleEF.Models
{
    public class Person
    {

        public Person(){}

        public Person(int id, string name, string address, string phone, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.age = age;

        }
        public int id { get; set; }
        public string name { get; set; }
        public string  address { get; set; }

        public string phone { get; set; }
        public int age { get; set; }

    }
}
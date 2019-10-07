namespace ToDoList.Domain
{
    public class ToDo
    {
        public ToDo(){}
        public ToDo(int id, string name, int priority, TypeToDo typeToDo)
        {
            this.id = id;
            this.name = name;
            this.priority = priority;
            this.TypeToDo = typeToDo;

        }
        public int id { get; set; }
        public string name { get; set; }
        public int priority { get; set; }

        public TypeToDo TypeToDo { get; set; }

    }
}
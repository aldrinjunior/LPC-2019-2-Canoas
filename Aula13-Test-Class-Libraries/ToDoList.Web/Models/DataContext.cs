using Microsoft.EntityFrameworkCore;

namespace ToDoList.Web.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
        {
        }

        public DbSet<ToDo> Todos { get; set; }
        
    }
}
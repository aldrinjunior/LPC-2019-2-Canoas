using Microsoft.EntityFrameworkCore;
using TarefasArnaldo.Domain;

namespace TarefasArnaldo.Repositories.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
            {

            }
        public DbSet<Task> TarefasArnaldo { get; set; }
    }
}
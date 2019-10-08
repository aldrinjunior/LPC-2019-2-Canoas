using System.Collections.Generic;

namespace TarefasArnaldo.Repositories.Interface
{
  public interface IBaseRepository<Entity> 
        where Entity : class
    {
        void Create(Entity task);
         void Update (Entity task);
         void Delete (int id);
         Entity GetById(int id);
         List<Entity> Getall();

    }
}
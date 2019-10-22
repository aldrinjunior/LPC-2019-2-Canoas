using System.Collections.Generic;
using System.Linq;
using restaurante.domain;
using restaurante.repository.Data;
using restaurante.repository.Interfaces;

namespace restaurante.repository.Repositories
{
    public class RestauranteRepository : IRestauranteRepository
    {

        DataContext context;

        public RestauranteRepository(DataContext context)
        {
            this.context= context;
        }
        public void Create(Restaurante obj)
        {
            context.Restaurantes.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Restaurante> GetAll()
        {
            return context.Restaurantes.ToList();
        }

        public Restaurante GetById(int id)
        {
            return context.Restaurantes.SingleOrDefault(x=>x.id == id);
        }

        public void Update(Restaurante obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
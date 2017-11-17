
using System.Collections.Generic;
using System.Linq;
using Financas.Domain;

namespace Financas.Repository.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly FinancasContext context;
        public CityRepository(FinancasContext context)
        {
            this.context = context;
        }

        public List<City> GetAll()
        {
            return context.Cities.ToList();
        }

        public City GetById(int id)
        {
            return context.Cities.Find(id);
        }
    }
}
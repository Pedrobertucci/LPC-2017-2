using System.Collections.Generic;
using Financas.Domain;

namespace Financas.Repository.Repositories
{
    public interface ICityRepository
    {
         List<City>GetAll();
         City GetById(int id);
    }
}
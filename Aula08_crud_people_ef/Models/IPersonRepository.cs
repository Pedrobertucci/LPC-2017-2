using System.Collections.Generic;
using crud_people.Models;

namespace Aula08_crud_people_ef.Models
{
    public interface IPersonRepository
    {
         void Create(Person person);
         void Update(Person person);
         void Delete(int id);
         List<Person>GetAll();
         Person GetById(int id);
    }
}
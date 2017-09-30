using System.Collections.Generic;
using System.Linq;
using Aula08_crud_people_ef.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_people.Models
{

    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
        public PersonRepository(DataContext context)
        {           
            this.context = context;
        }


        public void Create(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            context.People.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Person GetById(int id)
        {
            return context.People.SingleOrDefault(x=>x.id == id);
        }

        public List<Person> GetAll()
        {
            return context.People.ToList();
        }
    }
}
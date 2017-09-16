using System.Collections.Generic;

namespace crud_people.Models
{

    public class PersonRepository
    {

        public static List<Person> people = new List<Person>();
    
        public PersonRepository()
        {
            if(people.Count == 0)
                Fill();
        }

        public void Fill()
        {
            people.Add(new Person(1,"Alexandre", "rua x"));
            people.Add(new Person(1,"Raphael", "rua y"));
            people.Add(new Person(1,"Felipe", "rua z"));
        }
        public void Create(Person person)
        {
            people.Add(person);

        }
        public void Delete(int id)
        {
            
        }

        public void Update(Person person)
        {
        }

        public Person GetById(int id)
        {
            return null;
        }

        public List<Person> GetAll()
        {
            return people;
        }



    }
}
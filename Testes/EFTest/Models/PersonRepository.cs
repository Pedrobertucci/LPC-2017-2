using Microsoft.EntityFrameworkCore;
using EFTest.Models;

namespace EFTest.Models
{
    public class PersonRepository
    {      
        private readonly PersonContext _context;
        
        public PersonRepository(PersonContext context)
        {
               _context = context;
            
        }

        public void Create(Person person)
        {
            
            _context.People.Add(person);
            _context.SaveChanges();

        }
    }
}
using crud_people.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula08_crud_people_ef.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {            
        }

        public DbSet<Person> People { get; set; }

    }
}
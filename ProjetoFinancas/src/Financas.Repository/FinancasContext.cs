using System;
using Financas.Domain;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repository
{
    public class FinancasContext : DbContext 
    {
        public FinancasContext(DbContextOptions<FinancasContext> options)
            :base(options)
        {            
        }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<City> Cities {get;set;}
        public DbSet<Member> Members { get; set; }
    }
}

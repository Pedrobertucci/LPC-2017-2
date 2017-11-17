using System.Collections.Generic;
using System.Linq;
using Financas.Domain;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repository.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private FinancasContext context;
        public MemberRepository(FinancasContext context)
        {           
            this.context = context;
        }

        public void Create(Member member)
        {
            
            member.City = context.Cities.Find(member.City.Id);

            context.Members.Add(member);
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            context.Members.Remove(context.Members.Find(id));        
            context.SaveChanges();
        }

        public void Update(Member member)
        {
            context.Entry(member).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Member GetById(int id)
        {
            return context.Members.Include(x=>x.City).SingleOrDefault(x=>x.Id == id);
        }
        public List<Member> GetAll()
        {
            return context.Members.Include(x => x.City).ToList();
        }
    }
}
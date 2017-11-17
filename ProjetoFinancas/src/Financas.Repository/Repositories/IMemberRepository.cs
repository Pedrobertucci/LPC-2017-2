using System.Collections.Generic;
using Financas.Domain;

namespace Financas.Repository.Repositories
{
    public interface IMemberRepository
    {
         void Create(Member member);
         void Update(Member member);
         void Delete(int id);
         List<Member>GetAll();
         Member GetById(int id);
    }
}
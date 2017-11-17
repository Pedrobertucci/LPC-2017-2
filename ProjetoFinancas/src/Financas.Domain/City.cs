using System.Collections.Generic;

namespace Financas.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Member> Members { get; set; }
    }
}
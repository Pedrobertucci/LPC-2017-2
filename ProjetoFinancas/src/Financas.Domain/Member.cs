namespace Financas.Domain
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        
        public City City { get; set; }
        
    }
}
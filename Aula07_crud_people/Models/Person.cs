namespace crud_people.Models
{
    public class Person
    {
        public Person(int id, string name, string adress)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;

        }
        public int id { get; private set; }
        public string name { get; private set; }
        public string adress { get; private set; }

    }
}
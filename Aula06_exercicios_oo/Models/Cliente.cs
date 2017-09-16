namespace Aula06_exercicios_oo.Models
{
    public class Cliente
    {
        public int id { get; private set; }
        public string nome { get; private set;}

        public Cliente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

    }
}
namespace Aula06_oo.Models
{
    public abstract class Pessoa
    {        
       public string nome { get; private set; }
       public int idade { get; private set; }    
       
        public Pessoa(){}

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

       
        public virtual void Save(Pessoa pPessoa)
        {
              //salvar a pessoa no bd  
        }


    }
}
namespace Aula06_oo.Models
{
    public class Paciente : Pessoa
    {
        public int numeroPlanoSaude { get; set; }

        public Paciente(string pNome, 
                        int pIdade, 
                        int pNumeroPlanoSaude) 
                 : base(pNome, pIdade)
        {
            numeroPlanoSaude = pNumeroPlanoSaude;
        }

    }
}
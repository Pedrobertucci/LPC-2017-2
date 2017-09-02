namespace Aula06_oo.Models
{
    public class Medico : Pessoa
    {
        #region Atributos
        public string CRM { get; set; }

        #endregion

        #region Contrutores
    
        public Medico(string pNome, 
                      int pIdade,
                      string pCRM)
                : base(pNome, pIdade)
        {
            CRM = pCRM;
        }

        #endregion

        #region Metodos
        public override void Save(Pessoa pPessoa)
        {
            base.Save(pPessoa);
            //implementa para salvar o paciente
            

        }
            


        #endregion

        
    }
}
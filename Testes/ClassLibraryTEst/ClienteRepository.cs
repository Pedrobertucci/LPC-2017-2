using System.Collections.Generic;

namespace ClassLibraryTEst
{
    public class ClienteRepository
    {
        public List<Cliente>GetAll()
        {
            var lista = new List<Cliente> 
            { 
                new Cliente {id =1, Nome="Cassio"},
                new Cliente {id=2,Nome="joão"}
            };

            return lista;    
        }
    }
}
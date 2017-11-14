using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_people.Models
{
    public class PersonView_Model
    {        
        public int id { get; set; }
        [Required(ErrorMessage = "Preencher campo Nome")]
        public string name { get; set; }
        public string address { get; set; }

        public int age { get; set; }
    }
}

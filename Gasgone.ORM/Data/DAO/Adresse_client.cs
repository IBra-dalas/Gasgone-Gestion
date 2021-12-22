using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Data.DAO
{
    public class Adresse_client
    {
        public int Id { get; set; };
        public int CodePostal { get; set; };
        public int Numero { get; set; };
        public string Adresse { get; set; };
        public string Ville { get; set; };
        [ForeignKey("ClientID")]
        public Client client { get; set; };

    }
   
   
}

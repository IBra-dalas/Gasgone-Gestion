﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Data.DAO
{
    public class Commande
    {
        public int Id { get; set; };
        public DateTime DateCommande { get; set; };
        [ForeignKey("ClientID")]
        public Fournisseur Fournisseur { get; set; };

    }
}

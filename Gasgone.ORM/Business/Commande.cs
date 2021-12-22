using System;


namespace Gasgone.ORM.Business
{
    public class Commande
    {
        public int Id { get; set; };
        public DateTime DateCommande { get; set; };
        public Client client { get; set; };

    }
}
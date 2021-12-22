

namespace Gasgone.ORM.Business
{
    public class CommandeArticle
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public Article Article { get; set; }

    }
}

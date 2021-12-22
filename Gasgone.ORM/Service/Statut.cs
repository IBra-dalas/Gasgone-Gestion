using Gasgone.ORM.Data;
using Gasgone.ORM.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Service
{
    public class ServiceStatut
    {
        private readonly DataContext _bddContext;
        public ServiceStatut(DataContext _bdd)
        {
            _bddContext = _bdd;
        }

        public Statut Add(Statut model)
        {
            var entity = new Data.DAO.Statut { Libelle = model.Libelle };
            _ = _bddContext.Statut.Add(entity);
            _bddContext.SaveChanges();
            model.Id = entity.Id;
            return model;

        }

        public Statut Updated(Statut model)
        {
            var Statut = (from f in _bddContext.Statut
                               where f.Id == model.Id
                               select f
            ).FirstOrDefault();

            Statut.Libelle = model.Libelle;
            _bddContext.SaveChanges();
            return model;

        }

        public Statut Get(int id)
        {
            return (from f in _bddContext.Statut
                    where f.Id == id
                    select new Statut
                    {
                        Id = f.Id,
                        Libelle = f.Libelle,
                    }).FirstOrDefault();
        }
        public List<Statut> Get()
        {
            return (from f in _bddContext.Statut
                    select new Statut
                    {
                        Id = f.Id,
                        Libelle = f.Libelle,
                    }).ToList();



        }
    }
}

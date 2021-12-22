﻿using Gasgone.ORM.Data;
using Gasgone.ORM.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Service
{
    public class ServiceFournisseur
    {
        private readonly DataContext _bddContext;
        public ServiceFournisseur(DataContext _bdd)
        {
            _bddContext = _bdd;
        }

        public Fournisseur Add(Fournisseur model)
        {
            var entity = new Data.DAO.Fournisseur { Designation = model.Designation, Numero = model.Numero, Mail = model.Mail };
            _ = _bddContext.Fournisseur.Add(entity);
            _bddContext.SaveChanges();
            model.Id = entity.Id;
            return model;

        }

        public Fournisseur Updated(Fournisseur model)
        {
            var Fournisseur = (from f in _bddContext.Fournisseur
                               where f.Id == model.Id
                               select f
            ).FirstOrDefault();

            Fournisseur.Designation = model.Designation;
            Fournisseur.Numero = model.Numero;
            Fournisseur.Mail = model.Mail;
            _bddContext.SaveChanges();
            return model;

        }

        public Fournisseur Get(int id)
        {
            return (from f in _bddContext.Fournisseur
                    where f.Id == id
                    select new Fournisseur
                    {
                        Id = f.Id,
                        Designation = f.Designation,
                        Numero = f.Numero,
                        Mail = f.Mail
                    }).FirstOrDefault();
        }
        public List<Fournisseur> Get()
        {
            return (from f in _bddContext.Fournisseur
                    select new Fournisseur
                    {
                        Id = f.Id,
                        Designation = f.Designation,
                        Numero = f.Numero,
                        Mail = f.Mail
                    }).ToList();



        }
    }
}

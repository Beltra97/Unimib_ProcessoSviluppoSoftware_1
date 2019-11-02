using IntranetDAL.Models;
using IntranetDAL.Requests;
using IntranetDAL.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntranetDAL.DMControllers
{
    public class DipendenteDMController
    {
        public int Add(RequestAddDipendente request)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var d = new Dipendente()
                    {
                        Cognome = request.Cognome,
                        Nome = request.Nome,
                        Username = request.Username,
                        Psw = request.Psw,
                        Idruolo = request.IDRuolo
                    };
                    db.Dipendente.Add(d);
                    db.SaveChanges();
                    return d.Id;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public List<ResponseGetDipendenti> Get()
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    return db.Dipendente.Select(x => new ResponseGetDipendenti()
                    {
                        Id = x.Id,
                        Cognome = x.Cognome,
                        Nome = x.Nome,
                        Username = x.Username,
                        Ruolo = x.IdruoloNavigation.Nome
                    })
                    .OrderByDescending(x => x.Cognome).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Dipendente GetByID(int idDipendente)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var item = db.Dipendente.Where(x => x.Id == idDipendente).FirstOrDefault();

                    if (item != null)
                        return item;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }


        public bool Update(int idDipendente, RequestAddDipendente request)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var item = db.Dipendente.SingleOrDefault(x => x.Id == idDipendente);
                    if (item != null)
                    {
                        item.Cognome = request.Cognome;
                        item.Nome = request.Nome;
                        item.Username = request.Username;
                        item.Psw = request.Psw;
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public bool Delete(int idDipendente)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var user = db.Dipendente.SingleOrDefault(x => x.Id == idDipendente);

                    if (user != null)
                    {
                        db.Dipendente.Remove(user);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}
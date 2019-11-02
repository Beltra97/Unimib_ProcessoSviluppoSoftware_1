using IntranetDAL.Models;
using IntranetDAL.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntranetDAL.DMControllers
{
    public class ConvenzioneDMController
    {
        public int Add(RequestAddConvenzione request)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var c = new Convenzione()
                    {
                        Titolo = request.Titolo,
                        Descrizione = request.Descrizione,
                    };
                    db.Add(c);
                    db.SaveChanges();
                    return c.Id;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public Convenzione GetByID(int idConvenzione)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var item = db.Convenzione.SingleOrDefault(x => x.Id == idConvenzione);
                    if (item != null)
                        return item;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public List<Convenzione> Get()
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    return db.Convenzione.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(int idConvenzione, RequestAddConvenzione request)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var item = db.Convenzione.SingleOrDefault(x => x.Id == idConvenzione);
                    if (item != null)
                    {
                        item.Titolo = request.Titolo;
                        item.Descrizione = request.Descrizione;
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public bool Delete(int idConvenzione)
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    var item = db.Convenzione.SingleOrDefault(x => x.Id == idConvenzione);
                    if (item != null)
                    {
                        db.Convenzione.Remove(item);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}

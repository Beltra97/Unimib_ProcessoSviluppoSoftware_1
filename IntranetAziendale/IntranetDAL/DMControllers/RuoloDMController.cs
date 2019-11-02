using IntranetDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntranetDAL.DMControllers
{
    public class RuoloDMController
    {
        public List<Ruolo> Get()
        {
            try
            {
                using (var db = new aziendaContext())
                {
                    return db.Ruolo.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace IntranetDAL.Models
{
    public partial class Ruolo
    {
        public Ruolo()
        {
            Dipendente = new HashSet<Dipendente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Dipendente> Dipendente { get; set; }
    }
}

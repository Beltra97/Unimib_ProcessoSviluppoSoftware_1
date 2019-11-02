using System;
using System.Collections.Generic;

namespace IntranetDAL.Models
{
    public partial class Dipendente
    {
        public int Id { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Psw { get; set; }
        public int Idruolo { get; set; }

        public virtual Ruolo IdruoloNavigation { get; set; }
    }
}

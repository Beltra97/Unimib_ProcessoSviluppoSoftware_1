using System;

namespace IntranetDAL.Requests
{
    public class RequestAddDipendente
    {
        public string Cognome { get; set; }

        public string Nome { get; set; }

        public string Username { get; set; }

        public string Psw { get; set; }

        public int IDRuolo { get; set; }
    }
}

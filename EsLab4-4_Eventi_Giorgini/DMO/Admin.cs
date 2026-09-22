using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Admin : Utente
    {
        public Admin() : base()
        {
        }

        public Admin(int id, string nome, string cognome, string username, string password)
            : base(id, nome, cognome, username, password)
        {
        }

        public Admin(string nome, string cognome, string username, string password)
            : base(nome, cognome, username, password)
        {
        }
    }
}
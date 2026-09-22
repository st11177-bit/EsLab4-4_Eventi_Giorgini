using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public abstract class Utente
    {
        private int _id;
        private string _nome;
        private string _cognome;
        private string _username;
        private string _password;

        public int ID { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        protected Utente()
        {
        }

        protected Utente(int id, string nome, string cognome, string username, string password)
        {
            ID = id;
            Nome = nome;
            Cognome = cognome;
            Username = username;
            Password = password;
        }

        protected Utente(string nome, string cognome, string username, string password)
        {
            Nome = nome;
            Cognome = cognome;
            Username = username;
            Password = password;
        }
    }
}
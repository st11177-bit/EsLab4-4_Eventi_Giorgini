using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Studente : Utente
    {
        private string _matricola;
        private bool _rappresentanteClasse;
        private bool _rappresentanteIstituto;
        private string _classeID;

        public string Matricola { get => _matricola; set => _matricola = value; }
        public bool RappresentanteClasse { get => _rappresentanteClasse; set => _rappresentanteClasse = value; }
        public bool RappresentanteIstituto { get => _rappresentanteIstituto; set => _rappresentanteIstituto = value; }
        public string ClasseID { get => _classeID; set => _classeID = value; }

        public Studente() : base()
        {
        }

        public Studente(int id, string nome, string cognome, string username, string password, string matricola, bool rappresentanteClasse, bool rappresentanteIstituto, string classeID)
            : base(id, nome, cognome, username, password)
        {
            Matricola = matricola;
            RappresentanteClasse = rappresentanteClasse;
            RappresentanteIstituto = rappresentanteIstituto;
            ClasseID = classeID;
        }

        public Studente(string nome, string cognome, string username, string password, string matricola, bool rappresentanteClasse, bool rappresentanteIstituto, string classeID)
            : base(nome, cognome, username, password)
        {
            Matricola = matricola;
            RappresentanteClasse = rappresentanteClasse;
            RappresentanteIstituto = rappresentanteIstituto;
            ClasseID = classeID;
        }
    }
}
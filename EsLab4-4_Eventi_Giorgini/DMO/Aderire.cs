using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Aderire
    {
        private int _idAderire;
        private bool _iscritto;
        private bool _autorizzato;
        private bool _pagato;
        private bool _partecipato;
        private int _attivitaID;
        private string _classeID;
        private int _studenteID;

        public int IDAderire { get => _idAderire; set => _idAderire = value; }
        public bool Iscritto { get => _iscritto; set => _iscritto = value; }
        public bool Autorizzato { get => _autorizzato; set => _autorizzato = value; }
        public bool Pagato { get => _pagato; set => _pagato = value; }
        public bool Partecipato { get => _partecipato; set => _partecipato = value; }
        public int AttivitaID { get => _attivitaID; set => _attivitaID = value; }
        public string ClasseID { get => _classeID; set => _classeID = value; }
        public int StudenteID { get => _studenteID; set => _studenteID = value; }

        public Aderire()
        {
        }

        public Aderire(int idAderire, bool iscritto, bool autorizzato, bool pagato, bool partecipato, int attivitaID, string classeID, int studenteID)
        {
            IDAderire = idAderire;
            Iscritto = iscritto;
            Autorizzato = autorizzato;
            Pagato = pagato;
            Partecipato = partecipato;
            AttivitaID = attivitaID;
            ClasseID = classeID;
            StudenteID = studenteID;
        }

        public Aderire(bool iscritto, bool autorizzato, bool pagato, bool partecipato, int attivitaID, string classeID, int studenteID)
        {
            Iscritto = iscritto;
            Autorizzato = autorizzato;
            Pagato = pagato;
            Partecipato = partecipato;
            AttivitaID = attivitaID;
            ClasseID = classeID;
            StudenteID = studenteID;
        }
    }
}
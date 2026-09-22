using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Evento
    {
        private int _id;
        private string _nome;
        private string _descrizione;
        private DateTime _dal;
        private DateTime _al;
        private int _adminID;


        public int ID { get => _id; set => _id = value; }
        public string Nome { get =>_nome; set=>_nome=value; }
        public string Descrizione { get=>_descrizione; set=>_descrizione=value; }
        public DateTime Dal { get=>_dal; set=>_dal=value; }
        public DateTime Al { get=>_al; set=>_al=value; }
        public int AdminID { get=>_adminID; set => _adminID=value; }

        public Evento()
        {
        }

        public Evento(int id, string nome, string descrizione, DateTime dal, DateTime al, int adminID)
        {
            ID = id;
            Nome = nome;
            Descrizione = descrizione;
            Dal = dal;
            Al = al;
            AdminID = adminID;
        }

        public Evento(string nome, string descrizione, DateTime dal, DateTime al, int adminID)
        {
            Nome = nome;
            Descrizione = descrizione;
            Dal = dal;
            Al = al;
            AdminID = adminID;
        }
    }
}
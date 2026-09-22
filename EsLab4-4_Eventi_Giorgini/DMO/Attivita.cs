using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Attivita
    {
        private int _id;
        private string _titolo;
        private string _testo;
        private byte _ordine;
        private DateTime _dalle;
        private DateTime _alle;
        private int _eventoID;

        public int ID { get => _id; set => _id = value; }
        public string Titolo { get => _titolo; set => _titolo = value; }
        public string Testo { get => _testo; set => _testo = value; }
        public byte Ordine { get => _ordine; set => _ordine = value; }
        public DateTime Dalle { get => _dalle; set => _dalle = value; }
        public DateTime Alle { get => _alle; set => _alle = value; }
        public int EventoID { get => _eventoID; set => _eventoID = value; }

        public Attivita()
        {
        }

        public Attivita(int id, string titolo, string testo, byte ordine, DateTime dalle, DateTime alle, int eventoID)
        {
            ID = id;
            Titolo = titolo;
            Testo = testo;
            Ordine = ordine;
            Dalle = dalle;
            Alle = alle;
            EventoID = eventoID;
        }

        public Attivita(string titolo, string testo, byte ordine, DateTime dalle, DateTime alle, int eventoID)
        {
            Titolo = titolo;
            Testo = testo;
            Ordine = ordine;
            Dalle = dalle;
            Alle = alle;
            EventoID = eventoID;
        }
    }
}
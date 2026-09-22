using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Classe
    {
        private string _sigla;
        private string _aula;
        private byte _anno;
        private string _sezione;
        private int _indirizzoID;

        public string Sigla { get => _sigla; set => _sigla = value; }
        public string Aula { get => _aula; set => _aula = value; }
        public byte Anno { get => _anno; set => _anno = value; }
        public string Sezione { get => _sezione; set => _sezione = value; }
        public int IndirizzoID { get => _indirizzoID; set => _indirizzoID = value; }

        public Classe()
        {
        }

        public Classe(string sigla, string aula, byte anno, string sezione, int indirizzoID)
        {
            Sigla = sigla;
            Aula = aula;
            Anno = anno;
            Sezione = sezione;
            IndirizzoID = indirizzoID;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLab4_4_Eventi_Giorgini
{
    public class Indirizzo
    {
        private int _id;
        private string _nome;

        public int ID { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Indirizzo()
        {
        }

        public Indirizzo(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }

        public Indirizzo(string nome)
        {
            Nome = nome;
        }
    }
}
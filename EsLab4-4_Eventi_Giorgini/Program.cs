using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySqlConnector;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        public static string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public static MySqlConnection _conn = new MySqlConnector.MySqlConnection(_connectionString);

        public static Admin _admin = null;

        public static Studente _studente = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAccesso());

            
        }
    }
}

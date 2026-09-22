using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLab4_4_Eventi_Giorgini
{
    public partial class FrmAdesioni : Form
    {
        Attivita _attivita;

        List<Aderire> _adesioniStudenti;
        List<Aderire> _adesioniClassi;

        public FrmAdesioni(Attivita attivita)
        {
            InitializeComponent();
            _attivita = attivita;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            
        }

        private void PopulaAdesioniStudenti(List<Aderire> adesioni)
        {
            lvStudenti.Items.Clear();
            foreach (Aderire adesione in adesioni)
            {
                Studente _studente = StudenteBL.GetOne(ref Program._conn, adesione.StudenteID, out string errore);
                ListViewItem item = new ListViewItem(_studente.Nome);
                item.SubItems.Add(_studente.Cognome);
                item.SubItems.Add(_studente.Matricola);
                item.SubItems.Add(adesione.Autorizzato ? "Sì" : "No");
                item.SubItems.Add(adesione.Pagato ? "Sì" : "No");
                item.SubItems.Add(adesione.Partecipato ? "Sì" : "No");
                item.Tag = adesione;
                lvStudenti.Items.Add(item);
            }
        }

        private void PopulaAdesioniClassi(List<Aderire> adesioni)
        {
            lvClassi.Items.Clear();
            foreach (Aderire adesione in adesioni)
            {
                Classe _classe = ClasseBL.GetOne(ref Program._conn, adesione.ClasseID, out string errore);
                ListViewItem item = new ListViewItem(_classe.Sigla);
                item.SubItems.Add(_classe.Aula);
                item.SubItems.Add(_classe.Sezione);
                item.SubItems.Add(adesione.Autorizzato ? "Sì" : "No");
                item.SubItems.Add(adesione.Pagato ? "Sì" : "No");
                item.SubItems.Add(adesione.Partecipato ? "Sì" : "No");
                item.Tag = adesione;
                lvClassi.Items.Add(item);
            }
        }

        private void FrmAdesioni_Load(object sender, EventArgs e)
        {
            _adesioniClassi = AderireBL.GetAllByAttivitaIDClasse(ref Program._conn, , _attivita.ID, out string errore);
            _adesioniStudenti = AderireBL.GetAllByAttivitaIDStudenti(ref Program._conn, _attivita.ID, out errore);
            PopulaAdesioniClassi(_adesioniClassi);
            PopulaAdesioniStudenti(_adesioniStudenti);
        }
    }


    }

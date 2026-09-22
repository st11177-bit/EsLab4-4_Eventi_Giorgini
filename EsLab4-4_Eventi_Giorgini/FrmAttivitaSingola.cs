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
    public partial class FrmAttivitaSingola : Form
    {
        Attivita _attivita;
        public FrmAttivitaSingola(Attivita attivita)
        {
            InitializeComponent();
            _attivita = attivita;
            if(attivita != null)
            {
                tbTitolo.Text = _attivita.Titolo;
                rtbTesto.Text = _attivita.Testo;
                dtpDal.Value = _attivita.Dalle;
                dtpAl.Value = _attivita.Alle;
            }
            
        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
            Attivita _attivitaProvvisoria = new Attivita();
            _attivitaProvvisoria.Titolo = tbTitolo.Text;
            _attivitaProvvisoria.Testo = rtbTesto.Text;
            _attivitaProvvisoria.Dalle = dtpDal.Value;
            _attivitaProvvisoria.Alle = dtpAl.Value;
            if (_attivita != null)
                AttivitaBL.Edit(ref Program._conn, _attivitaProvvisoria, _attivita.ID, out string errore);
            else
                AttivitaBL.Create(ref Program._conn, _attivitaProvvisoria, out string errore);

            Close();

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVisualizzaAdesioni_Click(object sender, EventArgs e)
        {
            FrmAdesioni frmAdesioni = new FrmAdesioni(_attivita);
            frmAdesioni.ShowDialog();
        }
    }
}

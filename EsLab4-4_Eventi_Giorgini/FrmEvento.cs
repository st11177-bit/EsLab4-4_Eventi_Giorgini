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
    public partial class FrmEvento : Form
    {
        Evento _evento;
        List<Attivita> _attivitaList;           
        public FrmEvento(Evento evento=null)
        {
            InitializeComponent();
            _evento = evento;

           if(_evento != null)
           {
                tbNome.Text = _evento.Nome;
                rtbDescrizione.Text = _evento.Descrizione;
                dtpDal.Value = _evento.Dal;
                dtpAl.Value = _evento.Al;
           }

            if (Program._admin==null)
            {
                btnIscriviti.Visible = true;
                btnIscriviClasse.Visible = true;

                btnCrea.Visible = false;
                btnModifica.Visible = false;
                btnElimina.Visible = false;
            }

        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
            Evento _eventoProvvisorio=new Evento();
            _eventoProvvisorio.Nome = tbNome.Text;
            _eventoProvvisorio.Descrizione = rtbDescrizione.Text;
            _eventoProvvisorio.Dal = dtpDal.Value;
            _eventoProvvisorio.Al = dtpAl.Value;
            if (_evento != null)
                EventoBL.Edit(ref Program._conn, _eventoProvvisorio, _evento.ID, out string errore);
            else
                EventoBL.Create(ref Program._conn, _eventoProvvisorio, out string errore);

            Close();

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
            _attivitaList=AttivitaBL.GetAllByEvento(ref Program._conn, _evento.ID, out string errore);
            PopulaListView(_attivitaList);
        }

        private void btnIscriviti_Click(object sender, EventArgs e)
        {
            Aderire _adesione = new Aderire(true, false, false, false, ((Evento)lvAttivita.SelectedItems[0].Tag).ID, null, Program._studente.ID);
            AderireBL.Create(ref Program._conn, _adesione, out string errore);
        }

        private void btnIscriviClasse_Click(object sender, EventArgs e)
        {
            if (Program._studente.RappresentanteClasse)
            {
                Aderire _adesione = new Aderire(true, false, false, false, ((Evento)lvAttivita.SelectedItems[0].Tag).ID, Program._studente.ClasseID, -1);
                AderireBL.Create(ref Program._conn, _adesione, out string errore);
            }
        }

        private void PopulaListView(List<Attivita> attivita)
        {
            lvAttivita.Items.Clear();
            foreach (Attivita att in attivita)
            {
                ListViewItem item = new ListViewItem(att.ID.ToString());
                item.SubItems.Add(att.Titolo);
                item.SubItems.Add(att.Testo);
                item.SubItems.Add(att.Dalle.ToString("dd/MM/yyyy"));
                item.SubItems.Add(att.Alle.ToString("dd/MM/yyyy"));
                item.Tag = att;
                lvAttivita.Items.Add(item);
            }
        }
        }
}

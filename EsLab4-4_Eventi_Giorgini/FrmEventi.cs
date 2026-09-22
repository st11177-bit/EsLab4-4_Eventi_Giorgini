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
    public partial class FrmEventi : Form
    {
        List<Evento> _eventi = new List<Evento>();

        public FrmEventi()
        {

            InitializeComponent();
            
        }

        private void PopulaListView(List<Evento> eventi)
        {
            lvEventi.Items.Clear();
            foreach (Evento ev in eventi)
            {
                ListViewItem item = new ListViewItem(ev.ID.ToString());
                item.SubItems.Add(ev.Nome);
                item.SubItems.Add(ev.Descrizione);
                item.SubItems.Add(ev.Dal.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ev.Al.ToString("dd/MM/yyyy"));
                item.Tag = ev;
                lvEventi.Items.Add(item);
            }
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            FrmEvento frmEvento = new FrmEvento();
            frmEvento.ShowDialog();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            DialogResult d= MessageBox.Show("Sei sicuro di voler eliminare l'evento selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d==DialogResult.Yes)
            {
                EventoBL.Delete(ref Program._conn, ((Evento)lvEventi.SelectedItems[0].Tag).ID, out string errore);
            }
        }

        private void btnIscriviti_Click(object sender, EventArgs e)
        {

        }

        private void FrmEventi_Load(object sender, EventArgs e)
        {
            _eventi = EventoBL.GetAll(ref Program._conn, out string errore);
            PopulaListView(_eventi);
        }
    }
}
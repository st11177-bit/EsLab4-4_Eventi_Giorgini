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
    public partial class FrmAccesso : Form
    {
        public FrmAccesso()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(AdminBL.Accedi(ref Program._conn, tbEmail.Text, tbPassword.Text))
            {
                
            }
            else
            {   
                if (StudenteBL.Accedi(ref Program._conn, tbEmail.Text, tbPassword.Text))
                {
                    
                }
                else
                {
                    MessageBox.Show("Credenziali non valide.");
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }
    }
}

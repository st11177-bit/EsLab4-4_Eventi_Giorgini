namespace EsLab4_4_Eventi_Giorgini
{
    partial class FrmAdesioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.lvClassi = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvStudenti
            // 
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStudenti.FullRowSelect = true;
            this.lvStudenti.GridLines = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(37, 26);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(1269, 247);
            this.lvStudenti.TabIndex = 1;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            // 
            // lvClassi
            // 
            this.lvClassi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader10,
            this.columnHeader4,
            this.columnHeader12,
            this.columnHeader13});
            this.lvClassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClassi.FullRowSelect = true;
            this.lvClassi.GridLines = true;
            this.lvClassi.HideSelection = false;
            this.lvClassi.Location = new System.Drawing.Point(37, 338);
            this.lvClassi.Name = "lvClassi";
            this.lvClassi.Size = new System.Drawing.Size(1269, 213);
            this.lvClassi.TabIndex = 2;
            this.lvClassi.UseCompatibleStateImageBehavior = false;
            this.lvClassi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nome";
            this.columnHeader5.Width = 199;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cognome";
            this.columnHeader6.Width = 203;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Matricola";
            this.columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Classe";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sigla";
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 1;
            this.columnHeader10.Text = "Aula";
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 2;
            this.columnHeader11.Text = "Sezione";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "autorizzato";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "pagato";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "iscritto";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "autorizzato";
            this.columnHeader4.Width = 171;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "pagato";
            this.columnHeader12.Width = 177;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "iscritto";
            this.columnHeader13.Width = 151;
            // 
            // FrmAdesioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 585);
            this.Controls.Add(this.lvClassi);
            this.Controls.Add(this.lvStudenti);
            this.Name = "FrmAdesioni";
            this.Text = "FrmAdesioni";
            this.Load += new System.EventHandler(this.FrmAdesioni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ListView lvClassi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}
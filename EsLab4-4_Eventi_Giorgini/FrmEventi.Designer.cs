namespace EsLab4_4_Eventi_Giorgini
{
    partial class FrmEventi
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
            this.lvEventi = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEventi
            // 
            this.lvEventi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderDescrizione,
            this.columnHeaderDal,
            this.columnHeaderAl});
            this.lvEventi.FullRowSelect = true;
            this.lvEventi.GridLines = true;
            this.lvEventi.HideSelection = false;
            this.lvEventi.Location = new System.Drawing.Point(40, 65);
            this.lvEventi.Name = "lvEventi";
            this.lvEventi.Size = new System.Drawing.Size(534, 478);
            this.lvEventi.TabIndex = 0;
            this.lvEventi.UseCompatibleStateImageBehavior = false;
            this.lvEventi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 150;
            // 
            // columnHeaderDescrizione
            // 
            this.columnHeaderDescrizione.Text = "Descrizione";
            this.columnHeaderDescrizione.Width = 220;
            // 
            // columnHeaderDal
            // 
            this.columnHeaderDal.Text = "Dal";
            this.columnHeaderDal.Width = 80;
            // 
            // columnHeaderAl
            // 
            this.columnHeaderAl.Text = "Al";
            this.columnHeaderAl.Width = 80;
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(607, 284);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(122, 34);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCrea
            // 
            this.btnCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrea.Location = new System.Drawing.Point(607, 232);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(122, 34);
            this.btnCrea.TabIndex = 3;
            this.btnCrea.Text = "Crea";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(607, 337);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(122, 34);
            this.btnElimina.TabIndex = 5;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // FrmEventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 589);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.lvEventi);
            this.Name = "FrmEventi";
            this.Text = "FrmEventi";
            this.Load += new System.EventHandler(this.FrmEventi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEventi;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderDescrizione;
        private System.Windows.Forms.ColumnHeader columnHeaderDal;
        private System.Windows.Forms.ColumnHeader columnHeaderAl;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnElimina;
    }
}
namespace EsLab4_4_Eventi_Giorgini
{
    partial class FrmEvento
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.rtbDescrizione = new System.Windows.Forms.RichTextBox();
            this.dtpDal = new System.Windows.Forms.DateTimePicker();
            this.dtpAl = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnContinua = new System.Windows.Forms.Button();
            this.lvAttivita = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnIscriviClasse = new System.Windows.Forms.Button();
            this.btnIscriviti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(36, 48);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(289, 26);
            this.tbNome.TabIndex = 0;
            // 
            // rtbDescrizione
            // 
            this.rtbDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescrizione.Location = new System.Drawing.Point(36, 136);
            this.rtbDescrizione.Name = "rtbDescrizione";
            this.rtbDescrizione.Size = new System.Drawing.Size(289, 96);
            this.rtbDescrizione.TabIndex = 1;
            this.rtbDescrizione.Text = "";
            // 
            // dtpDal
            // 
            this.dtpDal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDal.Location = new System.Drawing.Point(36, 302);
            this.dtpDal.Name = "dtpDal";
            this.dtpDal.Size = new System.Drawing.Size(289, 26);
            this.dtpDal.TabIndex = 2;
            // 
            // dtpAl
            // 
            this.dtpAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAl.Location = new System.Drawing.Point(36, 389);
            this.dtpAl.Name = "dtpAl";
            this.dtpAl.Size = new System.Drawing.Size(289, 26);
            this.dtpAl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Al";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dal";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(190, 449);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(122, 47);
            this.btnAnnulla.TabIndex = 9;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Visible = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnContinua
            // 
            this.btnContinua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.Location = new System.Drawing.Point(36, 449);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(122, 47);
            this.btnContinua.TabIndex = 8;
            this.btnContinua.Text = "Continua";
            this.btnContinua.UseVisualStyleBackColor = true;
            this.btnContinua.Visible = false;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            // 
            // lvAttivita
            // 
            this.lvAttivita.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderDescrizione,
            this.columnHeaderDal,
            this.columnHeaderAl});
            this.lvAttivita.FullRowSelect = true;
            this.lvAttivita.GridLines = true;
            this.lvAttivita.HideSelection = false;
            this.lvAttivita.Location = new System.Drawing.Point(408, 59);
            this.lvAttivita.Name = "lvAttivita";
            this.lvAttivita.Size = new System.Drawing.Size(534, 478);
            this.lvAttivita.TabIndex = 10;
            this.lvAttivita.UseCompatibleStateImageBehavior = false;
            this.lvAttivita.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Titolo";
            this.columnHeaderNome.Width = 150;
            // 
            // columnHeaderDescrizione
            // 
            this.columnHeaderDescrizione.Text = "Testo";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attività";
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(1003, 407);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(122, 34);
            this.btnElimina.TabIndex = 14;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(1003, 354);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(122, 34);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCrea
            // 
            this.btnCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrea.Location = new System.Drawing.Point(1003, 302);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(122, 34);
            this.btnCrea.TabIndex = 12;
            this.btnCrea.Text = "Crea";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnIscriviClasse
            // 
            this.btnIscriviClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIscriviClasse.Location = new System.Drawing.Point(1003, 216);
            this.btnIscriviClasse.Name = "btnIscriviClasse";
            this.btnIscriviClasse.Size = new System.Drawing.Size(122, 34);
            this.btnIscriviClasse.TabIndex = 16;
            this.btnIscriviClasse.Text = "IscriviClasse";
            this.btnIscriviClasse.UseVisualStyleBackColor = true;
            this.btnIscriviClasse.Visible = false;
            this.btnIscriviClasse.Click += new System.EventHandler(this.btnIscriviClasse_Click);
            // 
            // btnIscriviti
            // 
            this.btnIscriviti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIscriviti.Location = new System.Drawing.Point(1003, 164);
            this.btnIscriviti.Name = "btnIscriviti";
            this.btnIscriviti.Size = new System.Drawing.Size(122, 34);
            this.btnIscriviti.TabIndex = 15;
            this.btnIscriviti.Text = "Iscriviti";
            this.btnIscriviti.UseVisualStyleBackColor = true;
            this.btnIscriviti.Visible = false;
            this.btnIscriviti.Click += new System.EventHandler(this.btnIscriviti_Click);
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 586);
            this.Controls.Add(this.btnIscriviClasse);
            this.Controls.Add(this.btnIscriviti);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvAttivita);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnContinua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAl);
            this.Controls.Add(this.dtpDal);
            this.Controls.Add(this.rtbDescrizione);
            this.Controls.Add(this.tbNome);
            this.Name = "FrmEvento";
            this.Text = "FrmEvento";
            this.Load += new System.EventHandler(this.FrmEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.RichTextBox rtbDescrizione;
        private System.Windows.Forms.DateTimePicker dtpDal;
        private System.Windows.Forms.DateTimePicker dtpAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnContinua;
        private System.Windows.Forms.ListView lvAttivita;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderDescrizione;
        private System.Windows.Forms.ColumnHeader columnHeaderDal;
        private System.Windows.Forms.ColumnHeader columnHeaderAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnIscriviClasse;
        private System.Windows.Forms.Button btnIscriviti;
    }
}
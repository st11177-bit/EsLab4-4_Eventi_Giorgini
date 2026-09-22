namespace EsLab4_4_Eventi_Giorgini
{
    partial class FrmAttivitaSingola
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
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnContinua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAl = new System.Windows.Forms.DateTimePicker();
            this.dtpDal = new System.Windows.Forms.DateTimePicker();
            this.rtbTesto = new System.Windows.Forms.RichTextBox();
            this.tbTitolo = new System.Windows.Forms.TextBox();
            this.btnVisualizzaAdesioni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(224, 467);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(122, 47);
            this.btnAnnulla.TabIndex = 19;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Visible = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnContinua
            // 
            this.btnContinua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.Location = new System.Drawing.Point(70, 467);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(122, 47);
            this.btnContinua.TabIndex = 18;
            this.btnContinua.Text = "Continua";
            this.btnContinua.UseVisualStyleBackColor = true;
            this.btnContinua.Visible = false;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Al";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Testo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Titolo";
            // 
            // dtpAl
            // 
            this.dtpAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAl.Location = new System.Drawing.Point(70, 407);
            this.dtpAl.Name = "dtpAl";
            this.dtpAl.Size = new System.Drawing.Size(289, 26);
            this.dtpAl.TabIndex = 13;
            // 
            // dtpDal
            // 
            this.dtpDal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDal.Location = new System.Drawing.Point(70, 320);
            this.dtpDal.Name = "dtpDal";
            this.dtpDal.Size = new System.Drawing.Size(289, 26);
            this.dtpDal.TabIndex = 12;
            // 
            // rtbTesto
            // 
            this.rtbTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTesto.Location = new System.Drawing.Point(70, 154);
            this.rtbTesto.Name = "rtbTesto";
            this.rtbTesto.Size = new System.Drawing.Size(289, 96);
            this.rtbTesto.TabIndex = 11;
            this.rtbTesto.Text = "";
            // 
            // tbTitolo
            // 
            this.tbTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitolo.Location = new System.Drawing.Point(70, 66);
            this.tbTitolo.Name = "tbTitolo";
            this.tbTitolo.Size = new System.Drawing.Size(289, 26);
            this.tbTitolo.TabIndex = 10;
            // 
            // btnVisualizzaAdesioni
            // 
            this.btnVisualizzaAdesioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaAdesioni.Location = new System.Drawing.Point(118, 530);
            this.btnVisualizzaAdesioni.Name = "btnVisualizzaAdesioni";
            this.btnVisualizzaAdesioni.Size = new System.Drawing.Size(187, 51);
            this.btnVisualizzaAdesioni.TabIndex = 20;
            this.btnVisualizzaAdesioni.Text = "Visualizza Adesioni";
            this.btnVisualizzaAdesioni.UseVisualStyleBackColor = true;
            this.btnVisualizzaAdesioni.Visible = false;
            this.btnVisualizzaAdesioni.Click += new System.EventHandler(this.btnVisualizzaAdesioni_Click);
            // 
            // FrmAttivitaSingola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 593);
            this.Controls.Add(this.btnVisualizzaAdesioni);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnContinua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAl);
            this.Controls.Add(this.dtpDal);
            this.Controls.Add(this.rtbTesto);
            this.Controls.Add(this.tbTitolo);
            this.Name = "FrmAttivitaSingola";
            this.Text = "FrmAttivitaSingola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnContinua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAl;
        private System.Windows.Forms.DateTimePicker dtpDal;
        private System.Windows.Forms.RichTextBox rtbTesto;
        private System.Windows.Forms.TextBox tbTitolo;
        private System.Windows.Forms.Button btnVisualizzaAdesioni;
    }
}
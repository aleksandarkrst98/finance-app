namespace View
{
    partial class FormAddTransaction
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
            this.cmbTipoviTransackije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajTransakciju = new System.Windows.Forms.Button();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoviTransackije
            // 
            this.cmbTipoviTransackije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoviTransackije.FormattingEnabled = true;
            this.cmbTipoviTransackije.Location = new System.Drawing.Point(179, 215);
            this.cmbTipoviTransackije.Name = "cmbTipoviTransackije";
            this.cmbTipoviTransackije.Size = new System.Drawing.Size(250, 24);
            this.cmbTipoviTransackije.TabIndex = 28;
            this.cmbTipoviTransackije.Text = "Trošak";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tip transakcije:";
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Location = new System.Drawing.Point(179, 166);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(250, 22);
            this.txtDatum.TabIndex = 26;
            this.txtDatum.Text = "02.02.2022.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Datum:";
            // 
            // btnDodajTransakciju
            // 
            this.btnDodajTransakciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTransakciju.Location = new System.Drawing.Point(72, 268);
            this.btnDodajTransakciju.Name = "btnDodajTransakciju";
            this.btnDodajTransakciju.Size = new System.Drawing.Size(357, 37);
            this.btnDodajTransakciju.TabIndex = 24;
            this.btnDodajTransakciju.Text = "Dodaj transakciju";
            this.btnDodajTransakciju.UseVisualStyleBackColor = true;
            this.btnDodajTransakciju.Click += new System.EventHandler(this.btnDodajTransakciju_Click);
            // 
            // txtVrednost
            // 
            this.txtVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVrednost.Location = new System.Drawing.Point(179, 118);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(250, 22);
            this.txtVrednost.TabIndex = 23;
            this.txtVrednost.Text = "200";
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.Location = new System.Drawing.Point(179, 72);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(250, 22);
            this.txtOpis.TabIndex = 22;
            this.txtOpis.Text = "Hrana";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vrednost:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Opis:";
            // 
            // FormAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 376);
            this.Controls.Add(this.cmbTipoviTransackije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajTransakciju);
            this.Controls.Add(this.txtVrednost);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddTransaction";
            this.Text = "FormAddTransaction";
            this.Load += new System.EventHandler(this.FormAddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoviTransackije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajTransakciju;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
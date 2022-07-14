namespace View.UserControls
{
    partial class UCAddTransaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodajTransakciju = new System.Windows.Forms.Button();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoviTransackije = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodajTransakciju
            // 
            this.btnDodajTransakciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTransakciju.Location = new System.Drawing.Point(69, 323);
            this.btnDodajTransakciju.Name = "btnDodajTransakciju";
            this.btnDodajTransakciju.Size = new System.Drawing.Size(357, 37);
            this.btnDodajTransakciju.TabIndex = 15;
            this.btnDodajTransakciju.Text = "Dodaj transakciju";
            this.btnDodajTransakciju.UseVisualStyleBackColor = true;
            // 
            // txtVrednost
            // 
            this.txtVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVrednost.Location = new System.Drawing.Point(176, 173);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(250, 22);
            this.txtVrednost.TabIndex = 14;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(176, 127);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 22);
            this.txtNaziv.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vrednost:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opis:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(176, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tip transakcije:";
            // 
            // cmbTipoviTransackije
            // 
            this.cmbTipoviTransackije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoviTransackije.FormattingEnabled = true;
            this.cmbTipoviTransackije.Location = new System.Drawing.Point(176, 270);
            this.cmbTipoviTransackije.Name = "cmbTipoviTransackije";
            this.cmbTipoviTransackije.Size = new System.Drawing.Size(250, 24);
            this.cmbTipoviTransackije.TabIndex = 19;
            // 
            // UCAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTipoviTransackije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajTransakciju);
            this.Controls.Add(this.txtVrednost);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UCAddTransaction";
            this.Size = new System.Drawing.Size(513, 519);
            this.Load += new System.EventHandler(this.UCAddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTransakciju;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoviTransackije;
    }
}

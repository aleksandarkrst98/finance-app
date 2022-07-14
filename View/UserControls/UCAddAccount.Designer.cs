namespace View.UserControls
{
    partial class UCAddAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.btnDodajRacun = new System.Windows.Forms.Button();
            this.dgvTransakcije = new System.Windows.Forms.DataGridView();
            this.btnDodajTransakciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv racuna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip racuna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrednost:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(304, 63);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(259, 22);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Text = "Kartica 1";
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(304, 111);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(259, 24);
            this.cmbTip.TabIndex = 5;
            this.cmbTip.Text = "Kartica";
            // 
            // txtVrednost
            // 
            this.txtVrednost.Location = new System.Drawing.Point(304, 156);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(259, 22);
            this.txtVrednost.TabIndex = 6;
            this.txtVrednost.Text = "200";
            // 
            // btnDodajRacun
            // 
            this.btnDodajRacun.Location = new System.Drawing.Point(206, 207);
            this.btnDodajRacun.Name = "btnDodajRacun";
            this.btnDodajRacun.Size = new System.Drawing.Size(176, 37);
            this.btnDodajRacun.TabIndex = 8;
            this.btnDodajRacun.Text = "Dodaj racun";
            this.btnDodajRacun.UseVisualStyleBackColor = true;
            this.btnDodajRacun.Click += new System.EventHandler(this.btnDodajRacun_Click);
            // 
            // dgvTransakcije
            // 
            this.dgvTransakcije.AllowUserToAddRows = false;
            this.dgvTransakcije.AllowUserToDeleteRows = false;
            this.dgvTransakcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransakcije.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransakcije.Location = new System.Drawing.Point(114, 285);
            this.dgvTransakcije.Name = "dgvTransakcije";
            this.dgvTransakcije.RowTemplate.Height = 24;
            this.dgvTransakcije.Size = new System.Drawing.Size(541, 165);
            this.dgvTransakcije.TabIndex = 9;
            // 
            // btnDodajTransakciju
            // 
            this.btnDodajTransakciju.Location = new System.Drawing.Point(388, 207);
            this.btnDodajTransakciju.Name = "btnDodajTransakciju";
            this.btnDodajTransakciju.Size = new System.Drawing.Size(175, 37);
            this.btnDodajTransakciju.TabIndex = 10;
            this.btnDodajTransakciju.Text = "Dodaj transakciju";
            this.btnDodajTransakciju.UseVisualStyleBackColor = true;
            this.btnDodajTransakciju.Click += new System.EventHandler(this.btnDodajTransakciju_Click);
            // 
            // UCAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajTransakciju);
            this.Controls.Add(this.dgvTransakcije);
            this.Controls.Add(this.btnDodajRacun);
            this.Controls.Add(this.txtVrednost);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddAccount";
            this.Size = new System.Drawing.Size(777, 504);
            this.Load += new System.EventHandler(this.UCAddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Button btnDodajRacun;
        private System.Windows.Forms.DataGridView dgvTransakcije;
        private System.Windows.Forms.Button btnDodajTransakciju;
    }
}

namespace View.UserControls
{
    partial class UCGetAccounts
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
            this.btnOdaberiRacun = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazivRacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransakcije = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoviTransackije = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.btnOdaberiTransakciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdaberiRacun
            // 
            this.btnOdaberiRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiRacun.Location = new System.Drawing.Point(632, 256);
            this.btnOdaberiRacun.Name = "btnOdaberiRacun";
            this.btnOdaberiRacun.Size = new System.Drawing.Size(217, 29);
            this.btnOdaberiRacun.TabIndex = 89;
            this.btnOdaberiRacun.Text = "Odaberi racun";
            this.btnOdaberiRacun.UseVisualStyleBackColor = true;
            this.btnOdaberiRacun.Click += new System.EventHandler(this.btnOdaberiRacun_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Location = new System.Drawing.Point(632, 31);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(217, 29);
            this.btnPretrazi.TabIndex = 88;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AllowUserToDeleteRows = false;
            this.dgvRacun.AllowUserToResizeColumns = false;
            this.dgvRacun.AllowUserToResizeRows = false;
            this.dgvRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacun.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(92, 70);
            this.dgvRacun.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacun.Size = new System.Drawing.Size(757, 161);
            this.dgvRacun.TabIndex = 87;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(205, 34);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(418, 22);
            this.txtFilter.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Pretraži racune:";
            // 
            // txtNazivRacuna
            // 
            this.txtNazivRacuna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivRacuna.Enabled = false;
            this.txtNazivRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivRacuna.Location = new System.Drawing.Point(225, 262);
            this.txtNazivRacuna.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivRacuna.Name = "txtNazivRacuna";
            this.txtNazivRacuna.Size = new System.Drawing.Size(160, 22);
            this.txtNazivRacuna.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Naziv racuna:";
            // 
            // dgvTransakcije
            // 
            this.dgvTransakcije.AllowUserToAddRows = false;
            this.dgvTransakcije.AllowUserToDeleteRows = false;
            this.dgvTransakcije.AllowUserToResizeColumns = false;
            this.dgvTransakcije.AllowUserToResizeRows = false;
            this.dgvTransakcije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTransakcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransakcije.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransakcije.Location = new System.Drawing.Point(92, 458);
            this.dgvTransakcije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransakcije.Name = "dgvTransakcije";
            this.dgvTransakcije.ReadOnly = true;
            this.dgvTransakcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransakcije.Size = new System.Drawing.Size(757, 236);
            this.dgvTransakcije.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Transakcije";
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(222, 345);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(160, 22);
            this.txtOpis.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Opis transakcije:";
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(222, 385);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(160, 22);
            this.txtDatum.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "Datum transakcije:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Tip transakcije:";
            // 
            // cmbTipoviTransackije
            // 
            this.cmbTipoviTransackije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoviTransackije.FormattingEnabled = true;
            this.cmbTipoviTransackije.Location = new System.Drawing.Point(558, 345);
            this.cmbTipoviTransackije.Name = "cmbTipoviTransackije";
            this.cmbTipoviTransackije.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoviTransackije.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 100;
            this.label6.Text = "Vrednost:";
            // 
            // txtVrednost
            // 
            this.txtVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVrednost.Location = new System.Drawing.Point(558, 388);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(160, 22);
            this.txtVrednost.TabIndex = 101;
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajIzmene.Enabled = false;
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(632, 422);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(217, 29);
            this.btnSacuvajIzmene.TabIndex = 102;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // btnOdaberiTransakciju
            // 
            this.btnOdaberiTransakciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiTransakciju.Enabled = false;
            this.btnOdaberiTransakciju.Location = new System.Drawing.Point(95, 422);
            this.btnOdaberiTransakciju.Name = "btnOdaberiTransakciju";
            this.btnOdaberiTransakciju.Size = new System.Drawing.Size(217, 29);
            this.btnOdaberiTransakciju.TabIndex = 103;
            this.btnOdaberiTransakciju.Text = "Odaberi transakciju";
            this.btnOdaberiTransakciju.UseVisualStyleBackColor = true;
            this.btnOdaberiTransakciju.Click += new System.EventHandler(this.btnOdaberiTransakciju_Click);
            // 
            // UCGetAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdaberiTransakciju);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.txtVrednost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoviTransackije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTransakcije);
            this.Controls.Add(this.btnOdaberiRacun);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNazivRacuna);
            this.Controls.Add(this.label1);
            this.Name = "UCGetAccounts";
            this.Size = new System.Drawing.Size(938, 730);
            this.Load += new System.EventHandler(this.UCGetAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberiRacun;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNazivRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransakcije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoviTransackije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Button btnSacuvajIzmene;
        private System.Windows.Forms.Button btnOdaberiTransakciju;
    }
}

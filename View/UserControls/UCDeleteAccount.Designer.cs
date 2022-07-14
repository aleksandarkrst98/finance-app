namespace View.UserControls
{
    partial class UCDeleteAccount
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
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazivRacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnOdaberiRacun = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
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
            this.dgvRacun.Location = new System.Drawing.Point(23, 52);
            this.dgvRacun.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacun.Size = new System.Drawing.Size(757, 161);
            this.dgvRacun.TabIndex = 78;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(136, 16);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(418, 22);
            this.txtFilter.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Pretraži racune:";
            // 
            // txtNazivRacuna
            // 
            this.txtNazivRacuna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivRacuna.Enabled = false;
            this.txtNazivRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivRacuna.Location = new System.Drawing.Point(136, 241);
            this.txtNazivRacuna.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivRacuna.Name = "txtNazivRacuna";
            this.txtNazivRacuna.Size = new System.Drawing.Size(160, 22);
            this.txtNazivRacuna.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Naziv racuna:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Location = new System.Drawing.Point(563, 13);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(217, 29);
            this.btnPretrazi.TabIndex = 81;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnOdaberiRacun
            // 
            this.btnOdaberiRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiRacun.Location = new System.Drawing.Point(563, 238);
            this.btnOdaberiRacun.Name = "btnOdaberiRacun";
            this.btnOdaberiRacun.Size = new System.Drawing.Size(217, 29);
            this.btnOdaberiRacun.TabIndex = 82;
            this.btnOdaberiRacun.Text = "Odaberi racun";
            this.btnOdaberiRacun.UseVisualStyleBackColor = true;
            this.btnOdaberiRacun.Click += new System.EventHandler(this.btnOdaberiRacun_Click);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiRacun.Location = new System.Drawing.Point(26, 304);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(217, 29);
            this.btnObrisiRacun.TabIndex = 83;
            this.btnObrisiRacun.Text = "Obrisi racun";
            this.btnObrisiRacun.UseVisualStyleBackColor = true;
            this.btnObrisiRacun.Click += new System.EventHandler(this.btnObrisiRacun_Click);
            // 
            // UCDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiRacun);
            this.Controls.Add(this.btnOdaberiRacun);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNazivRacuna);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UCDeleteAccount";
            this.Size = new System.Drawing.Size(990, 519);
            this.Load += new System.EventHandler(this.UCDeleteAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNazivRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnOdaberiRacun;
        private System.Windows.Forms.Button btnObrisiRacun;
    }
}

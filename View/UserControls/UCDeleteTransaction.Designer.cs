namespace View.UserControls
{
    partial class UCDeleteTransaction
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
            this.btnObrisiTransakciju = new System.Windows.Forms.Button();
            this.btnOdaberiTransakciju = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFakultet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpisTransakcije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiTransakciju
            // 
            this.btnObrisiTransakciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiTransakciju.Location = new System.Drawing.Point(86, 412);
            this.btnObrisiTransakciju.Name = "btnObrisiTransakciju";
            this.btnObrisiTransakciju.Size = new System.Drawing.Size(217, 29);
            this.btnObrisiTransakciju.TabIndex = 93;
            this.btnObrisiTransakciju.Text = "Obrisi transakciju";
            this.btnObrisiTransakciju.UseVisualStyleBackColor = true;
            // 
            // btnOdaberiTransakciju
            // 
            this.btnOdaberiTransakciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiTransakciju.Location = new System.Drawing.Point(623, 282);
            this.btnOdaberiTransakciju.Name = "btnOdaberiTransakciju";
            this.btnOdaberiTransakciju.Size = new System.Drawing.Size(217, 29);
            this.btnOdaberiTransakciju.TabIndex = 92;
            this.btnOdaberiTransakciju.Text = "Odaberi transakciju";
            this.btnOdaberiTransakciju.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Location = new System.Drawing.Point(623, 57);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(217, 29);
            this.btnPretrazi.TabIndex = 91;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvTim
            // 
            this.dgvTim.AllowUserToAddRows = false;
            this.dgvTim.AllowUserToDeleteRows = false;
            this.dgvTim.AllowUserToResizeColumns = false;
            this.dgvTim.AllowUserToResizeRows = false;
            this.dgvTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(83, 96);
            this.dgvTim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.ReadOnly = true;
            this.dgvTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTim.Size = new System.Drawing.Size(757, 161);
            this.dgvTim.TabIndex = 90;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(220, 60);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(394, 22);
            this.txtFilter.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "Pretraži transakcije:";
            // 
            // cmbFakultet
            // 
            this.cmbFakultet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFakultet.Enabled = false;
            this.cmbFakultet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFakultet.FormattingEnabled = true;
            this.cmbFakultet.Location = new System.Drawing.Point(202, 352);
            this.cmbFakultet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFakultet.Name = "cmbFakultet";
            this.cmbFakultet.Size = new System.Drawing.Size(160, 24);
            this.cmbFakultet.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tip transakcije:";
            // 
            // txtOpisTransakcije
            // 
            this.txtOpisTransakcije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpisTransakcije.Enabled = false;
            this.txtOpisTransakcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpisTransakcije.Location = new System.Drawing.Point(202, 288);
            this.txtOpisTransakcije.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpisTransakcije.Name = "txtOpisTransakcije";
            this.txtOpisTransakcije.Size = new System.Drawing.Size(160, 22);
            this.txtOpisTransakcije.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ime tima:";
            // 
            // UCDeleteTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiTransakciju);
            this.Controls.Add(this.btnOdaberiTransakciju);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbFakultet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpisTransakcije);
            this.Controls.Add(this.label1);
            this.Name = "UCDeleteTransaction";
            this.Size = new System.Drawing.Size(918, 498);
            this.Load += new System.EventHandler(this.UCDeleteTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiTransakciju;
        private System.Windows.Forms.Button btnOdaberiTransakciju;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvTim;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFakultet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpisTransakcije;
        private System.Windows.Forms.Label label1;
    }
}

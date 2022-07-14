namespace View.UserControls
{
    partial class UCGetTransactions
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
            this.btnOdaberiTransakciju = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImeTima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdaberiTransakciju
            // 
            this.btnOdaberiTransakciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiTransakciju.Location = new System.Drawing.Point(588, 287);
            this.btnOdaberiTransakciju.Name = "btnOdaberiTransakciju";
            this.btnOdaberiTransakciju.Size = new System.Drawing.Size(217, 29);
            this.btnOdaberiTransakciju.TabIndex = 99;
            this.btnOdaberiTransakciju.Text = "Odaberi transakciju";
            this.btnOdaberiTransakciju.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Location = new System.Drawing.Point(588, 62);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(217, 29);
            this.btnPretrazi.TabIndex = 98;
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
            this.dgvTim.Location = new System.Drawing.Point(48, 101);
            this.dgvTim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.ReadOnly = true;
            this.dgvTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTim.Size = new System.Drawing.Size(757, 161);
            this.dgvTim.TabIndex = 97;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(185, 65);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(394, 22);
            this.txtFilter.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 95;
            this.label8.Text = "Pretraži transakcije:";
            // 
            // txtImeTima
            // 
            this.txtImeTima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImeTima.Enabled = false;
            this.txtImeTima.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeTima.Location = new System.Drawing.Point(167, 293);
            this.txtImeTima.Margin = new System.Windows.Forms.Padding(4);
            this.txtImeTima.Name = "txtImeTima";
            this.txtImeTima.Size = new System.Drawing.Size(160, 22);
            this.txtImeTima.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Ime tima:";
            // 
            // UCGetTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdaberiTransakciju);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImeTima);
            this.Controls.Add(this.label1);
            this.Name = "UCGetTransactions";
            this.Size = new System.Drawing.Size(849, 379);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberiTransakciju;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvTim;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImeTima;
        private System.Windows.Forms.Label label1;
    }
}

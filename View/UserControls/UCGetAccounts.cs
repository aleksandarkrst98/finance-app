using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using Domain;

namespace View.UserControls
{
    public partial class UCGetAccounts : UserControl
    {
        MainController mainController = new MainController();

        public UCGetAccounts()
        {
            InitializeComponent();
        }

        private void UCGetAccounts_Load(object sender, EventArgs e)
        {
            mainController.LoadDataGridViewRacun(dgvRacun);
            mainController.LoadComboboxTipTransakcije(cmbTipoviTransackije);
            cmbTipoviTransackije.Text = "";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetRacunWithCondition(txtFilter, dgvRacun);
        }

        private void btnOdaberiRacun_Click(object sender, EventArgs e)
        {
            mainController.GetOneRacunWithConditionAndTransakcije(dgvRacun, txtNazivRacuna, dgvTransakcije);
            btnOdaberiTransakciju.Enabled = true;
            btnSacuvajIzmene.Enabled = true;
        }

        private void btnOdaberiTransakciju_Click(object sender, EventArgs e)
        {
            mainController.GetOneTransakcijaWithCondition(dgvTransakcije, txtOpis, 
                txtDatum, txtVrednost, cmbTipoviTransackije);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            mainController.UpdateTransakcija(dgvRacun, dgvTransakcije, txtOpis, txtDatum, txtVrednost, cmbTipoviTransackije);
        }
    }
}

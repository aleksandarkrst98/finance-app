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
    public partial class UCAddAccount : UserControl
    {
        MainController mainController = new MainController();
        BindingList<Transakcija> listaTransakcija;
        private Korisnik k;

        public UCAddAccount(Korisnik korisnik)
        {
            InitializeComponent();
            this.k = korisnik;
        }

        private void UCAddAccount_Load(object sender, EventArgs e)
        {
            mainController.LoadComboboxTipRacuna(cmbTip);
            dgvTransakcije.DataSource = listaTransakcija;
        }

        private void btnDodajTransakciju_Click(object sender, EventArgs e)
        {
            listaTransakcija = new BindingList<Transakcija>();
            new FormAddTransaction(listaTransakcija).ShowDialog();
            dgvTransakcije.DataSource = listaTransakcija;
        }

        private void btnDodajRacun_Click(object sender, EventArgs e)
        {
            mainController.SaveRacun(txtNaziv, cmbTip, txtVrednost, listaTransakcija, k);
        }
    }
}

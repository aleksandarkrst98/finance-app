using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using View.Controller;

namespace View
{
    public partial class FormAddTransaction : Form
    {
        MainController mainController = new MainController();
        private BindingList<Transakcija> listaTransakcija;

        public FormAddTransaction()
        {
            InitializeComponent();
        }

        public FormAddTransaction(BindingList<Transakcija> listaTransakcija)
        {
            InitializeComponent();
            this.listaTransakcija = listaTransakcija;
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {
            mainController.LoadComboboxTipTransakcije(cmbTipoviTransackije);
        }

        private void btnDodajTransakciju_Click(object sender, EventArgs e)
        {
            listaTransakcija.Add(mainController.SaveTransakcija(txtOpis, txtDatum, txtVrednost, cmbTipoviTransackije));
            this.Hide();
        }
    }
}

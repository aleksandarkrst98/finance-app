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
    public partial class UCDeleteAccount : UserControl
    {
        MainController mainController = new MainController();

        public UCDeleteAccount()
        {
            InitializeComponent();
        }

        private void UCDeleteAccount_Load(object sender, EventArgs e)
        {
            mainController.LoadDataGridViewRacun(dgvRacun);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetRacunWithCondition(txtFilter, dgvRacun);
        }

        private void btnOdaberiRacun_Click(object sender, EventArgs e)
        {
            mainController.GetOneRacunWithCondition(dgvRacun, txtNazivRacuna);
        }

        private void btnObrisiRacun_Click(object sender, EventArgs e)
        {
            mainController.DeleteAccount(dgvRacun);
        }
    }
}

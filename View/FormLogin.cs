using Controller;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using View.Exceptions;

namespace View
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController = new LoginController();

        public FrmLogin()
        {
            InitializeComponent();
            txtKorisnickoIme.Text = "nikola";
            txtSifra.Text = "nikola";
        }

        public FrmLogin(Korisnik korisnik)
        {
            InitializeComponent();
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
            txtSifra.Text = korisnik.Sifra;
        }

        public FrmLogin(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
            {
                try
                {
                    loginController.Login(txtKorisnickoIme, txtSifra, this);
                }
                catch (SystemNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().ShowDialog();
        }
    }
}

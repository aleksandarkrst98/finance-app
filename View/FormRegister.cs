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
    public partial class FormRegister : Form
    {
        private RegisterController registerController = new RegisterController();

        public FormRegister()
        {
            InitializeComponent();
            txtJmbg.Text = "1122333450031";
            txtIme.Text = "Marko";
            txtPrezime.Text = "Markovic";
            txtKorisnickoIme.Text = "marko";
            txtSifra.Text = "marko";
        }

        public FormRegister(RegisterController registerController)
        {
            InitializeComponent();
            this.registerController = registerController;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (registerController.Connect())
            {
                try
                {
                    registerController.Register(txtJmbg, txtIme, txtPrezime, txtKorisnickoIme, txtSifra, this);
                }
                catch (SystemNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().ShowDialog();
        }
    }
}

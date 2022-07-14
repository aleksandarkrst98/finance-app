using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using View.Controller;

namespace View
{
    public partial class FormMain : Form
    {
        
        MainController mainController = new MainController();
        private Korisnik korisnik;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void dodajRacunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddAccount(this, korisnik);
        }

        private void promeniRacunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUpdateAccount(this, korisnik);
        }

        private void obrisiRacunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteAccount(this);
        }      

        private void transakcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izmeniTransakcijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCGetAccounts(this);
        }

        private void obrisiTransakcijuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteTransaction(this);
        }
    }
}

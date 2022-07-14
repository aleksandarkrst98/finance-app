using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    public partial class FormServer : Form
    {
        private Server s;
        private System.Windows.Forms.Timer t;

        public FormServer()
        {
            InitializeComponent();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;

            t = new Timer();
            t.Interval = 1000;
            t.Tick += osvezi;
            t.Start();
        }

        private void osvezi(object sender, EventArgs e)
        {
            lblTimer.Text = "Timer " + DateTime.Now.ToString("dd. MM. yyyy. HH:mm:ss");
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                txtStanjeServera.Text = "Server je pokrenut";
                txtStanjeServera.BackColor = Color.LightGreen;
                s.Korisnici.ListChanged += Users_ListChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno pokretanje servera! " + ex.Message);
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;
        }

        private void Users_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvKorisnik.Invoke(new Action(() => dgvKorisnik.DataSource = s.Korisnici.ToList()));
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class LoginController
    {
        internal void Login(TextBox txtKorisnickoIme, TextBox txtSifra, FrmLogin frmLogin)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtKorisnickoIme)
                || !UserControlHelpers.EmptyFieldValidation(txtSifra))
            {
                return;
            }

            try
            {
                Korisnik k = CommunicationC.Instance.Login(txtKorisnickoIme.Text, txtSifra.Text);

                if (k != null)
                {
                    if (k.StatusUlogavan)
                    {
                        throw new SystemNotFoundException("Korisnik je vec ulogovan!");
                    }

                    FormMain frmMain = new FormMain(k);
                    MessageBox.Show($"Korisnik {k.Ime} {k.Prezime} se uspesno ulogovao!");
                    frmMain.FormBorderStyle = FormBorderStyle.FixedDialog;
                    frmLogin.Visible = false;
                    frmMain.ShowDialog();
                }
                else
                    throw new SystemNotFoundException();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal bool Connect()
        {
            try
            {
                CommunicationC.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom!");
                return false;
            }
        }
    }
}

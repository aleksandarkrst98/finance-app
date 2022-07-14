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
    public class RegisterController
    {
        internal void Register(TextBox txtJmbg, TextBox txtIme, TextBox txtPrezime,
            TextBox txtKorisnickoIme, TextBox txtSifra, FormRegister frmRegister)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtJmbg) || !UserControlHelpers.AllNumberValidation(txtJmbg) 
                || !UserControlHelpers.EmptyFieldValidation(txtIme) || !UserControlHelpers.EmptyFieldValidation(txtPrezime) 
                || !UserControlHelpers.EmptyFieldValidation(txtKorisnickoIme) || !UserControlHelpers.EmptyFieldValidation(txtSifra))
            {
                return;
            }

            try
            {
                Korisnik k = new Korisnik()
                {
                    Jmbg = txtJmbg.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Sifra = txtSifra.Text
                };

                List<Korisnik> korisnici = CommunicationC.Instance.GetKorisnik();
                foreach (Korisnik kor in korisnici)
                {
                    if (k.Jmbg == kor.Jmbg && k.Ime == kor.Ime && k.Prezime == kor.Prezime
                        && k.KorisnickoIme == kor.KorisnickoIme && k.Sifra == kor.Sifra)
                    {
                        MessageBox.Show("Korisnik vec postoji");
                        new FrmLogin(k).ShowDialog();
                    }
                }

                CommunicationC.Instance.Register(k);

                if (k != null)
                {
                    if (k.StatusUlogavan)
                    {
                        throw new SystemNotFoundException("Korisnik je vec ulogovan!");
                    }

                    FormMain frmMain = new FormMain(k);
                    MessageBox.Show($"Korisnik {k.Ime} {k.Prezime} je uspesno kreirao nalog!");
                    frmMain.FormBorderStyle = FormBorderStyle.FixedDialog;
                    frmRegister.Visible = false;
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

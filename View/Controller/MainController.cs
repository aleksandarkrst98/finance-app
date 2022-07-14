using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communication;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.Controller
{
    public class MainController
    {
        internal void OpenUCAddAccount(FormMain formMain, Korisnik korisnik)
        {
            formMain.SetPanel(new UCAddAccount(korisnik));
        }

        internal void OpenUCUpdateAccount(FormMain formMain, Korisnik korisnik)
        {
            formMain.SetPanel(new UCUpdateAccount());
        }

        internal void LoadDataGridViewRacun(DataGridView dgvRacun)
        {
            dgvRacun.DataSource = new BindingList<Racun>((CommunicationC.Instance.GetRacun()));
        }

        internal void GetOneRacunWithConditionAndTransakcije(DataGridView dgvRacun, TextBox txtNazivRacuna, DataGridView dgvTransakcije)
        {
            if (dgvRacun.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijedan racun!");
                return;
            }
            Racun r = new Racun();
            r.Uslov = $"r.id={((Racun)dgvRacun.SelectedRows[0].DataBoundItem).Id}";
            r = CommunicationC.Instance.GetOneRacunWithCondition(r);

            if (r == null)
            {
                MessageBox.Show("Traženi racun nije pronađen!");
            }
            else
            {
                MessageBox.Show("Traženi racun je pronađen!");
                txtNazivRacuna.Text = r.Naziv;
                r.ListaTransakcija = new BindingList<Transakcija>(CommunicationC.Instance.GetTransakcija());
                dgvTransakcije.DataSource = r.ListaTransakcija;
            }
        }

        internal void UpdateTransakcija(DataGridView dgvRacun, DataGridView dgvTransakcije, TextBox txtOpis, TextBox txtDatum, TextBox txtVrednost, ComboBox cmbTipoviTransackije)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtOpis) || !UserControlHelpers.EmptyFieldValidation(txtDatum)
                || !UserControlHelpers.EmptyFieldValidation(txtVrednost)
                || !UserControlHelpers.ComboValidation(cmbTipoviTransackije))
            {
                MessageBox.Show("Greska!");
                return;
            }
            if (dgvTransakcije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati učesnika!");
                return;
            }
            try
            {
                Racun r = new Racun();
                r = (Racun)dgvRacun.SelectedRows[0].DataBoundItem;

                Transakcija t = new Transakcija();
                t.Id = ((Transakcija)dgvTransakcije.SelectedRows[0].DataBoundItem).Id;
                t.Opis = txtOpis.Text;
                t.Datum = Convert.ToDateTime(txtDatum.Text);
                t.Vrednost = Convert.ToDouble(txtVrednost.Text);
                t.TipTransakcije = cmbTipoviTransackije.SelectedItem as TipTransakcije;
                t.Racun = r;

                CommunicationC.Instance.UpdateTransakcija(t);
                r.ListaTransakcija = new BindingList<Transakcija>(CommunicationC.Instance.GetTransakcija());
                dgvTransakcije.DataSource = r.ListaTransakcija;
                MessageBox.Show("Uspešno ste ažurirali podatke o transakciji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void GetOneTransakcijaWithCondition(DataGridView dgvTransakcije,
            TextBox txtOpis, TextBox txtDatum, TextBox txtVrednost, ComboBox cmbTipTransakcije)
        {
            if (dgvTransakcije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijednu transakciju!");
                return;
            }
            Transakcija t = new Transakcija();
            t.Uslov = $"t.id={((Transakcija)dgvTransakcije.SelectedRows[0].DataBoundItem).Id}";
            t = CommunicationC.Instance.GetOneTransakcijaWithCondition(t) as Transakcija;

            if (t == null)
            {
                MessageBox.Show("Tražena transakcija nije pronađena!");
            }
            else
            {
                MessageBox.Show("Tražena transakcija je pronađena!");
                txtOpis.Text = t.Opis;
                txtDatum.Text = t.Datum.ToString("dd.MM.yyyy");
                txtVrednost.Text = Convert.ToString(t.Vrednost);
                cmbTipTransakcije.SelectedIndex = 
                    cmbTipTransakcije.FindStringExact(t.TipTransakcije.Naziv); 
            }
        }

        internal void DeleteAccount(DataGridView dgvRacun)
        {
            if (dgvRacun.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati racun!");
                return;
            }
            try
            {
                Racun r = new Racun();
                r = (Racun)dgvRacun.SelectedRows[0].DataBoundItem;
                r.ListaTransakcija = new BindingList<Transakcija>(CommunicationC.Instance.GetTransakcija());
                foreach (Transakcija t in r.ListaTransakcija)
                {
                    CommunicationC.Instance.DeleteTransakcija(t);
                }

                CommunicationC.Instance.DeleteRacun(r);

                LoadDataGridViewRacun(dgvRacun);
                MessageBox.Show("Uspešno ste obrisali racun!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Ne možete da izbrišete ovaj racun!");
            }
        }

        internal void GetOneRacunWithCondition(DataGridView dgvRacun, TextBox txtNaziv)
        {
            if(dgvRacun.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jedan racun!");
                return;
            }

            Racun r = new Racun();
            r.Uslov = $"r.Naziv='{((Racun)dgvRacun.SelectedRows[0].DataBoundItem).Naziv}'";
            r = CommunicationC.Instance.GetOneRacunWithCondition(r);

            if (r == null)
            {
                MessageBox.Show("Traženi racun nije pronađen!");
            }
            else
            {
                MessageBox.Show("Traženi racun je pronađen!");
                txtNaziv.Text = r.Naziv;
            }
        }

        internal void GetRacunWithCondition(TextBox txtFilter, DataGridView dgvRacun)
        {
            Racun r = new Racun();
            r.Uslov = $" r.Naziv like '{txtFilter.Text}%'";
            List<Racun> lista = CommunicationC.Instance.GetRacunWithCondition(r);

            if (lista.Count == 0)
            {
                MessageBox.Show("Traženi racuni nisu pronađeni.");
                dgvRacun.DataSource = lista;
            }
            else
            {
                dgvRacun.DataSource = lista;
                MessageBox.Show("Traženi racuni su pronađeni!");
            }
        }

        internal void OpenUCDeleteAccount(FormMain formMain)
        {
            formMain.SetPanel(new UCDeleteAccount());
        }

        internal void OpenUCGetAccounts(FormMain formMain)
        {
            formMain.SetPanel(new UCGetAccounts());
        }

        internal Transakcija SaveTransakcija(TextBox txtOpis, TextBox txtDatum, TextBox txtVrednost, 
            ComboBox cmbTipoviTransackije)
        {
            Transakcija t = new Transakcija();

            if(!UserControlHelpers.EmptyFieldValidation(txtOpis) || !UserControlHelpers.EmptyFieldValidation(txtDatum) 
                || !UserControlHelpers.EmptyFieldValidation(txtVrednost) || !UserControlHelpers.ComboValidation(cmbTipoviTransackije))
            {
                MessageBox.Show("Greska! Sva polja moraju biti popunjena");
                return null;
            }

            if (!UserControlHelpers.DateValidation(txtDatum))
            {
                MessageBox.Show("Datum nije u dobrom formatu");
                return null;
            }

            t.Opis = txtOpis.Text;
            t.Datum = DateTime.ParseExact(txtDatum.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            t.Vrednost = Convert.ToDouble(txtVrednost.Text);
            t.TipTransakcije = cmbTipoviTransackije.SelectedItem as TipTransakcije;

            return t;
        }

        internal void OpenUCDeleteTransaction(FormMain formMain)
        {
            formMain.SetPanel(new UCDeleteTransaction());
        }

        List<TipTransakcije> listaTipovaTransakcija = new List<TipTransakcije>();
        internal void LoadComboboxTipTransakcije(ComboBox cmbTip)
        {
            listaTipovaTransakcija = CommunicationC.Instance.GetTipTransakcije();
            cmbTip.DataSource = listaTipovaTransakcija;
            cmbTip.SelectedIndex = -1;
            cmbTip.Text = "Izaberite tip transakcije";
        }

        internal void LoadComboboxTipRacuna(ComboBox cmbTip)
        {
            cmbTip.Items.Add("Kartica");
            cmbTip.Items.Add("Keš");
            cmbTip.SelectedIndex = -1;
            cmbTip.Text = "Izaberite tip racuna";
        }

        internal void LoadDataGridView(DataGridView dgvTransakcije, List<Transakcija> lista)
        {
            dgvTransakcije.DataSource = lista;
        }

        internal void SaveRacun(TextBox txtNaziv, ComboBox cmbTip, TextBox txtVrednost, BindingList<Transakcija> list, Korisnik k)
        {
            if(!UserControlHelpers.EmptyFieldValidation(txtNaziv) || !UserControlHelpers.EmptyFieldValidation(txtVrednost) 
                || !UserControlHelpers.ComboValidation(cmbTip))
            {
                MessageBox.Show("Greska! Sva polja moraju biti popunjena");
                return;
            }

            try
            {
                Racun r = new Racun();
                r.Naziv = txtNaziv.Text;
                r.Tip = (string)cmbTip.SelectedItem;
                r.Korisnik = k;
                try
                {

                    r.Vrednost = Convert.ToDouble(txtVrednost.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vrednost nije u dobrom formatu");
                    return;
                }
                
                try
                {
                    r.ListaTransakcija = new BindingList<Transakcija>(list);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ne mozete da sacuvate racun bez transakcija");
                    return;
                }

                foreach (Transakcija tr in r.ListaTransakcija)
                {
                    tr.Racun = r;
                }

                CommunicationC.Instance.SaveRacun(r);
                MessageBox.Show("Uspešno ste sačuvali racun!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

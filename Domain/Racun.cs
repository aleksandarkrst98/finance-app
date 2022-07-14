using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Racun:IEntity
    {
        int id;
        string naziv;
        string tip;
        double vrednost;
        Korisnik korisnik;
        BindingList<Transakcija> listaTransakcija;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Tip { get => tip; set => tip = value; }
        public double Vrednost { get => vrednost; set => vrednost = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        public BindingList<Transakcija> ListaTransakcija { get => listaTransakcija; set => listaTransakcija = value; }
        [Browsable(false)]
        public string TableName => "Racun";
        [Browsable(false)]
        public string InsertValues => $"'{Id}', '{Naziv}', '{Tip}', '{Vrednost}', '{Korisnik.Id}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "on (r.IdKorisnika = k.Id)";
        [Browsable(false)]
        public string JoinTable => "join Korisnik k";
        [Browsable(false)]
        public string TableAlias => "r";
        [Browsable(false)]
        public object SelectedValues => "r.Id, r.Naziv, r.Tip, r.Vrednost, k.Id, k.JMBG, k.Ime, k.Prezime, k.KorisnickoIme, k.Sifra";
        [Browsable(false)]
        public string WhereCondition => $"Id = '{Id}'";
        [Browsable(false)]
        public string GetUpdatedValues => $"Naziv = '{Naziv}', Tip = '{Tip}', " +
            $"Vrednost = '{Vrednost}', IdKorisnika = '{Korisnik.Id}'";
        [Browsable(false)]
        public string Uslov;
        [Browsable(false)]
        public string GeneralCondition => $"{Uslov} ";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Racun r = new Racun();
                r.Id = reader.GetInt32(0);
                r.Naziv = reader.GetString(1);
                r.Tip = reader.GetString(2);
                r.Vrednost = reader.GetDouble(3);
                r.korisnik = new Korisnik();
                r.Korisnik.Id = reader.GetInt32(4);
                r.korisnik.Jmbg = reader.GetString(5);
                r.Korisnik.Ime = reader.GetString(6);
                r.Korisnik.Prezime = reader.GetString(7);
                r.Korisnik.KorisnickoIme = reader.GetString(8);
                r.korisnik.Sifra = reader.GetString(9);

                result.Add(r);
            }
            return result;
        }

        public override string ToString()
        {
            return Korisnik.Ime + " " + Korisnik.Prezime;
        }
    }
}

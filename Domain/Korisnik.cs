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
    public class Korisnik:IEntity
    {
        int id;
        string jmbg;
        string ime;
        string prezime;
        string korisnickoIme;
        string sifra;
        //BindingList<Racun> listaRacuna;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        [Browsable(false)]
        public bool StatusUlogavan { get; set; }
        //public BindingList<Racun> ListaRacuna { get => listaRacuna; set => listaRacuna = value; }
        [Browsable(false)]
        public string TableName => "Korisnik";
        [Browsable(false)]
        public string InsertValues => $"('{Jmbg}', '{Ime}', '{Prezime}', '{KorisnickoIme}', '{Sifra}')";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectedValues => "*";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdatedValues => "";
        [Browsable(false)]
        public string GeneralCondition => $"KorisnickoIme = {KorisnickoIme} and Sifra = {Sifra}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Korisnik k = new Korisnik();
                k.Id = reader.GetInt32(0);
                k.Jmbg = reader.GetString(1);
                k.Ime = reader.GetString(2);
                k.Prezime = reader.GetString(3);
                k.KorisnickoIme = reader.GetString(4);
                k.Sifra = reader.GetString(5);

                result.Add(k);
            }
            return result;
        }
    }
}

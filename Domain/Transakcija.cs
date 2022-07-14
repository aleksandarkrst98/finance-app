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
    public class Transakcija:IEntity
    {
        int id;
        string opis;
        double vrednost;
        DateTime datum;
        Racun racun;
        TipTransakcije tipTransakcije;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Opis { get => opis; set => opis = value; }
        public double Vrednost { get => vrednost; set => vrednost = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        [Browsable(false)]
        public Racun Racun { get => racun; set => racun = value; }
        [DisplayName("Tip transakcije")]
        public TipTransakcije TipTransakcije { get => tipTransakcije; set => tipTransakcije = value; }
        [Browsable(false)]
        public object SelectedValues => "t.Id, t.Opis, t.Vrednost, t.Datum, t.IdRacun, r.Naziv, r.Tip, r.Vrednost, tt.Id, tt.Naziv";
        [Browsable(false)]
        public string InsertValues => $"'{Id}', '{Opis}', '{Vrednost}', '{Datum}', '{Racun.Id}', '{TipTransakcije.Id}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string TableName => "Transakcija";
        [Browsable(false)]
        public string TableAlias => "t";
        [Browsable(false)]
        public string JoinTable => "join Racun r";
        [Browsable(false)]
        public string JoinCondition => "on (t.IdRacun = r.Id) join TipTransakcije tt on t.IdTipTransakcije = tt.Id";
        [Browsable(false)]
        public string WhereCondition => $"Id = {Id}";
        [Browsable(false)]
        public string GetUpdatedValues => $"Opis = '{Opis}', Vrednost = {Vrednost}, Datum = '{Datum.ToString("yyyy-MM-dd")}', " +
            $"IdRacun = {Racun.Id}, IdTipTransakcije = {TipTransakcije.Id}";
        [Browsable(false)]
        public string Uslov;
        [Browsable(false)]
        public string GeneralCondition => $"{Uslov}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Transakcija t = new Transakcija();
                t.Id = reader.GetInt32(0);
                t.Opis = reader.GetString(1);
                t.Vrednost = Convert.ToDouble(reader.GetDouble(2));
                t.Datum = Convert.ToDateTime(reader.GetDateTime(3));
                t.Racun = new Racun();
                t.Racun.Id = reader.GetInt32(4);
                t.Racun.Naziv = reader.GetString(5);
                t.Racun.Tip = reader.GetString(6);
                t.Racun.Vrednost = Convert.ToDouble(reader.GetDouble(7));
                t.TipTransakcije = new TipTransakcije();
                t.TipTransakcije.Id = reader.GetInt32(8);
                t.TipTransakcije.Naziv = reader.GetString(9);

                result.Add(t);
            }
            return result;
        }
    }
}

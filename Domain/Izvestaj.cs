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
    public class Izvestaj:IEntity
    {
        Racun racun;
        Transakcija transakcija;
        double ukupanTrosak;
        double ukupanPrihod;
        double ukupanTrosakPoRacunu;
        double ukupanPrihodPoRacunu;
        Racun racunSaNajmanjimTroskovima;
        Racun racunSaNajvecimTroskovima;

        public Racun Racun { get => racun; set => racun = value; }
        public Transakcija Transakcija { get => transakcija; set => transakcija = value; }
        public double UkupanTrosak { get => ukupanTrosak; set => ukupanTrosak = value; }
        public double UkupanPrihod { get => ukupanPrihod; set => ukupanPrihod = value; }
        public double UkupanTrosakPoRacunu { get => ukupanTrosakPoRacunu; set => ukupanTrosakPoRacunu = value; }
        public double UkupanPrihodPoRacunu { get => ukupanPrihodPoRacunu; set => ukupanPrihodPoRacunu = value; }
        public Racun RacunSaNajmanjimTroskovima { get => racunSaNajmanjimTroskovima; set => racunSaNajmanjimTroskovima = value; }
        public Racun RacunSaNajvecimTroskovima { get => racunSaNajvecimTroskovima; set => racunSaNajvecimTroskovima = value; }

        public object SelectedValues => "";

        public string InsertValues => $"{Racun.Id}, {Transakcija.Id}, {UkupanTrosak}, {UkupanPrihod}, {UkupanTrosakPoRacunu}, {UkupanPrihodPoRacunu}," +
            $"{RacunSaNajmanjimTroskovima.Id}, {RacunSaNajvecimTroskovima.Id}";

        public string IdName => "Id ";

        public string TableName => "Izvestaj";

        public string TableAlias => "i";

        public string JoinTable => "join Racun r";

        public string JoinCondition => "on (i.IdRacun = r.Id) join Transakcija t on (i.IdTransakcija = t.Id)";

        public string WhereCondition => "";

        public string GetUpdatedValues => "";
        [Browsable(false)]
        public string uslov;
        [Browsable(false)]
        public string GeneralCondition => $"{uslov}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Izvestaj i = new Izvestaj();
                i.Racun.Id = reader.GetInt32(0);
                i.Transakcija.Id = reader.GetInt32(1);
                i.UkupanTrosak = Convert.ToDouble(reader.GetDouble(2));
                i.UkupanPrihod = Convert.ToDouble(reader.GetDouble(3));
                i.UkupanTrosakPoRacunu = Convert.ToDouble(reader.GetDouble(4));
                i.UkupanPrihodPoRacunu = Convert.ToDouble(reader.GetDouble(5));
                i.RacunSaNajmanjimTroskovima.Id = reader.GetInt32(6);
                i.racunSaNajvecimTroskovima.Id = reader.GetInt32(7);

                result.Add(i);
            }
            return result;
        }
    }
}

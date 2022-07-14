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
    public class TipTransakcije:IEntity
    {
        int id;
        string naziv;
        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        [Browsable(false)]
        public object SelectedValues => "*";
        [Browsable(false)]
        public string InsertValues => $"{Naziv}";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string TableName => "TipTransakcije";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdatedValues => "";
        [Browsable(false)]
        public string GeneralCondition => $"Naziv = {Naziv}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                TipTransakcije tt = new TipTransakcije();
                tt.Id = reader.GetInt32(0);
                tt.Naziv = reader.GetString(1);

                result.Add(tt);
            }
            return result;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}

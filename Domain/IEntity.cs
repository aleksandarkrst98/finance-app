using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        object SelectedValues { get; }
        string InsertValues { get; }
        string IdName { get; }
        string TableName { get; }
        string TableAlias { get; }
        string JoinTable { get; }
        string JoinCondition { get; }
        string WhereCondition { get; }
        string GetUpdatedValues { get; }
        string GeneralCondition { get; }
        List<IEntity> GetEntities(SqlDataReader reader);
    }
}

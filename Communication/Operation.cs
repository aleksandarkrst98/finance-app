using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public enum Operation
    {
        Registration,
        Login,
        GetKorisnik,
        SaveRacun,
        UpdateRacun,
        DeleteRacun,
        GetRacun,
        UpdateTransakcija,
        DeleteTransakcija,
        GetTipTransakcije,
        GetIzvestaj,
        GetRacunWithCondition,
        GetTransakcijaWithCondition,
        GetOneTransakcijaWithCondition,
        GetOneRacunWithCondition,
        GetTransakcija
    }
}

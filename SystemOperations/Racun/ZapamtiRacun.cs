using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ZapamtiRacun : SystemOperationsBase
    {
        public Racun Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Racun r = (Racun)entity;
            int id = repository.GetNewId(new Racun());
            r.Id = id;
            repository.Save(r);
            foreach (Transakcija t in r.ListaTransakcija)
            {
                t.Racun.Id = id;
                int idT = repository.GetNewId(new Transakcija());
                t.Id = idT;
                repository.Save(t);
            }
        }
    }
}

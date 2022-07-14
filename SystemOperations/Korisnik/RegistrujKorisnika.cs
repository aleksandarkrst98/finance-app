using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class RegistrujKorisnika:SystemOperationsBase
    {
        public Korisnik Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save((Korisnik)entity);
            Result = (Korisnik)entity;
            int id = repository.GetNewId(new Korisnik());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class PrijaviKorisnika : SystemOperationsBase
    {
        public Korisnik Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Korisnik k = (Korisnik)entity;
            foreach (Korisnik kor in repository.GetAll(new Korisnik()))
            {
                if(kor.KorisnickoIme == k.KorisnickoIme && kor.Sifra == k.Sifra)
                {
                    k.Id = kor.Id;
                    k.Jmbg = kor.Jmbg;
                    k.Ime = kor.Ime;
                    k.Prezime = kor.Prezime;
                    Result = k;
                    return;
                }
            }
        }
    }
}

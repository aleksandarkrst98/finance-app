using DatabaseBroker;
using Domain;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace Controller
{
    public class ControllerC
    {
        private IGenericRepository repository;
        public Korisnik korisnik { get; set; }

        private static ControllerC instance;

        private static object _lock = new object();
        public static ControllerC Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new ControllerC();
                        }
                    }
                }
                return instance;
            }
        }
        private ControllerC()
        {
            repository = new GenericRepository();
        }

        public Korisnik Login(Korisnik k)
        {
            PrijaviKorisnika so = new PrijaviKorisnika();
            so.ExecuteTemplate(k);
            return so.Result;
        }

        #region Korisnik
        public Korisnik Register(Korisnik k)
        {
            RegistrujKorisnika so = new RegistrujKorisnika();
            so.ExecuteTemplate(k);
            return so.Result;
        }

        public List<Korisnik> GetKorisnik()
        {
            VratiListuKorisnika so = new VratiListuKorisnika();
            so.ExecuteTemplate(new Korisnik());
            return so.Result;
        }
        #endregion

        #region Racun
        public void DeleteRacun(Racun racun)
        {
            ObrisiOdabraniRacun so = new ObrisiOdabraniRacun();
            so.ExecuteTemplate(racun);
        }

        public object GetRacunWithCondition(Racun racun)
        {
            PretraziRacune so = new PretraziRacune();
            so.ExecuteTemplate(racun);
            return so.Result;
        }

        public void UpdateRacun(Racun racun)
        {
            SacuvajIzmeneRacuna so = new SacuvajIzmeneRacuna();
            so.ExecuteTemplate(racun);
        }

        public object GetOneRacunWithCondition(Racun racun)
        {
            UcitajOdabraniRacun so = new UcitajOdabraniRacun();
            so.ExecuteTemplate(racun);
            return so.Result;
        }

        public List<Racun> GetRacun()
        {
            VratiListuRacuna so = new VratiListuRacuna();
            so.ExecuteTemplate(new Racun());
            return so.Result;
        }

        public void SaveRacun(Racun racun)
        {
            ZapamtiRacun so = new ZapamtiRacun();
            so.ExecuteTemplate(racun);
        }

        #endregion

        public List<TipTransakcije> GetTipTransakcije()
        {
            VratiListuTipovaTransakcija so = new VratiListuTipovaTransakcija();
            so.ExecuteTemplate(new TipTransakcije());
            return so.Result;
        }

        #region Transakcija
        public List<Transakcija> GetTransakcija()
        {
            VratiListuTransakcija so = new VratiListuTransakcija();
            so.ExecuteTemplate(new Transakcija());
            return so.Result;
        }

        public void DeleteTransakcija(Transakcija transakcija)
        {
            ObrisiOdabranuTransakciju so = new ObrisiOdabranuTransakciju();
            so.ExecuteTemplate(transakcija);
        }

        public object GetTransakcijaWithCondition(Transakcija transakcija)
        {
            PretraziTransakcije so = new PretraziTransakcije();
            so.ExecuteTemplate(transakcija);
            return so.Result;
        }

        public void UpdateTransakcija(Transakcija transakcija)
        {
            SacuvajIzmeneTransakcije so = new SacuvajIzmeneTransakcije();
            so.ExecuteTemplate(transakcija);
        }

        public object GetOneTransakcijaWithCondition(Transakcija transakcija)
        {
            UcitajOdabranuTransakciju so = new UcitajOdabranuTransakciju();
            so.ExecuteTemplate(transakcija);
            return so.Result;
        }

        #endregion

    }
}

using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace View.Communication
{
    public class CommunicationC
    {
        private static CommunicationC instance;

        private Socket socket;
        private CommunicationClient client;

        public static CommunicationC Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommunicationC();
                return instance;
            }
        }

        public CommunicationC()
        {

        }

        public void Connect()
        {
            if(socket != null && socket.Connected)
            {
                return;
            }

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("localhost", 20000);
            client = new CommunicationClient(socket);
        }

        internal void Disconect()
        {
            socket.Close();
            socket = null;
        }

        internal Korisnik Login(string korisnickoIme, string sifra)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new Korisnik { KorisnickoIme = korisnickoIme, Sifra = sifra }
            };
            client.SendRequest(request);
            return (Korisnik)client.GetResponseResult();
        }

        internal Korisnik Register(Korisnik k)
        {
            Request request = new Request()
            {
                Operation = Operation.Registration,
                RequestObject = k
            };
            client.SendRequest(request);
            return (Korisnik)client.GetResponseResult();
        }

        internal List<Korisnik> GetKorisnik()
        {
            Request request = new Request() { Operation = Operation.GetKorisnik };
            client.SendRequest(request);
            return client.GetResponseResult() as List<Korisnik>;
        }

        internal void DeleteRacun(Racun racun)
        {
            Request request = new Request() { Operation = Operation.DeleteRacun, RequestObject = racun };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Racun> GetRacunWithCondition(Racun racun)
        {
            Request request = new Request() { Operation = Operation.GetRacunWithCondition, RequestObject = racun };
            client.SendRequest(request);
            return client.GetResponseResult() as List<Racun>;
        }

        internal void UpdateRacun(Racun racun)
        {
            Request request = new Request() { Operation = Operation.UpdateRacun, RequestObject = racun };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal Racun GetOneRacunWithCondition(Racun racun)
        {
            Request request = new Request() { Operation = Operation.GetOneRacunWithCondition, RequestObject = racun };
            client.SendRequest(request);
            return (Racun)client.GetResponseResult();
        }

        internal List<Racun> GetRacun()
        {
            Request request = new Request() { Operation = Operation.GetRacun };
            client.SendRequest(request);
            return client.GetResponseResult() as List<Racun>;
        }

        internal void SaveRacun(Racun racun)
        {
            Request request = new Request() { Operation = Operation.SaveRacun, RequestObject = racun };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<TipTransakcije> GetTipTransakcije()
        {
            Request request = new Request() { Operation = Operation.GetTipTransakcije };
            client.SendRequest(request);
            return client.GetResponseResult() as List<TipTransakcije>;
        }

        internal List<Transakcija> GetTransakcija()
        {
            Request request = new Request() { Operation = Operation.GetTransakcija };
            client.SendRequest(request);
            return client.GetResponseResult() as List<Transakcija>;
        }

        internal void DeleteTransakcija(Transakcija transakcija)
        {
            Request request = new Request() { Operation = Operation.DeleteTransakcija, RequestObject = transakcija };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal object GetTransakcijaWithCondition(Transakcija transakcija)
        {
            Request request = new Request() { Operation = Operation.GetTransakcijaWithCondition, RequestObject = transakcija };
            client.SendRequest(request);
            return client.GetResponseResult() as List<Transakcija>;
        }

        internal void UpdateTransakcija(Transakcija transakcija)
        {
            Request request = new Request() { Operation = Operation.UpdateTransakcija, RequestObject = transakcija };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal object GetOneTransakcijaWithCondition(Transakcija transakcija)
        {
            Request request = new Request() { Operation = Operation.GetOneTransakcijaWithCondition, RequestObject = transakcija };
            client.SendRequest(request);
            return (Transakcija)client.GetResponseResult();
        }
    }
}

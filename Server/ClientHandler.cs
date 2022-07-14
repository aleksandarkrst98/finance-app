using Communication;
using Controller;
using Domain;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    internal class ClientHandler
    {
        private Socket client;
        private readonly BindingList<Korisnik> korisnici;
        private Korisnik ulogovaniKorisnik;

        public ClientHandler(Socket client, BindingList<Korisnik> korisnici)
        {
            this.client = client;
            this.korisnici = korisnici;
        }

        internal void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.isSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                korisnici.Remove(ulogovaniKorisnik);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                korisnici.Remove(ulogovaniKorisnik);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Doslo je do prekida veze. " + ex.Message);
                korisnici.Remove(ulogovaniKorisnik);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.isSuccessful = true;
            switch (request.Operation)
            {
                case Operation.Registration:
                    Korisnik korisnik = ControllerC.Instance.Register((Korisnik)request.RequestObject);
                    if (korisnik != null)
                    {
                        korisnik.StatusUlogavan = true;
                        ulogovaniKorisnik = korisnik;
                        korisnici.Add(ulogovaniKorisnik);
                    }
                    response.Result = korisnik;
                    break;
                case Operation.Login:
                    Korisnik k = ControllerC.Instance.Login((Korisnik)request.RequestObject);
                    if(k != null)
                    {
                        k.StatusUlogavan = korisnici.Any(kor => kor.Sifra == k.Sifra);
                        ulogovaniKorisnik = k;
                        korisnici.Add(ulogovaniKorisnik);
                    }
                    response.Result = k;
                    break;
                case Operation.GetKorisnik:
                    response.Result = ControllerC.Instance.GetKorisnik();
                    break;
                case Operation.SaveRacun:
                    ControllerC.Instance.SaveRacun((Racun)request.RequestObject);
                    break;
                case Operation.UpdateRacun:
                    ControllerC.Instance.UpdateRacun((Racun)request.RequestObject);
                    break;
                case Operation.DeleteRacun:
                    ControllerC.Instance.DeleteRacun((Racun)request.RequestObject);
                    break;
                case Operation.GetRacun:
                    response.Result = ControllerC.Instance.GetRacun();
                    break;
                case Operation.GetTransakcija:
                    response.Result = ControllerC.Instance.GetTransakcija();
                    break;
                case Operation.UpdateTransakcija:
                    ControllerC.Instance.UpdateTransakcija((Transakcija)request.RequestObject);
                    break;
                case Operation.DeleteTransakcija:
                    ControllerC.Instance.DeleteTransakcija((Transakcija)request.RequestObject);
                    break;
                case Operation.GetTipTransakcije:
                    response.Result = ControllerC.Instance.GetTipTransakcije();
                    break;
                    // Izvestaj
                case Operation.GetIzvestaj:
                    break;
                case Operation.GetRacunWithCondition:
                    response.Result = ControllerC.Instance.GetRacunWithCondition((Racun)request.RequestObject);
                    break;
                case Operation.GetTransakcijaWithCondition:
                    response.Result = ControllerC.Instance.GetTransakcijaWithCondition((Transakcija)request.RequestObject);
                    break;
                case Operation.GetOneRacunWithCondition:
                    response.Result = ControllerC.Instance.GetOneRacunWithCondition((Racun)request.RequestObject);
                    break;
                case Operation.GetOneTransakcijaWithCondition:
                    response.Result = ControllerC.Instance.GetOneTransakcijaWithCondition((Transakcija)request.RequestObject);
                    break;
                default:
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();
        }
    }
}

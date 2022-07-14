using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    class Server
    {
        private Socket listener;
        private List<ClientHandler> clients = new List<ClientHandler>();
        private BindingList<Korisnik> korisnici = new BindingList<Korisnik>();

        public BindingList<Korisnik> Korisnici
        {
            get { return korisnici; }
        }

        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
            listener.Bind(ep);
        }

        public void Listen()
        {
            listener.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Socket client = listener.Accept();
                    ClientHandler handler = new ClientHandler(client, korisnici);
                    clients.Add(handler);
                    Thread thread = new Thread(handler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch (SocketException)
                {
                    Console.WriteLine("Kraj rada");
                    kraj = true;
                }
            }
        }

        internal void Stop()
        {
            listener.Close();
            foreach (ClientHandler ch in clients)
            {
                ch.Stop();
            }
            clients.Clear();
        }
    }
}

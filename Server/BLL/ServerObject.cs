using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BLL;
using HelperLibrary;


namespace Server.BLL
{
   public class ServerObject
    {
        bool running = true;
        List<Socket> clients = new List<Socket>();
        IPAddress iPAddress;
        IPEndPoint endpoint;
        Socket serverSocket;
        Thread acceptingThread;
        Thread receivingThread;
        Thread sendingThread;

        public ServerObject()
        {
            InitializeServer();
            StartServer();
        }

        private void InitializeServer()
        {
            iPAddress = Dns.GetHostAddresses(Changeables.ipNetwork)[1];
            endpoint = new IPEndPoint(iPAddress, Changeables.portNumber);

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void StartServer()
        {
            serverSocket.Bind(endpoint);
            serverSocket.Listen(10);

            acceptingThread = new Thread(() => AllowConnection());
            acceptingThread.Start();
        }

        private void AllowConnection()
        {
            while (running)
            {
                Socket client = serverSocket.Accept();
                clients.Add(client);

                receivingThread = new Thread(() => ReceiveData(client));
                receivingThread.Start();
            }
        }

        private void ReceiveData(Socket client)
        {
            while (running)
            {
                byte[] buffer = new byte[client.ReceiveBufferSize];
                client.Receive(buffer);
                MessageObject message = ((MessageObject)(buffer.BinaryDeserialization()));
                ServerActions(message, client);

            }
        }

        public void StopServer()
        {
            running = false;
            acceptingThread.Abort();
            receivingThread.Abort();
            sendingThread.Abort();

            Thread.Sleep(1000);

            serverSocket.Shutdown(SocketShutdown.Both);
            serverSocket.Dispose();
            serverSocket.Close();
        }

        public void SendData(MessageObject message , Socket client)
        {
            sendingThread = new Thread(() =>
             {
                 client.Send(message.BinarySerialization());
             });
            sendingThread.Start();
        }

        public void ServerActions(MessageObject message, Socket client)
        {
            switch (message.FormIdentifier)
            {
                case 1:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            case 1:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        case 1:
                                            {
                                                Farmer farmer = new Farmer();
                                                Farmer[] AllFarmers = farmer.FarmerSelection();
                                                message.Data = AllFarmers.BinarySerialization();
                                                SendData(message,client);
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}

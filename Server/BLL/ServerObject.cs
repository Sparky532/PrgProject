using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BLL;

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
            iPAddress = Dns.GetHostAddresses("localhost")[1];
            endpoint = new IPEndPoint(iPAddress, 19200);

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
                // MessageObject message = (MessageObject)buffer.BinaryDeserialization();
                //ServerActions(message);

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

        public void SendData()
        {

        }

        public void ServerActions(MessageObject message)
        {

        }
    }
}

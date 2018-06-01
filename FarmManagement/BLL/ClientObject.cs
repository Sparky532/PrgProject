using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FarmManagement.BLL
{
    public class ClientObject
    {
        bool running = true;
        List<Socket> clients = new List<Socket>();
        IPAddress iPAddress;
        IPEndPoint endpoint;
        Socket clientSocket;
        Thread receivingThread;
        Thread sendingThread;

        public ClientObject()
        {
            InitializeServer();
            StartServer();
        }

        private void InitializeServer()
        {
            iPAddress = Dns.GetHostAddresses("localhost")[1];
            endpoint = new IPEndPoint(iPAddress, 19200);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void StartServer()
        {
            clientSocket.Connect(endpoint);

            receivingThread = new Thread(() => ReceiveData());
            receivingThread.Start();
        }
        public void ReceiveData()
        {
            while (running)
            {
                byte[] buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.Receive(buffer);
                // MessageObject message = (MessageObject)buffer.BinaryDeserialization();
                //ClientActions(message);

            }
        }
        public void StopClient()
        {
            running = false;
            receivingThread.Abort();
            sendingThread.Abort();

            Thread.Sleep(1000);

            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Dispose();
            clientSocket.Close();
        }

        public void SendData()
        {

        }

        public void ClientActions(MessageObject message)
        {

        }
    }
}

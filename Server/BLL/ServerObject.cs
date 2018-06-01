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
            Console.WriteLine("Initializing Server.....");

            iPAddress = Dns.GetHostAddresses(Changeables.ipNetwork)[1];
            endpoint = new IPEndPoint(iPAddress, Changeables.portNumber);

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Thread.Sleep(1000);

            Console.WriteLine("Server Initialized");
        }

        private void StartServer()
        {
            Console.WriteLine("Starting Server....");
            serverSocket.Bind(endpoint);
            serverSocket.Listen(10);
            Thread.Sleep(1000);

            Console.WriteLine("Server Started");

            acceptingThread = new Thread(() => AllowConnection());
            acceptingThread.Start();
        }

        private void AllowConnection()
        {
            while (running)
            {
                Socket client = serverSocket.Accept();
                clients.Add(client);
               // Thread.Sleep(100);
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
                Console.WriteLine("Message Received From " + client.RemoteEndPoint);

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
            Console.WriteLine("Data Sent to " + client.RemoteEndPoint);

        }

        public void ServerActions(MessageObject message, Socket client)
        {
            switch (message.FormIdentifier)
            {
                //From Farmer Selection
                case 1:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            //Farmer
                            case 1:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Select
                                        case 1:
                                            {
                                                Farmer farmer = new Farmer();
                                                Farmer[] AllFarmers = farmer.FarmerSelection();
                                                message.Data = AllFarmers.BinarySerialization();
                                                SendData(message, client);
                                                break;
                                            }
                                            //Delete
                                        case 2:
                                            {
                                                Farmer farmer = (Farmer)message.Data.BinaryDeserialization();
                                                farmer.DeleteFarmer();
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
                //From Farmer Creation
                case 2:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            //Farmer
                            case 1:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Insert
                                        case 2:
                                            {
                                                Farmer farmer = (Farmer)message.Data.BinaryDeserialization();
                                                farmer.InsertFarmer();
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
                //From Farm Creation
                case 3:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            //Farm
                            case 2:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Insert
                                        case 2:
                                            {
                                                Farm farm = (Farm)message.Data.BinaryDeserialization();
                                                farm.insertFarm();
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
                //From Animal Selection
                case 4:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            //Animal
                            case 3:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Insert
                                        case 2:
                                            {
                                                Animal animal = new Animal();
                                                List<AnimalsSelected> animalsSelected = (List<AnimalsSelected>)message.Data.BinaryDeserialization();
                                                animal.AddAnimal(animalsSelected);
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    break;
                                }
                                //Species
                            case 4:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Select
                                        case 1:
                                            {
                                                AnimalsSelected animalsSelected = new AnimalsSelected();
                                                List<Species> species=animalsSelected.getAnimalName();
                                                message.Data = species.BinarySerialization();
                                                SendData(message, client);
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
                //From Add Species
                case 5:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            //Species
                            case 4:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Insert
                                        case 2:
                                            {
                                                Species species = (Species)message.Data.BinaryDeserialization();
                                                species.writeSpecies();
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
                //From Farm View
                case 6:
                    {
                        switch (message.ObjectIdentifier)
                        {
                            //Farm
                            case 2:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Select
                                        case 1:
                                            {
                                                int id = (int)message.Data.BinaryDeserialization();
                                                Farm farm = new Farm();
                                                List<Farm> farms = farm.selectFarm(id);
                                                message.Data = farms.BinarySerialization();
                                                SendData(message, client);
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    break;
                                }
                            //Animal
                            case 3:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Select
                                        case 1:
                                            {
                                                int id = (int)message.Data.BinaryDeserialization();
                                                Animal animal = new Animal();
                                                List<Animal> animals = animal.selectAnimals(id);
                                                message.Data = animals.BinarySerialization();
                                                SendData(message, client);
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    break;
                                }
                                //Location
                            case 5:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Select
                                        case 1:
                                            {
                                                int id = (int)message.Data.BinaryDeserialization();
                                                Location location = new Location();
                                                List<Location> locations = location.selectLocation(id);
                                                message.Data = locations.BinarySerialization();
                                                SendData(message, client);
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

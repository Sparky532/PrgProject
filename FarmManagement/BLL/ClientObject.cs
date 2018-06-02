﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HelperLibrary;
using System.Windows.Forms;

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

        public ClientObject(bool firstStartup, MessageObject message)
        {
            InitializeServer();
            StartServer();
            if (firstStartup)
            {
                Thread.Sleep(2500);
                SendData(message);
            }
        }
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
                MessageObject message = (MessageObject)buffer.BinaryDeserialization();
                ClientActions(message);

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

        public void SendData(MessageObject message)
        {
            // Thread.Sleep(1000);
            clientSocket.Send(message.BinarySerialization());
        }

        public void ClientActions(MessageObject message)
        {
            switch (message.FormIdentifier)
            {
                //Farmer Selection
                case 1:
                    {

                        Farmer_Selection farmerSelection = (Farmer_Selection)Form.ActiveForm;

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
                                                Farmer[] AllFarmers = (Farmer[])message.Data.BinaryDeserialization();
                                                //farmerSelection.ReceiveFarmers(AllFarmers);
                                                InvokeFarmer(AllFarmers, farmerSelection);
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
                    //Animal Selection
                case 4:
                    {

                        Animal_Selection animalSelection = (Animal_Selection)Form.ActiveForm;

                        switch (message.ObjectIdentifier)
                        {
                            //Species
                            case 4:
                                {
                                    switch (message.ActionIdentifier)
                                    {
                                        //Select
                                        case 1:
                                            {
                                                List<Species> Species = (List<Species>)message.Data.BinaryDeserialization();

                                               // Farmer[] AllFarmers = (Farmer[])message.Data.BinaryDeserialization();
                                               // animalSelection.ReceiveAnimals(Species);
                                                InvokeAnimal(Species, animalSelection);
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
                    //Farm View
                case 6:
                    {

                        Farmer_Selection farmerSelection = (Farmer_Selection)Form.ActiveForm;

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
                                                //Farmer[] AllFarmers = (Farmer[])message.Data.BinaryDeserialization();
                                                //farmerSelection.ReceiveFarmers(AllFarmers);
                                                //InvokeFarmer(AllFarmers, farmerSelection);
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
                                                //Farmer[] AllFarmers = (Farmer[])message.Data.BinaryDeserialization();
                                                //farmerSelection.ReceiveFarmers(AllFarmers);
                                                //InvokeFarmer(AllFarmers, farmerSelection);
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
                                                //Farmer[] AllFarmers = (Farmer[])message.Data.BinaryDeserialization();
                                                //farmerSelection.ReceiveFarmers(AllFarmers);
                                                //InvokeFarmer(AllFarmers, farmerSelection);
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
        private void InvokeFarmer(Farmer[] AllFarmers, Farmer_Selection farmerSelection)
        {
            try
            {
                if (farmerSelection.InvokeRequired)
                {
                    farmerSelection.Invoke(new Action<Farmer[], Farmer_Selection>(InvokeFarmer), AllFarmers, farmerSelection);
                }
                farmerSelection.ReceiveFarmers(AllFarmers);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void InvokeAnimal(List<Species> allSpecies, Animal_Selection animalSelection)
        {
            try
            {
                if (animalSelection.InvokeRequired)
                {
                    animalSelection.Invoke(new Action<List<Species>, Animal_Selection> (InvokeAnimal), allSpecies, animalSelection);
                }
                animalSelection.ReceiveAnimals(allSpecies);
            }
            catch (NullReferenceException)
            {
            }
        }
    }
}

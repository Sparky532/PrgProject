using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.BLL;
using System.Runtime.InteropServices;
using System.Threading;

namespace Server
{
    class Program
    {
       static ServerObject so;

        static void Main(string[] args)
        {
            //Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            so = new ServerObject();
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;            
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            so.StopServer();
        }
    }
}

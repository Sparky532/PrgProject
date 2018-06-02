using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using FarmManagement.BLL;
using System.Threading;

namespace FarmManagement
{
    public partial class LoadingScreen : Form
    {
        Farmer[] AllFarmers = new Farmer[5];
        Farmer farmer = new Farmer();
        Farmer CurrentFarmer = new Farmer();
        ClientObject co = new ClientObject();

        int index = 0;
        bool received = false;
        bool FirstRun = false;

        delegate void MyDelegate();
        event MyDelegate myEvent;

        public void ReceiveFarmers(Farmer[] farmers)
        {
           
            if (!received)
            {
                for (int i = 0; i < 80; i++)
                {
                    pgbLoading.Increment(1);
                    Thread.Sleep(1);
                }
                index = 0;
                foreach (Farmer item in farmers)
                {
                    CheckReceiveMethod(item);
                    index++;
                }
                for (int i = 0; i < 80; i++)
                {
                    pgbLoading.Increment(1);
                    Thread.Sleep(1);
                }             

                myEvent.Invoke();
                received = true;
            }
        }
        public void CheckReceiveMethod(Farmer farmer)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Farmer>(CheckReceiveMethod), farmer);
            }
            AllFarmers[index] = farmer;
        }

        public LoadingScreen()
        {
            InitializeComponent();
            FormStart();

        }        

        private void FormStart()
        {
          
            MessageObject message = new MessageObject(new byte[1], 0, 1, 1);
            co = new ClientObject(true, message);
            myEvent = Complete;
           
        }

        private void Complete()
        {           

            if (pgbLoading.Value >= pgbLoading.Maximum)
            {
                Farmer_Selection navToFarmerSelection = new Farmer_Selection(AllFarmers);
                this.Hide();
                navToFarmerSelection.ShowDialog();
                this.Close();
            }
         
        }
    }
}

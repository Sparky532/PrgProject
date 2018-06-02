using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    public partial class SplashScreen : Form
    {
        Timer timer;
        delegate void TimerStop(object sender, EventArgs e);
        event TimerStop stopping;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            //creating the timer that will run for 3 seconds
            timer = new Timer
            {
                Interval = 1000
            };

            timer.Start();

            //event that will run when the timer stops
            stopping = new TimerStop((object send, EventArgs args) =>
            {
                timer.Stop();
                LoadingScreen form = new LoadingScreen();
                this.Hide();
                form.ShowDialog();
                this.Close();
            });

            //calling the stopping event
            timer.Tick += new EventHandler(stopping);
        }
    }
}

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
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void timerStop(object sender, EventArgs e)
        {
            timer.Stop();
            Farmer_Selection form = new Farmer_Selection();
            form.Show();
            this.Hide();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Shown_1(object sender, EventArgs e)
        {

            timer = new Timer();
            timer.Interval = 3000;
            timer.Start();

            timer.Tick += timerStop;
        }
    }
}

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

namespace FarmManagement
{
    public partial class Farm_Creation : Form
    {
        Farmer farmer = new Farmer();
        int farmerID = 0;

        public Farm_Creation()
        {
            InitializeComponent();
            farmer = farmer.NewestFarmer();

        }
        public Farm_Creation(int id)
        {
            InitializeComponent();
            farmer.ID = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double size = double.Parse(txtSize.Text);
            Farm f = new Farm(name,size);
            f.insertFarm();
            Animal_Selection assd = new Animal_Selection(farmer.ID);
            assd.Show();
            this.Hide();
        }
    }
}

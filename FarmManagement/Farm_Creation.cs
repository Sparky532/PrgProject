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
        string name;
        double size =0 ;
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
            name = txtFarmName.Text;
            //MessageBox.Show(size.ToString());
            if (size == 0)
            {
                MessageBox.Show("Please Select a Farm Size");
            }
            else
            {
            Farm f = new Farm(name, size);
            f.insertFarm();
            Animal_Selection assd = new Animal_Selection(farmer.ID);
            assd.Show();
            this.Hide();
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbxSmallClicked.Visible = true;
            pbxMediumClicked.Visible = false;
            pbxLargeClicked.Visible = false;
            string name = txtFarmName.Text;
            size = 400;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtFarmName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFarmName_Click(object sender, EventArgs e)
        {
            txtFarmName.Text = "";
            txtFarmName.ForeColor = Color.Black;
            txtFarmName.Font = new Font(this.txtFarmName.Font,FontStyle.Regular);
        }

        private void Farm_Creation_Load(object sender, EventArgs e)
        {
            pbxSmallClicked.Visible = false;
            pbxMediumClicked.Visible = false;
            pbxLargeClicked.Visible = false;
        }

        private void pbxSmallClicked_Click(object sender, EventArgs e)
        {
            pbxSmallClicked.Visible = false;
            size = 0;
        }

        private void pbxMedium_Click(object sender, EventArgs e)
        {
            pbxSmallClicked.Visible = false;
            pbxMediumClicked.Visible = true;
            pbxLargeClicked.Visible = false;
            string name = txtFarmName.Text;
            size = 900;
        }

        private void pbxMediumClicked_Click(object sender, EventArgs e)
        {
            pbxMediumClicked.Visible = false;
            size = 0;

        }

        private void pbxLarge_Click(object sender, EventArgs e)
        {
            pbxSmallClicked.Visible = false;
            pbxMediumClicked.Visible = false;
            pbxLargeClicked.Visible = true;
            string name = txtFarmName.Text;
            size = 1600;
        }

        private void pbxLargeClicked_Click(object sender, EventArgs e)
        {
            pbxLargeClicked.Visible = false;
            size = 0;
        }
    }
}

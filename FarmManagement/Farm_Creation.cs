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
            this.ActiveControl = null;
            pbxSmallClicked.Visible = false;
            pbxMediumClicked.Visible = false;
            pbxLargeClicked.Visible = false;

            pbxBackground.Controls.Add(pbxSmallClicked);
            pbxBackground.Controls.Add(pbxSmall);
            pbxBackground.Controls.Add(pbxMediumClicked);
            pbxBackground.Controls.Add(pbxMedium);
            pbxBackground.Controls.Add(pbxLargeClicked);
            pbxBackground.Controls.Add(pbxLarge);
            pbxBackground.Controls.Add(pbxCreate);

            pbxSmallClicked.Location = new Point(12, 64);
            pbxSmall.Location = new Point(12, 64);
            pbxMediumClicked.Location = new Point(247, 64);
            pbxMedium.Location = new Point(247, 64);
            pbxLargeClicked.Location = new Point(482, 64);
            pbxLarge.Location = new Point(482, 64);
            pbxCreate.Location = new Point(257, 225);
        }

        private void pbxMedium_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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
            this.ActiveControl = null;
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

        private void txtFarmName_Leave(object sender, EventArgs e)
        {
            if (txtFarmName.Text == "")
            {
                txtFarmName.Text = "Farm name";
                txtFarmName.ForeColor = Color.Gray;
                txtFarmName.Font = new Font(this.txtFarmName.Font, FontStyle.Italic);
            }
        }

        private void pbxSmall_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            pbxSmallClicked.Visible = true;
            pbxMediumClicked.Visible = false;
            pbxLargeClicked.Visible = false;
            string name = txtFarmName.Text;
            size = 400;
        }

        private void pbxSmallClicked_Click_1(object sender, EventArgs e)
        {
            pbxSmallClicked.Visible = false;
            size = 0;
        }

        private void Farm_Creation_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pbxCreate_Click(object sender, EventArgs e)
        {

        }
    }
}

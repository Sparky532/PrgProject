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
using System.IO;
using System.Drawing.Imaging;

namespace FarmManagement
{
    public partial class Add_Species : Form
    {
        public Add_Species()
        {
            InitializeComponent();
            cbxType.SelectedIndex = 0;

            pbxSpeciesBackground.Controls.Add(pbxBack);
            pbxSpeciesBackground.Controls.Add(pbxAdd);
            pbxSpeciesBackground.Controls.Add(pbxBrowse);

            pbxBack.Location = new Point(323, 410);
            pbxBack.Location = new Point(23, 2);
            pbxBrowse.Location = new Point(530, 310);
            
        }

        private void btnWriteToTxt_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            //Write the name to a textfile so that developers can add the species to the database themselves
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            Stream FilePath = null;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "png files (*.png)|*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.DefaultExt = ".png";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((FilePath = fileDialog.OpenFile()) != null)
                    {
                        txtChooseimage.Text = fileDialog.FileName;
                        Image NewAnimal = Image.FromFile(txtChooseimage.Text);
                        pbxNewAnimal.Image = NewAnimal;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not find the file you want");
                    throw;
                }
            }
        }

        private void Add_Species_Load(object sender, EventArgs e)
        {
            pbxSpeciesBackground.Controls.Add(lblName);
            pbxSpeciesBackground.Controls.Add(lblChooseImage);
            pbxSpeciesBackground.Controls.Add(lblAddSpecies);
            pbxSpeciesBackground.Controls.Add(lblSpaceNeeded);
            pbxSpeciesBackground.Controls.Add(lblSpeed);
            pbxSpeciesBackground.Controls.Add(lblType);

            lblName.Location = new Point(110, 99);
            lblChooseImage.Location = new Point(40, 322);
            lblAddSpecies.Location = new Point(256, 28);
            lblType.Location = new Point(115, 154);
            lblSpaceNeeded.Location = new Point(40, 263);
            lblSpeed.Location = new Point(93, 213);
        }

        private void btnBackToAnimalSelection_Click(object sender, EventArgs e)
        {

        }

        private void Add_Species_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Animal_Selection navanimalselection = new Animal_Selection();
            navanimalselection.Show();
            this.Hide();
        }

        private void pbxSpeciesBackground_Click(object sender, EventArgs e)
        {

        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + @"\" + txtName.Text + ".png") == false)
            {
                pbxNewAnimal.Image.Save(Environment.CurrentDirectory + @"\" + txtName.Text + ".png", ImageFormat.Png);
                if (txtName != null && txtSpace != null && txtSpeed != null && cbxType.SelectedItem.ToString() != null)
                {
                    Species spec = new Species();
                    spec.AnimalName = txtName.Text;
                    spec.Animaltype = cbxType.SelectedItem.ToString();
                    spec.Space = double.Parse(txtSpace.Text);
                    spec.Speed = double.Parse(txtSpeed.Text);
                    //Write the four items to the text file
                    spec.writeSpecies();
                }

            }
            Animal_Selection assd = new Animal_Selection();
            assd.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + @"\" + txtName.Text + ".png") == false)
            {
                pbxNewAnimal.Image.Save(Environment.CurrentDirectory + @"\" + txtName.Text + ".png", ImageFormat.Png);
                if (txtName != null && txtSpace != null && txtSpeed != null && cbxType.SelectedItem.ToString() != null)
                {
                    Species spec = new Species();
                    spec.AnimalName = txtName.Text;
                    spec.Animaltype = cbxType.SelectedItem.ToString();
                    spec.Space = double.Parse(txtSpace.Text);
                    spec.Speed = double.Parse(txtSpeed.Text);
                    //Write the four items to the text file
                    spec.writeSpecies();
                }

            }
            Animal_Selection assd = new Animal_Selection();
            assd.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stream FilePath = null;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "png files (*.png)|*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.DefaultExt = ".png";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((FilePath = fileDialog.OpenFile()) != null)
                    {
                        txtChooseimage.Text = fileDialog.FileName;
                        Image NewAnimal = Image.FromFile(txtChooseimage.Text);
                        pbxNewAnimal.Image = NewAnimal;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not find the file you want");
                    throw;
                }
            }
        }
    }
}

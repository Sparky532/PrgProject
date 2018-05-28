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
        List<AnimalsSelected> animalsSelected = new List<AnimalsSelected>();
        List<Species> animalSpecies = new List<Species>();
        int farmerID = 0;
        public Add_Species(List<AnimalsSelected> animalsSelectedP, List<Species> animalSpeciesP,int farmerIDP)
        {
            InitializeComponent();
            this.animalsSelected = animalsSelectedP;
            this.animalSpecies = animalSpeciesP;
            this.farmerID = farmerIDP;
            cbxType.SelectedIndex = 0;

            pbxSpeciesBackground.Controls.Add(pbxBack);
            pbxSpeciesBackground.Controls.Add(pbxAdd);
            pbxSpeciesBackground.Controls.Add(pbxBrowse);
            pbxSpeciesBackground.Controls.Add(pbxNewAnimal);
            pbxSpeciesBackground.Controls.Add(pbxAddSpecies);

            pbxBack.Location = new Point(23, 2);
            pbxBrowse.Location = new Point(530, 310);
            pbxNewAnimal.Location = new Point(545, 99);
            pbxAddSpecies.Location = new Point(250, 12);
           
        }      

        private void Add_Species_Load(object sender, EventArgs e)
        {
            pbxSpeciesBackground.Controls.Add(lblName);
            pbxSpeciesBackground.Controls.Add(lblChooseImage);
            pbxSpeciesBackground.Controls.Add(lblSpaceNeeded);
            pbxSpeciesBackground.Controls.Add(lblSpeed);
            pbxSpeciesBackground.Controls.Add(lblType);

            lblName.Location = new Point(110, 99);
            lblChooseImage.Location = new Point(40, 322);
            lblType.Location = new Point(115, 154);
            lblSpaceNeeded.Location = new Point(40, 263);
            lblSpeed.Location = new Point(93, 213);
        }
        //goes back to animal Selection 
        private void pbxBack_Click(object sender, EventArgs e)
        {
            Animal_Selection form = new Animal_Selection(animalsSelected, animalSpecies, farmerID);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        // adds the new species and goes back to animal Selection Screen
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChooseimage.Text == null || txtChooseimage.Text == "")
                {
                    throw new NoImageDirectoryException();
                }
                if (File.Exists(Environment.CurrentDirectory + @"\" + txtName.Text + ".png") == false)
                {
                    pbxNewAnimal.Image.Save(Environment.CurrentDirectory + @"\" + txtName.Text + ".png", ImageFormat.Png);

                }
                if (txtName != null && txtSpace != null && txtSpeed != null && cbxType.SelectedItem.ToString() != null)
                {
                    Species spec = new Species();
                    spec.AnimalName = txtName.Text;
                    spec.Animaltype = cbxType.SelectedItem.ToString();
                    spec.Space = double.Parse(txtSpace.Text);
                    spec.Speed = double.Parse(txtSpeed.Text);
                    animalSpecies.Add(spec);
                    //Write the four items to the text file
                    spec.writeSpecies();
                }

            
            
                Animal_Selection form = new Animal_Selection(animalsSelected, animalSpecies, farmerID);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            catch (NoImageDirectoryException)
            {
                MessageBox.Show("Please ensure a picture is selected, and the URL to that image is loaded!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure that Speed and Space are both numbers!");
            }
        }
        //if enter key is pressed it Adds the Species
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtChooseimage.Text == null || txtChooseimage.Text == "")
                {
                    throw new NoImageDirectoryException();
                }
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
                Animal_Selection form = new Animal_Selection();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            catch (NoImageDirectoryException)
            {
                MessageBox.Show("Please ensure a picture is selected, and the URL to that image is loaded!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure that Speed and Space are both numbers!");
            }
        }
        //Opens filedialog so you can choose your File
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
                        pbxNewAnimal.Visible = true;
                        pbxNewAnimal.Image = NewAnimal;
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not find the file you want");
                    Species species = new Species();
                    species.NewSpeciesException();
                    throw;
                }
            }
        }

        private void pbxSpeciesBackground_Click(object sender, EventArgs e)
        {

        }
    }
}

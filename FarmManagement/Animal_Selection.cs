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
using System.Reflection;
using System.IO;

namespace FarmManagement
{
    public partial class Animal_Selection : Form
    {
        private int index = 0;
        List<AnimalsSelected> animalsSelected = new List<AnimalsSelected>();
        List<Species> animalSpecies = new List<Species>();
        BindingSource bs1 = new BindingSource();
        BindingSource bs2 = new BindingSource();
        bool animalsAdded = false;
        int ID = 0;

        public Animal_Selection()
        {
            InitializeComponent();
            pbxBackground.Controls.Add(pbxAnimal);
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            
        }
        public Animal_Selection(int id)
        {
            this.ID = id;
            InitializeComponent();
            pbxBackground.Controls.Add(pbxAnimal);
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;

        }

        private void Animal_Selection_Load(object sender, EventArgs e)
        {
            //Select the animal species from the database
            AnimalsSelected selects = new AnimalsSelected();
            animalSpecies = selects.getAnimalName();

            //Set binding sources
            bs2.DataSource = animalSpecies;
            bs1.DataSource = animalsSelected;

            //Link combo box
            cbxAnimals.DataSource = bs2;

            //If the box is empty make it display no animals yet
            if (animalsAdded == false)
            {
                lstAnimalsSelected.Items.Add("No animals yet");
            }

            pbxPanel.Controls.Add(pbxPrevious);
            pbxPanel.Controls.Add(pbxNext1);
            pbxPanel.Controls.Add(pbxAdd);
            pbxPanel.Controls.Add(pbxNext);
            pbxPanel.Controls.Add(pbxAddNew);
            pbxPanel.Controls.Add(pbxChange);

            pbxPrevious.Location = new Point(75,100);
            pbxNext1.Location = new Point(228,100);
            pbxAdd.Location = new Point(104,150);
            pbxNext.Location = new Point(443, 150);
            pbxAddNew.Location = new Point(443, 30);
            pbxChange.Location = new Point(450, 60);
        }

        private void btnAnimalAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnimalRemove_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewSpecies_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make the change part visible
            txtSelectedAnimalAmount.Visible = true;
            pbxChange.Visible = true;
            btnRemove.Visible = true;
            pbxAddNew.Visible = false;

            //Change the amount of specific species
            try
            {
                txtSelectedAnimalAmount.Text = ((AnimalsSelected)lstAnimalsSelected.SelectedItem).AnimalAmount.ToString();
            }
            catch (NullReferenceException)
            {
            }

        }

        private void btnChangeValues_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }
 
        private void cbxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

          



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void cbxAnimals_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxAnimals.Text != "")
            {
                Species speciesSelected = (Species)cbxAnimals.SelectedItem;
                string streamText = "FarmManagement.Resources." + speciesSelected.AnimalName + ".png";
                Assembly assembly = Assembly.GetExecutingAssembly();
                Stream AnimalImage = assembly.GetManifestResourceStream(streamText);
                if (AnimalImage != null)
                {
                    pbxAnimal.Image = (Image)new Bitmap(AnimalImage);
                }
                else
                {
                    String DirectoryPath = Environment.CurrentDirectory;
                //    MessageBox.Show(DirectoryPath);
                  //  DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10)+"\\Resources";
                    Image NewAnimal = Image.FromFile(DirectoryPath + @"\" + speciesSelected.AnimalName + ".png");
                    pbxAnimal.Image = NewAnimal;
                }
            }
            else
            {
                pbxAnimal.Image = null;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            try
            {
                int predatorsNum = 0;
                int preysNum = 0;
                //Checking to see that there is at least 1 prey and 1 predator
                foreach (AnimalsSelected item in animalsSelected)
                {
                    if (item.Animaal.Animaltype == "Predator")
                    {
                        predatorsNum++;
                    }
                    else if (item.Animaal.Animaltype == "Prey")
                    {
                        preysNum++;
                    }
                }
                if (preysNum > 0 && predatorsNum > 0)
                {
                    //Making sure there is more than 3 types of animals selected
                    if (animalsSelected.Count >= 3)
                    {
                        //adding the animals
                        Animal animal = new Animal();
                        animal.AddAnimal(animalsSelected);
                        Farm_View navFarmView = new Farm_View(ID);
                        navFarmView.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new AnimalCriteriaNotMeetException("At least 3 different animals need to be selected");
                    }
                }
                else
                {
                    throw new AnimalCriteriaNotMeetException("At least 1 Prey and 1 Predator needs to be selected");
                }
            }
            catch (AnimalCriteriaNotMeetException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            //Make the change part not visible
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            btnRemove.Visible = false;
            pbxAddNew.Visible = true;

            //As soon as an animal is added make sure the binding source gets linked
            animalsAdded = true;
            if (animalsAdded)
            {
                lstAnimalsSelected.DataSource = bs1;
            }

            try
            {
                AnimalsSelected selects = new AnimalsSelected();

                //Checking if there are still animals in the combo box
                if (cbxAnimals.SelectedItem != null)
                {
                    string animalname = cbxAnimals.SelectedItem.ToString();
                    int amount = int.Parse(txtAnimalAmount.Text);

                    //Making sure there is more than 5 animals
                    if (amount >= 5)
                    {
                        Species selectedSpecies = ((Species)cbxAnimals.SelectedItem);
                        selects.Animaal = selectedSpecies;
                        selects.AnimalAmount = amount;
                        animalsSelected.Add(selects);

                        //Refresh the List
                        bs1.ResetBindings(false);

                        int currentIndex = cbxAnimals.SelectedIndex;

                        //Remove option of animal already added
                        animalSpecies.RemoveAt(currentIndex);

                        //Refresh the combo box
                        bs2.ResetBindings(false);
                    }
                    else
                    {
                        throw new AnimalCriteriaNotMeetException("At least 5 animals have to be selected");
                    }
                }
            }
            catch (AnimalCriteriaNotMeetException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                index--;
                if (index < 0)
                {
                    throw new NegativeAnimalsException("Cannot have a negative amount of animals");
                }
                else
                {
                    txtAnimalAmount.Text = index.ToString();
                }
            }
            catch (NegativeAnimalsException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                index++;
            }
        }

        private void pbxNext1_Click(object sender, EventArgs e)
        {
            index++;
            txtAnimalAmount.Text = index.ToString();
        }

        private void pbxChange_Click(object sender, EventArgs e)
        {
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            btnRemove.Visible = false;
            pbxAddNew.Visible = true;
            try
            {
                int newAmount = int.Parse(txtSelectedAnimalAmount.Text);

                //Make sure the new amount is still greater than 5
                if (newAmount >= 5)
                {
                    AnimalsSelected currentAnimal = ((AnimalsSelected)lstAnimalsSelected.SelectedItem);
                    int counter = 0;
                    foreach (AnimalsSelected item in animalsSelected)
                    {
                        if (item.Equals(currentAnimal))
                        {
                            currentAnimal = item;
                            currentAnimal.AnimalAmount = newAmount;
                            animalsSelected.Add(currentAnimal);

                            //Remove old instance of the animal
                            animalsSelected.RemoveAt(counter);
                            //Reset List
                            bs1.ResetBindings(false);
                            return;
                        }
                        counter++;
                    }

                }
                else
                {
                    throw new AnimalCriteriaNotMeetException("At least 5 animals have to be selected");
                }
            }
            catch (AnimalCriteriaNotMeetException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxAddNew_Click(object sender, EventArgs e)
        {
            //Go to add species form
            Add_Species addSpecies = new Add_Species();
            addSpecies.Show();
            this.Hide();
        }

        private void cbxAnimals_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Animal_Selection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            btnRemove.Visible = false;
            pbxAddNew.Visible = true;
            AnimalsSelected assd = (AnimalsSelected)lstAnimalsSelected.SelectedItem;
            animalsSelected.Remove(assd);
            //Refresh the List
            bs1.ResetBindings(false);

            //Remove option of animal already added
            animalSpecies.Add(assd.Animaal);

            //Refresh the combo box
            bs2.ResetBindings(false);

            txtAnimalAmount.Text = "0";
        }

        private void pbxAnimal_Click(object sender, EventArgs e)
        {
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            btnRemove.Visible = false;
            pbxAddNew.Visible = true;
        }
    }
}

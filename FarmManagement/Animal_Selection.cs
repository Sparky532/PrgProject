﻿using System;
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
        }
        public Animal_Selection(int id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void Animal_Selection_Load(object sender, EventArgs e)
        {
            pbxBackground.Controls.Add(pbxAnimal);
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;

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

            //Link all buttons to panel
            pbxPanel.Controls.Add(pbxPrevious);
            pbxPanel.Controls.Add(pbxNext1);
            pbxPanel.Controls.Add(pbxAdd);
            pbxPanel.Controls.Add(pbxNext);
            pbxPanel.Controls.Add(pbxAddNew);
            pbxPanel.Controls.Add(pbxChange);
            pbxPanel.Controls.Add(pbxRemove);

            pbxPrevious.Location = new Point(75, 100);
            pbxNext1.Location = new Point(228, 100);
            pbxAdd.Location = new Point(104, 150);
            pbxNext.Location = new Point(443, 150);
            pbxAddNew.Location = new Point(443, 30);
            pbxChange.Location = new Point(355, 60);
            pbxRemove.Location = new Point(560, 30);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!lstAnimalsSelected.SelectedItem.ToString().Equals("No animals yet"))
                {
                    //Make the change part visible
                    txtSelectedAnimalAmount.Visible = true;
                    pbxChange.Visible = true;
                    pbxRemove.Visible = true;
                    pbxAddNew.Visible = false;

                    //Change the amount of specific species
                    txtSelectedAnimalAmount.Text = ((AnimalsSelected)lstAnimalsSelected.SelectedItem).AnimalAmount.ToString();
                }
            }
            catch (NullReferenceException nulls)
            {
                AnimalsSelected selected = new AnimalsSelected();
                selected.NullReferenceExpetion(nulls.Message.ToString());
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
                
                //Counting predator and prey
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

                //Checking to see that there is at least 1 prey and 1 predator
                if (preysNum > 0 && predatorsNum > 0)
                {
                    //Making sure there is more than 3 types of animals selected
                    if (animalsSelected.Count >= 3)
                    {
                        //adding the animals
                        Animal animal = new Animal();
                        animal.AddAnimal(animalsSelected);
                        Farm_View form = new Farm_View(ID);
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
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
            pbxRemove.Visible = false;
            pbxAddNew.Visible = true;

            lstAnimalsSelected.DataSource = bs1;

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
                        quickSortSelected(animalsSelected, 0, animalsSelected.Count - 1);
                        bs1.ResetBindings(false);
                        int currentIndex = cbxAnimals.SelectedIndex;

                        //Remove option of animal already added
                        animalSpecies.RemoveAt(currentIndex);

                        //Refresh the combo box
                        quickSortSpecies(animalSpecies, 0, animalSpecies.Count - 1);
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
            catch (FormatException)
            {
                MessageBox.Show("Please ensure a number is entered!");
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
            pbxRemove.Visible = false;
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

                            quickSortSelected(animalsSelected, 0, animalsSelected.Count - 1);
                            //Reset List
                            bs1.ResetBindings(false);
                            quickSortSpecies(animalSpecies, 0, animalSpecies.Count - 1);
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
            catch (FormatException)
            {
                MessageBox.Show("Please ensure a number is entered!");
            }
        }

        private void pbxAddNew_Click(object sender, EventArgs e)
        {
            //Go to add species form
            Add_Species form = new Add_Species();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void cbxAnimals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void Animal_Selection_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void pbxAnimal_Click(object sender, EventArgs e)
        {
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            pbxRemove.Visible = false;
            pbxAddNew.Visible = true;
        }

        void quickSortSelected(List<AnimalsSelected> animalsSelected, int indexLow, int indexHigh)
        {
            if (indexLow < indexHigh)
            {
                /* split is partitioning index, arr[p] is now
                   at right place */
                int split = splitSelected(animalsSelected, indexLow, indexHigh);

                // Separately sort elements before partition and after partition
                quickSortSelected(animalsSelected, indexLow, split - 1);
                quickSortSelected(animalsSelected, split + 1, indexHigh);
            }
        }

        int splitSelected(List<AnimalsSelected> animalsSelected, int indexLow, int indexHigh)
        {
            AnimalsSelected pivot = animalsSelected[indexHigh];    // values are shifted around this value
            int i = (indexLow - 1);  // Index of smaller element
            AnimalsSelected temp;
            for (int j = indexLow; j <= indexHigh - 1; j++)
            {
                // If current element is smaller than or equal to pivot
                if (animalsSelected[j].Animaal.AnimalName.CompareTo(pivot.Animaal.AnimalName) <= 0)
                {
                    i++;    // increment index of smaller element
                    temp = animalsSelected[i];
                    animalsSelected[i] = animalsSelected[j];
                    animalsSelected[j] = temp;
                }
            }
            temp = animalsSelected[i + 1];
            animalsSelected[i + 1] = animalsSelected[indexHigh];
            animalsSelected[indexHigh] = temp;
            return (i + 1);
        }


        void quickSortSpecies(List<Species> animalSpecies, int indexLow, int indexHigh)
        {
            if (indexLow < indexHigh)
            {
                /* split is partitioning index, animalSpecies[indexHigh] is now
                   at right place */
                int split = splitSpecies(animalSpecies, indexLow, indexHigh);

                // Separately sort elements before partition and after partition
                quickSortSpecies(animalSpecies, indexLow, split - 1);
                quickSortSpecies(animalSpecies, split + 1, indexHigh);
            }
        }

        int splitSpecies(List<Species> animalSpecies, int indexLow, int indexHigh)
        {
            Species pivot = animalSpecies[indexHigh];    // values are shifted around this value
            int i = (indexLow - 1);  // Index of smaller element
            Species temp;
            for (int j = indexLow; j <= indexHigh - 1; j++)
            {
                // If current element is smaller than or equal to pivot, 
                if (animalSpecies[j].AnimalName.CompareTo(pivot.AnimalName) <= 0)
                {
                    i++;    // increment index of smaller element
                    temp = animalSpecies[i];
                    animalSpecies[i] = animalSpecies[j];
                    animalSpecies[j] = temp;
                }
            }
            temp = animalSpecies[i + 1];
            animalSpecies[i + 1] = animalSpecies[indexHigh];
            animalSpecies[indexHigh] = temp;
            return (i + 1);
        }

        private void pbxRemove_Click(object sender, EventArgs e)
        {
            txtSelectedAnimalAmount.Visible = false;
            pbxChange.Visible = false;
            pbxRemove.Visible = false;
            pbxAddNew.Visible = true;
            AnimalsSelected assd = (AnimalsSelected)lstAnimalsSelected.SelectedItem;
            animalsSelected.Remove(assd);
            //Refresh the List
            if (animalsSelected.Count > 0)
            {
                quickSortSelected(animalsSelected, 0, animalsSelected.Count - 1);
            }
            bs1.ResetBindings(false);
            //Remove option of animal already added
            animalSpecies.Add(assd.Animaal);

            //Refresh the combo box
            quickSortSpecies(animalSpecies, 0, animalSpecies.Count - 1);
            bs2.ResetBindings(false);

            txtAnimalAmount.Text = "0";
        }
    }
}

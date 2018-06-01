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
    public partial class Farm_View : Form
    {
        List<Farm> farms = new List<Farm>();
        List<Location> locations = new List<Location>();
        List<Animal> animals = new List<Animal>();
        int ID = 0;
        public Farm_View(int id)
        {
            InitializeComponent();
            this.ID = id;
            
        }
        public Farm_View()
        {
            InitializeComponent();
         
        }

        private void Farm_View_Load(object sender, EventArgs e)
        {
            Farm f = new Farm();
            Location l = new Location();
            Animal a = new Animal();
            farms = f.selectFarm(ID);
            locations = l.selectLocation(ID);
            animals = a.selectAnimals(ID);
            lstFarm.DataSource = farms;
            lstLocations.DataSource = locations;
            lstAnimals.DataSource = animals;
        }

      

        private void returnToFarmerSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Farmer_Selection form = new Farmer_Selection();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void lionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Selectitem = from item in animals
                              where item.Species.ToString() == "Lion"
                              select item.Species.AnimalName + " " + item.MateState + " " + item.Gender + " " + item.EatingTime;
            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }

        }

        private void tigerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Selectitem = from item in animals
                              where item.Species.ToString() == "Tiger"
                              select item.Species.AnimalName + " " + item.MateState + " " + item.Gender + " " + item.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void cowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Selectitem = from item in animals
                              where item.Species.ToString() == "Cow"
                              select item.Species.AnimalName + " " + item.MateState + " " + item.Gender + " " + item.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void sheepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Selectitem = from item in animals
                              where item.Species.ToString() == "Sheep"
                              select item.Species.AnimalName + " " + item.MateState + " " + item.Gender + " " + item.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Selectitem = from item in animals
                              where item.Species.ToString() == "Horse"
                              select item.Species.AnimalName + " " + item.MateState + " " + item.Gender + " " + item.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void allAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectAnimals = from item in animals                              
                              select item.Species.AnimalName + " " + item.MateState + " " + item.Gender + " " + item.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectAnimals)
            {
                lstAnimals.Items.Add(item);
            }
        }
    }
}

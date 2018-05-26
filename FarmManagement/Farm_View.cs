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
        List<Location> locations = new List<BLL.Location>();
        List<Animal> animals = new List<Animal>();
        int ID = 0;
        public Farm_View(int id)
        {
            InitializeComponent();
            this.ID = id;
            //Farm f = new Farm();
            //Location l = new BLL.Location();
            //Animal a = new Animal();
            //farms = f.selectFarm(id);
            //locations = l.selectLocation();
            //animals = a.selectAnimals();
            //lstFarm.DataSource = farms;
            //lstLocations.DataSource = locations;
            //lstAnimals.DataSource = animals;
        }
        public Farm_View()
        {
            InitializeComponent();
            //int id = 1;
            //Farm f = new Farm();
            //Location l = new BLL.Location();
            //Animal a = new Animal();
            //farms = f.selectFarm(id);
            //locations = l.selectLocation();
            //animals = a.selectAnimals();
            //lstFarm.DataSource = farms;
            //lstLocations.DataSource = locations;
            //lstAnimals.DataSource = animals;
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

        private void Farm_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(0);
        }

        private void returnToFarmerSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Farmer_Selection navFarmerSelection = new Farmer_Selection();
            navFarmerSelection.Show();
            this.Hide();
        }

        private void lionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectLions = from lions in animals
                              where lions.Species.ToString() == "Lion"
                              select lions.Species.AnimalName + " " + lions.MateState + " " + lions.Gender + " " + lions.EatingTime;
            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectLions)
            {
                lstAnimals.Items.Add(item);
            }

        }

        private void tigerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectLions = from lions in animals
                              where lions.Species.ToString() == "Tiger"
                              select lions.Species.AnimalName + " " + lions.MateState + " " + lions.Gender + " " + lions.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectLions)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void cowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectLions = from lions in animals
                              where lions.Species.ToString() == "Cow"
                              select lions.Species.AnimalName + " " + lions.MateState + " " + lions.Gender + " " + lions.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectLions)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void sheepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectLions = from lions in animals
                              where lions.Species.ToString() == "Sheep"
                              select lions.Species.AnimalName + " " + lions.MateState + " " + lions.Gender + " " + lions.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectLions)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectLions = from lions in animals
                              where lions.Species.ToString() == "Horse"
                              select lions.Species.AnimalName + " " + lions.MateState + " " + lions.Gender + " " + lions.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectLions)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void allAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectAnimals = from lions in animals                              
                              select lions.Species.AnimalName + " " + lions.MateState + " " + lions.Gender + " " + lions.EatingTime;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (string item in SelectAnimals)
            {
                lstAnimals.Items.Add(item);
            }
        }
    }
}

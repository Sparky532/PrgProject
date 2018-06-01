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
using System.Threading;

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
            pnlMenu.Location = new Point(-190, 0);
            pnlSortSubMenu.Location = new Point(-190, 50);
            pnlSettingsSubMenu.Location = new Point(-190, 50);
            btnOpenMenu.Location = new Point(0,0);

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
            //form.Show();
            //this.Hide();
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

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            btnOpenMenu.Visible = false;
            pnlMenu.Visible = true;
            Thread openMenu = new Thread(() => {
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i,0,pnlMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
        }
        public void moveMenu(int x, int y, Panel pnl)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int, int, Panel>(moveMenu), x, y, pnl);
            }
            pnl.Location = new Point(x, y);
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            btnOpenMenu.Visible = true;
            pnlMenu.Visible = true;
            Thread openMenu = new Thread(() => {
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 0, pnlMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            openMenu = new Thread(() => {
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 50, pnlSortSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            openMenu = new Thread(() => {
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 50, pnlSettingsSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            pnlSortSubMenu.Visible = true;
            Thread openMenu = new Thread(() => {
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i, 50, pnlSortSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            pnlSortSubMenu.Visible = true;
            Thread openMenu = new Thread(() => {
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 50, pnlSortSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSettingsSubMenu.Visible = true;
            Thread openMenu = new Thread(() => {
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i, 50, pnlSettingsSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pnlSettingsSubMenu.Visible = true;
            Thread openMenu = new Thread(() => {
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 50, pnlSettingsSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
        }

        private void SortLion_MouseMove(object sender, MouseEventArgs e)
        {
            SortLion.BackColor = Color.FromArgb(125, 204, 242);
        }

        private void SortLion_MouseLeave(object sender, EventArgs e)
        {
            SortLion.BackColor = Color.WhiteSmoke;
        }

        private void SortTiger_MouseMove(object sender, MouseEventArgs e)
        {
            SortTiger.BackColor = Color.FromArgb(125, 204, 242);
        }

        private void SortTiger_MouseLeave(object sender, EventArgs e)
        {
            SortTiger.BackColor = Color.WhiteSmoke;
        }

        private void SortCow_MouseMove(object sender, MouseEventArgs e)
        {
            SortCow.BackColor = Color.FromArgb(125, 204, 242);
        }

        private void SortCow_MouseLeave(object sender, EventArgs e)
        {
            SortCow.BackColor = Color.WhiteSmoke;
        }

        private void SortSheep_MouseMove(object sender, MouseEventArgs e)
        {
            SortSheep.BackColor = Color.FromArgb(125, 204, 242);
        }

        private void SortSheep_MouseLeave(object sender, EventArgs e)
        {
            SortSheep.BackColor = Color.WhiteSmoke;
        }

        private void SortHorse_MouseMove(object sender, MouseEventArgs e)
        {
            SortHorse.BackColor = Color.FromArgb(125, 204, 242);
        }

        private void SortHorse_MouseLeave(object sender, EventArgs e)
        {
            SortHorse.BackColor = Color.WhiteSmoke;
        }

        private void SortAll_MouseMove(object sender, MouseEventArgs e)
        {
            SortAll.BackColor = Color.FromArgb(125, 204, 242);
        }

        private void SortAll_MouseLeave(object sender, EventArgs e)
        {
            SortAll.BackColor = Color.WhiteSmoke;
        }

        private void btnSort_MouseMove(object sender, MouseEventArgs e)
        {
            btnSort.BackColor = Color.FromArgb(201, 201, 201);
        }

        private void btnSort_MouseLeave(object sender, EventArgs e)
        {
            btnSort.BackColor = Color.WhiteSmoke;
        }

        private void btnSettings_MouseMove(object sender, MouseEventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(201, 201, 201);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.WhiteSmoke;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(226, 52, 52);
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.ForeColor = Color.Black;
        }
    }
}

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
using FarmManagement.BLL;
using HelperLibrary;
using System.Collections;

namespace FarmManagement
{
    public partial class Farm_View : Form
    {
        List<Farm> farms = new List<Farm>();
        List<Location> locations = new List<Location>();
        List<Animal> animals = new List<Animal>();
        List<Species> species = new List<Species>();
        ClientObject co;
        Thread openLists;
        Thread openMenu;
        bool received = false;
        bool listsOpen = false;
        int ID = 0;
        string updating = "";
        public Farm_View(int id)
        {
            InitializeComponent();
            this.ID = id;

        }
        public Farm_View()
        {
            InitializeComponent();
        }

        delegate void MyDelegate();
        event MyDelegate myEvent;

        public void ReceiveData(ArrayList farmViewData)
        {
            if (!received)
            {
                List<Farm> farmss = (List<Farm>)farmViewData[0];
                List<Animal> animalss = (List<Animal>)farmViewData[1];
                List<Location> locationss = (List<Location>)farmViewData[2];
                foreach (Location item in locationss)
                {
                    CheckLocationReceiveMethod(item);
                }
                foreach (Animal item in animalss)
                {
                    CheckAnimalReceiveMethod(item);
                }
                foreach (Farm item in farmss)
                {
                    CheckFarmReceiveMethod(item);
                }
                //var species = from animal in animals
                //              select animal.Species;
                
                myEvent.Invoke();
                received = true;
            }
        }
        public void CheckFarmReceiveMethod(Farm farm)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Farm>(CheckFarmReceiveMethod), farm);
            }
            farms.Add(farm);
        }
        public void CheckAnimalReceiveMethod(Animal animal)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Animal>(CheckAnimalReceiveMethod), animal);
            }
            animals.Add(animal);
        }
        public void CheckLocationReceiveMethod(Location location)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Location>(CheckLocationReceiveMethod), location);
            }
            locations.Add(location);
        }

        private void Farm_View_Load(object sender, EventArgs e)
        {
            myEvent = LoadLists;
            co = new ClientObject();
            MessageObject message = new MessageObject(ID.BinarySerialization(), 6, 2, 1);
            co.SendData(message);


            pnlMenu.Location = new Point(-190, 0);
            pnlSortSubMenu.Location = new Point(-190, 50);
            pnlSettingsSubMenu.Location = new Point(-190, 50);
            btnOpenMenu.Location = new Point(0, 0);
            pblSortLists.Location = new Point(-280, 0);
            pnlCagesSort.Location = new Point(-190, 50);
            pnlUpdateName.Location = new Point(190,0);
            btnDeleteAnimal.Visible = false;

            //Farm f = new Farm();
            //Location l = new Location();
            //Animal a = new Animal();
            //farms = f.selectFarm(ID);
            //locations = l.selectLocation(ID);
            //animals = a.selectAnimals(ID);

            var species = animals.GroupBy(animal => animal.Species)
                    .Select(group => group.First().Species)
                    .ToList();

            foreach (Species item in species)
            {
                species.Add(item);
            }

        }

        public void LoadLists()
        {
            //lstFarm.DataSource = farms;
            txtFarmName.Text = farms[0].FarmName;
            lstLocations.DataSource = locations;
            lstAnimals.DataSource = animals;
        }

        private void returnToFarmerSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Farmer_Selection form = new Farmer_Selection();
            //form.Show();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        #region AnimalClickInMenu
        private void lionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pblSortLists.Visible = true;
            ShiftListPanel();
            var Selectitem = from item in animals
                             where item.Species.ToString() == "Lion"
                             select item;
            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }

        }

        private void tigerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pblSortLists.Visible = true;
            ShiftListPanel();
            var Selectitem = from item in animals
                             where item.Species.ToString() == "Tiger"
                             select item;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void cowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pblSortLists.Visible = true;
            ShiftListPanel();
            var Selectitem = from item in animals
                             where item.Species.ToString() == "Cow"
                             select item;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void sheepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pblSortLists.Visible = true;
            ShiftListPanel();
            var Selectitem = from item in animals
                             where item.Species.ToString() == "Sheep"
                             select item;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pblSortLists.Visible = true;
            ShiftListPanel();
            var Selectitem = from item in animals
                             where item.Species.ToString() == "Horse"
                             select item;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }
        }

        private void allAnimalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pblSortLists.Visible = true;
            ShiftListPanel();
            var SelectAnimals = from item in animals
                                select item;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in SelectAnimals)
            {
                lstAnimals.Items.Add(item);
            }
        }

        #endregion

        private void ShiftListPanel()
        {
            if (!listsOpen)
            {
                openLists = new Thread(() =>
                {
                    openLists.Priority = ThreadPriority.Highest;
                    for (int i = -90; i <= 190; i = i + 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                });
                openLists.Priority = ThreadPriority.Highest;
                openLists.Start();
            }
            listsOpen = true;
        }

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            btnOpenMenu.Visible = false;
            pnlMenu.Visible = true;
            openMenu = new Thread(() =>
            {
                openMenu.Priority = ThreadPriority.Highest;
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i, 0, pnlMenu);
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
            if (!listsOpen)
            {
                openMenu = new Thread(() =>
                {
                    openMenu.Priority = ThreadPriority.Highest;
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 0, pnlMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openMenu = new Thread(() =>
                {
                    openMenu.Priority = ThreadPriority.Highest;
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlSortSubMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openMenu = new Thread(() =>
                {
                    openMenu.Priority = ThreadPriority.Highest;
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlCagesSort);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openMenu = new Thread(() =>
                {
                    openMenu.Priority = ThreadPriority.Highest;
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlSettingsSubMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
            }
            else
            {
                openLists = new Thread(() =>
                {
                    openLists.Priority = ThreadPriority.Highest;
                    for (int i = 190; i >= -90; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                    Thread.Sleep(70);
                    openMenu = new Thread(() =>
                    {
                        openMenu.Priority = ThreadPriority.Highest;
                        for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 0, pnlMenu);
                        Thread.Sleep(2);
                    }
                });
                    openMenu.Start();
                    openMenu = new Thread(() =>
                    {
                        openMenu.Priority = ThreadPriority.Highest;
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlSortSubMenu);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    openMenu = new Thread(() =>
                    {
                        openMenu.Priority = ThreadPriority.Highest;
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlSettingsSubMenu);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    openMenu = new Thread(() =>
                    {
                        openMenu.Priority = ThreadPriority.Highest;
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlCagesSort);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    for (int i = -90; i >= -280; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                });
                openLists.Start();
            }
            listsOpen = false;
            //System.Timers.Timer timer = new System.Timers.Timer(700);
            //timer.Start();
            //timer.Elapsed += Timer_Elapsed;
        }

        //private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    openLists.Abort();
        //    openMenu.Abort();
        //}

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstLocations.Visible = false;
            pnlSortSubMenu.Visible = true;
            pblSortLists.Visible = true;
            openMenu = new Thread(() =>
            {
                openMenu.Priority = ThreadPriority.Highest;
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i, 50, pnlSortSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            openLists = new Thread(() =>
            {
                openLists.Priority = ThreadPriority.Highest;
                for (int i = -280; i <= -90; i = i + 3)
                {
                    moveMenu(i, 0, pblSortLists);
                    Thread.Sleep(2);
                }
            });
            openLists.Start();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            if (listsOpen)
            {
                pnlSortSubMenu.Visible = true;
                openLists = new Thread(() =>
                {
                    openLists.Priority = ThreadPriority.Highest;
                    for (int i = 190; i >= -90; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                    Thread.Sleep(70);
                    openMenu = new Thread(() =>
                    {
                        openMenu.Priority = ThreadPriority.Highest;
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlSortSubMenu);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    for (int i = -90; i >= -280; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                });
                openLists.Start();
            }
            else
            {
                openMenu = new Thread(() =>
                {
                    openMenu.Priority = ThreadPriority.Highest;
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlSortSubMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
            }
            listsOpen = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlSettingsSubMenu.Visible = true;
            openMenu = new Thread(() =>
            {
                openMenu.Priority = ThreadPriority.Highest;
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
            openMenu = new Thread(() =>
            {
                openMenu.Priority = ThreadPriority.Highest;
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
        #region MenuColors
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
        #endregion


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Farm_View_Click(object sender, EventArgs e)
        {
            //btnOpenMenu.Visible = true;
            //pnlMenu.Visible = true;
            //if (!listsOpen)
            //{
            //    Thread openMenu = new Thread(() =>
            //    {
            //        for (int i = 0; i >= -190; i = i - 3)
            //        {
            //            moveMenu(i, 0, pnlMenu);
            //            Thread.Sleep(2);
            //        }
            //    });
            //    openMenu.Start();
            //    openMenu = new Thread(() =>
            //    {
            //        for (int i = 0; i >= -190; i = i - 3)
            //        {
            //            moveMenu(i, 50, pnlSortSubMenu);
            //            Thread.Sleep(2);
            //        }
            //    });
            //    openMenu.Start();
            //    openMenu = new Thread(() =>
            //    {
            //        for (int i = 0; i >= -190; i = i - 3)
            //        {
            //            moveMenu(i, 50, pnlSettingsSubMenu);
            //            Thread.Sleep(2);
            //        }
            //    });
            //    openMenu.Start();
            //}
            //else
            //{
            //    Thread openLists = new Thread(() =>
            //    {
            //        for (int i = 190; i >= -90; i = i - 3)
            //        {
            //            moveMenu(i, 0, pblSortLists);
            //            Thread.Sleep(2);
            //        }
            //        Thread.Sleep(70);
            //        Thread openMenu = new Thread(() =>
            //        {
            //            for (int i = 0; i >= -190; i = i - 3)
            //            {
            //                moveMenu(i, 0, pnlMenu);
            //                Thread.Sleep(2);
            //            }
            //        });
            //        openMenu.Start();
            //        openMenu = new Thread(() =>
            //        {
            //            for (int i = 0; i >= -190; i = i - 3)
            //            {
            //                moveMenu(i, 50, pnlSortSubMenu);
            //                Thread.Sleep(2);
            //            }
            //        });
            //        openMenu.Start();
            //        openMenu = new Thread(() =>
            //        {
            //            for (int i = 0; i >= -190; i = i - 3)
            //            {
            //                moveMenu(i, 50, pnlSettingsSubMenu);
            //                Thread.Sleep(2);
            //            }
            //        });
            //        openMenu.Start();
            //        for (int i = -90; i >= -280; i = i - 3)
            //        {
            //            moveMenu(i, 0, pblSortLists);
            //            Thread.Sleep(2);
            //        }
            //    });
            //    openLists.Start();
            //}
            //listsOpen = false;
        }

        private void btnCages_Click(object sender, EventArgs e)
        {
            lstLocations.Visible = true;
            pnlCagesSort.Visible = true;
            pblSortLists.Visible = true;
            openMenu = new Thread(() =>
            {
                openMenu.Priority = ThreadPriority.Highest;
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i, 50, pnlCagesSort);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            pblSortLists.Location = new Point(-280, 0);
            pblSortLists.Visible = true;
            openLists = new Thread(() =>
            {
                openLists.Priority = ThreadPriority.Highest;
                for (int i = -280; i <= 190; i = i + 3)
                {
                    moveMenu(i, 0, pblSortLists);
                    Thread.Sleep(2);
                }
            });
            openLists.Start();
            listsOpen = true;
            lstLocations.SelectedIndex = 1;
            lstLocations.SelectedIndex = 0;
            lstAnimals.SelectedIndex = 1;
            lstAnimals.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listsOpen)
            {
                pnlSortSubMenu.Visible = true;
                openLists = new Thread(() =>
                {
                    openLists.Priority = ThreadPriority.Highest;
                    for (int i = 190; i >= -90; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(1);
                    }
                    Thread.Sleep(70);
                    openMenu = new Thread(() =>
                    {
                        openMenu.Priority = ThreadPriority.Highest;
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlCagesSort);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    for (int i = -90; i >= -280; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                });
                openLists.Start();
                listsOpen = false;
            }
        }

        private void lstAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteAnimal.Visible = true;
        }

        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstLocations_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = ((Location)lstLocations.SelectedItem).ID;
            var Selectitem = from item in animals
                             where item.LocationID == id
                             select item;

            lstAnimals.DataSource = null;
            lstAnimals.Items.Clear();

            foreach (Animal item in Selectitem)
            {
                lstAnimals.Items.Add(item);
            }

            lstAnimals.SelectedIndex = 1;
            lstAnimals.SelectedIndex = 0;
        }

        private void btnUpdateFarmerName_Click(object sender, EventArgs e)
        {
            updating = "Farmer";
            lblUpdating.Text = "Farmer";
            pnlUpdateName.Visible = true;
        }

        private void btnUpdateFarmName_Click(object sender, EventArgs e)
        {
            updating = "Farm";
            lblUpdating.Text = "Farm";
            pnlUpdateName.Visible = true;
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (updating.Equals("Farmer"))
            {
                Farmer farmer = new Farmer();
                farmer.ID = ID;
                farmer.Name = txtUpdateName.Text;
                MessageObject message = new MessageObject(farmer.BinarySerialization(), 6, 1, 4);
                co.SendData(message);
                txtUpdateName.Text = "";
            }
            else if (updating.Equals("Farm"))
            {
                farms[0].FarmName = txtUpdateName.Text;
                MessageObject message = new MessageObject(farms[0].BinarySerialization(), 6, 2, 4);
                co.SendData(message);
                txtFarmName.Text = farms[0].FarmName;
                txtUpdateName.Text = "";
            }
            updating = "";
            lblUpdating.Text = "";
            pnlUpdateName.Visible = false;
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = ((Animal)lstAnimals.SelectedItem);
            animals.Remove(animal);
            MessageObject message = new MessageObject(animal.BinarySerialization(), 6,3,3);
            co.SendData(message);
            lstAnimals.Items.Remove(animal);
            btnDeleteAnimal.Visible = false;
        }
    }
}

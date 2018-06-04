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
        Dictionary<int, PictureBox> LargeFarm = new Dictionary<int, PictureBox>();
        Dictionary<int, PictureBox> MediumFarm = new Dictionary<int, PictureBox>();
        Dictionary<int, PictureBox> SmallFarm = new Dictionary<int, PictureBox>();
        Dictionary<int, PictureBox> ActiveDictionary = new Dictionary<int, PictureBox>();
        PictureBox AnimalPbx;
        PictureBox feedingPbx;
        PictureBox animal2Pbx;
        List<Farm> farms = new List<Farm>();
        List<Location> locations = new List<Location>();
        List<Animal> animals = new List<Animal>();
        List<Species> species = new List<Species>();
        List<Location> tempLoc = new List<Location>();

        ClientObject co;
        Thread openLists;
        Thread openMenu;
        Thread killAnAnimal;
        bool received = false;
        bool listsOpen = false;
        bool simRunning=false;
        int ID = 0;
        string updating = "";
        int CagesNeeded;
        int numcages;
        int FarmSize;



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
                myEvent.Invoke();
                received = true;
            }
        }
        #region ReceiveData
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
        #endregion


        private void Farm_View_Load(object sender, EventArgs e)
        {
            pnlSmall.Visible = false;
            pnlMedium.Visible = false;
            pnlLarge.Visible = false;




            myEvent = LoadLists;
            co = new ClientObject();
            MessageObject message = new MessageObject(ID.BinarySerialization(), 6, 2, 1);
            co.SendData(message);
            //Thread.Sleep(1000);
            #region LargeDictionary
            LargeFarm.Add(1, pbxLarge1);
            LargeFarm.Add(2, pbxLarge2);
            LargeFarm.Add(3, pbxLarge3);
            LargeFarm.Add(4, pbxLarge4);
            LargeFarm.Add(5, pbxLarge5);
            LargeFarm.Add(6, pbxLarge6);
            LargeFarm.Add(7, pbxLarge7);
            LargeFarm.Add(8, pbxLarge8);
            LargeFarm.Add(9, pbxLarge9);
            LargeFarm.Add(10, pbxLarge10);
            LargeFarm.Add(11, pbxLarge11);
            LargeFarm.Add(12, pbxLarge12);
            LargeFarm.Add(13, pbxLarge13);
            LargeFarm.Add(14, pbxLarge14);
            LargeFarm.Add(15, pbxLarge15);
            LargeFarm.Add(16, pbxLarge16);
            #endregion
            #region MediumDictionary
            MediumFarm.Add(1, pbxMedium1);
            MediumFarm.Add(2, pbxMedium2);
            MediumFarm.Add(3, pbxMedium3);
            MediumFarm.Add(4, pbxMedium4);
            MediumFarm.Add(5, pbxMedium5);
            MediumFarm.Add(6, pbxMedium6);
            MediumFarm.Add(7, pbxMedium7);
            MediumFarm.Add(8, pbxMedium8);
            MediumFarm.Add(9, pbxMedium9);
            #endregion
            #region SmallDictionary
            SmallFarm.Add(1, pbxSmall1);
            SmallFarm.Add(2, pbxSmall2);
            SmallFarm.Add(3, pbxSmall3);
            SmallFarm.Add(4, pbxSmall4);

            #endregion

            pnlMenu.Location = new Point(-190, 0);
            pnlSortSubMenu.Location = new Point(-190, 50);
            pnlSettingsSubMenu.Location = new Point(-190, 50);
            btnOpenMenu.Location = new Point(0, 0);
            pblSortLists.Location = new Point(-280, 0);
            pnlCagesSort.Location = new Point(-190, 50);
            pnlUpdateName.Location = new Point(190, 0);
            pnlAddAnimals.Location = new Point(190, 0);
            btnDeleteClick.Visible = false;



        }

        public void LoadLists()
        {
            //lstFarm.DataSource = farms;
            txtFarmName.Text = farms[0].FarmName;
            foreach (Location item in locations)
            {
                lstLocations.Items.Add(item);
            }
            foreach (Animal item in animals)
            {
                lstAnimals.Items.Add(item);
            }

            killAnAnimal = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(10000);
                    Random rnd = new Random();
                    int happen = rnd.Next(0, 10);
                    if (happen == 6)
                    {
                        rnd = new Random();
                        int animalTK = rnd.Next(0, animals.Count);
                        Animal animal = animals[animalTK];
                        animals.Remove(animal);
                        MessageObject message = new MessageObject(animal.BinarySerialization(), 6, 3, 3);
                        co.SendData(message);
                        DeleteAnimal(animal);
                        int newMessage = rnd.Next(0, 5);
                        switch (newMessage)
                        {
                            case 1:
                                addToActionsLst("Animal " + animal.ID + " jumped off a cliff that does not exist");
                                break;
                            case 2:
                                addToActionsLst("Animal " + animal.ID + " was eaten by a sheep that turned Canabal");
                                break;
                            case 3:
                                addToActionsLst("Animal " + animal.ID + " was shot by a hunter");
                                break;
                            case 4:
                                addToActionsLst("Animal " + animal.ID + " died due to natural causes");
                                break;
                            case 5:
                                addToActionsLst("Animal " + animal.ID + " was abducted by aliens");
                                break;
                            default:
                                addToActionsLst("An animal has died");
                                break;
                        }
                    }
                }
            });
            killAnAnimal.Start();


            var speciess = animals.GroupBy(animal => animal.Species)
                                .Select(group => group.First().Species)
                                .ToList();

            foreach (Species item in speciess)
            {
                species.Add(item);
            }
            List<Location> CageLocaitons = new List<Location>();
            Dictionary<int, Species> speciesIdentifier = new Dictionary<int, Species>();
            //var specieswiithCage = from itemspecieswithcage in animals
            //                       where itemspecieswithcage.LocationID = 

            foreach (Farm item in farms)
            {
                FarmSize = (int)item.Size;
            }

            var cageIds = from loc in locations
                          where !(loc.Cage.Equals(null))
                          select loc;
            foreach (Location item in cageIds)
            {
                CageLocaitons.Add(item);
            }

            foreach (Location item in locations)
            {
                //    var specieswiithCage = from itemspecieswithcage in locations
                //                           where itemspecieswithcage.ID == item.LocationID
                //                           select itemspecieswithcage.XCoord;
                var species = animals.Where(n => n.LocationID == item.ID).Select(n => n.Species);
            }

            foreach (Species itemspecies in species)
            {
                foreach (Location item in CageLocaitons)
                {

                    if (!speciesIdentifier.ContainsKey(item.YCoord))
                    {
                        if (!speciesIdentifier.ContainsValue(itemspecies))
                        {
                            speciesIdentifier.Add(item.YCoord, itemspecies);

                        }
                        

                    }
                }
            }
            switch (FarmSize)
            {
                case 400:
                    foreach (KeyValuePair<int, Species> item in speciesIdentifier)
                    {
                        pnlSmall.Location = new Point(555, 212);
                        pnlSmall.Visible = true;
                        string directoryPath = Environment.CurrentDirectory;
                        directoryPath = directoryPath.Substring(0, directoryPath.Length - 10) + "\\Resources\\";
                        if (item.Value.AnimalName == "Sheep" || item.Value.AnimalName == "Tiger" || item.Value.AnimalName == "Horse")
                        {
                            SmallFarm[item.Key].Image = Image.FromFile(directoryPath + item.Value.AnimalName + "Cage.png");

                        }
                        else
                        {
                            SmallFarm[item.Key].Image = Image.FromFile(directoryPath + item.Value.AnimalName + "sCage.png");
                        }
                    }
                    break;
                case 900:
                    foreach (KeyValuePair<int, Species> item in speciesIdentifier)
                    {
                        pnlMedium.Location = new Point(555, 212);
                        pnlMedium.Visible = true;
                        string directoryPath = Environment.CurrentDirectory;
                        directoryPath = directoryPath.Substring(0, directoryPath.Length - 10) + "\\Resources\\";
                        if (item.Value.AnimalName == "Sheep" || item.Value.AnimalName == "Tiger" || item.Value.AnimalName == "Horse")
                        {
                            MediumFarm[item.Key].Image = Image.FromFile(directoryPath + item.Value.AnimalName + "Cage.png");

                        }
                        else
                        {
                            MediumFarm[item.Key].Image = Image.FromFile(directoryPath + item.Value.AnimalName + "sCage.png");
                        }
                    }
                    break;
                case 1600:
                    foreach (KeyValuePair<int, Species> item in speciesIdentifier)
                    {
                        pnlLarge.Location = new Point(555, 212);
                        pnlLarge.Visible = true;
                        string directoryPath = Environment.CurrentDirectory;
                        directoryPath = directoryPath.Substring(0, directoryPath.Length - 10) + "\\Resources\\";
                        if (item.Value.AnimalName == "Sheep" || item.Value.AnimalName == "Tiger" || item.Value.AnimalName == "Horse")
                        {
                            LargeFarm[item.Key].Image = Image.FromFile(directoryPath + item.Value.AnimalName + "Cage.png");

                        }
                        else
                        {
                            LargeFarm[item.Key].Image = Image.FromFile(directoryPath + item.Value.AnimalName + "sCage.png");
                        }
                    }
                    break;
                default:
                    break;
            }
            
          //  MessageBox.Show("");
            //while (farms[0].FarmName == "")
            //{
            if (farms.Count != 0)
            {



            }
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
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 0, pnlMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openMenu = new Thread(() =>
                {
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlSortSubMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openMenu = new Thread(() =>
                {
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlCagesSort);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openMenu = new Thread(() =>
                {
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlSettingsSubMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openLists = new Thread(() =>
                {
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
                openLists = new Thread(() =>
                {
                    for (int i = 190; i >= -90; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                    Thread.Sleep(70);
                    openMenu = new Thread(() =>
                {
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 0, pnlMenu);
                        Thread.Sleep(2);
                    }
                });
                    openMenu.Start();
                    openMenu = new Thread(() =>
                    {
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlSortSubMenu);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    openMenu = new Thread(() =>
                    {
                        for (int i = 0; i >= -190; i = i - 3)
                        {
                            moveMenu(i, 50, pnlSettingsSubMenu);
                            Thread.Sleep(2);
                        }
                    });
                    openMenu.Start();
                    openMenu = new Thread(() =>
                    {
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
            pnlUpdateName.Visible = false;
            pnlAddAnimals.Visible = false;
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
            pnlAddAnimals.Visible = false;
            lstLocations.Visible = false;
            pnlSortSubMenu.Visible = true;
            pblSortLists.Visible = true;
            openMenu = new Thread(() =>
            {
                for (int i = -189; i <= 0; i = i + 3)
                {
                    moveMenu(i, 50, pnlSortSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            openLists = new Thread(() =>
            {
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
                    for (int i = 190; i >= -90; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                    Thread.Sleep(70);
                    openMenu = new Thread(() =>
                    {
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
                    for (int i = 0; i >= -190; i = i - 3)
                    {
                        moveMenu(i, 50, pnlSortSubMenu);
                        Thread.Sleep(2);
                    }
                });
                openMenu.Start();
                openLists = new Thread(() =>
                {
                    for (int i = -90; i >= -280; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                });
                openLists.Start();
            }
            listsOpen = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlAddAnimals.Visible = false;
            pnlSettingsSubMenu.Visible = true;
            openMenu = new Thread(() =>
            {
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
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 50, pnlSettingsSubMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            pnlUpdateName.Visible = false;
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
            pnlAddAnimals.Visible = false;
            lstLocations.Visible = true;
            pnlCagesSort.Visible = true;
            pblSortLists.Visible = true;
            openMenu = new Thread(() =>
            {
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
                for (int i = -280; i <= 190; i = i + 3)
                {
                    moveMenu(i, 0, pblSortLists);
                    Thread.Sleep(2);
                }
            });
            openLists.Start();
            listsOpen = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listsOpen)
            {
                pnlSortSubMenu.Visible = true;
                openLists = new Thread(() =>
                {
                    for (int i = 190; i >= -90; i = i - 3)
                    {
                        moveMenu(i, 0, pblSortLists);
                        Thread.Sleep(2);
                    }
                    Thread.Sleep(70);
                    openMenu = new Thread(() =>
                    {
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
            btnDeleteClick.Visible = true;
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

        private void btnDeleteClick_Click(object sender, EventArgs e)
        {
            {
                Animal animal = ((Animal)lstAnimals.SelectedItem);
                MessageBox.Show(animal.ID + "");
                animals.Remove(animal);
                MessageObject message = new MessageObject(animal.BinarySerialization(), 6, 3, 3);
                co.SendData(message);
                lstAnimals.Items.Remove(animal);
                btnDeleteClick.Visible = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddAnimals.Visible = true;
            cbxSpecies.DataSource = species;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlAddAnimals.Visible = false;
        }

        private void btnAddAnimalsSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(txtAnimalAmount.Text);
                Species specie = (Species)cbxSpecies.SelectedItem;
                int counter = animals.Where(ani => ani.Species.Equals(specie)).Count();
                if (counter % 10 == 0)
                {
                    AnimalsSelected assd = new AnimalsSelected();
                    assd.Animaal = specie;
                    assd.AnimalAmount = amount;
                    AddingAnimal adding = new AddingAnimal(new List<AnimalsSelected>() { assd },ID);
                    MessageObject message = new MessageObject(assd.BinarySerialization(),4,3,2);
                }
                else
                {
                    //Cages available
                    var cageIds = from loc in locations
                                  where !(loc.Cage.Equals(null))
                                  select loc;
                    foreach (Location item in cageIds)
                    {
                        tempLoc.Add(item);
                    }
                    int counters = 0;
                    Species[] space = new Species[tempLoc.Count];
                    foreach (Location item in tempLoc)
                    {
                        foreach (Animal item2 in animals)
                        {
                            if (item.ID == item2.LocationID)
                            {
                                space[counters] = item2.Species;
                            }
                        }
                        counters++;
                    }
                    for (int i = 0; i < space.Length; i++)
                    {
                        if (space[i].Equals(specie))
                        {
                            int animalAmount = 0;
                            foreach (Animal item in animals)
                            {
                                if (item.LocationID == tempLoc[i].ID)
                                {
                                    animalAmount++;
                                }
                            }
                            for (int j = 0; j < amount + 1; j++)
                            {
                                if (animalAmount < 10)
                                {
                                    //Insert Singular Animal Here
                                    ArrayList AnimalToAdd = new ArrayList();
                                    AnimalToAdd.Add(specie.AnimalName);

                                    //Generate Gender
                                    Random rnd = new Random();
                                    int genderChance = rnd.Next(0, 7);
                                    string gender = "";
                                    if (genderChance <= 3)
                                    {
                                        gender = "Female";
                                        AnimalToAdd.Add(gender);
                                    }
                                    else
                                    {
                                        gender = "Male";
                                        AnimalToAdd.Add(gender);
                                    }
                                    int age = rnd.Next(0, 2556);
                                    string mate = "";
                                    if ((gender.Equals("Male") || gender.Equals("Female")) && age > 474)
                                    {
                                        mate = "Ready";
                                    }
                                    else
                                    {
                                        mate = "Not Ready";
                                    }
                                    AnimalToAdd.Add(mate);
                                    AnimalToAdd.Add(age);
                                    double eatTime = 2;
                                    if (age < 365 || age > 2920)
                                    {
                                        eatTime += 1.5;
                                    }
                                    AnimalToAdd.Add(eatTime);
                                    Animal ani = new Animal(gender, mate, eatTime, specie, age, tempLoc[i].ID);
                                    animals.Add(ani);
                                    MessageObject message = new MessageObject(ani.BinarySerialization(), 6, 3, 2);
                                    co.SendData(message);
                                    animalAmount++;
                                    amount--;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number for Amount!");
            }

        }

        private void btnRunSim_MouseMove(object sender, MouseEventArgs e)
        {
            btnRunSim.BackColor = Color.FromArgb(97, 255, 116);
            btnRunSim.ForeColor = Color.White;
        }

        private void btnRunSim_MouseLeave(object sender, EventArgs e)
        {
            btnRunSim.BackColor = Color.WhiteSmoke;
            btnRunSim.ForeColor = Color.Black;
        }

        private void btnRunSim_Click(object sender, EventArgs e)
        {
            btnOpenMenu.Visible = true;
            openMenu = new Thread(() =>
            {
                for (int i = 0; i >= -190; i = i - 3)
                {
                    moveMenu(i, 0, pnlMenu);
                    Thread.Sleep(2);
                }
            });
            openMenu.Start();
            if (!simRunning)
            {
                simRunning = true;
                btnRunSim.Text = "Running...";
                lstActions.Items.Clear();
                #region species
                var cageIds = from loc in locations
                              where !(loc.Cage.Equals(null))
                              select loc;
                List<Location> tempLoc = new List<Location>();
                foreach (Location item in cageIds)
                {
                    tempLoc.Add(item);
                }
                int counters = 0;
                Species[] spacess = new Species[tempLoc.Count];
                int counting = 0;
                foreach (Location item in tempLoc)
                {
                    foreach (Animal item2 in animals)
                    {
                        if (item.ID == item2.LocationID && (!spacess.Contains(item2.Species)))
                        {
                            spacess[counting] = item2.Species;
                            counting++;
                        }
                    }
                    counters++;
                }
                Species[] space = new Species[counting];
                for (int i = 0; i < counting; i++)
                {
                    space[i] = spacess[i];
                }
                double[] slowestAnimalEat = new double[counting];
                for (int i = 0; i < slowestAnimalEat.Length; i++)
                {
                    foreach (Animal item in animals)
                    {
                        if (item.Species.Equals(species[i]) && item.EatingTime > slowestAnimalEat[i])
                        {
                            slowestAnimalEat[i] = item.EatingTime;
                        }
                    }
                }
                #endregion
                Thread runSim = new Thread(() =>
                {
                    addToActionsLst("Running Simulation...");
                    addToActionsLst("All Gates Opened...");
                    #region sort
                    for (int pass = 1; pass <= space.Length - 2; pass++)
                    {
                        for (int i = 0; i <= space.Length - 2; i++)
                        {
                            if (slowestAnimalEat[i] > slowestAnimalEat[i + 1])
                            {
                                double temp = slowestAnimalEat[i + 1];
                                Species spec = space[i + 1];
                                slowestAnimalEat[i + 1] = slowestAnimalEat[i];
                                space[i + 1] = space[i];
                                slowestAnimalEat[i] = temp;
                                space[i] = spec;
                            }

                        }

                    }
                    #endregion
                    for (int i = 0; i < space.Length; i++)
                    {
                        addToActionsLst("");
                        for (int j = 0; j < space.Length; j++)
                        {
                            if (i == j)
                            {
                                addToActionsLst(space[j].AnimalName + "s are walking to the Feeding Area");
                            }
                            else
                            {
                                addToActionsLst(space[j].AnimalName + "s have been diverted");
                            }
                        }
                        Thread.Sleep((int)((10 - space[i].Speed) * 1000));
                        addToActionsLst("");
                        addToActionsLst(space[i].AnimalName + "s are eating");
                        Thread.Sleep((int)slowestAnimalEat[i] * 2000);
                        addToActionsLst("");
                        addToActionsLst(space[i].AnimalName + "s are walking back");
                        Thread.Sleep((int)((10 - space[i].Speed) * 1000));
                    }
                    addToActionsLst("");
                    addToActionsLst("All animals have eaten and are back in their respective Cages");
                    addToActionsLst("");
                    addToActionsLst("...All gates Closed");

                    simRunning = false;
                    btnRunSim.Text = "Run Simulation";
                });
                runSim.Start();
            }

        }
        private void addToActionsLst(string val)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addToActionsLst), val);
            }
            try
            {
                lstActions.Items.Add(val);
            }
            catch (InvalidOperationException)
            {

            }
        }
        private void DeleteAnimal(Animal val)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Animal>(DeleteAnimal), val);
            }
            try
            {
                lstActions.Items.Remove(val);
            }
            catch (InvalidOperationException)
            {

            }
        }

    }
}

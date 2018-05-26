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
using System.Threading;

namespace FarmManagement
{
    public partial class Farmer_Selection : Form
    {
        Farmer[] AllFarmers = new Farmer[5];
        Farmer farmer = new Farmer();
        Farmer CurrentFarmer = new Farmer();
        public Farmer_Selection()
        {
            InitializeComponent();
            //Setting Which 
            pbxFarmer1.Visible = false;
            pbxFarmer2.Visible = false;
            pbxFarmer3.Visible = false;
            pbxFarmer4.Visible = false;
            pbxFarmer5.Visible = false;
            pbxNewFarmer1.Visible = true;
            pbxNewFarmer2.Visible = true;
            pbxNewFarmer3.Visible = true;
            pbxNewFarmer4.Visible = true;
            pbxNewFarmer5.Visible = true;
            pbxFarmer1.Cursor = Cursors.Hand;
            pbxFarmer2.Cursor = Cursors.Hand;
            pbxFarmer3.Cursor = Cursors.Hand;
            pbxFarmer4.Cursor = Cursors.Hand;
            pbxFarmer5.Cursor = Cursors.Hand;
            pbxNewFarmer1.Cursor = Cursors.Hand;
            pbxNewFarmer2.Cursor = Cursors.Hand;
            pbxNewFarmer3.Cursor = Cursors.Hand;
            pbxNewFarmer4.Cursor = Cursors.Hand;
            pbxNewFarmer5.Cursor = Cursors.Hand;


            AllFarmers = farmer.FarmerSelection();

            if (AllFarmers[0] != null)
            {
                pbxNewFarmer1.Visible = false;
                pbxFarmer1.Visible = true;
                CurrentFarmer = (Farmer)AllFarmers[0];
                txtFarmerName1.Text = CurrentFarmer.Name;
                txtFarmerGender1.Text = CurrentFarmer.Gender;
                txtFarmerAge1.Text = CurrentFarmer.Age;
                txtNumOfAnimals1.Text = CurrentFarmer.numOfAnimals().ToString();
                txtFarmSize1.Text = CurrentFarmer.GetFarmSize().ToString();

                if (AllFarmers[0].Gender == "Male")
                {
                    loadMaleAvatar(AllFarmers[0].FarmerStyle.OutfitType, AllFarmers[0].FarmerStyle.Eyecolour, AllFarmers[0].FarmerStyle.HairColour, AllFarmers[0].FarmerStyle.SkinColour, pbxBodyOne, pbxOutfitOne, pbxEyesOne, pbxHairOne);
                }
                else if (AllFarmers[0].Gender == "Female")
                {
                    loadFemaleAvatar(AllFarmers[0].FarmerStyle.OutfitType, AllFarmers[0].FarmerStyle.Eyecolour, AllFarmers[0].FarmerStyle.HairColour, AllFarmers[0].FarmerStyle.SkinColour, pbxBodyOne, pbxOutfitOne, pbxEyesOne, pbxHairOne);
                }
            }
            if (AllFarmers[1] != null)
            {
                pbxNewFarmer2.Visible = false;
                pbxFarmer2.Visible = true;
                CurrentFarmer = (Farmer)AllFarmers[1];
                txtFarmerName2.Text = CurrentFarmer.Name;
                txtFarmerGender2.Text = CurrentFarmer.Gender;
                txtFarmerAge2.Text = CurrentFarmer.Age;
                txtNumOfAnimals2.Text = CurrentFarmer.numOfAnimals().ToString();
                txtFarmSize2.Text = CurrentFarmer.GetFarmSize().ToString();

                if (AllFarmers[1].Gender == "Male")
                {
                    loadMaleAvatar(AllFarmers[1].FarmerStyle.OutfitType, AllFarmers[1].FarmerStyle.Eyecolour, AllFarmers[1].FarmerStyle.HairColour, AllFarmers[1].FarmerStyle.SkinColour, pbxBodyTwo, pbxOutfitTwo, pbxEyesTwo, pbxHairTwo);
                }
                else if (AllFarmers[1].Gender == "Female")
                {
                    loadFemaleAvatar(AllFarmers[1].FarmerStyle.OutfitType, AllFarmers[1].FarmerStyle.Eyecolour, AllFarmers[1].FarmerStyle.HairColour, AllFarmers[1].FarmerStyle.SkinColour, pbxBodyTwo, pbxOutfitTwo, pbxEyesTwo, pbxHairTwo);
                }
            }
            if (AllFarmers[2] != null)
            {
                pbxNewFarmer3.Visible = false;
                pbxFarmer3.Visible = true;
                CurrentFarmer = (Farmer)AllFarmers[2];
                txtFarmerName3.Text = CurrentFarmer.Name;
                txtFarmerGender3.Text = CurrentFarmer.Gender;
                txtFarmerAge3.Text = CurrentFarmer.Age;
                txtFarmSize3.Text = CurrentFarmer.GetFarmSize().ToString();
                txtNumOfAnimals3.Text = CurrentFarmer.numOfAnimals().ToString();

                if (AllFarmers[2].Gender == "Male")
                {
                    loadMaleAvatar(AllFarmers[2].FarmerStyle.OutfitType, AllFarmers[2].FarmerStyle.Eyecolour, AllFarmers[2].FarmerStyle.HairColour, AllFarmers[2].FarmerStyle.SkinColour, pbxBodyThree, pbxOutfitThree, pbxEyesThree, pbxHairThree);
                }
                else if (AllFarmers[2].Gender == "Female")
                {
                    loadFemaleAvatar(AllFarmers[2].FarmerStyle.OutfitType, AllFarmers[2].FarmerStyle.Eyecolour, AllFarmers[2].FarmerStyle.HairColour, AllFarmers[2].FarmerStyle.SkinColour, pbxBodyThree, pbxOutfitThree, pbxEyesThree, pbxHairThree);
                }
            }
            if (AllFarmers[3] != null)
            {
                pbxNewFarmer4.Visible = false;
                pbxFarmer4.Visible = true;
                CurrentFarmer = (Farmer)AllFarmers[3];
                txtFarmerName4.Text = CurrentFarmer.Name;
                txtFarmerGender4.Text = CurrentFarmer.Gender;
                txtFarmerAge4.Text = CurrentFarmer.Age;
                txtFarmSize4.Text = CurrentFarmer.GetFarmSize().ToString();
                txtNumOfAnimals4.Text = CurrentFarmer.numOfAnimals().ToString();

                if (AllFarmers[3].Gender == "Male")
                {
                    loadMaleAvatar(AllFarmers[3].FarmerStyle.OutfitType, AllFarmers[3].FarmerStyle.Eyecolour, AllFarmers[3].FarmerStyle.HairColour, AllFarmers[3].FarmerStyle.SkinColour, pbxBodyFour, pbxOutfitFour, pbxEyesFour, pbxHairFour);
                }
                else if (AllFarmers[3].Gender == "Female")
                {
                    loadFemaleAvatar(AllFarmers[3].FarmerStyle.OutfitType, AllFarmers[3].FarmerStyle.Eyecolour, AllFarmers[3].FarmerStyle.HairColour, AllFarmers[3].FarmerStyle.SkinColour, pbxBodyFour, pbxOutfitFour, pbxEyesFour, pbxHairFour);
                }
            }
            if (AllFarmers[4] != null)
            {
                pbxNewFarmer5.Visible = false;
                pbxFarmer5.Visible = true;
                CurrentFarmer = (Farmer)AllFarmers[4];
                txtFarmerName5.Text = CurrentFarmer.Name;
                txtFarmerGender5.Text = CurrentFarmer.Gender;
                txtFarmerAge5.Text = CurrentFarmer.Age;
                txtFarmSize5.Text = CurrentFarmer.GetFarmSize().ToString();
                txtNumOfAnimals5.Text = CurrentFarmer.numOfAnimals().ToString();

                if (AllFarmers[4].Gender == "Male")
                {
                    loadMaleAvatar(AllFarmers[4].FarmerStyle.OutfitType, AllFarmers[4].FarmerStyle.Eyecolour, AllFarmers[4].FarmerStyle.HairColour, AllFarmers[4].FarmerStyle.SkinColour, pbxBodyFive, pbxOutfitFive, pbxEyesFive, pbxHairFive);
                }
                else if (AllFarmers[4].Gender == "Female")
                {
                    loadFemaleAvatar(AllFarmers[4].FarmerStyle.OutfitType, AllFarmers[4].FarmerStyle.Eyecolour, AllFarmers[4].FarmerStyle.HairColour, AllFarmers[4].FarmerStyle.SkinColour, pbxBodyFive, pbxOutfitFive, pbxEyesFive, pbxHairFive);
                }
            }




            //how we gonna ensure there are only 5 farmers




        }

        public void loadMaleAvatar(string outfit, string eyes, string hair, string skin, PictureBox pbxBody, PictureBox pbxOutfit, PictureBox pbxEyes, PictureBox pbxHair)
        {
            pbxEyes.Location = new Point(4, 33);
            if (outfit == "One")
            {
                outfit = "1";
            }
            else if (outfit == "Two")
            {
                outfit = "2";
            }
            else if (outfit == "Three")
            {
                outfit = "3";
            }
            else if (outfit == "Four")
            {
                outfit = "4";
            }

            string streamText = "FarmManagement.Properties." + skin + "BoyLayer.png";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxBody.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\" + skin + "BoyLayer.png");
                pbxBody.Image = newBody;
            }

            streamText = "FarmManagement.Properties.Boy" + hair + "Hair.png";
            assembly = Assembly.GetExecutingAssembly();
            body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxHair.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\Boy" + hair + "Hair.png");
                pbxHair.Image = newBody;
            }

            streamText = "FarmManagement.Properties.Girl" + eyes + "Eyes.png";
            assembly = Assembly.GetExecutingAssembly();
            body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxEyes.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\Girl" + eyes + "Eyes.png");
                pbxEyes.Image = newBody;
            }

            streamText = "FarmManagement.Properties.BoyOutfit" + outfit + ".png";
            assembly = Assembly.GetExecutingAssembly();
            body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxOutfit.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\BoyOutfit" + outfit + ".png");
                pbxOutfit.Image = newBody;
            }
        }

        public void loadFemaleAvatar(string outfit, string eyes, string hair, string skin, PictureBox pbxBody, PictureBox pbxOutfit, PictureBox pbxEyes, PictureBox pbxHair)
        {
            pbxEyes.Location = new Point(0, 35);
            if (outfit == "One")
            {
                outfit = "1";
            }
            else if (outfit == "Two")
            {
                outfit = "2";
            }
            else if (outfit == "Three")
            {
                outfit = "3";
            }
            else if (outfit == "Four")
            {
                outfit = "4";
            }

            string streamText = "FarmManagement.Properties." + skin + "GirlSkin.png";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxBody.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\" + skin + "GirlSkin.png");
                pbxBody.Image = newBody;
            }

            streamText = "FarmManagement.Properties." + hair + "HairGirl.png";
            assembly = Assembly.GetExecutingAssembly();
            body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxHair.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\" + hair + "HairGirl.png");
                pbxHair.Image = newBody;
            }

            streamText = "FarmManagement.Properties.Girl" + eyes + "Eyes.png";
            assembly = Assembly.GetExecutingAssembly();
            body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxEyes.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\Girl" + eyes + "Eyes.png");
                pbxEyes.Image = newBody;
            }

            streamText = "FarmManagement.Properties.GirlOutfit" + outfit + ".png";
            assembly = Assembly.GetExecutingAssembly();
            body = assembly.GetManifestResourceStream(streamText);
            if (body != null)
            {
                pbxOutfit.Image = (Image)new Bitmap(body);
            }
            else
            {
                String DirectoryPath = Environment.CurrentDirectory;
                DirectoryPath = DirectoryPath.Substring(0, DirectoryPath.Length - 10) + "\\Properties";
                Image newBody = Image.FromFile(DirectoryPath + @"\GirlOutfit" + outfit + ".png");
                pbxOutfit.Image = newBody;
            }
        }

        //private void PcbLoadFarmer1_Click(object sender, EventArgs e)
        //{
        //    //Going to the screen to created the farmer
        //    Farmer_Creation creation = new Farmer_Creation();
        //    creation.Show();

        //    this.Hide();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            pbxFarmer1.Controls.Add(txtFarmerName1);
            pbxFarmer1.Controls.Add(txtFarmerGender1);
            pbxFarmer1.Controls.Add(txtFarmerAge1);
            pbxFarmer1.Controls.Add(txtNumOfAnimals1);
            pbxFarmer1.Controls.Add(txtFarmSize1);
            pbxFarmer1.Controls.Add(pbxCross1);

            #region avatars
            pbxFarmer1.Controls.Add(pbxOne);
            pbxOne.Location = new Point(14, 16);
            pbxBodyOne.Location = new Point(-4, 0);
            pbxOne.Controls.Add(pbxBodyOne);
            pbxHairOne.Location = new Point(0, -2);
            pbxBodyOne.Controls.Add(pbxHairOne);
            pbxHairOne.Controls.Add(pbxEyesOne);
            pbxBodyOne.Controls.Add(pbxOutfitOne);
            pbxOutfitOne.Location = new Point(0, 70);

            pbxFarmer2.Controls.Add(pbxTwo);
            pbxTwo.Location = new Point(14, 16);
            pbxBodyTwo.Location = new Point(-4, 0);
            pbxTwo.Controls.Add(pbxBodyTwo);
            pbxHairTwo.Location = new Point(0, -2);
            pbxBodyTwo.Controls.Add(pbxHairTwo);
            pbxHairTwo.Controls.Add(pbxEyesTwo);
            pbxBodyTwo.Controls.Add(pbxOutfitTwo);
            pbxOutfitTwo.Location = new Point(0, 70);

            pbxFarmer3.Controls.Add(pbxThree);
            pbxThree.Location = new Point(14, 16);
            pbxBodyThree.Location = new Point(-4, 0);
            pbxThree.Controls.Add(pbxBodyThree);
            pbxHairThree.Location = new Point(0, -2);
            pbxBodyThree.Controls.Add(pbxHairThree);
            pbxHairThree.Controls.Add(pbxEyesThree);
            pbxBodyThree.Controls.Add(pbxOutfitThree);
            pbxOutfitThree.Location = new Point(0, 70);

            pbxFarmer4.Controls.Add(pbxFour);
            pbxFour.Location = new Point(14, 16);
            pbxBodyFour.Location = new Point(-4, 0);
            pbxFour.Controls.Add(pbxBodyFour);
            pbxHairFour.Location = new Point(0, -2);
            pbxBodyFour.Controls.Add(pbxHairFour);
            pbxHairFour.Controls.Add(pbxEyesFour);
            pbxBodyFour.Controls.Add(pbxOutfitFour);
            pbxOutfitFour.Location = new Point(0, 70);

            pbxFarmer5.Controls.Add(pbxFive);
            pbxFive.Location = new Point(14, 16);
            pbxBodyFive.Location = new Point(-4, 0);
            pbxFive.Controls.Add(pbxBodyFive);
            pbxHairFive.Location = new Point(0, -2);
            pbxBodyFive.Controls.Add(pbxHairFive);
            pbxHairFive.Controls.Add(pbxEyesFive);
            pbxBodyFive.Controls.Add(pbxOutfitFive);
            pbxOutfitFive.Location = new Point(0, 70);
            #endregion

            txtFarmerName1.Location = new Point(240, 13);
            txtFarmerGender1.Location = new Point(240, 48);
            txtFarmerAge1.Location = new Point(240, 80);
            txtNumOfAnimals1.Location = new Point(475, 70);
            txtFarmSize1.Location = new Point(475, 30);
            pbxCross1.Location = new Point(508, 5);

            pbxFarmer2.Controls.Add(txtFarmerName2);
            pbxFarmer2.Controls.Add(txtFarmerGender2);
            pbxFarmer2.Controls.Add(txtFarmerAge2);
            pbxFarmer2.Controls.Add(txtNumOfAnimals2);
            pbxFarmer2.Controls.Add(txtFarmSize2);
            pbxFarmer2.Controls.Add(pbxCross2);


            txtFarmerName2.Location = new Point(240, 13);
            txtFarmerGender2.Location = new Point(240, 48);
            txtFarmerAge2.Location = new Point(240, 80);
            txtNumOfAnimals2.Location = new Point(475, 70);
            txtFarmSize2.Location = new Point(475, 30);
            pbxCross2.Location = new Point(508, 5);

            pbxFarmer3.Controls.Add(txtFarmerName3);
            pbxFarmer3.Controls.Add(txtFarmerGender3);
            pbxFarmer3.Controls.Add(txtFarmerAge3);
            pbxFarmer3.Controls.Add(txtNumOfAnimals3);
            pbxFarmer3.Controls.Add(txtFarmSize3);
            pbxFarmer3.Controls.Add(pbxCross3);

            txtFarmerName3.Location = new Point(240, 13);
            txtFarmerGender3.Location = new Point(240, 48);
            txtFarmerAge3.Location = new Point(240, 80);
            txtNumOfAnimals3.Location = new Point(475, 70);
            txtFarmSize3.Location = new Point(475, 30);
            pbxCross3.Location = new Point(508, 5);

            pbxFarmer4.Controls.Add(txtFarmerName4);
            pbxFarmer4.Controls.Add(txtFarmerGender4);
            pbxFarmer4.Controls.Add(txtFarmerAge4);
            pbxFarmer4.Controls.Add(txtNumOfAnimals4);
            pbxFarmer4.Controls.Add(txtFarmSize4);
            pbxFarmer4.Controls.Add(pbxCross4);


            txtFarmerName4.Location = new Point(240, 13);
            txtFarmerGender4.Location = new Point(240, 48);
            txtFarmerAge4.Location = new Point(240, 80);
            txtNumOfAnimals4.Location = new Point(475, 70);
            txtFarmSize4.Location = new Point(475, 30);
            pbxCross4.Location = new Point(508, 5);


            pbxFarmer5.Controls.Add(txtFarmerName5);
            pbxFarmer5.Controls.Add(txtFarmerGender5);
            pbxFarmer5.Controls.Add(txtFarmerAge5);
            pbxFarmer5.Controls.Add(txtNumOfAnimals5);
            pbxFarmer5.Controls.Add(txtFarmSize5);
            pbxFarmer5.Controls.Add(pbxCross5);

            txtFarmerName5.Location = new Point(240, 13);
            txtFarmerGender5.Location = new Point(240, 48);
            txtFarmerAge5.Location = new Point(240, 80);
            txtNumOfAnimals5.Location = new Point(475, 70);
            txtFarmSize5.Location = new Point(475, 30);
            pbxCross5.Location = new Point(508, 5);

        }


        private void pbxNewFarmer1_Click(object sender, EventArgs e)
        {
            Farmer_Creation navCreaation = new Farmer_Creation();
            navCreaation.Show();
            this.Hide();
        }

        private void pbxNewFarmer2_Click(object sender, EventArgs e)
        {
            Farmer_Creation navCreaation = new Farmer_Creation();
            navCreaation.Show();
            this.Hide();
        }

        private void pbxNewFarmer3_Click(object sender, EventArgs e)
        {
            Farmer_Creation navCreaation = new Farmer_Creation();
            navCreaation.Show();
            this.Hide();
        }

        private void pbxNewFarmer4_Click(object sender, EventArgs e)
        {
            Farmer_Creation navCreaation = new Farmer_Creation();
            navCreaation.Show();
            this.Hide();
        }

        private void pbxNewFarmer5_Click(object sender, EventArgs e)
        {
            Farmer_Creation navCreaation = new Farmer_Creation();
            navCreaation.Show();
            this.Hide();
        }

        private void pbxFarmer1_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[0];
            if (CurrentFarmer.GetFarmSize() > 0)
            {
                if (CurrentFarmer.numOfAnimals() > 0)
                {
                    Farm_View navFarmView = new Farm_View(CurrentFarmer.ID);
                    navFarmView.Show();
                    this.Hide();
                }
                else
                {
                    Animal_Selection assd = new Animal_Selection(CurrentFarmer.ID);
                    assd.Show();
                    this.Hide();
                }
            }
            else
            {
                Farm_Creation fc = new Farm_Creation(CurrentFarmer.ID);
                fc.Show();
                this.Hide();
            }

            //MessageBox.Show("Load farmer One");
        }

        private void pbxFarmer2_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[1];
            if (CurrentFarmer.GetFarmSize() > 0)
            {
                if (CurrentFarmer.numOfAnimals() > 0)
                {
                    Farm_View navFarmView = new Farm_View(CurrentFarmer.ID);
                    navFarmView.Show();
                    this.Hide();
                }
                else
                {
                    Animal_Selection assd = new Animal_Selection(CurrentFarmer.ID);
                    assd.Show();
                    this.Hide();
                }
            }
            else
            {
                Farm_Creation fc = new Farm_Creation(CurrentFarmer.ID);
                fc.Show();
                this.Hide();
            }
            // MessageBox.Show("Load farmer Two");
        }

        private void pbxFarmer3_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[2];
            if (CurrentFarmer.GetFarmSize() > 0)
            {
                if (CurrentFarmer.numOfAnimals() > 0)
                {
                    Farm_View navFarmView = new Farm_View(CurrentFarmer.ID);
                    navFarmView.Show();
                    this.Hide();
                }
                else
                {
                    Animal_Selection assd = new Animal_Selection(CurrentFarmer.ID);
                    assd.Show();
                    this.Hide();
                }
            }
            else
            {
                Farm_Creation fc = new Farm_Creation(CurrentFarmer.ID);
                fc.Show();
                this.Hide();
            }
            //  MessageBox.Show("Load farmer Three");
        }

        private void pbxFarmer4_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[3];
            if (CurrentFarmer.GetFarmSize() > 0)
            {
                if (CurrentFarmer.numOfAnimals() > 0)
                {
                    Farm_View navFarmView = new Farm_View(CurrentFarmer.ID);
                    navFarmView.Show();
                    this.Hide();
                }
                else
                {
                    Animal_Selection assd = new Animal_Selection(CurrentFarmer.ID);
                    assd.Show();
                    this.Hide();
                }
            }
            else
            {
                Farm_Creation fc = new Farm_Creation(CurrentFarmer.ID);
                fc.Show();
                this.Hide();
            }
            //  MessageBox.Show("Load farmer Four");
        }

        private void pbxFarmer5_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[4];
            if (CurrentFarmer.GetFarmSize() > 0)
            {
                if (CurrentFarmer.numOfAnimals() > 0)
                {
                    Farm_View navFarmView = new Farm_View(CurrentFarmer.ID);
                    navFarmView.Show();
                    this.Hide();
                }
                else
                {
                    Animal_Selection assd = new Animal_Selection(CurrentFarmer.ID);
                    assd.Show();
                    this.Hide();
                }
            }
            else
            {
                Farm_Creation fc = new Farm_Creation(CurrentFarmer.ID);
                fc.Show();
                this.Hide();
            }
            //  MessageBox.Show("Load farmer Five");
        }

        private void pbxCross1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the delete button");
        }

        private void pbxCross1_Click_1(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[0];
            int succes = CurrentFarmer.DeleteFarmer();
            
            Thread RefreshThread = new Thread(() => { Application.Run(new Farmer_Selection()); });

            RefreshThread.Start();

            this.Close();

        }

        private void pbxCross2_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[1];
            int succes = CurrentFarmer.DeleteFarmer();
           
            Thread RefreshThread = new Thread(() => { Application.Run(new Farmer_Selection()); });

            RefreshThread.Start();

            this.Close();
        }

        private void pbxCross3_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[2];
            int succes = CurrentFarmer.DeleteFarmer();
            
            Thread RefreshThread = new Thread(() => { Application.Run(new Farmer_Selection()); });

            RefreshThread.Start();

            this.Close();

        }

        private void pbxCross4_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[3];
            int succes = CurrentFarmer.DeleteFarmer();
           
            Thread RefreshThread = new Thread(() => { Application.Run(new Farmer_Selection()); });

            RefreshThread.Start();

            this.Close();

        }

        private void pbxCross5_Click(object sender, EventArgs e)
        {
            CurrentFarmer = (Farmer)AllFarmers[4];
            int succes = CurrentFarmer.DeleteFarmer();
           
            Thread RefreshThread = new Thread(() => { Application.Run(new Farmer_Selection()); });

            RefreshThread.Start();

            this.Close();
        }
    }
}

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

        public delegate void NavFormsWithParam(Farmer currentFarmer);
        public event NavFormsWithParam navFormwithParam;

        public delegate void DeleteFarmerDel(Farmer currentFarmer,string name);
        public event DeleteFarmerDel deleteFarmer;

        public delegate void NavFormWithoutParam();
        public event NavFormWithoutParam navFormWithoutParam;
        
        public Farmer_Selection()
        {
            InitializeComponent();
        }
        private void Farmer_Selection_Load(object sender, EventArgs e)
        {
            navFormwithParam += new NavFormsWithParam(NavResumeOrFarmView);
            navFormWithoutParam += new NavFormWithoutParam(NavFarmerCreation);

            //Setting the farmer pictures to default
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

            //Loading existing farmers from database
            AllFarmers = farmer.FarmerSelection();

            if (AllFarmers[0] != null)
            {
                CharacterLoad(pbxNewFarmer1, pbxFarmer1, lblFarmerName1, lblFarmerGender1, lblFarmerAge1, lblNumOfAnimals1, lblFarmSize1, 0, pbxBodyOne, pbxOutfitOne, pbxEyesOne, pbxHairOne);
            }
            if (AllFarmers[1] != null)
            {
                CharacterLoad(pbxNewFarmer2, pbxFarmer2, lblFarmerName2, lblFarmerGender2, lblFarmerAge2, lblNumOfAnimals2, lblFarmSize2, 1, pbxBodyTwo, pbxOutfitTwo, pbxEyesTwo, pbxHairTwo);
            }
            if (AllFarmers[2] != null)
            {
                CharacterLoad(pbxNewFarmer3, pbxFarmer3, lblFarmerName3, lblFarmerGender3, lblFarmerAge3, lblNumOfAnimals3, lblFarmSize3, 2, pbxBodyThree, pbxOutfitThree, pbxEyesThree, pbxHairThree);
            }
            if (AllFarmers[3] != null)
            {
                CharacterLoad(pbxNewFarmer4, pbxFarmer4, lblFarmerName4, lblFarmerGender4, lblFarmerAge4, lblNumOfAnimals4, lblFarmSize4, 3, pbxBodyFour, pbxOutfitFour, pbxEyesFour, pbxHairFour);
            }
            if (AllFarmers[4] != null)
            {
                CharacterLoad(pbxNewFarmer5, pbxFarmer5, lblFarmerName5, lblFarmerGender5, lblFarmerAge5, lblNumOfAnimals5, lblFarmSize5, 4, pbxBodyFive, pbxOutfitFive, pbxEyesFive, pbxHairFive);
            }

            #region Avatars
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

            #region FarmerLabels
            pbxFarmer1.Controls.Add(lblFarmerName1);
            pbxFarmer1.Controls.Add(lblFarmerGender1);
            pbxFarmer1.Controls.Add(lblFarmerAge1);
            pbxFarmer1.Controls.Add(lblNumOfAnimals1);
            pbxFarmer1.Controls.Add(lblFarmSize1);
            pbxFarmer1.Controls.Add(pbxCross1);

            lblFarmerName1.Location = new Point(240, 13);
            lblFarmerGender1.Location = new Point(240, 48);
            lblFarmerAge1.Location = new Point(240, 80);
            lblNumOfAnimals1.Location = new Point(470, 70);
            lblFarmSize1.Location = new Point(470, 30);
            pbxCross1.Location = new Point(508, 5);

            pbxFarmer2.Controls.Add(lblFarmerName2);
            pbxFarmer2.Controls.Add(lblFarmerGender2);
            pbxFarmer2.Controls.Add(lblFarmerAge2);
            pbxFarmer2.Controls.Add(lblNumOfAnimals2);
            pbxFarmer2.Controls.Add(lblFarmSize2);
            pbxFarmer2.Controls.Add(pbxCross2);


            lblFarmerName2.Location = new Point(240, 13);
            lblFarmerGender2.Location = new Point(240, 48);
            lblFarmerAge2.Location = new Point(240, 80);
            lblNumOfAnimals2.Location = new Point(470, 70);
            lblFarmSize2.Location = new Point(470, 30);
            pbxCross2.Location = new Point(508, 5);

            pbxFarmer3.Controls.Add(lblFarmerName3);
            pbxFarmer3.Controls.Add(lblFarmerGender3);
            pbxFarmer3.Controls.Add(lblFarmerAge3);
            pbxFarmer3.Controls.Add(lblNumOfAnimals3);
            pbxFarmer3.Controls.Add(lblFarmSize3);
            pbxFarmer3.Controls.Add(pbxCross3);

            lblFarmerName3.Location = new Point(240, 13);
            lblFarmerGender3.Location = new Point(240, 48);
            lblFarmerAge3.Location = new Point(240, 80);
            lblNumOfAnimals3.Location = new Point(470, 70);
            lblFarmSize3.Location = new Point(470, 30);
            pbxCross3.Location = new Point(508, 5);

            pbxFarmer4.Controls.Add(lblFarmerName4);
            pbxFarmer4.Controls.Add(lblFarmerGender4);
            pbxFarmer4.Controls.Add(lblFarmerAge4);
            pbxFarmer4.Controls.Add(lblNumOfAnimals4);
            pbxFarmer4.Controls.Add(lblFarmSize4);
            pbxFarmer4.Controls.Add(pbxCross4);


            lblFarmerName4.Location = new Point(240, 13);
            lblFarmerGender4.Location = new Point(240, 48);
            lblFarmerAge4.Location = new Point(240, 80);
            lblNumOfAnimals4.Location = new Point(470, 70);
            lblFarmSize4.Location = new Point(470, 30);
            pbxCross4.Location = new Point(508, 5);


            pbxFarmer5.Controls.Add(lblFarmerName5);
            pbxFarmer5.Controls.Add(lblFarmerGender5);
            pbxFarmer5.Controls.Add(lblFarmerAge5);
            pbxFarmer5.Controls.Add(lblNumOfAnimals5);
            pbxFarmer5.Controls.Add(lblFarmSize5);
            pbxFarmer5.Controls.Add(pbxCross5);

            lblFarmerName5.Location = new Point(240, 13);
            lblFarmerGender5.Location = new Point(240, 48);
            lblFarmerAge5.Location = new Point(240, 80);
            lblNumOfAnimals5.Location = new Point(470, 70);
            lblFarmSize5.Location = new Point(470, 30);
            pbxCross5.Location = new Point(508, 5);
            #endregion
        }

        #region NewFarmer_Click
        private void pbxNewFarmer1_Click(object sender, EventArgs e)
        {
            navFormWithoutParam.Invoke();
        }

        private void pbxNewFarmer2_Click(object sender, EventArgs e)
        {
            navFormWithoutParam.Invoke();
        }

        private void pbxNewFarmer3_Click(object sender, EventArgs e)
        {
            navFormWithoutParam.Invoke();
        }

        private void pbxNewFarmer4_Click(object sender, EventArgs e)
        {
            navFormWithoutParam.Invoke();
        }

        private void pbxNewFarmer5_Click(object sender, EventArgs e)
        {
            navFormWithoutParam.Invoke();
        }
        #endregion

        #region ExistingFarmer_Click
        private void pbxFarmer1_Click(object sender, EventArgs e)
        {
            navFormwithParam.Invoke((Farmer)AllFarmers[0]);
            navFormwithParam -= new NavFormsWithParam(NavResumeOrFarmView);
        }

        private void pbxFarmer2_Click(object sender, EventArgs e)
        {
            navFormwithParam.Invoke((Farmer)AllFarmers[1]);
            navFormwithParam -= new NavFormsWithParam(NavResumeOrFarmView);
        }

        private void pbxFarmer3_Click(object sender, EventArgs e)
        {
            navFormwithParam.Invoke((Farmer)AllFarmers[2]);
            navFormwithParam -= new NavFormsWithParam(NavResumeOrFarmView);
        }

        private void pbxFarmer4_Click(object sender, EventArgs e)
        {

            navFormwithParam.Invoke((Farmer)AllFarmers[3]);
            navFormwithParam -= new NavFormsWithParam(NavResumeOrFarmView);
        }

        private void pbxFarmer5_Click(object sender, EventArgs e)
        {
            navFormwithParam.Invoke((Farmer)AllFarmers[4]);
            navFormwithParam -= new NavFormsWithParam(NavResumeOrFarmView);
        }
        #endregion

        #region Delete_Click
        private void pbxCross1_Click(object sender, EventArgs e)
        {
            deleteFarmer += new DeleteFarmerDel(DeleteFarmer);
            deleteFarmer.Invoke((Farmer)AllFarmers[0], lblFarmerName1.Text);
        }

        private void pbxCross2_Click(object sender, EventArgs e)
        {
            deleteFarmer += new DeleteFarmerDel(DeleteFarmer);
            deleteFarmer.Invoke((Farmer)AllFarmers[1], lblFarmerName2.Text);
        }

        private void pbxCross3_Click(object sender, EventArgs e)
        {
            deleteFarmer += new DeleteFarmerDel(DeleteFarmer);
            deleteFarmer.Invoke((Farmer)AllFarmers[2], lblFarmerName3.Text);
        }

        private void pbxCross4_Click(object sender, EventArgs e)
        {
            deleteFarmer += new DeleteFarmerDel(DeleteFarmer);
            deleteFarmer.Invoke((Farmer)AllFarmers[3], lblFarmerName4.Text);
        }

        private void pbxCross5_Click(object sender, EventArgs e)
        {
            deleteFarmer += new DeleteFarmerDel(DeleteFarmer);
            deleteFarmer.Invoke((Farmer)AllFarmers[4], lblFarmerName5.Text);
        }
        #endregion

        #region Methods
        //Loading existing characters
        private void CharacterLoad(PictureBox newFarmer, PictureBox farmer, Label farmerName, Label farmerGender, Label farmerAge, Label numOfAnimals, Label farmSize, int index, PictureBox pbxBody, PictureBox pbxOutfit, PictureBox pbxEyes, PictureBox pbxHair)
        {
            newFarmer.Visible = false;
            farmer.Visible = true;
            CurrentFarmer = (Farmer)AllFarmers[index];
            farmerName.Text = CurrentFarmer.Name;
            farmerGender.Text = CurrentFarmer.Gender;
            farmerAge.Text = CurrentFarmer.Age + "";
            numOfAnimals.Text = CurrentFarmer.numOfAnimals().ToString();
            farmSize.Text = CurrentFarmer.GetFarmSize().ToString();

            if (AllFarmers[index].Gender == "Male")
            {
                loadMaleAvatar(AllFarmers[index].FarmerStyle.OutfitType, AllFarmers[index].FarmerStyle.Eyecolour, AllFarmers[index].FarmerStyle.HairColour, AllFarmers[index].FarmerStyle.SkinColour, pbxBody, pbxOutfit, pbxEyes, pbxHair);
            }
            else if (AllFarmers[index].Gender == "Female")
            {
                loadFemaleAvatar(AllFarmers[index].FarmerStyle.OutfitType, AllFarmers[index].FarmerStyle.Eyecolour, AllFarmers[index].FarmerStyle.HairColour, AllFarmers[index].FarmerStyle.SkinColour, pbxBody, pbxOutfit, pbxEyes, pbxHair);
            }
        }
        //Loading Character avatars
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

        //Delete a farmer that already exists
        private void DeleteFarmer(Farmer CurrentFarmer, string Name)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete " + Name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                CurrentFarmer.DeleteFarmer();

                Thread RefreshThread = new Thread(() => { Application.Run(new Farmer_Selection()); });

                RefreshThread.Start();

                this.Close();

            }
        }

        //Method for the event to go to a specific form if a farmer that exists is selected
        private void NavResumeOrFarmView(Farmer CurrentFarmer)
        {
            if (CurrentFarmer.GetFarmSize() > 0)
            {
                if (CurrentFarmer.numOfAnimals() > 0)
                {
                    Farm_View form = new Farm_View(CurrentFarmer.ID);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    Animal_Selection form = new Animal_Selection(CurrentFarmer.ID);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                Farm_Creation form = new Farm_Creation(CurrentFarmer.ID);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        //Method to go to farmer creation when a new farmer is clicked
        private void NavFarmerCreation()
        {
            Farmer_Creation form = new Farmer_Creation();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        #endregion
    }
}

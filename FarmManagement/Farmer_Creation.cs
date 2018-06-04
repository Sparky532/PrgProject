using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using HelperLibrary;
using FarmManagement.BLL;

namespace FarmManagement
{

    public partial class Farmer_Creation : Form
    {
        ClientObject Client = new ClientObject();

        //Declaration of character items
        Dictionary<string, Bitmap> skins = new Dictionary<string, Bitmap>();
        Dictionary<string, Bitmap> hairs = new Dictionary<string, Bitmap>();
        Dictionary<string, Bitmap> eyes = new Dictionary<string, Bitmap>();
        Dictionary<string, Bitmap> outfits = new Dictionary<string, Bitmap>();
        int[] indexes = new int[] { 0, 0, 0, 0 };

        public Farmer_Creation()
        {
            InitializeComponent();
        }
        private void Farmer_Creation_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            pbxBackground.Controls.Add(pbxBack);
            pbxBack.Location = new Point(0, 0);
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == 0)
            {
                loadFemales();
                pbxBody.Location = new Point(36, 35);
                loadDefaults();
            }
            else
            {
                loadMales();
                pbxBody.Location = new Point(17, 28);
                loadDefaults();
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Farmer_Selection form = new Farmer_Selection();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }


        #region Previous_click
        //Skin previous
        private void pbxPrevious1_Click(object sender, EventArgs e)
        {
            PreviousButton_Click(0, skins, txtSkin, pbxBody);
        }

        //Hair previous
        private void pbxPrevious2_Click(object sender, EventArgs e)
        {
            PreviousButton_Click(1, hairs, txtHair, pbxHairs);
        }

        //Eye previous
        private void pbxPrevious3_Click(object sender, EventArgs e)
        {
            PreviousButton_Click(2, eyes, txtEye, pbxEyes);
        }

        //Oufit previous
        private void pbxPrevious4_Click(object sender, EventArgs e)
        {
            PreviousButton_Click(3, outfits, txtOutfit, pbxOutfits);
        }
        #endregion

        #region Next_click
        //Skin Next
        private void pbxNext1_Click(object sender, EventArgs e)
        {
            NextButton_Click(0, skins, txtSkin, pbxBody);
        }

        //Hair Next
        private void pbxNext2_Click(object sender, EventArgs e)
        {
            NextButton_Click(1, hairs, txtHair, pbxHairs);
        }

        //Eyes Next
        private void pbxNext3_Click(object sender, EventArgs e)
        {
            NextButton_Click(2, eyes, txtEye, pbxEyes);
        }

        //Outfit Next
        private void pbxNext4_Click(object sender, EventArgs e)
        {
            NextButton_Click(3, outfits, txtOutfit, pbxOutfits);
        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    throw new NoFarmerNameException();
                }
                int success = 0;
                Style FarmerStyle = new Style();
                FarmerStyle.Eyecolour = txtEye.Text;
                FarmerStyle.OutfitType = txtOutfit.Text;
                FarmerStyle.SkinColour = txtSkin.Text;
                FarmerStyle.HairColour = txtHair.Text;
                Farmer farmer = new Farmer(txtName.Text, cmbGender.Text, int.Parse(txtAge.Text), FarmerStyle);
                MessageObject FarmerToAdd = new MessageObject();
                FarmerToAdd.Data = farmer.BinarySerialization();
                FarmerToAdd.FormIdentifier = 2;
                FarmerToAdd.ObjectIdentifier = 1;
                FarmerToAdd.ActionIdentifier = 2;
                Client.SendData(FarmerToAdd);
                // success = farmer.InsertFarmer();3
                Farm_Creation form = new Farm_Creation();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            catch (NoFarmerNameException)
            {
                MessageBox.Show("Your Farmer needs a Name");
            }
            catch (FormatException)
            {
                MessageBox.Show("Age has to be a number");
            }
        }
        #endregion

        #region Characters Methods
        //Loading female characters
        private void loadFemales()
        {
            eyes.Clear();
            skins.Clear();
            hairs.Clear();
            outfits.Clear();

            pbxEyes.Location = new Point(0, 103);
            pbxHairs.Location = new Point(0, -10);

            eyes.Add("Green", Properties.Resources.GirlGreenEyes);
            eyes.Add("Blue", Properties.Resources.GirlBlueEyes);
            eyes.Add("Brown", Properties.Resources.GirlBrownEyes);

            skins.Add("Black", Properties.Resources.BlackGirlSkin);
            skins.Add("White", Properties.Resources.WhiteGirlSkin);

            hairs.Add("Black", Properties.Resources.BlackHairGirl);
            hairs.Add("Brown", Properties.Resources.BrownHairGirl);
            hairs.Add("Red", Properties.Resources.RedHairGirl);
            hairs.Add("Blond", Properties.Resources.BlondHairGirl);

            outfits.Add("One", Properties.Resources.GirlOutfit1);
            outfits.Add("Two", Properties.Resources.GirlOutfit2);
            outfits.Add("Three", Properties.Resources.GirlOutfit3);
            outfits.Add("Four", Properties.Resources.GirlOutfit4);
        }

        //Loading male characters
        private void loadMales()
        {
            eyes.Clear();
            skins.Clear();
            hairs.Clear();
            outfits.Clear();

            pbxEyes.Location = new Point(10, 105);
            pbxHairs.Location = new Point(0, -17);

            eyes.Add("Green", Properties.Resources.GirlGreenEyes);
            eyes.Add("Blue", Properties.Resources.GirlBlueEyes);
            eyes.Add("Brown", Properties.Resources.GirlBrownEyes);

            skins.Add("Black", Properties.Resources.BlackBoyLayer);
            skins.Add("White", Properties.Resources.WhiteBoyLayer);

            hairs.Add("Black", Properties.Resources.BoyBlackHair);
            hairs.Add("Brown", Properties.Resources.BoyBrownHair);
            hairs.Add("Red", Properties.Resources.BoyRedHair);
            hairs.Add("Blond", Properties.Resources.BoyBlondHair);

            outfits.Add("One", Properties.Resources.BoyOutfit1);
            outfits.Add("Two", Properties.Resources.BoyOutfit2);
            outfits.Add("Three", Properties.Resources.BoyOutfit3);
            outfits.Add("Four", Properties.Resources.BoyOutfit4);
        }

        //Loading the default character
        public void loadDefaults()
        {
            KeyValuePair<string, Bitmap> eye = eyes.ElementAt(0);
            txtEye.Text = eye.Key;
            pbxEyes.Image = eye.Value;

            KeyValuePair<string, Bitmap> skin = skins.ElementAt(0);
            txtSkin.Text = skin.Key;
            pbxBody.Image = skin.Value;

            KeyValuePair<string, Bitmap> hair = hairs.ElementAt(0);
            txtHair.Text = hair.Key;
            pbxHairs.Image = hair.Value;

            KeyValuePair<string, Bitmap> outfit = outfits.ElementAt(0);
            txtOutfit.Text = outfit.Key;
            pbxOutfits.Image = outfit.Value;

            pbxBody.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxOutfits.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEyes.SizeMode = PictureBoxSizeMode.Zoom;
            pbxHairs.SizeMode = PictureBoxSizeMode.Zoom;

            pbxBackground.Controls.Add(pbxBody);

            pbxBody.Controls.Add(pbxOutfits);
            pbxOutfits.Location = new Point(0, 196);

            pbxBody.Controls.Add(pbxEyes);
            pbxHairs.Controls.Add(pbxEyes);
            pbxBody.Controls.Add(pbxHairs);
        }
        #endregion

        #region Methods
        private void NextButton_Click(int index, Dictionary<string, Bitmap> items, TextBox txt, PictureBox pbx)
        {
            try
            {
                indexes[index]++;
                KeyValuePair<string, Bitmap> item = items.ElementAt(indexes[index]);
                txt.Text = item.Key;
                pbx.Image = item.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[index] = 0;
                KeyValuePair<string, Bitmap> item = items.ElementAt(indexes[index]);
                txt.Text = item.Key;
                pbx.Image = item.Value;
            }
        }

        private void PreviousButton_Click(int index, Dictionary<string, Bitmap> items, TextBox txt, PictureBox pbx)
        {
            try
            {
                indexes[index]--;
                KeyValuePair<string, Bitmap> item = items.ElementAt(indexes[index]);
                txt.Text = item.Key;
                pbx.Image = item.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[index] = items.Count - 1;
                KeyValuePair<string, Bitmap> item = items.ElementAt(indexes[index]);
                txt.Text = item.Key;
                pbx.Image = item.Value;
            }
        }
        #endregion

    }
}

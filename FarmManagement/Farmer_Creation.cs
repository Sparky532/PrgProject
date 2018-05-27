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

namespace FarmManagement
{
    public partial class Farmer_Creation : Form
    {
        Dictionary<string, Bitmap> skins = new Dictionary<string, Bitmap>();
        Dictionary<string, Bitmap> hairs = new Dictionary<string, Bitmap>();
        Dictionary<string, Bitmap> eyes = new Dictionary<string, Bitmap>();
        Dictionary<string, Bitmap> outfits = new Dictionary<string, Bitmap>();
        int[] indexes = new int[]{0,0,0,0};
        public Farmer_Creation()
        {
            InitializeComponent();
            cmbGender.SelectedIndex = 0;
            
        }

        //public Farmer_Creation(int id)
        //{
        //    InitializeComponent();
        //    cmbGender.SelectedIndex = 0;

        //}

        void loadFemales()
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

        void loadMales()
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

            //this.BackColor = Color.FromArgb(36, 41, 45);

            pbxBody.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxOutfits.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEyes.SizeMode = PictureBoxSizeMode.Zoom;
            pbxHairs.SizeMode = PictureBoxSizeMode.Zoom;

            pbxBackground.Controls.Add(pbxBody);
            

            pbxBody.Controls.Add(pbxOutfits);
            pbxOutfits.Location = new Point(0, 196);
            pbxOutfits.BackColor = Color.Transparent;

            pbxBody.Controls.Add(pbxEyes);
            pbxEyes.BackColor = Color.Transparent;

            pbxHairs.Controls.Add(pbxEyes);

            pbxBody.Controls.Add(pbxHairs);
            pbxHairs.BackColor = Color.Transparent;
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex==0)
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

        private void Farmer_Creation_Load(object sender, EventArgs e)
        {
            pbxBackground.Controls.Add(pbxBack);
            pbxBack.Location = new Point(0, 0);
        }

        private void Farmer_Creation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        //Skin Previous
        private void pbxPrevious1_Click(object sender, EventArgs e)
        {

            try
            {
                indexes[0]--;
                KeyValuePair<string, Bitmap> skin = skins.ElementAt(indexes[0]);
                txtSkin.Text = skin.Key;
                pbxBody.Image = skin.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[0] = skins.Count - 1;
                KeyValuePair<string, Bitmap> skin = skins.ElementAt(indexes[0]);
                txtSkin.Text = skin.Key;
                pbxBody.Image = skin.Value;
            }
        }
        //HairPrevious
        private void pbxPrevious2_Click(object sender, EventArgs e)
        {
            try
            {
                indexes[1]--;
                KeyValuePair<string, Bitmap> hair = hairs.ElementAt(indexes[1]);
                txtHair.Text = hair.Key;
                pbxHairs.Image = hair.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[1] = hairs.Count - 1;
                KeyValuePair<string, Bitmap> hair = hairs.ElementAt(indexes[1]);
                txtHair.Text = hair.Key;
                pbxHairs.Image = hair.Value;
            }
        }
        //EyesPrevious
        private void pbxPrevious3_Click(object sender, EventArgs e)
        {
            try
            {
                indexes[2]--;
                KeyValuePair<string, Bitmap> eye = eyes.ElementAt(indexes[2]);
                txtEye.Text = eye.Key;
                pbxEyes.Image = eye.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[2] = eyes.Count - 1;
                KeyValuePair<string, Bitmap> eye = eyes.ElementAt(indexes[2]);
                txtEye.Text = eye.Key;
                pbxEyes.Image = eye.Value;

            }
        }
        //OutfitPrevious
        private void pbxPrevious4_Click(object sender, EventArgs e)
        {
            try
            {
                indexes[3]--;
                KeyValuePair<string, Bitmap> outfit = outfits.ElementAt(indexes[3]);
                txtOutfit.Text = outfit.Key;
                pbxOutfits.Image = outfit.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[3] = outfits.Count - 1;
                KeyValuePair<string, Bitmap> outfit = outfits.ElementAt(indexes[3]);
                txtOutfit.Text = outfit.Key;
                pbxOutfits.Image = outfit.Value;
            }
        }
        //Skin Next
        private void pbxNext1_Click(object sender, EventArgs e)
        {
            try
            {
                indexes[0]++;
                KeyValuePair<string, Bitmap> skin = skins.ElementAt(indexes[0]);
                txtSkin.Text = skin.Key;
                pbxBody.Image = skin.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[0] = 0;
                KeyValuePair<string, Bitmap> skin = skins.ElementAt(indexes[0]);
                txtSkin.Text = skin.Key;
                pbxBody.Image = skin.Value;
            }
        }
        //Hair Next
        private void pbxNext2_Click(object sender, EventArgs e)
        {

            try
            {
                indexes[1]++;
                KeyValuePair<string, Bitmap> hair = hairs.ElementAt(indexes[1]);
                txtHair.Text = hair.Key;
                pbxHairs.Image = hair.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[1] = 0;
                KeyValuePair<string, Bitmap> hair = hairs.ElementAt(indexes[1]);
                txtHair.Text = hair.Key;
                pbxHairs.Image = hair.Value;
            }
        }
        //Eyes Next
        private void pbxNext3_Click(object sender, EventArgs e)
        {
            try
            {
                indexes[2]++;
                KeyValuePair<string, Bitmap> eye = eyes.ElementAt(indexes[2]);
                txtEye.Text = eye.Key;
                pbxEyes.Image = eye.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[2] = 0;
                KeyValuePair<string, Bitmap> eye = eyes.ElementAt(indexes[2]);
                txtEye.Text = eye.Key;
                pbxEyes.Image = eye.Value;
            }
        }
        //OutfitNext
        private void pbxNext4_Click(object sender, EventArgs e)
        {
            try
            {
                indexes[3]++;
                KeyValuePair<string, Bitmap> outfit = outfits.ElementAt(indexes[3]);
                txtOutfit.Text = outfit.Key;
                pbxOutfits.Image = outfit.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                indexes[3] = 0;
                KeyValuePair<string, Bitmap> outfit = outfits.ElementAt(indexes[3]);
                txtOutfit.Text = outfit.Key;
                pbxOutfits.Image = outfit.Value;
            }
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
                success = farmer.InsertFarmer();


                if (success == 2)
                {
                    Farm_Creation form = new Farm_Creation();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Insert Failed");

                }
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
    }
}

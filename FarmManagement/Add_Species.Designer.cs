namespace FarmManagement
{
    partial class Add_Species
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Species));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtChooseimage = new System.Windows.Forms.TextBox();
            this.lblChooseImage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWriteToTxt = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblSpaceNeeded = new System.Windows.Forms.Label();
            this.txtSpace = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.OpfdChooseImage = new System.Windows.Forms.OpenFileDialog();
            this.pbxNewAnimal = new System.Windows.Forms.PictureBox();
            this.pbxSpeciesBackground = new System.Windows.Forms.PictureBox();
            this.lblAddSpecies = new System.Windows.Forms.Label();
            this.btnBackToAnimalSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpeciesBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(93, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtName.Location = new System.Drawing.Point(273, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 45);
            this.txtName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(108, 154);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(88, 38);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtSpeed.Location = new System.Drawing.Point(273, 210);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(236, 45);
            this.txtSpeed.TabIndex = 5;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(93, 213);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(113, 38);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Speed";
            // 
            // txtChooseimage
            // 
            this.txtChooseimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtChooseimage.Location = new System.Drawing.Point(273, 319);
            this.txtChooseimage.Name = "txtChooseimage";
            this.txtChooseimage.Size = new System.Drawing.Size(236, 45);
            this.txtChooseimage.TabIndex = 7;
            // 
            // lblChooseImage
            // 
            this.lblChooseImage.AutoSize = true;
            this.lblChooseImage.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseImage.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseImage.Location = new System.Drawing.Point(24, 322);
            this.lblChooseImage.Name = "lblChooseImage";
            this.lblChooseImage.Size = new System.Drawing.Size(238, 38);
            this.lblChooseImage.TabIndex = 6;
            this.lblChooseImage.Text = "Choose Image";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(598, 488);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 51);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWriteToTxt
            // 
            this.btnWriteToTxt.Location = new System.Drawing.Point(521, 410);
            this.btnWriteToTxt.Name = "btnWriteToTxt";
            this.btnWriteToTxt.Size = new System.Drawing.Size(217, 51);
            this.btnWriteToTxt.TabIndex = 9;
            this.btnWriteToTxt.Text = "Let Game Developers Add the Details";
            this.btnWriteToTxt.UseVisualStyleBackColor = true;
            this.btnWriteToTxt.Click += new System.EventHandler(this.btnWriteToTxt_Click);
            // 
            // cbxType
            // 
            this.cbxType.BackColor = System.Drawing.Color.White;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Prey",
            "Predator"});
            this.cbxType.Location = new System.Drawing.Point(273, 154);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(236, 46);
            this.cbxType.TabIndex = 10;
            // 
            // lblSpaceNeeded
            // 
            this.lblSpaceNeeded.AutoSize = true;
            this.lblSpaceNeeded.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceNeeded.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceNeeded.Location = new System.Drawing.Point(24, 263);
            this.lblSpaceNeeded.Name = "lblSpaceNeeded";
            this.lblSpaceNeeded.Size = new System.Drawing.Size(237, 38);
            this.lblSpaceNeeded.TabIndex = 6;
            this.lblSpaceNeeded.Text = "Space Needed";
            // 
            // txtSpace
            // 
            this.txtSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtSpace.Location = new System.Drawing.Point(273, 260);
            this.txtSpace.Name = "txtSpace";
            this.txtSpace.Size = new System.Drawing.Size(236, 45);
            this.txtSpace.TabIndex = 7;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(521, 322);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 42);
            this.btnChooseFile.TabIndex = 11;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // OpfdChooseImage
            // 
            this.OpfdChooseImage.FileName = "openFileDialog1";
            // 
            // pbxNewAnimal
            // 
            this.pbxNewAnimal.Location = new System.Drawing.Point(521, 99);
            this.pbxNewAnimal.Name = "pbxNewAnimal";
            this.pbxNewAnimal.Size = new System.Drawing.Size(214, 205);
            this.pbxNewAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNewAnimal.TabIndex = 12;
            this.pbxNewAnimal.TabStop = false;
            // 
            // pbxSpeciesBackground
            // 
            this.pbxSpeciesBackground.Image = global::FarmManagement.Properties.Resources.AddSpeciesBG;
            this.pbxSpeciesBackground.Location = new System.Drawing.Point(-22, 0);
            this.pbxSpeciesBackground.Name = "pbxSpeciesBackground";
            this.pbxSpeciesBackground.Size = new System.Drawing.Size(788, 585);
            this.pbxSpeciesBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSpeciesBackground.TabIndex = 13;
            this.pbxSpeciesBackground.TabStop = false;
            // 
            // lblAddSpecies
            // 
            this.lblAddSpecies.AutoSize = true;
            this.lblAddSpecies.BackColor = System.Drawing.Color.Transparent;
            this.lblAddSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSpecies.Location = new System.Drawing.Point(256, 28);
            this.lblAddSpecies.Name = "lblAddSpecies";
            this.lblAddSpecies.Size = new System.Drawing.Size(211, 39);
            this.lblAddSpecies.TabIndex = 14;
            this.lblAddSpecies.Text = "Add Species";
            // 
            // btnBackToAnimalSelection
            // 
            this.btnBackToAnimalSelection.Location = new System.Drawing.Point(31, 488);
            this.btnBackToAnimalSelection.Name = "btnBackToAnimalSelection";
            this.btnBackToAnimalSelection.Size = new System.Drawing.Size(95, 50);
            this.btnBackToAnimalSelection.TabIndex = 15;
            this.btnBackToAnimalSelection.Text = "Back";
            this.btnBackToAnimalSelection.UseVisualStyleBackColor = true;
            this.btnBackToAnimalSelection.Click += new System.EventHandler(this.btnBackToAnimalSelection_Click);
            // 
            // Add_Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 579);
            this.Controls.Add(this.btnBackToAnimalSelection);
            this.Controls.Add(this.lblAddSpecies);
            this.Controls.Add(this.pbxNewAnimal);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.btnWriteToTxt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSpace);
            this.Controls.Add(this.txtChooseimage);
            this.Controls.Add(this.lblSpaceNeeded);
            this.Controls.Add(this.lblChooseImage);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxSpeciesBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Species";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Species_FormClosing);
            this.Load += new System.EventHandler(this.Add_Species_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNewAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpeciesBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtChooseimage;
        private System.Windows.Forms.Label lblChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWriteToTxt;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblSpaceNeeded;
        private System.Windows.Forms.TextBox txtSpace;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog OpfdChooseImage;
        private System.Windows.Forms.PictureBox pbxNewAnimal;
        private System.Windows.Forms.PictureBox pbxSpeciesBackground;
        private System.Windows.Forms.Label lblAddSpecies;
        private System.Windows.Forms.Button btnBackToAnimalSelection;
    }
}
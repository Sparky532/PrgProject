namespace FarmManagement
{
    partial class Animal_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animal_Selection));
            this.txtAnimalAmount = new System.Windows.Forms.TextBox();
            this.cbxAnimals = new System.Windows.Forms.ComboBox();
            this.lstAnimalsSelected = new System.Windows.Forms.ListBox();
            this.txtSelectedAnimalAmount = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.pbxPrevious = new System.Windows.Forms.PictureBox();
            this.pbxAddNew = new System.Windows.Forms.PictureBox();
            this.pbxChange = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.pbxNext1 = new System.Windows.Forms.PictureBox();
            this.pbxAnimal = new System.Windows.Forms.PictureBox();
            this.pbxFrame = new System.Windows.Forms.PictureBox();
            this.pbxPanel = new System.Windows.Forms.PictureBox();
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            this.txtCurrentCages = new System.Windows.Forms.TextBox();
            this.lblCurrentCages = new System.Windows.Forms.Label();
            this.txtMaxCages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAnimalAmount
            // 
            this.txtAnimalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnimalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtAnimalAmount.Location = new System.Drawing.Point(131, 404);
            this.txtAnimalAmount.Name = "txtAnimalAmount";
            this.txtAnimalAmount.Size = new System.Drawing.Size(70, 45);
            this.txtAnimalAmount.TabIndex = 10;
            this.txtAnimalAmount.Text = "0";
            this.txtAnimalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxAnimals
            // 
            this.cbxAnimals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAnimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cbxAnimals.FormattingEnabled = true;
            this.cbxAnimals.Location = new System.Drawing.Point(67, 341);
            this.cbxAnimals.Name = "cbxAnimals";
            this.cbxAnimals.Size = new System.Drawing.Size(194, 46);
            this.cbxAnimals.TabIndex = 21;
            this.cbxAnimals.SelectedIndexChanged += new System.EventHandler(this.cbxAnimals_SelectedIndexChanged);
            this.cbxAnimals.SelectedValueChanged += new System.EventHandler(this.cbxAnimals_SelectedValueChanged);
            // 
            // lstAnimalsSelected
            // 
            this.lstAnimalsSelected.BackColor = System.Drawing.Color.White;
            this.lstAnimalsSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAnimalsSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAnimalsSelected.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnimalsSelected.FormattingEnabled = true;
            this.lstAnimalsSelected.ItemHeight = 21;
            this.lstAnimalsSelected.Location = new System.Drawing.Point(450, 46);
            this.lstAnimalsSelected.MultiColumn = true;
            this.lstAnimalsSelected.Name = "lstAnimalsSelected";
            this.lstAnimalsSelected.Size = new System.Drawing.Size(233, 210);
            this.lstAnimalsSelected.TabIndex = 23;
            this.lstAnimalsSelected.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSelectedAnimalAmount
            // 
            this.txtSelectedAnimalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectedAnimalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtSelectedAnimalAmount.Location = new System.Drawing.Point(406, 326);
            this.txtSelectedAnimalAmount.Name = "txtSelectedAnimalAmount";
            this.txtSelectedAnimalAmount.Size = new System.Drawing.Size(70, 45);
            this.txtSelectedAnimalAmount.TabIndex = 26;
            this.txtSelectedAnimalAmount.Text = "0";
            this.txtSelectedAnimalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSelectedAnimalAmount.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(650, 369);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            // 
            // pbxRemove
            // 
            this.pbxRemove.BackColor = System.Drawing.Color.Transparent;
            this.pbxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRemove.Image = global::FarmManagement.Properties.Resources.RemoveButton;
            this.pbxRemove.Location = new System.Drawing.Point(556, 369);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(147, 80);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRemove.TabIndex = 38;
            this.pbxRemove.TabStop = false;
            this.pbxRemove.Visible = false;
            this.pbxRemove.Click += new System.EventHandler(this.pbxRemove_Click);
            // 
            // pbxPrevious
            // 
            this.pbxPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbxPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPrevious.Image = global::FarmManagement.Properties.Resources.PreviousN;
            this.pbxPrevious.Location = new System.Drawing.Point(51, 401);
            this.pbxPrevious.Name = "pbxPrevious";
            this.pbxPrevious.Size = new System.Drawing.Size(64, 50);
            this.pbxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPrevious.TabIndex = 32;
            this.pbxPrevious.TabStop = false;
            this.pbxPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxPrevious_MouseDown);
            // 
            // pbxAddNew
            // 
            this.pbxAddNew.BackColor = System.Drawing.Color.Transparent;
            this.pbxAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAddNew.Image = global::FarmManagement.Properties.Resources.AddNewSpeciesButton;
            this.pbxAddNew.Location = new System.Drawing.Point(305, 350);
            this.pbxAddNew.Name = "pbxAddNew";
            this.pbxAddNew.Size = new System.Drawing.Size(201, 97);
            this.pbxAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddNew.TabIndex = 36;
            this.pbxAddNew.TabStop = false;
            this.pbxAddNew.Click += new System.EventHandler(this.pbxAddNew_Click);
            // 
            // pbxChange
            // 
            this.pbxChange.BackColor = System.Drawing.Color.Transparent;
            this.pbxChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxChange.Image = global::FarmManagement.Properties.Resources.ChangeButton;
            this.pbxChange.Location = new System.Drawing.Point(356, 369);
            this.pbxChange.Name = "pbxChange";
            this.pbxChange.Size = new System.Drawing.Size(178, 80);
            this.pbxChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxChange.TabIndex = 35;
            this.pbxChange.TabStop = false;
            this.pbxChange.Click += new System.EventHandler(this.pbxChange_Click);
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = global::FarmManagement.Properties.Resources.AddButton;
            this.pbxAdd.Location = new System.Drawing.Point(104, 468);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(173, 88);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 34;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxNext
            // 
            this.pbxNext.BackColor = System.Drawing.Color.Transparent;
            this.pbxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNext.Image = global::FarmManagement.Properties.Resources.NextButton;
            this.pbxNext.Location = new System.Drawing.Point(418, 468);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(178, 80);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNext.TabIndex = 33;
            this.pbxNext.TabStop = false;
            this.pbxNext.Click += new System.EventHandler(this.pbxNext_Click);
            // 
            // pbxNext1
            // 
            this.pbxNext1.BackColor = System.Drawing.Color.Transparent;
            this.pbxNext1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNext1.Image = global::FarmManagement.Properties.Resources.NextN;
            this.pbxNext1.Location = new System.Drawing.Point(197, 401);
            this.pbxNext1.Name = "pbxNext1";
            this.pbxNext1.Size = new System.Drawing.Size(64, 50);
            this.pbxNext1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNext1.TabIndex = 31;
            this.pbxNext1.TabStop = false;
            this.pbxNext1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxNext1_Click);
            // 
            // pbxAnimal
            // 
            this.pbxAnimal.BackColor = System.Drawing.Color.Transparent;
            this.pbxAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAnimal.Image = global::FarmManagement.Properties.Resources.Sheep;
            this.pbxAnimal.Location = new System.Drawing.Point(78, 75);
            this.pbxAnimal.Name = "pbxAnimal";
            this.pbxAnimal.Size = new System.Drawing.Size(214, 205);
            this.pbxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAnimal.TabIndex = 0;
            this.pbxAnimal.TabStop = false;
            this.pbxAnimal.Click += new System.EventHandler(this.pbxAnimal_Click);
            // 
            // pbxFrame
            // 
            this.pbxFrame.BackColor = System.Drawing.Color.Transparent;
            this.pbxFrame.Image = global::FarmManagement.Properties.Resources.FrameBGNew;
            this.pbxFrame.Location = new System.Drawing.Point(378, -5);
            this.pbxFrame.Name = "pbxFrame";
            this.pbxFrame.Size = new System.Drawing.Size(376, 309);
            this.pbxFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFrame.TabIndex = 29;
            this.pbxFrame.TabStop = false;
            // 
            // pbxPanel
            // 
            this.pbxPanel.Image = global::FarmManagement.Properties.Resources.PanelNew;
            this.pbxPanel.Location = new System.Drawing.Point(1, 303);
            this.pbxPanel.Name = "pbxPanel";
            this.pbxPanel.Size = new System.Drawing.Size(755, 279);
            this.pbxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPanel.TabIndex = 30;
            this.pbxPanel.TabStop = false;
            // 
            // pbxBackground
            // 
            this.pbxBackground.Image = global::FarmManagement.Properties.Resources.BarnBGNew1;
            this.pbxBackground.Location = new System.Drawing.Point(-6, -5);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(414, 311);
            this.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBackground.TabIndex = 28;
            this.pbxBackground.TabStop = false;
            // 
            // txtCurrentCages
            // 
            this.txtCurrentCages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(225)))));
            this.txtCurrentCages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentCages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentCages.Location = new System.Drawing.Point(114, 69);
            this.txtCurrentCages.Name = "txtCurrentCages";
            this.txtCurrentCages.ReadOnly = true;
            this.txtCurrentCages.Size = new System.Drawing.Size(100, 17);
            this.txtCurrentCages.TabIndex = 39;
            this.txtCurrentCages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentCages
            // 
            this.lblCurrentCages.AutoSize = true;
            this.lblCurrentCages.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCages.Location = new System.Drawing.Point(7, 69);
            this.lblCurrentCages.Name = "lblCurrentCages";
            this.lblCurrentCages.Size = new System.Drawing.Size(101, 20);
            this.lblCurrentCages.TabIndex = 40;
            this.lblCurrentCages.Text = "Current Cages";
            this.lblCurrentCages.Click += new System.EventHandler(this.lblCurrentCages_Click);
            // 
            // txtMaxCages
            // 
            this.txtMaxCages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(225)))));
            this.txtMaxCages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxCages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCages.Location = new System.Drawing.Point(114, 32);
            this.txtMaxCages.Name = "txtMaxCages";
            this.txtMaxCages.ReadOnly = true;
            this.txtMaxCages.Size = new System.Drawing.Size(100, 17);
            this.txtMaxCages.TabIndex = 39;
            this.txtMaxCages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Max Amount";
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(209)))), ((int)(((byte)(225)))));
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.Add(this.label1);
            this.pnlStats.Controls.Add(this.txtMaxCages);
            this.pnlStats.Controls.Add(this.label2);
            this.pnlStats.Controls.Add(this.txtCurrentCages);
            this.pnlStats.Controls.Add(this.lblCurrentCages);
            this.pnlStats.Location = new System.Drawing.Point(512, 337);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(223, 110);
            this.pnlStats.TabIndex = 41;
            this.pnlStats.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStats_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cage Statistics";
            // 
            // Animal_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 568);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pbxRemove);
            this.Controls.Add(this.pbxPrevious);
            this.Controls.Add(this.pbxAddNew);
            this.Controls.Add(this.pbxChange);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.pbxNext1);
            this.Controls.Add(this.txtSelectedAnimalAmount);
            this.Controls.Add(this.lstAnimalsSelected);
            this.Controls.Add(this.cbxAnimals);
            this.Controls.Add(this.txtAnimalAmount);
            this.Controls.Add(this.pbxAnimal);
            this.Controls.Add(this.pbxFrame);
            this.Controls.Add(this.pbxPanel);
            this.Controls.Add(this.pbxBackground);
            this.Controls.Add(this.btnRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Animal_Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal_Selection";
            this.Load += new System.EventHandler(this.Animal_Selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAnimal;
        private System.Windows.Forms.TextBox txtAnimalAmount;
        private System.Windows.Forms.ComboBox cbxAnimals;
        private System.Windows.Forms.ListBox lstAnimalsSelected;
        private System.Windows.Forms.TextBox txtSelectedAnimalAmount;
        private System.Windows.Forms.PictureBox pbxBackground;
        private System.Windows.Forms.PictureBox pbxFrame;
        private System.Windows.Forms.PictureBox pbxPanel;
        private System.Windows.Forms.PictureBox pbxNext1;
        private System.Windows.Forms.PictureBox pbxPrevious;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxChange;
        private System.Windows.Forms.PictureBox pbxAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.TextBox txtCurrentCages;
        private System.Windows.Forms.Label lblCurrentCages;
        private System.Windows.Forms.TextBox txtMaxCages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label label1;
    }
}
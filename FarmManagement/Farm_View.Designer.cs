namespace FarmManagement
{
    partial class Farm_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farm_View));
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCages = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCloseMenu = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.pnlSortSubMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SortLion = new System.Windows.Forms.Button();
            this.SortTiger = new System.Windows.Forms.Button();
            this.SortCow = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SortSheep = new System.Windows.Forms.Button();
            this.SortHorse = new System.Windows.Forms.Button();
            this.SortAll = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlSettingsSubMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.pblSortLists = new System.Windows.Forms.Panel();
            this.txtAnimals = new System.Windows.Forms.TextBox();
            this.pnlCagesSort = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCages = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtFarmName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlSortSubMenu.SuspendLayout();
            this.pnlSettingsSubMenu.SuspendLayout();
            this.pblSortLists.SuspendLayout();
            this.pnlCagesSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLocations
            // 
            this.lstLocations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstLocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLocations.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 22;
            this.lstLocations.Location = new System.Drawing.Point(50, 50);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(140, 396);
            this.lstLocations.TabIndex = 1;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged_1);
            // 
            // lstAnimals
            // 
            this.lstAnimals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAnimals.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.ItemHeight = 22;
            this.lstAnimals.Location = new System.Drawing.Point(0, 100);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(280, 396);
            this.lstAnimals.TabIndex = 2;
            this.lstAnimals.SelectedIndexChanged += new System.EventHandler(this.lstAnimals_SelectedIndexChanged);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnCages);
            this.pnlMenu.Controls.Add(this.textBox1);
            this.pnlMenu.Controls.Add(this.btnCloseMenu);
            this.pnlMenu.Controls.Add(this.btnSort);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Location = new System.Drawing.Point(961, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(190, 500);
            this.pnlMenu.TabIndex = 4;
            this.pnlMenu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 450);
            this.panel1.TabIndex = 10;
            // 
            // btnCages
            // 
            this.btnCages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCages.FlatAppearance.BorderSize = 0;
            this.btnCages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCages.Location = new System.Drawing.Point(40, 300);
            this.btnCages.Name = "btnCages";
            this.btnCages.Size = new System.Drawing.Size(150, 50);
            this.btnCages.TabIndex = 11;
            this.btnCages.Text = "Cages";
            this.btnCages.UseVisualStyleBackColor = false;
            this.btnCages.Click += new System.EventHandler(this.btnCages_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(90, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Menu ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseMenu.FlatAppearance.BorderSize = 0;
            this.btnCloseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCloseMenu.Location = new System.Drawing.Point(0, 0);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.Size = new System.Drawing.Size(50, 50);
            this.btnCloseMenu.TabIndex = 8;
            this.btnCloseMenu.Text = "≡";
            this.btnCloseMenu.UseVisualStyleBackColor = false;
            this.btnCloseMenu.Click += new System.EventHandler(this.btnCloseMenu_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSort.Location = new System.Drawing.Point(40, 350);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(150, 50);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            this.btnSort.MouseLeave += new System.EventHandler(this.btnSort_MouseLeave);
            this.btnSort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSort_MouseMove);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSettings.Location = new System.Drawing.Point(40, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnExit.Location = new System.Drawing.Point(40, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenMenu.FlatAppearance.BorderSize = 0;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOpenMenu.Location = new System.Drawing.Point(0, 0);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(50, 50);
            this.btnOpenMenu.TabIndex = 9;
            this.btnOpenMenu.Text = "≡";
            this.btnOpenMenu.UseVisualStyleBackColor = false;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // pnlSortSubMenu
            // 
            this.pnlSortSubMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSortSubMenu.Controls.Add(this.panel2);
            this.pnlSortSubMenu.Controls.Add(this.textBox2);
            this.pnlSortSubMenu.Controls.Add(this.SortLion);
            this.pnlSortSubMenu.Controls.Add(this.SortTiger);
            this.pnlSortSubMenu.Controls.Add(this.SortCow);
            this.pnlSortSubMenu.Controls.Add(this.btnBackToMenu);
            this.pnlSortSubMenu.Controls.Add(this.SortSheep);
            this.pnlSortSubMenu.Controls.Add(this.SortHorse);
            this.pnlSortSubMenu.Controls.Add(this.SortAll);
            this.pnlSortSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSortSubMenu.Name = "pnlSortSubMenu";
            this.pnlSortSubMenu.Size = new System.Drawing.Size(190, 450);
            this.pnlSortSubMenu.TabIndex = 9;
            this.pnlSortSubMenu.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 400);
            this.panel2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox2.Location = new System.Drawing.Point(56, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 31);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Sort ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SortLion
            // 
            this.SortLion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortLion.FlatAppearance.BorderSize = 0;
            this.SortLion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortLion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SortLion.Location = new System.Drawing.Point(40, 50);
            this.SortLion.Name = "SortLion";
            this.SortLion.Size = new System.Drawing.Size(150, 50);
            this.SortLion.TabIndex = 11;
            this.SortLion.Text = "Lion";
            this.SortLion.UseVisualStyleBackColor = false;
            this.SortLion.Click += new System.EventHandler(this.lionToolStripMenuItem_Click);
            this.SortLion.MouseLeave += new System.EventHandler(this.SortLion_MouseLeave);
            this.SortLion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SortLion_MouseMove);
            // 
            // SortTiger
            // 
            this.SortTiger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortTiger.FlatAppearance.BorderSize = 0;
            this.SortTiger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortTiger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SortTiger.Location = new System.Drawing.Point(40, 100);
            this.SortTiger.Name = "SortTiger";
            this.SortTiger.Size = new System.Drawing.Size(150, 50);
            this.SortTiger.TabIndex = 10;
            this.SortTiger.Text = "Tiger";
            this.SortTiger.UseVisualStyleBackColor = false;
            this.SortTiger.Click += new System.EventHandler(this.tigerToolStripMenuItem_Click);
            this.SortTiger.MouseLeave += new System.EventHandler(this.SortTiger_MouseLeave);
            this.SortTiger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SortTiger_MouseMove);
            // 
            // SortCow
            // 
            this.SortCow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortCow.FlatAppearance.BorderSize = 0;
            this.SortCow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortCow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SortCow.Location = new System.Drawing.Point(40, 150);
            this.SortCow.Name = "SortCow";
            this.SortCow.Size = new System.Drawing.Size(150, 50);
            this.SortCow.TabIndex = 9;
            this.SortCow.Text = "Cow";
            this.SortCow.UseVisualStyleBackColor = false;
            this.SortCow.Click += new System.EventHandler(this.cowToolStripMenuItem_Click);
            this.SortCow.MouseLeave += new System.EventHandler(this.SortCow_MouseLeave);
            this.SortCow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SortCow_MouseMove);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Silver;
            this.btnBackToMenu.FlatAppearance.BorderSize = 0;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(50, 50);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "<";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // SortSheep
            // 
            this.SortSheep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortSheep.FlatAppearance.BorderSize = 0;
            this.SortSheep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortSheep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SortSheep.Location = new System.Drawing.Point(40, 200);
            this.SortSheep.Name = "SortSheep";
            this.SortSheep.Size = new System.Drawing.Size(150, 50);
            this.SortSheep.TabIndex = 7;
            this.SortSheep.Text = "Sheep";
            this.SortSheep.UseVisualStyleBackColor = false;
            this.SortSheep.Click += new System.EventHandler(this.sheepToolStripMenuItem_Click);
            this.SortSheep.MouseLeave += new System.EventHandler(this.SortSheep_MouseLeave);
            this.SortSheep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SortSheep_MouseMove);
            // 
            // SortHorse
            // 
            this.SortHorse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortHorse.FlatAppearance.BorderSize = 0;
            this.SortHorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SortHorse.Location = new System.Drawing.Point(40, 250);
            this.SortHorse.Name = "SortHorse";
            this.SortHorse.Size = new System.Drawing.Size(150, 50);
            this.SortHorse.TabIndex = 6;
            this.SortHorse.Text = "Horse";
            this.SortHorse.UseVisualStyleBackColor = false;
            this.SortHorse.Click += new System.EventHandler(this.horseToolStripMenuItem_Click);
            this.SortHorse.MouseLeave += new System.EventHandler(this.SortHorse_MouseLeave);
            this.SortHorse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SortHorse_MouseMove);
            // 
            // SortAll
            // 
            this.SortAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortAll.FlatAppearance.BorderSize = 0;
            this.SortAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SortAll.Location = new System.Drawing.Point(40, 300);
            this.SortAll.Name = "SortAll";
            this.SortAll.Size = new System.Drawing.Size(150, 50);
            this.SortAll.TabIndex = 5;
            this.SortAll.Text = " All Animals";
            this.SortAll.UseVisualStyleBackColor = false;
            this.SortAll.Click += new System.EventHandler(this.allAnimalsToolStripMenuItem_Click);
            this.SortAll.MouseLeave += new System.EventHandler(this.SortAll_MouseLeave);
            this.SortAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SortAll_MouseMove);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.Location = new System.Drawing.Point(822, 599);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.returnToFarmerSelectionToolStripMenuItem_Click);
            // 
            // pnlSettingsSubMenu
            // 
            this.pnlSettingsSubMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSettingsSubMenu.Controls.Add(this.panel4);
            this.pnlSettingsSubMenu.Controls.Add(this.textBox3);
            this.pnlSettingsSubMenu.Controls.Add(this.button8);
            this.pnlSettingsSubMenu.Controls.Add(this.button9);
            this.pnlSettingsSubMenu.Controls.Add(this.button10);
            this.pnlSettingsSubMenu.Controls.Add(this.button11);
            this.pnlSettingsSubMenu.Controls.Add(this.button12);
            this.pnlSettingsSubMenu.Controls.Add(this.button13);
            this.pnlSettingsSubMenu.Controls.Add(this.button14);
            this.pnlSettingsSubMenu.Location = new System.Drawing.Point(1353, 27);
            this.pnlSettingsSubMenu.Name = "pnlSettingsSubMenu";
            this.pnlSettingsSubMenu.Size = new System.Drawing.Size(190, 450);
            this.pnlSettingsSubMenu.TabIndex = 12;
            this.pnlSettingsSubMenu.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 400);
            this.panel4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox3.Location = new System.Drawing.Point(56, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 31);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Settings ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button8.Location = new System.Drawing.Point(40, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 50);
            this.button8.TabIndex = 11;
            this.button8.Text = "Lion";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button9.Location = new System.Drawing.Point(40, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 50);
            this.button9.TabIndex = 10;
            this.button9.Text = "Tiger";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button10.Location = new System.Drawing.Point(40, 150);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 50);
            this.button10.TabIndex = 9;
            this.button10.Text = "Cow";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 8;
            this.button11.Text = "<";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button12.Location = new System.Drawing.Point(40, 200);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 50);
            this.button12.TabIndex = 7;
            this.button12.Text = "Sheep";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button13.Location = new System.Drawing.Point(40, 250);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(150, 50);
            this.button13.TabIndex = 6;
            this.button13.Text = "Horse";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button14.Location = new System.Drawing.Point(40, 300);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 50);
            this.button14.TabIndex = 5;
            this.button14.Text = " All Animals";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // pblSortLists
            // 
            this.pblSortLists.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pblSortLists.Controls.Add(this.txtAnimals);
            this.pblSortLists.Controls.Add(this.lstAnimals);
            this.pblSortLists.Location = new System.Drawing.Point(190, 0);
            this.pblSortLists.Name = "pblSortLists";
            this.pblSortLists.Size = new System.Drawing.Size(280, 500);
            this.pblSortLists.TabIndex = 13;
            this.pblSortLists.Visible = false;
            // 
            // txtAnimals
            // 
            this.txtAnimals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtAnimals.Location = new System.Drawing.Point(0, 58);
            this.txtAnimals.Name = "txtAnimals";
            this.txtAnimals.Size = new System.Drawing.Size(131, 31);
            this.txtAnimals.TabIndex = 11;
            this.txtAnimals.Text = " Animals ";
            // 
            // pnlCagesSort
            // 
            this.pnlCagesSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCagesSort.Controls.Add(this.panel5);
            this.pnlCagesSort.Controls.Add(this.lstLocations);
            this.pnlCagesSort.Controls.Add(this.txtCages);
            this.pnlCagesSort.Controls.Add(this.button4);
            this.pnlCagesSort.Location = new System.Drawing.Point(533, 50);
            this.pnlCagesSort.Name = "pnlCagesSort";
            this.pnlCagesSort.Size = new System.Drawing.Size(190, 450);
            this.pnlCagesSort.TabIndex = 12;
            this.pnlCagesSort.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 400);
            this.panel5.TabIndex = 11;
            // 
            // txtCages
            // 
            this.txtCages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCages.Location = new System.Drawing.Point(56, 8);
            this.txtCages.Name = "txtCages";
            this.txtCages.Size = new System.Drawing.Size(131, 31);
            this.txtCages.TabIndex = 10;
            this.txtCages.Text = "Cages ";
            this.txtCages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtFarmName
            // 
            this.txtFarmName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFarmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFarmName.Enabled = false;
            this.txtFarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtFarmName.Location = new System.Drawing.Point(694, 12);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.Size = new System.Drawing.Size(268, 38);
            this.txtFarmName.TabIndex = 15;
            this.txtFarmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmManagement.Properties.Resources.BgFarm1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Farm_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.txtFarmName);
            this.Controls.Add(this.pnlCagesSort);
            this.Controls.Add(this.pnlSettingsSubMenu);
            this.Controls.Add(this.pnlSortSubMenu);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnOpenMenu);
            this.Controls.Add(this.pblSortLists);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Farm_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farm_View";
            this.Load += new System.EventHandler(this.Farm_View_Load);
            this.Click += new System.EventHandler(this.Farm_View_Click);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSortSubMenu.ResumeLayout(false);
            this.pnlSortSubMenu.PerformLayout();
            this.pnlSettingsSubMenu.ResumeLayout(false);
            this.pnlSettingsSubMenu.PerformLayout();
            this.pblSortLists.ResumeLayout(false);
            this.pblSortLists.PerformLayout();
            this.pnlCagesSort.ResumeLayout(false);
            this.pnlCagesSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCloseMenu;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.Panel pnlSortSubMenu;
        private System.Windows.Forms.Button SortLion;
        private System.Windows.Forms.Button SortTiger;
        private System.Windows.Forms.Button SortCow;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button SortSheep;
        private System.Windows.Forms.Button SortHorse;
        private System.Windows.Forms.Button SortAll;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSettingsSubMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel pblSortLists;
        private System.Windows.Forms.Button btnCages;
        private System.Windows.Forms.Panel pnlCagesSort;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCages;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAnimals;
        private System.Windows.Forms.TextBox txtFarmName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
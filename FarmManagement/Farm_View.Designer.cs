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
            this.lstFarm = new System.Windows.Forms.ListBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToFarmerSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortBySpeciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFarm
            // 
            this.lstFarm.FormattingEnabled = true;
            this.lstFarm.Location = new System.Drawing.Point(159, 119);
            this.lstFarm.Name = "lstFarm";
            this.lstFarm.Size = new System.Drawing.Size(120, 95);
            this.lstFarm.TabIndex = 0;
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(316, 119);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(120, 95);
            this.lstLocations.TabIndex = 1;
            // 
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.Location = new System.Drawing.Point(472, 119);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(292, 95);
            this.lstAnimals.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToFarmerSelectionToolStripMenuItem,
            this.sortBySpeciesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToFarmerSelectionToolStripMenuItem
            // 
            this.returnToFarmerSelectionToolStripMenuItem.Name = "returnToFarmerSelectionToolStripMenuItem";
            this.returnToFarmerSelectionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.returnToFarmerSelectionToolStripMenuItem.Text = "Return To Farmer Selection";
            this.returnToFarmerSelectionToolStripMenuItem.Click += new System.EventHandler(this.returnToFarmerSelectionToolStripMenuItem_Click);
            // 
            // sortBySpeciesToolStripMenuItem
            // 
            this.sortBySpeciesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lionToolStripMenuItem,
            this.tigerToolStripMenuItem,
            this.cowToolStripMenuItem,
            this.sheepToolStripMenuItem,
            this.horseToolStripMenuItem,
            this.allAnimalsToolStripMenuItem});
            this.sortBySpeciesToolStripMenuItem.Name = "sortBySpeciesToolStripMenuItem";
            this.sortBySpeciesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sortBySpeciesToolStripMenuItem.Text = "Sort By Species";
            // 
            // lionToolStripMenuItem
            // 
            this.lionToolStripMenuItem.Name = "lionToolStripMenuItem";
            this.lionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lionToolStripMenuItem.Text = "Lion";
            this.lionToolStripMenuItem.Click += new System.EventHandler(this.lionToolStripMenuItem_Click);
            // 
            // tigerToolStripMenuItem
            // 
            this.tigerToolStripMenuItem.Name = "tigerToolStripMenuItem";
            this.tigerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tigerToolStripMenuItem.Text = "Tiger";
            this.tigerToolStripMenuItem.Click += new System.EventHandler(this.tigerToolStripMenuItem_Click);
            // 
            // cowToolStripMenuItem
            // 
            this.cowToolStripMenuItem.Name = "cowToolStripMenuItem";
            this.cowToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cowToolStripMenuItem.Text = "Cow";
            this.cowToolStripMenuItem.Click += new System.EventHandler(this.cowToolStripMenuItem_Click);
            // 
            // sheepToolStripMenuItem
            // 
            this.sheepToolStripMenuItem.Name = "sheepToolStripMenuItem";
            this.sheepToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sheepToolStripMenuItem.Text = "Sheep";
            this.sheepToolStripMenuItem.Click += new System.EventHandler(this.sheepToolStripMenuItem_Click);
            // 
            // horseToolStripMenuItem
            // 
            this.horseToolStripMenuItem.Name = "horseToolStripMenuItem";
            this.horseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.horseToolStripMenuItem.Text = "Horse";
            this.horseToolStripMenuItem.Click += new System.EventHandler(this.horseToolStripMenuItem_Click);
            // 
            // allAnimalsToolStripMenuItem
            // 
            this.allAnimalsToolStripMenuItem.Name = "allAnimalsToolStripMenuItem";
            this.allAnimalsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.allAnimalsToolStripMenuItem.Text = "All Animals";
            this.allAnimalsToolStripMenuItem.Click += new System.EventHandler(this.allAnimalsToolStripMenuItem_Click);
            // 
            // Farm_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 627);
            this.Controls.Add(this.lstAnimals);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.lstFarm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Farm_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farm_View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Farm_View_FormClosing);
            this.Load += new System.EventHandler(this.Farm_View_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFarm;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToFarmerSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortBySpeciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAnimalsToolStripMenuItem;
    }
}
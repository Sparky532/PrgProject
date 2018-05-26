namespace FarmManagement
{
    partial class Farm_Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farm_Creation));
            this.btnCreateFarm = new System.Windows.Forms.Button();
            this.pbxSmall = new System.Windows.Forms.PictureBox();
            this.pbxLarge = new System.Windows.Forms.PictureBox();
            this.pbxMedium = new System.Windows.Forms.PictureBox();
            this.txtFarmName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateFarm
            // 
            this.btnCreateFarm.Location = new System.Drawing.Point(285, 236);
            this.btnCreateFarm.Name = "btnCreateFarm";
            this.btnCreateFarm.Size = new System.Drawing.Size(132, 60);
            this.btnCreateFarm.TabIndex = 0;
            this.btnCreateFarm.Text = "Create";
            this.btnCreateFarm.UseVisualStyleBackColor = true;
            this.btnCreateFarm.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxSmall
            // 
            this.pbxSmall.Image = global::FarmManagement.Properties.Resources.AnimalCreationBG;
            this.pbxSmall.Location = new System.Drawing.Point(12, 64);
            this.pbxSmall.Name = "pbxSmall";
            this.pbxSmall.Size = new System.Drawing.Size(177, 117);
            this.pbxSmall.TabIndex = 1;
            this.pbxSmall.TabStop = false;
            this.pbxSmall.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxLarge
            // 
            this.pbxLarge.Location = new System.Drawing.Point(528, 64);
            this.pbxLarge.Name = "pbxLarge";
            this.pbxLarge.Size = new System.Drawing.Size(177, 117);
            this.pbxLarge.TabIndex = 1;
            this.pbxLarge.TabStop = false;
            this.pbxLarge.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbxMedium
            // 
            this.pbxMedium.Location = new System.Drawing.Point(267, 64);
            this.pbxMedium.Name = "pbxMedium";
            this.pbxMedium.Size = new System.Drawing.Size(177, 117);
            this.pbxMedium.TabIndex = 1;
            this.pbxMedium.TabStop = false;
            this.pbxMedium.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtFarmName
            // 
            this.txtFarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarmName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFarmName.Location = new System.Drawing.Point(13, 13);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.Size = new System.Drawing.Size(690, 38);
            this.txtFarmName.TabIndex = 2;
            this.txtFarmName.Tag = "Farm Name";
            this.txtFarmName.Text = "Farm Name";
            this.txtFarmName.Click += new System.EventHandler(this.txtFarmName_Click);
            this.txtFarmName.TextChanged += new System.EventHandler(this.txtFarmName_TextChanged);
            // 
            // Farm_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 342);
            this.Controls.Add(this.txtFarmName);
            this.Controls.Add(this.pbxMedium);
            this.Controls.Add(this.pbxLarge);
            this.Controls.Add(this.pbxSmall);
            this.Controls.Add(this.btnCreateFarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Farm_Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farm_Creation";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedium)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFarm;
        private System.Windows.Forms.PictureBox pbxSmall;
        private System.Windows.Forms.PictureBox pbxLarge;
        private System.Windows.Forms.PictureBox pbxMedium;
        private System.Windows.Forms.TextBox txtFarmName;
    }
}
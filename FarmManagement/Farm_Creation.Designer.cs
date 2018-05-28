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
            this.txtFarmName = new System.Windows.Forms.TextBox();
            this.pbxLargeSize = new System.Windows.Forms.PictureBox();
            this.pbxMediumSize = new System.Windows.Forms.PictureBox();
            this.pbxSmallSize = new System.Windows.Forms.PictureBox();
            this.pbxCreate = new System.Windows.Forms.PictureBox();
            this.pbxSmallClicked = new System.Windows.Forms.PictureBox();
            this.pbxLargeClicked = new System.Windows.Forms.PictureBox();
            this.pbxMediumClicked = new System.Windows.Forms.PictureBox();
            this.pbxLarge = new System.Windows.Forms.PictureBox();
            this.pbxMedium = new System.Windows.Forms.PictureBox();
            this.pbxSmall = new System.Windows.Forms.PictureBox();
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            this.lblSmall = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLargeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMediumSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmallSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmallClicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLargeClicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMediumClicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
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
            // txtFarmName
            // 
            this.txtFarmName.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarmName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFarmName.Location = new System.Drawing.Point(13, 13);
            this.txtFarmName.Name = "txtFarmName";
            this.txtFarmName.Size = new System.Drawing.Size(690, 38);
            this.txtFarmName.TabIndex = 2;
            this.txtFarmName.Tag = "Farm Name";
            this.txtFarmName.Text = "Farm Name";
            this.txtFarmName.Click += new System.EventHandler(this.txtFarmName_Click);       
            this.txtFarmName.Leave += new System.EventHandler(this.txtFarmName_Leave);
            // 
            // pbxLargeSize
            // 
            this.pbxLargeSize.BackColor = System.Drawing.Color.Transparent;
            this.pbxLargeSize.Image = global::FarmManagement.Properties.Resources.LargeFarmSize;
            this.pbxLargeSize.Location = new System.Drawing.Point(531, 235);
            this.pbxLargeSize.Name = "pbxLargeSize";
            this.pbxLargeSize.Size = new System.Drawing.Size(123, 47);
            this.pbxLargeSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLargeSize.TabIndex = 11;
            this.pbxLargeSize.TabStop = false;
            // 
            // pbxMediumSize
            // 
            this.pbxMediumSize.BackColor = System.Drawing.Color.Transparent;
            this.pbxMediumSize.Image = global::FarmManagement.Properties.Resources.MediumFarmSize;
            this.pbxMediumSize.Location = new System.Drawing.Point(293, 235);
            this.pbxMediumSize.Name = "pbxMediumSize";
            this.pbxMediumSize.Size = new System.Drawing.Size(123, 47);
            this.pbxMediumSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMediumSize.TabIndex = 11;
            this.pbxMediumSize.TabStop = false;
            // 
            // pbxSmallSize
            // 
            this.pbxSmallSize.BackColor = System.Drawing.Color.Transparent;
            this.pbxSmallSize.Image = global::FarmManagement.Properties.Resources.SmallFarmSize;
            this.pbxSmallSize.Location = new System.Drawing.Point(42, 234);
            this.pbxSmallSize.Name = "pbxSmallSize";
            this.pbxSmallSize.Size = new System.Drawing.Size(123, 47);
            this.pbxSmallSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSmallSize.TabIndex = 11;
            this.pbxSmallSize.TabStop = false;
            // 
            // pbxCreate
            // 
            this.pbxCreate.BackColor = System.Drawing.Color.Transparent;
            this.pbxCreate.Image = global::FarmManagement.Properties.Resources.CreateButton;
            this.pbxCreate.Location = new System.Drawing.Point(261, 282);
            this.pbxCreate.Name = "pbxCreate";
            this.pbxCreate.Size = new System.Drawing.Size(189, 76);
            this.pbxCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCreate.TabIndex = 9;
            this.pbxCreate.TabStop = false;
            this.pbxCreate.Click += new System.EventHandler(this.pbxCreate_Click);
            // 
            // pbxSmallClicked
            // 
            this.pbxSmallClicked.BackColor = System.Drawing.Color.Transparent;
            this.pbxSmallClicked.Image = global::FarmManagement.Properties.Resources.SmallFarmChoiceClicked1;
            this.pbxSmallClicked.Location = new System.Drawing.Point(13, 98);
            this.pbxSmallClicked.Name = "pbxSmallClicked";
            this.pbxSmallClicked.Size = new System.Drawing.Size(210, 146);
            this.pbxSmallClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSmallClicked.TabIndex = 8;
            this.pbxSmallClicked.TabStop = false;
            this.pbxSmallClicked.Click += new System.EventHandler(this.pbxSmallClicked_Click_1);
            this.pbxSmallClicked.MouseLeave += new System.EventHandler(this.pbxSmallClicked_MouseLeave);
            this.pbxSmallClicked.MouseHover += new System.EventHandler(this.pbxSmallClicked_MouseHover);
            // 
            // pbxLargeClicked
            // 
            this.pbxLargeClicked.BackColor = System.Drawing.Color.Transparent;
            this.pbxLargeClicked.Image = global::FarmManagement.Properties.Resources.LargeFarmChoiceClicked;
            this.pbxLargeClicked.Location = new System.Drawing.Point(482, 98);
            this.pbxLargeClicked.Name = "pbxLargeClicked";
            this.pbxLargeClicked.Size = new System.Drawing.Size(210, 146);
            this.pbxLargeClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLargeClicked.TabIndex = 7;
            this.pbxLargeClicked.TabStop = false;
            this.pbxLargeClicked.Click += new System.EventHandler(this.pbxLargeClicked_Click);
            this.pbxLargeClicked.MouseLeave += new System.EventHandler(this.pbxLargeClicked_MouseLeave);
            this.pbxLargeClicked.MouseHover += new System.EventHandler(this.pbxLargeClicked_MouseHover);
            // 
            // pbxMediumClicked
            // 
            this.pbxMediumClicked.BackColor = System.Drawing.Color.Transparent;
            this.pbxMediumClicked.Image = global::FarmManagement.Properties.Resources.MediumFarmChoiceClicked;
            this.pbxMediumClicked.Location = new System.Drawing.Point(247, 98);
            this.pbxMediumClicked.Name = "pbxMediumClicked";
            this.pbxMediumClicked.Size = new System.Drawing.Size(210, 146);
            this.pbxMediumClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMediumClicked.TabIndex = 6;
            this.pbxMediumClicked.TabStop = false;
            this.pbxMediumClicked.Click += new System.EventHandler(this.pbxMediumClicked_Click);
            this.pbxMediumClicked.MouseLeave += new System.EventHandler(this.pbxMediumClicked_MouseLeave);
            this.pbxMediumClicked.MouseHover += new System.EventHandler(this.pbxMediumClicked_MouseHover);
            // 
            // pbxLarge
            // 
            this.pbxLarge.BackColor = System.Drawing.Color.Transparent;
            this.pbxLarge.Image = global::FarmManagement.Properties.Resources.LargeFarmChoice;
            this.pbxLarge.Location = new System.Drawing.Point(482, 98);
            this.pbxLarge.Name = "pbxLarge";
            this.pbxLarge.Size = new System.Drawing.Size(210, 146);
            this.pbxLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLarge.TabIndex = 4;
            this.pbxLarge.TabStop = false;
            this.pbxLarge.Click += new System.EventHandler(this.pbxLarge_Click);
            this.pbxLarge.MouseLeave += new System.EventHandler(this.pbxLarge_MouseLeave);
            this.pbxLarge.MouseHover += new System.EventHandler(this.pbxLarge_MouseHover);
            // 
            // pbxMedium
            // 
            this.pbxMedium.BackColor = System.Drawing.Color.Transparent;
            this.pbxMedium.Image = global::FarmManagement.Properties.Resources.MediumFarmChoice;
            this.pbxMedium.Location = new System.Drawing.Point(247, 98);
            this.pbxMedium.Name = "pbxMedium";
            this.pbxMedium.Size = new System.Drawing.Size(210, 146);
            this.pbxMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMedium.TabIndex = 3;
            this.pbxMedium.TabStop = false;
            this.pbxMedium.Click += new System.EventHandler(this.pbxMedium_Click);
            this.pbxMedium.MouseLeave += new System.EventHandler(this.pbxMedium_MouseLeave);
            this.pbxMedium.MouseHover += new System.EventHandler(this.pbxMedium_MouseHover);
            // 
            // pbxSmall
            // 
            this.pbxSmall.BackColor = System.Drawing.Color.Transparent;
            this.pbxSmall.Image = global::FarmManagement.Properties.Resources.SmallFarmChoice1;
            this.pbxSmall.Location = new System.Drawing.Point(12, 98);
            this.pbxSmall.Name = "pbxSmall";
            this.pbxSmall.Size = new System.Drawing.Size(210, 146);
            this.pbxSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSmall.TabIndex = 1;
            this.pbxSmall.TabStop = false;
            this.pbxSmall.Click += new System.EventHandler(this.pbxSmall_Click);
            this.pbxSmall.MouseLeave += new System.EventHandler(this.pbxSmall_MouseLeave);
            this.pbxSmall.MouseHover += new System.EventHandler(this.pbxSmall_MouseHover);
            // 
            // pbxBackground
            // 
            this.pbxBackground.Image = global::FarmManagement.Properties.Resources.FarmBackground;
            this.pbxBackground.Location = new System.Drawing.Point(-3, -3);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(776, 373);
            this.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBackground.TabIndex = 10;
            this.pbxBackground.TabStop = false;
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.BackColor = System.Drawing.Color.Transparent;
            this.lblSmall.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmall.Location = new System.Drawing.Point(70, 58);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(95, 37);
            this.lblSmall.TabIndex = 12;
            this.lblSmall.Text = "Small";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.BackColor = System.Drawing.Color.Transparent;
            this.lblMedium.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(278, 58);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(126, 37);
            this.lblMedium.TabIndex = 12;
            this.lblMedium.Text = "Medium";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.BackColor = System.Drawing.Color.Transparent;
            this.lblLarge.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(544, 58);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(95, 37);
            this.lblLarge.TabIndex = 12;
            this.lblLarge.Text = "Large";
            // 
            // Farm_Creation
            // 
            this.AcceptButton = this.btnCreateFarm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 364);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblSmall);
            this.Controls.Add(this.pbxLargeSize);
            this.Controls.Add(this.pbxMediumSize);
            this.Controls.Add(this.pbxSmallSize);
            this.Controls.Add(this.pbxCreate);
            this.Controls.Add(this.pbxSmallClicked);
            this.Controls.Add(this.pbxLargeClicked);
            this.Controls.Add(this.pbxMediumClicked);
            this.Controls.Add(this.pbxLarge);
            this.Controls.Add(this.pbxMedium);
            this.Controls.Add(this.txtFarmName);
            this.Controls.Add(this.pbxSmall);
            this.Controls.Add(this.pbxBackground);
            this.Controls.Add(this.btnCreateFarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Farm_Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farm_Creation";
            this.Load += new System.EventHandler(this.Farm_Creation_Load);
            this.Click += new System.EventHandler(this.Farm_Creation_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLargeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMediumSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmallSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmallClicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLargeClicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMediumClicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFarm;
        private System.Windows.Forms.PictureBox pbxSmall;
        private System.Windows.Forms.TextBox txtFarmName;
        private System.Windows.Forms.PictureBox pbxMedium;
        private System.Windows.Forms.PictureBox pbxLarge;
        private System.Windows.Forms.PictureBox pbxMediumClicked;
        private System.Windows.Forms.PictureBox pbxLargeClicked;
        private System.Windows.Forms.PictureBox pbxSmallClicked;
        private System.Windows.Forms.PictureBox pbxCreate;
        private System.Windows.Forms.PictureBox pbxBackground;
        private System.Windows.Forms.PictureBox pbxSmallSize;
        private System.Windows.Forms.PictureBox pbxMediumSize;
        private System.Windows.Forms.PictureBox pbxLargeSize;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLarge;
    }
}
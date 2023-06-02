namespace StarWarsAPI
{
    partial class PlanetForm
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
            this.planetInstrLbl = new System.Windows.Forms.Label();
            this.planetIdBox = new System.Windows.Forms.TextBox();
            this.planetSearchBtn = new System.Windows.Forms.Button();
            this.titlePlanetNameLbl = new System.Windows.Forms.Label();
            this.titleRotationPdLbl = new System.Windows.Forms.Label();
            this.titleOrbitalPdLbl = new System.Windows.Forms.Label();
            this.titleSurfaceH20Lbl = new System.Windows.Forms.Label();
            this.titleTerrainLbl = new System.Windows.Forms.Label();
            this.titleDiameterLbl = new System.Windows.Forms.Label();
            this.titleGravityLbl = new System.Windows.Forms.Label();
            this.titleClimateLbl = new System.Windows.Forms.Label();
            this.titlePopulationLbl = new System.Windows.Forms.Label();
            this.planetNameLbl = new System.Windows.Forms.Label();
            this.planetRotationPdLbl = new System.Windows.Forms.Label();
            this.planetOrbitalPdLbl = new System.Windows.Forms.Label();
            this.planetDiameterLbl = new System.Windows.Forms.Label();
            this.planetClimateLbl = new System.Windows.Forms.Label();
            this.planetGravityLbl = new System.Windows.Forms.Label();
            this.planetTerrainLbl = new System.Windows.Forms.Label();
            this.planetSurfaceH20Lbl = new System.Windows.Forms.Label();
            this.planetPopulationLbl = new System.Windows.Forms.Label();
            this.planetHomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetInstrLbl
            // 
            this.planetInstrLbl.AutoSize = true;
            this.planetInstrLbl.Location = new System.Drawing.Point(213, 36);
            this.planetInstrLbl.Name = "planetInstrLbl";
            this.planetInstrLbl.Size = new System.Drawing.Size(165, 20);
            this.planetInstrLbl.TabIndex = 0;
            this.planetInstrLbl.Text = "Type a planet id below";
            // 
            // planetIdBox
            // 
            this.planetIdBox.Location = new System.Drawing.Point(261, 80);
            this.planetIdBox.Name = "planetIdBox";
            this.planetIdBox.Size = new System.Drawing.Size(100, 26);
            this.planetIdBox.TabIndex = 1;
            // 
            // planetSearchBtn
            // 
            this.planetSearchBtn.Location = new System.Drawing.Point(261, 133);
            this.planetSearchBtn.Name = "planetSearchBtn";
            this.planetSearchBtn.Size = new System.Drawing.Size(100, 39);
            this.planetSearchBtn.TabIndex = 2;
            this.planetSearchBtn.Text = "Search";
            this.planetSearchBtn.UseVisualStyleBackColor = true;
            this.planetSearchBtn.Click += new System.EventHandler(this.planetSearchBtn_Click);
            // 
            // titlePlanetNameLbl
            // 
            this.titlePlanetNameLbl.AutoSize = true;
            this.titlePlanetNameLbl.Location = new System.Drawing.Point(257, 202);
            this.titlePlanetNameLbl.Name = "titlePlanetNameLbl";
            this.titlePlanetNameLbl.Size = new System.Drawing.Size(100, 20);
            this.titlePlanetNameLbl.TabIndex = 3;
            this.titlePlanetNameLbl.Text = "Planet Name";
            // 
            // titleRotationPdLbl
            // 
            this.titleRotationPdLbl.AutoSize = true;
            this.titleRotationPdLbl.Location = new System.Drawing.Point(257, 246);
            this.titleRotationPdLbl.Name = "titleRotationPdLbl";
            this.titleRotationPdLbl.Size = new System.Drawing.Size(118, 20);
            this.titleRotationPdLbl.TabIndex = 4;
            this.titleRotationPdLbl.Text = "Rotation period";
            // 
            // titleOrbitalPdLbl
            // 
            this.titleOrbitalPdLbl.AutoSize = true;
            this.titleOrbitalPdLbl.Location = new System.Drawing.Point(257, 293);
            this.titleOrbitalPdLbl.Name = "titleOrbitalPdLbl";
            this.titleOrbitalPdLbl.Size = new System.Drawing.Size(103, 20);
            this.titleOrbitalPdLbl.TabIndex = 5;
            this.titleOrbitalPdLbl.Text = "Orbital period";
            // 
            // titleSurfaceH20Lbl
            // 
            this.titleSurfaceH20Lbl.AutoSize = true;
            this.titleSurfaceH20Lbl.Location = new System.Drawing.Point(257, 516);
            this.titleSurfaceH20Lbl.Name = "titleSurfaceH20Lbl";
            this.titleSurfaceH20Lbl.Size = new System.Drawing.Size(112, 20);
            this.titleSurfaceH20Lbl.TabIndex = 6;
            this.titleSurfaceH20Lbl.Text = "Surface Water";
            // 
            // titleTerrainLbl
            // 
            this.titleTerrainLbl.AutoSize = true;
            this.titleTerrainLbl.Location = new System.Drawing.Point(257, 468);
            this.titleTerrainLbl.Name = "titleTerrainLbl";
            this.titleTerrainLbl.Size = new System.Drawing.Size(58, 20);
            this.titleTerrainLbl.TabIndex = 7;
            this.titleTerrainLbl.Text = "Terrain";
            // 
            // titleDiameterLbl
            // 
            this.titleDiameterLbl.AutoSize = true;
            this.titleDiameterLbl.Location = new System.Drawing.Point(257, 336);
            this.titleDiameterLbl.Name = "titleDiameterLbl";
            this.titleDiameterLbl.Size = new System.Drawing.Size(74, 20);
            this.titleDiameterLbl.TabIndex = 8;
            this.titleDiameterLbl.Text = "Diameter";
            // 
            // titleGravityLbl
            // 
            this.titleGravityLbl.AutoSize = true;
            this.titleGravityLbl.Location = new System.Drawing.Point(257, 422);
            this.titleGravityLbl.Name = "titleGravityLbl";
            this.titleGravityLbl.Size = new System.Drawing.Size(58, 20);
            this.titleGravityLbl.TabIndex = 10;
            this.titleGravityLbl.Text = "Gravity";
            // 
            // titleClimateLbl
            // 
            this.titleClimateLbl.AutoSize = true;
            this.titleClimateLbl.Location = new System.Drawing.Point(257, 381);
            this.titleClimateLbl.Name = "titleClimateLbl";
            this.titleClimateLbl.Size = new System.Drawing.Size(62, 20);
            this.titleClimateLbl.TabIndex = 11;
            this.titleClimateLbl.Text = "Climate";
            // 
            // titlePopulationLbl
            // 
            this.titlePopulationLbl.AutoSize = true;
            this.titlePopulationLbl.Location = new System.Drawing.Point(257, 563);
            this.titlePopulationLbl.Name = "titlePopulationLbl";
            this.titlePopulationLbl.Size = new System.Drawing.Size(84, 20);
            this.titlePopulationLbl.TabIndex = 12;
            this.titlePopulationLbl.Text = "Population";
            // 
            // planetNameLbl
            // 
            this.planetNameLbl.AutoSize = true;
            this.planetNameLbl.Location = new System.Drawing.Point(427, 202);
            this.planetNameLbl.Name = "planetNameLbl";
            this.planetNameLbl.Size = new System.Drawing.Size(100, 20);
            this.planetNameLbl.TabIndex = 13;
            this.planetNameLbl.Text = "Planet Name";
            // 
            // planetRotationPdLbl
            // 
            this.planetRotationPdLbl.AutoSize = true;
            this.planetRotationPdLbl.Location = new System.Drawing.Point(427, 246);
            this.planetRotationPdLbl.Name = "planetRotationPdLbl";
            this.planetRotationPdLbl.Size = new System.Drawing.Size(119, 20);
            this.planetRotationPdLbl.TabIndex = 15;
            this.planetRotationPdLbl.Text = "Rotation Period";
            // 
            // planetOrbitalPdLbl
            // 
            this.planetOrbitalPdLbl.AutoSize = true;
            this.planetOrbitalPdLbl.Location = new System.Drawing.Point(427, 293);
            this.planetOrbitalPdLbl.Name = "planetOrbitalPdLbl";
            this.planetOrbitalPdLbl.Size = new System.Drawing.Size(103, 20);
            this.planetOrbitalPdLbl.TabIndex = 16;
            this.planetOrbitalPdLbl.Text = "Orbital period";
            // 
            // planetDiameterLbl
            // 
            this.planetDiameterLbl.AutoSize = true;
            this.planetDiameterLbl.Location = new System.Drawing.Point(427, 336);
            this.planetDiameterLbl.Name = "planetDiameterLbl";
            this.planetDiameterLbl.Size = new System.Drawing.Size(74, 20);
            this.planetDiameterLbl.TabIndex = 17;
            this.planetDiameterLbl.Text = "Diameter";
            // 
            // planetClimateLbl
            // 
            this.planetClimateLbl.AutoSize = true;
            this.planetClimateLbl.Location = new System.Drawing.Point(427, 381);
            this.planetClimateLbl.Name = "planetClimateLbl";
            this.planetClimateLbl.Size = new System.Drawing.Size(62, 20);
            this.planetClimateLbl.TabIndex = 18;
            this.planetClimateLbl.Text = "Climate";
            // 
            // planetGravityLbl
            // 
            this.planetGravityLbl.AutoSize = true;
            this.planetGravityLbl.Location = new System.Drawing.Point(427, 422);
            this.planetGravityLbl.Name = "planetGravityLbl";
            this.planetGravityLbl.Size = new System.Drawing.Size(58, 20);
            this.planetGravityLbl.TabIndex = 19;
            this.planetGravityLbl.Text = "Gravity";
            // 
            // planetTerrainLbl
            // 
            this.planetTerrainLbl.AutoSize = true;
            this.planetTerrainLbl.Location = new System.Drawing.Point(427, 468);
            this.planetTerrainLbl.Name = "planetTerrainLbl";
            this.planetTerrainLbl.Size = new System.Drawing.Size(58, 20);
            this.planetTerrainLbl.TabIndex = 20;
            this.planetTerrainLbl.Text = "Terrain";
            // 
            // planetSurfaceH20Lbl
            // 
            this.planetSurfaceH20Lbl.AutoSize = true;
            this.planetSurfaceH20Lbl.Location = new System.Drawing.Point(415, 516);
            this.planetSurfaceH20Lbl.Name = "planetSurfaceH20Lbl";
            this.planetSurfaceH20Lbl.Size = new System.Drawing.Size(112, 20);
            this.planetSurfaceH20Lbl.TabIndex = 21;
            this.planetSurfaceH20Lbl.Text = "Surface Water";
            // 
            // planetPopulationLbl
            // 
            this.planetPopulationLbl.AutoSize = true;
            this.planetPopulationLbl.Location = new System.Drawing.Point(417, 563);
            this.planetPopulationLbl.Name = "planetPopulationLbl";
            this.planetPopulationLbl.Size = new System.Drawing.Size(84, 20);
            this.planetPopulationLbl.TabIndex = 22;
            this.planetPopulationLbl.Text = "Population";
            // 
            // planetHomeBtn
            // 
            this.planetHomeBtn.Location = new System.Drawing.Point(261, 621);
            this.planetHomeBtn.Name = "planetHomeBtn";
            this.planetHomeBtn.Size = new System.Drawing.Size(112, 46);
            this.planetHomeBtn.TabIndex = 43;
            this.planetHomeBtn.Text = "Home";
            this.planetHomeBtn.UseVisualStyleBackColor = true;
            this.planetHomeBtn.Click += new System.EventHandler(this.planetHomeBtn_Click);
            // 
            // PlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 735);
            this.Controls.Add(this.planetHomeBtn);
            this.Controls.Add(this.planetPopulationLbl);
            this.Controls.Add(this.planetSurfaceH20Lbl);
            this.Controls.Add(this.planetTerrainLbl);
            this.Controls.Add(this.planetGravityLbl);
            this.Controls.Add(this.planetClimateLbl);
            this.Controls.Add(this.planetDiameterLbl);
            this.Controls.Add(this.planetOrbitalPdLbl);
            this.Controls.Add(this.planetRotationPdLbl);
            this.Controls.Add(this.planetNameLbl);
            this.Controls.Add(this.titlePopulationLbl);
            this.Controls.Add(this.titleClimateLbl);
            this.Controls.Add(this.titleGravityLbl);
            this.Controls.Add(this.titleDiameterLbl);
            this.Controls.Add(this.titleTerrainLbl);
            this.Controls.Add(this.titleSurfaceH20Lbl);
            this.Controls.Add(this.titleOrbitalPdLbl);
            this.Controls.Add(this.titleRotationPdLbl);
            this.Controls.Add(this.titlePlanetNameLbl);
            this.Controls.Add(this.planetSearchBtn);
            this.Controls.Add(this.planetIdBox);
            this.Controls.Add(this.planetInstrLbl);
            this.Name = "PlanetForm";
            this.Text = "PlanetForm";
            this.Load += new System.EventHandler(this.PlanetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planetInstrLbl;
        private System.Windows.Forms.TextBox planetIdBox;
        private System.Windows.Forms.Button planetSearchBtn;
        private System.Windows.Forms.Label titlePlanetNameLbl;
        private System.Windows.Forms.Label titleRotationPdLbl;
        private System.Windows.Forms.Label titleOrbitalPdLbl;
        private System.Windows.Forms.Label titleSurfaceH20Lbl;
        private System.Windows.Forms.Label titleTerrainLbl;
        private System.Windows.Forms.Label titleDiameterLbl;
        private System.Windows.Forms.Label titleGravityLbl;
        private System.Windows.Forms.Label titleClimateLbl;
        private System.Windows.Forms.Label titlePopulationLbl;
        private System.Windows.Forms.Label planetNameLbl;
        private System.Windows.Forms.Label planetRotationPdLbl;
        private System.Windows.Forms.Label planetOrbitalPdLbl;
        private System.Windows.Forms.Label planetDiameterLbl;
        private System.Windows.Forms.Label planetClimateLbl;
        private System.Windows.Forms.Label planetGravityLbl;
        private System.Windows.Forms.Label planetTerrainLbl;
        private System.Windows.Forms.Label planetSurfaceH20Lbl;
        private System.Windows.Forms.Label planetPopulationLbl;
        private System.Windows.Forms.Button planetHomeBtn;
    }
}
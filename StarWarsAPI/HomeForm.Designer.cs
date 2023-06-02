namespace StarWarsAPI
{
    partial class HomeForm
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
            this.searchLbl = new System.Windows.Forms.Label();
            this.planetBtn = new System.Windows.Forms.Button();
            this.personBtn = new System.Windows.Forms.Button();
            this.speciesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(271, 43);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(215, 20);
            this.searchLbl.TabIndex = 0;
            this.searchLbl.Text = "What do you want to search?";
            // 
            // planetBtn
            // 
            this.planetBtn.Location = new System.Drawing.Point(57, 106);
            this.planetBtn.Name = "planetBtn";
            this.planetBtn.Size = new System.Drawing.Size(92, 36);
            this.planetBtn.TabIndex = 1;
            this.planetBtn.Text = "Planet";
            this.planetBtn.UseVisualStyleBackColor = true;
            this.planetBtn.Click += new System.EventHandler(this.planetBtn_Click);
            // 
            // personBtn
            // 
            this.personBtn.Location = new System.Drawing.Point(321, 106);
            this.personBtn.Name = "personBtn";
            this.personBtn.Size = new System.Drawing.Size(96, 36);
            this.personBtn.TabIndex = 2;
            this.personBtn.Text = "Person";
            this.personBtn.UseVisualStyleBackColor = true;
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click);
            // 
            // speciesBtn
            // 
            this.speciesBtn.Location = new System.Drawing.Point(576, 106);
            this.speciesBtn.Name = "speciesBtn";
            this.speciesBtn.Size = new System.Drawing.Size(89, 36);
            this.speciesBtn.TabIndex = 3;
            this.speciesBtn.Text = "Species";
            this.speciesBtn.UseVisualStyleBackColor = true;
            this.speciesBtn.Click += new System.EventHandler(this.speciesBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speciesBtn);
            this.Controls.Add(this.personBtn);
            this.Controls.Add(this.planetBtn);
            this.Controls.Add(this.searchLbl);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button planetBtn;
        private System.Windows.Forms.Button personBtn;
        private System.Windows.Forms.Button speciesBtn;
    }
}
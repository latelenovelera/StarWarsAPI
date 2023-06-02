namespace StarWarsAPI
{
    partial class SpeciesForm
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
            this.allSpeciesBox = new System.Windows.Forms.ListBox();
            this.speciesHomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allSpeciesBox
            // 
            this.allSpeciesBox.FormattingEnabled = true;
            this.allSpeciesBox.ItemHeight = 20;
            this.allSpeciesBox.Location = new System.Drawing.Point(12, 30);
            this.allSpeciesBox.Name = "allSpeciesBox";
            this.allSpeciesBox.Size = new System.Drawing.Size(407, 224);
            this.allSpeciesBox.TabIndex = 0;
            this.allSpeciesBox.SelectedIndexChanged += new System.EventHandler(this.allSpeciesBox_SelectedIndexChanged);
            // 
            // speciesHomeBtn
            // 
            this.speciesHomeBtn.Location = new System.Drawing.Point(358, 312);
            this.speciesHomeBtn.Name = "speciesHomeBtn";
            this.speciesHomeBtn.Size = new System.Drawing.Size(112, 46);
            this.speciesHomeBtn.TabIndex = 43;
            this.speciesHomeBtn.Text = "Home";
            this.speciesHomeBtn.UseVisualStyleBackColor = true;
            this.speciesHomeBtn.Click += new System.EventHandler(this.speciesHomeBtn_Click);
            // 
            // SpeciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 442);
            this.Controls.Add(this.speciesHomeBtn);
            this.Controls.Add(this.allSpeciesBox);
            this.Name = "SpeciesForm";
            this.Text = "SpeciesForm";
            this.Load += new System.EventHandler(this.SpeciesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox allSpeciesBox;
        private System.Windows.Forms.Button speciesHomeBtn;
    }
}
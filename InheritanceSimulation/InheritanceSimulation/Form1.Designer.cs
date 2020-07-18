namespace InheritanceSimulation
{
    partial class FormMain
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
            this.StoryBox = new System.Windows.Forms.TextBox();
            this.StoryBoxLabel = new System.Windows.Forms.Label();
            this.SubmitName = new System.Windows.Forms.Button();
            this.SubmitAge = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CharacterOptions = new System.Windows.Forms.ComboBox();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoryBox
            // 
            this.StoryBox.Location = new System.Drawing.Point(468, 236);
            this.StoryBox.Multiline = true;
            this.StoryBox.Name = "StoryBox";
            this.StoryBox.ReadOnly = true;
            this.StoryBox.Size = new System.Drawing.Size(367, 225);
            this.StoryBox.TabIndex = 0;
            // 
            // StoryBoxLabel
            // 
            this.StoryBoxLabel.AutoSize = true;
            this.StoryBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryBoxLabel.Location = new System.Drawing.Point(602, 201);
            this.StoryBoxLabel.Name = "StoryBoxLabel";
            this.StoryBoxLabel.Size = new System.Drawing.Size(77, 20);
            this.StoryBoxLabel.TabIndex = 1;
            this.StoryBoxLabel.Text = "Story Box";
            // 
            // SubmitName
            // 
            this.SubmitName.Location = new System.Drawing.Point(270, 64);
            this.SubmitName.Name = "SubmitName";
            this.SubmitName.Size = new System.Drawing.Size(92, 23);
            this.SubmitName.TabIndex = 2;
            this.SubmitName.Text = "Submit Name";
            this.SubmitName.UseVisualStyleBackColor = true;
            // 
            // SubmitAge
            // 
            this.SubmitAge.Location = new System.Drawing.Point(270, 158);
            this.SubmitAge.Name = "SubmitAge";
            this.SubmitAge.Size = new System.Drawing.Size(92, 23);
            this.SubmitAge.TabIndex = 3;
            this.SubmitAge.Text = "Submit Age";
            this.SubmitAge.UseVisualStyleBackColor = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(73, 66);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(170, 20);
            this.NameBox.TabIndex = 4;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(73, 161);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(170, 20);
            this.AgeBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(70, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(150, 16);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Type name of character";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(70, 133);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(140, 16);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Type age of character";
            // 
            // CharacterOptions
            // 
            this.CharacterOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterOptions.FormattingEnabled = true;
            this.CharacterOptions.Items.AddRange(new object[] {
            "Assassin",
            "Mercenary",
            "Sniper"});
            this.CharacterOptions.Location = new System.Drawing.Point(549, 65);
            this.CharacterOptions.Name = "CharacterOptions";
            this.CharacterOptions.Size = new System.Drawing.Size(121, 24);
            this.CharacterOptions.TabIndex = 8;
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterLabel.Location = new System.Drawing.Point(546, 32);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(118, 16);
            this.CharacterLabel.TabIndex = 9;
            this.CharacterLabel.Text = "Select a Character";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InheritanceSimulation.Properties.Resources.Simulation;
            this.ClientSize = new System.Drawing.Size(860, 483);
            this.Controls.Add(this.CharacterLabel);
            this.Controls.Add(this.CharacterOptions);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SubmitAge);
            this.Controls.Add(this.SubmitName);
            this.Controls.Add(this.StoryBoxLabel);
            this.Controls.Add(this.StoryBox);
            this.Name = "FormMain";
            this.Text = "Character Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StoryBox;
        private System.Windows.Forms.Label StoryBoxLabel;
        private System.Windows.Forms.Button SubmitName;
        private System.Windows.Forms.Button SubmitAge;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox CharacterOptions;
        private System.Windows.Forms.Label CharacterLabel;
    }
}


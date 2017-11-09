namespace Game
{
    partial class Settings
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
            this.label_Music = new System.Windows.Forms.Label();
            this.label_Difficulty = new System.Windows.Forms.Label();
            this.label_Sfx = new System.Windows.Forms.Label();
            this.btn_Music = new System.Windows.Forms.Button();
            this.btn_Sfx = new System.Windows.Forms.Button();
            this.comboBox_Difficulty = new System.Windows.Forms.ComboBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Music
            // 
            this.label_Music.AutoSize = true;
            this.label_Music.Location = new System.Drawing.Point(12, 9);
            this.label_Music.Name = "label_Music";
            this.label_Music.Size = new System.Drawing.Size(35, 13);
            this.label_Music.TabIndex = 0;
            this.label_Music.Text = "Music";
            // 
            // label_Difficulty
            // 
            this.label_Difficulty.AutoSize = true;
            this.label_Difficulty.Location = new System.Drawing.Point(12, 64);
            this.label_Difficulty.Name = "label_Difficulty";
            this.label_Difficulty.Size = new System.Drawing.Size(47, 13);
            this.label_Difficulty.TabIndex = 1;
            this.label_Difficulty.Text = "Difficulty";
            // 
            // label_Sfx
            // 
            this.label_Sfx.AutoSize = true;
            this.label_Sfx.Location = new System.Drawing.Point(12, 35);
            this.label_Sfx.Name = "label_Sfx";
            this.label_Sfx.Size = new System.Drawing.Size(70, 13);
            this.label_Sfx.TabIndex = 2;
            this.label_Sfx.Text = "Soundeffects";
            // 
            // btn_Music
            // 
            this.btn_Music.Location = new System.Drawing.Point(53, 4);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.Size = new System.Drawing.Size(75, 23);
            this.btn_Music.TabIndex = 3;
            this.btn_Music.Text = "On";
            this.btn_Music.UseVisualStyleBackColor = true;
            // 
            // btn_Sfx
            // 
            this.btn_Sfx.Location = new System.Drawing.Point(88, 30);
            this.btn_Sfx.Name = "btn_Sfx";
            this.btn_Sfx.Size = new System.Drawing.Size(75, 23);
            this.btn_Sfx.TabIndex = 4;
            this.btn_Sfx.Text = "On";
            this.btn_Sfx.UseVisualStyleBackColor = true;
            // 
            // comboBox_Difficulty
            // 
            this.comboBox_Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Difficulty.FormattingEnabled = true;
            this.comboBox_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboBox_Difficulty.Location = new System.Drawing.Point(66, 64);
            this.comboBox_Difficulty.Name = "comboBox_Difficulty";
            this.comboBox_Difficulty.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Difficulty.TabIndex = 5;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(199, 108);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(97, 49);
            this.btn_Apply.TabIndex = 6;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(7, 108);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(97, 49);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 171);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.comboBox_Difficulty);
            this.Controls.Add(this.btn_Sfx);
            this.Controls.Add(this.btn_Music);
            this.Controls.Add(this.label_Sfx);
            this.Controls.Add(this.label_Difficulty);
            this.Controls.Add(this.label_Music);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Music;
        private System.Windows.Forms.Label label_Difficulty;
        private System.Windows.Forms.Label label_Sfx;
        private System.Windows.Forms.Button btn_Music;
        private System.Windows.Forms.Button btn_Sfx;
        private System.Windows.Forms.ComboBox comboBox_Difficulty;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
namespace Game
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_PlayerModel = new System.Windows.Forms.PictureBox();
            this.timer_Direction = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerModel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_PlayerModel
            // 
            this.pictureBox_PlayerModel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_PlayerModel.Location = new System.Drawing.Point(353, 255);
            this.pictureBox_PlayerModel.Name = "pictureBox_PlayerModel";
            this.pictureBox_PlayerModel.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_PlayerModel.TabIndex = 0;
            this.pictureBox_PlayerModel.TabStop = false;
            // 
            // timer_Direction
            // 
            this.timer_Direction.Enabled = true;
            this.timer_Direction.Interval = 10;
            this.timer_Direction.Tick += new System.EventHandler(this.timer_Direction_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_PlayerModel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PlayerModel;
        private System.Windows.Forms.Timer timer_Direction;
    }
}
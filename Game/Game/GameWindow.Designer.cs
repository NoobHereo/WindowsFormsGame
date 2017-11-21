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
            this.pictureBox_EnemyRight = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyTop = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyBottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyLeft = new System.Windows.Forms.PictureBox();
            this.timer_Enemies = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_EnemyBRC = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyTLC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTLC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_PlayerModel
            // 
            this.pictureBox_PlayerModel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_PlayerModel.Location = new System.Drawing.Point(246, 143);
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
            // pictureBox_EnemyRight
            // 
            this.pictureBox_EnemyRight.BackColor = System.Drawing.Color.Red;
            this.pictureBox_EnemyRight.Location = new System.Drawing.Point(704, 258);
            this.pictureBox_EnemyRight.Name = "pictureBox_EnemyRight";
            this.pictureBox_EnemyRight.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyRight.TabIndex = 1;
            this.pictureBox_EnemyRight.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            this.pictureBox2.Location = new System.Drawing.Point(361, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 65);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_EnemyTop
            // 
            this.pictureBox_EnemyTop.BackColor = System.Drawing.Color.Red;
            this.pictureBox_EnemyTop.Location = new System.Drawing.Point(371, 12);
            this.pictureBox_EnemyTop.Name = "pictureBox_EnemyTop";
            this.pictureBox_EnemyTop.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyTop.TabIndex = 3;
            this.pictureBox_EnemyTop.TabStop = false;
            // 
            // pictureBox_EnemyBottom
            // 
            this.pictureBox_EnemyBottom.BackColor = System.Drawing.Color.Red;
            this.pictureBox_EnemyBottom.Location = new System.Drawing.Point(371, 546);
            this.pictureBox_EnemyBottom.Name = "pictureBox_EnemyBottom";
            this.pictureBox_EnemyBottom.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyBottom.TabIndex = 4;
            this.pictureBox_EnemyBottom.TabStop = false;
            // 
            // pictureBox_EnemyLeft
            // 
            this.pictureBox_EnemyLeft.BackColor = System.Drawing.Color.Red;
            this.pictureBox_EnemyLeft.Location = new System.Drawing.Point(12, 268);
            this.pictureBox_EnemyLeft.Name = "pictureBox_EnemyLeft";
            this.pictureBox_EnemyLeft.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyLeft.TabIndex = 5;
            this.pictureBox_EnemyLeft.TabStop = false;
            // 
            // timer_Enemies
            // 
            this.timer_Enemies.Enabled = true;
            this.timer_Enemies.Tick += new System.EventHandler(this.timer_Enemies_Tick);
            // 
            // pictureBox_EnemyBRC
            // 
            this.pictureBox_EnemyBRC.BackColor = System.Drawing.Color.Red;
            this.pictureBox_EnemyBRC.Location = new System.Drawing.Point(704, 546);
            this.pictureBox_EnemyBRC.Name = "pictureBox_EnemyBRC";
            this.pictureBox_EnemyBRC.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyBRC.TabIndex = 6;
            this.pictureBox_EnemyBRC.TabStop = false;
            // 
            // pictureBox_EnemyTLC
            // 
            this.pictureBox_EnemyTLC.BackColor = System.Drawing.Color.Red;
            this.pictureBox_EnemyTLC.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_EnemyTLC.Name = "pictureBox_EnemyTLC";
            this.pictureBox_EnemyTLC.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyTLC.TabIndex = 7;
            this.pictureBox_EnemyTLC.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(756, 602);
            this.Controls.Add(this.pictureBox_EnemyTLC);
            this.Controls.Add(this.pictureBox_EnemyBRC);
            this.Controls.Add(this.pictureBox_EnemyLeft);
            this.Controls.Add(this.pictureBox_EnemyBottom);
            this.Controls.Add(this.pictureBox_EnemyTop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_EnemyRight);
            this.Controls.Add(this.pictureBox_PlayerModel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTLC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PlayerModel;
        private System.Windows.Forms.Timer timer_Direction;
        private System.Windows.Forms.PictureBox pictureBox_EnemyRight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_EnemyTop;
        private System.Windows.Forms.PictureBox pictureBox_EnemyBottom;
        private System.Windows.Forms.PictureBox pictureBox_EnemyLeft;
        private System.Windows.Forms.Timer timer_Enemies;
        private System.Windows.Forms.PictureBox pictureBox_EnemyBRC;
        private System.Windows.Forms.PictureBox pictureBox_EnemyTLC;
    }
}
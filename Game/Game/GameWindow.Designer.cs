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
            this.pictureBox_TowerModel = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyTop = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyBottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyLeft = new System.Windows.Forms.PictureBox();
            this.timer_Enemies = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_EnemyBRC = new System.Windows.Forms.PictureBox();
            this.pictureBox_EnemyTLC = new System.Windows.Forms.PictureBox();
            this.timer_EnemyMoveBack = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_TowerHealth = new System.Windows.Forms.ProgressBar();
            this.label_HealthNumeric = new System.Windows.Forms.Label();
            this.label_Healing = new System.Windows.Forms.Label();
            this.label_Points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TowerModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTLC)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // pictureBox_TowerModel
            // 
            this.pictureBox_TowerModel.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_TowerModel.Location = new System.Drawing.Point(361, 247);
            this.pictureBox_TowerModel.Name = "pictureBox_TowerModel";
            this.pictureBox_TowerModel.Size = new System.Drawing.Size(68, 65);
            this.pictureBox_TowerModel.TabIndex = 2;
            this.pictureBox_TowerModel.TabStop = false;
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
            this.timer_Enemies.Interval = 300;
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
            this.pictureBox_EnemyTLC.Location = new System.Drawing.Point(56, 12);
            this.pictureBox_EnemyTLC.Name = "pictureBox_EnemyTLC";
            this.pictureBox_EnemyTLC.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_EnemyTLC.TabIndex = 7;
            this.pictureBox_EnemyTLC.TabStop = false;
            // 
            // timer_EnemyMoveBack
            // 
            this.timer_EnemyMoveBack.Enabled = true;
            this.timer_EnemyMoveBack.Tick += new System.EventHandler(this.timer_EnemyMoveBack_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Points);
            this.groupBox1.Controls.Add(this.label_Healing);
            this.groupBox1.Controls.Add(this.label_HealthNumeric);
            this.groupBox1.Controls.Add(this.progressBar_TowerHealth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 142);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tower health:";
            // 
            // progressBar_TowerHealth
            // 
            this.progressBar_TowerHealth.Location = new System.Drawing.Point(90, 52);
            this.progressBar_TowerHealth.Name = "progressBar_TowerHealth";
            this.progressBar_TowerHealth.Size = new System.Drawing.Size(138, 13);
            this.progressBar_TowerHealth.TabIndex = 1;
            this.progressBar_TowerHealth.Value = 100;
            // 
            // label_HealthNumeric
            // 
            this.label_HealthNumeric.AutoSize = true;
            this.label_HealthNumeric.ForeColor = System.Drawing.Color.Chartreuse;
            this.label_HealthNumeric.Location = new System.Drawing.Point(143, 36);
            this.label_HealthNumeric.Name = "label_HealthNumeric";
            this.label_HealthNumeric.Size = new System.Drawing.Size(0, 13);
            this.label_HealthNumeric.TabIndex = 2;
            // 
            // label_Healing
            // 
            this.label_Healing.AutoSize = true;
            this.label_Healing.ForeColor = System.Drawing.Color.Red;
            this.label_Healing.Location = new System.Drawing.Point(97, 72);
            this.label_Healing.Name = "label_Healing";
            this.label_Healing.Size = new System.Drawing.Size(0, 13);
            this.label_Healing.TabIndex = 4;
            // 
            // label_Points
            // 
            this.label_Points.AutoSize = true;
            this.label_Points.Location = new System.Drawing.Point(15, 20);
            this.label_Points.Name = "label_Points";
            this.label_Points.Size = new System.Drawing.Size(39, 13);
            this.label_Points.TabIndex = 5;
            this.label_Points.Text = "Points:";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(756, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_EnemyTLC);
            this.Controls.Add(this.pictureBox_EnemyBRC);
            this.Controls.Add(this.pictureBox_EnemyLeft);
            this.Controls.Add(this.pictureBox_EnemyBottom);
            this.Controls.Add(this.pictureBox_EnemyTop);
            this.Controls.Add(this.pictureBox_TowerModel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TowerModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyBRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EnemyTLC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PlayerModel;
        private System.Windows.Forms.Timer timer_Direction;
        private System.Windows.Forms.PictureBox pictureBox_EnemyRight;
        private System.Windows.Forms.PictureBox pictureBox_TowerModel;
        private System.Windows.Forms.PictureBox pictureBox_EnemyTop;
        private System.Windows.Forms.PictureBox pictureBox_EnemyBottom;
        private System.Windows.Forms.PictureBox pictureBox_EnemyLeft;
        private System.Windows.Forms.Timer timer_Enemies;
        private System.Windows.Forms.PictureBox pictureBox_EnemyBRC;
        private System.Windows.Forms.PictureBox pictureBox_EnemyTLC;
        private System.Windows.Forms.Timer timer_EnemyMoveBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_HealthNumeric;
        private System.Windows.Forms.ProgressBar progressBar_TowerHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Points;
        private System.Windows.Forms.Label label_Healing;
    }
}
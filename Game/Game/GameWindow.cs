using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Media;

namespace Game
{
    public partial class GameWindow : Form
    {
        public static GameWindow instance;
        int points = 0;
        int towerHealth = 100;

        public GameWindow()
        {
            InitializeComponent();
            instance = this;
            timer_Enemies.Interval = Settings.interval;
            int towerHealthMAX = progressBar_TowerHealth.Maximum;

            label_Points.Text = "Points: " + points.ToString();
            label_HealthNumeric.Text = towerHealth + "/" + towerHealthMAX.ToString();

            playMusic();
        }

        private enum Direction
        {
            Up = 1 << 0,
            Down = 1 << 1,
            Right = 1 << 2,
            Left = 1 << 3
        }
        private Direction _direction;

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    _direction |= Direction.Up;
                    break;
                case Keys.Up:
                    _direction |= Direction.Up;
                    break;

                case Keys.S:
                    _direction |= Direction.Down;
                    break;
                case Keys.Down:
                    _direction |= Direction.Down;
                    break;

                case Keys.D:
                    _direction |= Direction.Right;
                    break;
                case Keys.Right:
                    _direction |= Direction.Right;
                    break;

                case Keys.A:
                    _direction |= Direction.Left;
                    break;
                case Keys.Left:
                    _direction |= Direction.Left;
                    break;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    _direction &= ~Direction.Up;
                    break;
                case Keys.Up:
                    _direction &= ~Direction.Up;
                    break;

                case Keys.S:
                    _direction &= ~Direction.Down;
                    break;
                case Keys.Down:
                    _direction &= ~Direction.Down;
                    break;

                case Keys.D:
                    _direction &= ~Direction.Right;
                    break;
                case Keys.Right:
                    _direction &= ~Direction.Right;
                    break;

                case Keys.A:
                    _direction &= ~Direction.Left;
                    break;
                case Keys.Left:
                    _direction &= ~Direction.Left;
                    break;
            }
        }


        private void timer_Direction_Tick(object sender, EventArgs e)
        {

            if ((_direction & Direction.Up) == Direction.Up)
            {
                if (pictureBox_PlayerModel.Location.Y > 0)      
                    pictureBox_PlayerModel.Top--;                                        
            }

            if ((_direction & Direction.Down) == Direction.Down)
            {
                if (pictureBox_PlayerModel.Location.Y < ClientSize.Height - pictureBox_PlayerModel.Height)
                pictureBox_PlayerModel.Top++;
            }

            if ((_direction & Direction.Right) == Direction.Right)
            {               
                if (pictureBox_PlayerModel.Location.X < ClientSize.Width - pictureBox_PlayerModel.Width)
                pictureBox_PlayerModel.Left++;
            }

            if ((_direction & Direction.Left) == Direction.Left)
            {
                if (pictureBox_PlayerModel.Location.X > 0)
                    pictureBox_PlayerModel.Left--;
                }
            }

      
        private void timer_Enemies_Tick(object sender, EventArgs e)
        {
            int speed_left = 1;
            int speed_bottom = 2;
            int speed_right = 3;
            int speed_top = 4;
            int speed_cornors = 1;


            #region Left Enemy
            if (pictureBox_EnemyLeft.Bounds.IntersectsWith(pictureBox_PlayerModel.Bounds))
            {
                pictureBox_EnemyLeft.Location = new Point(12, 268);
            }
                
            if (pictureBox_EnemyLeft.Bounds.IntersectsWith(pictureBox_TowerModel.Bounds))
            {
                pictureBox_EnemyLeft.Location = new Point(12, 268);
                DamageTower();
            }
            else
                pictureBox_EnemyLeft.Left += speed_left;
            #endregion

            #region Top Enemy
            if (pictureBox_EnemyTop.Bounds.IntersectsWith(pictureBox_PlayerModel.Bounds))
            {
                pictureBox_EnemyTop.Location = new Point(371, 12);
                points++;
                label_Points.Text = "Points: " + points.ToString();
            }
            if (pictureBox_EnemyTop.Bounds.IntersectsWith(pictureBox_TowerModel.Bounds))
            {
                pictureBox_EnemyTop.Location = new Point(371, 12);
                DamageTower();
            }          
            else
                pictureBox_EnemyTop.Top += speed_left;
            #endregion

            #region Bottom Enemy
            if (pictureBox_EnemyBottom.Bounds.IntersectsWith(pictureBox_PlayerModel.Bounds))
            {
                pictureBox_EnemyBottom.Location = new Point(371, 546);
                points++;
                label_Points.Text = "Points: " + points.ToString();
            }
            if (pictureBox_EnemyBottom.Bounds.IntersectsWith(pictureBox_TowerModel.Bounds))
            {
                pictureBox_EnemyBottom.Location = new Point(371, 546);
                DamageTower();
            }
            
            else
                pictureBox_EnemyBottom.Top -= speed_left;
            #endregion

            #region Right Enemy
            if (pictureBox_EnemyRight.Bounds.IntersectsWith(pictureBox_PlayerModel.Bounds))
            {
                pictureBox_EnemyRight.Location = new Point(704, 258);
                points++;
                label_Points.Text = "Points: " + points.ToString();
            }           
            if (pictureBox_EnemyRight.Bounds.IntersectsWith(pictureBox_TowerModel.Bounds))
            {
                pictureBox_EnemyRight.Location = new Point(704, 258);
                DamageTower();
            }
           
            else
                pictureBox_EnemyRight.Left -= speed_left;
            #endregion

            #region Left Top Cornor Enemy
            if (pictureBox_EnemyTLC.Bounds.IntersectsWith(pictureBox_PlayerModel.Bounds))
            {
                pictureBox_EnemyTLC.Location = new Point(56, 12);
                points++;
                label_Points.Text = "Points: " + points.ToString();
            }
            if (pictureBox_EnemyTLC.Bounds.IntersectsWith(pictureBox_TowerModel.Bounds))
            {
                pictureBox_EnemyTLC.Location = new Point(56, 12);
                DamageTower();
            }
            else
                 {
                    pictureBox_EnemyTLC.Top += speed_cornors;
                     pictureBox_EnemyTLC.Left += speed_cornors;
                 }
            #endregion

            #region Bottom Right Cornor Enemy
            if (pictureBox_EnemyBRC.Bounds.IntersectsWith(pictureBox_PlayerModel.Bounds))
            { 
                pictureBox_EnemyBRC.Location = new Point(704, 546);
                points++;
                label_Points.Text = "Points: " + points.ToString();
            }
            if (pictureBox_EnemyBRC.Bounds.IntersectsWith(pictureBox_TowerModel.Bounds))
            {
                pictureBox_EnemyBRC.Location = new Point(704, 546);
                
            }
            else
            {
                pictureBox_EnemyBRC.Top -= speed_cornors;
                pictureBox_EnemyBRC.Left -= speed_cornors;
            }
            #endregion


            pictureBox_EnemyBottom.Top -= speed_bottom;
            pictureBox_EnemyRight.Left -= speed_right;
            pictureBox_EnemyTop.Top += speed_top;




        }

        private void DamageTower()
        {
            int towerHealthMAX = progressBar_TowerHealth.Maximum;           

            if (towerHealth <= 25)
            {
                Main.instance.playMusic();
                Close();
            }
            else
            {
                towerHealth -= 25;
                progressBar_TowerHealth.Value -= 25;
                label_HealthNumeric.Text = towerHealth + "/" + towerHealthMAX.ToString();
            }
        }

        private void playMusic()
        {
            SoundPlayer music = new SoundPlayer(@"C:\Users\PC\Desktop\WindowsFormsGame\Game\Game\Sound\Music\game_screen.wav");
            music.Play();
        }







        private void timer_EnemyMoveBack_Tick(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

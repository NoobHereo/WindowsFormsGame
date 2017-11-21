using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameWindow : Form
    {
        public static GameWindow instance;

        public GameWindow()
        {
            InitializeComponent();
            instance = this;
            timer_Enemies.Interval = Settings.interval;
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



            pictureBox_EnemyLeft.Left += speed_left;
            pictureBox_EnemyBottom.Top -= speed_bottom;
            pictureBox_EnemyRight.Left -= speed_right;
            pictureBox_EnemyTop.Top += speed_top;
        }
    }
    }

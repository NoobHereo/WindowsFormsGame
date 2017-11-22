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

namespace Game
{

    public partial class Settings : Form
    {
        public static int interval;
        public static Settings instance;

        public Settings()
        {
            InitializeComponent();
            instance = this;
            
        }
        public void SetDifficulty(string difficulty)
        {

            switch (difficulty)
            {
                case "Easy":
                    interval = 320;
                    break;

                case "Medium":
                    interval = 220;
                    break;

                case "Hard":
                    interval = 100;
                    break;

                default:
                    interval = 320;
                    break;
            }

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            if (comboBox_Difficulty.Text == "")
            {
                MessageBox.Show("You must choose a difficulty before playing", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Main.instance.ActivatePlayButton();
            string difficultySelected = comboBox_Difficulty.Text;

            SetDifficulty(difficultySelected);
            Close();
        }

        public bool musicPlaying;
        private void btn_Music_Click(object sender, EventArgs e)
        {
            if (musicPlaying == true)
            {
                Main.instance.stopMusic();
                btn_Music.Text = "On";
                musicPlaying = false;
            }

            else if (musicPlaying == false)
            {
                Main.instance.startMusic();
                btn_Music.Text = "Off";
                musicPlaying = true;
            }
        }

    }
}

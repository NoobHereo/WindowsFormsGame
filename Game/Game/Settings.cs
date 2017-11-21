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

        public Settings()
        {
            InitializeComponent();
        }
        public void SetDifficulty(string difficulty)
        {

            switch (difficulty)
            {
                case "Easy":
                    interval = 120;
                    break;

                case "Medium":
                    interval = 90;
                    break;

                case "Hard":
                    interval = 50;
                    break;

                default:
                    interval = 120;
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
    }
}

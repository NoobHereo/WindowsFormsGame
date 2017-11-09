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
    public partial class Main : Form
    {
        public static Main instance;

        public Main()
        {
            InitializeComponent();
            instance = this;
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.ShowDialog();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Hide();
            CharacterScreen charScreenWindow = new CharacterScreen();
            charScreenWindow.Location = Location;
            charScreenWindow.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Location = new Point(Location.X + (Size.Width / 2) - (loginWindow.Size.Width / 2), Location.Y + (Size.Height / 2) - (loginWindow.Size.Height / 2));

            loginWindow.ShowDialog();
        }

        public void ActivatePlayButton()
        {
            btn_Play.Enabled = true;
        }
    }
}

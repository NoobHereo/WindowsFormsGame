using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            SelectClass classSelectionScreen = new SelectClass();
            classSelectionScreen.Location = Location;
            classSelectionScreen.ShowDialog();
            
        }

        public void startMusic()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"Sound\Music\main_screen.wav";
            SoundPlayer music = new SoundPlayer(path);
            music.Play();
        }
        public void stopMusic()
        {
            SoundPlayer music = new SoundPlayer();
            music.Stop();

        }
    }
}

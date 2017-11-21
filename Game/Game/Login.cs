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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //login
            //Main.instance.ActivatePlayButton();
            this.Close();
        }

        private void linkLabel_RegisterHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerWindow = new Register();
            registerWindow.Location = Location;
            registerWindow.ShowDialog();
        }
    }
}

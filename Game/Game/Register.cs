using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Game.Database;

namespace Game
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Database.Database db = new Database.Database();
            string nameInput = textBox_Username.Text;
            string passwordInput = textBox_Password.Text;
            string passwordRepeatInput = textBox_RepeatPassword.Text;


            if (nameInput == "")
            {
                MessageBox.Show("You have to use a valid username", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (passwordInput == "")
            {
                MessageBox.Show("You have to use a valid password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (passwordInput != passwordRepeatInput)
            {
                MessageBox.Show("Passwords, do not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                db.Register(name: nameInput, password: passwordInput);
                Close();
            }

        }
    }
}

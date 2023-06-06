using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Logout Application", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dialogResult == DialogResult.Yes) // check if yes is pressed then logout otherwise not
            Application.Exit();  // for logout 
        }

        private void picSignout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Logout Application", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) // check if yes is pressed then logout otherwise not
                Application.Restart();  // for Signout

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString();
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}

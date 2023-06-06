using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagmentSystem
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }
        int move, startpoint = 0;

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            panelSlide.Width = 0;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            panelSlide.Width += 2;
            if (panelSlide.Width >= 636)
            {
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();

            }
            if(panelSlide.Width < 0)
            {
                move = 2;
            }
        }
    }
}

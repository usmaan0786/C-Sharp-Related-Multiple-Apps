﻿using System;
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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        
        private void BtnProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            if(int.Parse(TxtStartingNo.Text) < int.Parse(TxtEndingNo.Text))
            {
                for (int i = int.Parse(TxtStartingNo.Text); i <= int.Parse(TxtEndingNo.Text); i++)
                {
                    progressBar1.Value = i;
                    RichTxtTable.Text = RichTxtTable.Text + Environment.NewLine + int.Parse(TxtTable.Text) + " x " + i + "= " + int.Parse(TxtTable.Text) * i + "\n";
                }
            }
            else
            {
                MessageBox.Show("invalid Starting Point or Ending Point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

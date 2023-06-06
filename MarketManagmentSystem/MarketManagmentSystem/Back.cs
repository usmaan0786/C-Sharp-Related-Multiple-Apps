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
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxKey_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (TxtBoxKey.Text == "123")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProductForm productForm = new ProductForm();
                    this.Hide();
                    productForm.Show();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

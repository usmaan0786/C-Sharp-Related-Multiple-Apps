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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string userPassword = string.Empty;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtboxUserName.Text == "" && txtboxPassword.Text == "")
            {
                MessageBox.Show("Enter The UserName and Password");
            }
            else
            {
                if(comboBoxSelectRole.Text == "Admin")
                {                 
                    if(txtboxUserName.Text == "Admin" && txtboxPassword.Text == "Admin")
                    {
                        ProductForm productForm = new ProductForm();
                        this.Hide();
                        productForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct UserName and Password", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                    }
                }
                if (comboBoxSelectRole.Text == "Seller")
                {
                    if (txtboxUserName.Text == "Seller" && txtboxPassword.Text == "Seller")
                    {
                        SellingForm sellingForm = new SellingForm();
                        this.Hide();
                        sellingForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct UserName and Password", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picShowPassword.Show();
            picHidePassword.Hide();
            txtboxPassword.PasswordChar = '*';
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Hide();
            picHidePassword.Show();
            txtboxPassword.PasswordChar = '\0';
        }

        private void txtboxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtboxPassword.Focus();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtboxUserName.Text = "";
            txtboxPassword.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagmentSystem
{
    public partial class AddSeller : Form
    {
        private SqlCommand sqlCommand;

        public AddSeller()
        {
            InitializeComponent();
        }

        private void SellerAdd_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBoxSellerAddOk_Click(object sender, EventArgs e)
        {
            if (txtBoxSellerAddName.Text != string.Empty && txtBoxSellerAddAge.Text != string.Empty && txtBoxSellerAddPhone.Text != string.Empty && txtBoxSellerAddPassword.Text != string.Empty)
            {

                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [MarketManagment].[dbo].[Seller]
                       ([SellerName], [SellerAge], [SellerPhone],[SellerPassword])
                        VALUES
                        ('" + txtBoxSellerAddName.Text + "' ," + txtBoxSellerAddAge.Text + ", '" + txtBoxSellerAddPhone.Text + "', '" + txtBoxSellerAddPassword.Text + "');", con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();

                        MessageBox.Show(" Added Succesfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void btnBoxSellerAddCancel_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void picHidePassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Show();
            picHidePassword.Hide();
            txtBoxSellerAddPassword.PasswordChar = '*';
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Hide();
            picHidePassword.Show();
            txtBoxSellerAddPassword.PasswordChar = '\0';
        }
    }
}

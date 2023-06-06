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
    public partial class EditSeller : Form
    {
        private SqlCommand sqlCommand;

        public EditSeller()
        {
            InitializeComponent();
        }

        private void btnBoxSellerEditOk_Click(object sender, EventArgs e)
        {
            if (txtBoxSellerEditID.Text != string.Empty && txtBoxSellerEditName.Text != string.Empty && txtBoxSellerEditAge.Text != string.Empty && txtBoxSellerEditPhone.Text != string.Empty && txtBoxSellerEditPassword.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@" Update [MarketManagment].[dbo].[Seller]
                        Set
                        SellerName = '" + txtBoxSellerEditName.Text + "', SellerAge = '" + txtBoxSellerEditAge.Text + "', SellerPhone = '" + txtBoxSellerEditPhone.Text + "', SellerPassword = '" + txtBoxSellerEditPassword.Text + "'  Where SellerID = " + txtBoxSellerEditID.Text, con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();
                        MessageBox.Show(" Seller Successfully Updated ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBoxSellerEditcancel_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void picHidePassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Show();
            picHidePassword.Hide();
            txtBoxSellerEditPassword.PasswordChar = '*';
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Hide();
            picHidePassword.Show();
            txtBoxSellerEditPassword.PasswordChar = '\0';
        }

        private void txtBoxSellerEditID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

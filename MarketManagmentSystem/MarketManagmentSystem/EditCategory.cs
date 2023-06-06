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
    public partial class EditCategory : Form
    {
        private SqlCommand sqlCommand;

        public EditCategory()
        {
            InitializeComponent();
        }

        private void btnBoxCatEditOk_Click(object sender, EventArgs e)
        {
            if (txtBoxCatEditID.Text != string.Empty && txtBoxCatEditName.Text != string.Empty && txtBoxCatEditDescription.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@" Update [MarketManagment].[dbo].[CategoriesTable]
                        Set
                        CatName = '" + txtBoxCatEditName.Text + "' , CatDescription = '" + txtBoxCatEditDescription.Text + "'  Where CatID = " + txtBoxCatEditID.Text, con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();
                        MessageBox.Show(" Update Succesfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void btnBoxCatEditcancel_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void txtBoxCatEditID_KeyPress(object sender, KeyPressEventArgs e)
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

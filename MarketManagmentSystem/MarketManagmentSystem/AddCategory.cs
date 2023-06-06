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
    public partial class AddCategory : Form
    {
        private SqlCommand sqlCommand;

        public AddCategory()
        {
            InitializeComponent();
        }
        private void btnCatAddOk_Click(object sender, EventArgs e)
        {

            if (txtBoxCatAddName.Text != string.Empty && txtBoxCatAddDescription.Text != string.Empty)
            {

                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [MarketManagment].[dbo].[CategoriesTable]
                       ([CatName], [CatDescription])
                        VALUES
                        ('" + txtBoxCatAddName.Text + "' ,'" + txtBoxCatAddDescription.Text + "');", con);

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
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void btnCatAddCancel_Click(object sender, EventArgs e)
        {

            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }
    }
}

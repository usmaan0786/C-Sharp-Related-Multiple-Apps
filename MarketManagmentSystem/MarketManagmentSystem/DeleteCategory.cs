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
    public partial class DeleteCategory : Form
    {
        private SqlCommand sqlCommand;

        public DeleteCategory()
        {
            InitializeComponent();
        }

        private void btnCatDeleteOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection c = DBConnection.OpenDBConnection();
                if (txtBoxCatDeleteID.Text != String.Empty)
                {
                    sqlCommand = new SqlCommand(@"Delete From [MarketManagment].[dbo].[CategoriesTable] where CatID =  '" + txtBoxCatDeleteID.Text + "'", c);
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.Dispose();
                    c.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void btnCatDeleteCancel_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void txtBoxCatDeleteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCatDeleteID_KeyPress(object sender, KeyPressEventArgs e)
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

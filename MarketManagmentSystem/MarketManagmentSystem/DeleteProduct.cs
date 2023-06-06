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
    public partial class DeleteProduct : Form
    {
        private SqlCommand sqlCommand;

        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnBoxCatDeleteOk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection c = DBConnection.OpenDBConnection();
                if (txtBoxProductDeleteID.Text != String.Empty)
                {
                    sqlCommand = new SqlCommand(@"Delete From [MarketManagment].[dbo].[Product] where ProdID =  '" + txtBoxProductDeleteID.Text + "'", c);
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.Dispose();
                    c.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void btnBoxCatDeleteCancel_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void txtBoxProductDeleteID_KeyPress(object sender, KeyPressEventArgs e)
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

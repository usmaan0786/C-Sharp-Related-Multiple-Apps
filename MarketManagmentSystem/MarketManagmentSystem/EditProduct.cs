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
    public partial class EditProduct : Form
    {
        private SqlCommand sqlCommand;

        public EditProduct()
        {
            InitializeComponent();
        }

        private void btnBoxProductEditOk_Click(object sender, EventArgs e)
        {
            if (txtBoxProductEditID.Text != string.Empty && txtBoxProductEditName.Text != string.Empty && txtBoxProductEditPrice.Text != string.Empty && txtBoxProductEditQuantity.Text != string.Empty && comboBoxEditProdCategory.SelectedValue.ToString() != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@" Update [MarketManagment].[dbo].[Product]
                        Set
                        ProdName = '" + txtBoxProductEditName.Text + "', ProdQuantity = '" + txtBoxProductEditQuantity.Text + "', ProdPrice = '" + txtBoxProductEditPrice.Text + "'  Where ProdID = " + txtBoxProductEditID.Text, con);

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

            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void btnBoxProductEditcancel_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketManagmentDataSet11.CategoriesTable' table. You can move, or remove it, as needed.
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet11.CategoriesTable);

        }

        private void txtBoxProductEditID_KeyPress(object sender, KeyPressEventArgs e)
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

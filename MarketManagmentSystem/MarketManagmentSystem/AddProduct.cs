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
    public partial class AddProduct : Form
    {
        private SqlCommand sqlCommand;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnBoxCatAddOk_Click(object sender, EventArgs e)
        {
            if (txtBoxProductEditName.Text != string.Empty && txtBoxProductAddQuantity.Text != string.Empty && txtBoxProductAddPrice.Text != string.Empty && comboBoxAddProdCategory.Text != string.Empty)
            {

                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [MarketManagment].[dbo].[Product]
                       ([ProdName], [ProdQuantity], [ProdPrice])
                        VALUES
                        ('" + txtBoxProductEditName.Text + "' ," + txtBoxProductAddQuantity.Text + ", '" + txtBoxProductAddPrice.Text + "');", con);

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
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void btnBoxCatAddcancel_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketManagmentDataSet10.CategoriesTable' table. You can move, or remove it, as needed.
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet10.CategoriesTable);


        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

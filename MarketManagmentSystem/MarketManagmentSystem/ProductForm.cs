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
    public partial class ProductForm : Form
    {
        private SqlCommand sqlCommand;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
            this.productTableAdapter.Fill(this.marketManagmentDataSet9.Product);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketManagmentDataSet19.CategoriesTable' table. You can move, or remove it, as needed.
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet19.CategoriesTable);
            // TODO: This line of code loads data into the 'marketManagmentDataSet9.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.marketManagmentDataSet9.Product);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            this.Hide();
            addProduct.Show();
            this.productTableAdapter.Fill(this.marketManagmentDataSet9.Product);
            dgvManageProducts.Refresh();       

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            this.Hide();
            deleteProduct.Show();
            this.productTableAdapter.Fill(this.marketManagmentDataSet9.Product);
            dgvManageProducts.Refresh();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct();
            this.Hide();
            editProduct.Show();
            this.productTableAdapter.Fill(this.marketManagmentDataSet9.Product);
            dgvManageProducts.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            this.Hide();
            sellingForm.Show();
        }

        private void btnProdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DBConnection.OpenDBConnection();
                if (con.State == ConnectionState.Open)
                {
                    sqlCommand = new SqlCommand(@"Delete from [MarketManagment].[dbo].[Product] ", con);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommand.ExecuteNonQuery();
                    }   
                    sqlCommand.Dispose();
                    con.Close();
                   
                    this.productTableAdapter.Fill(this.marketManagmentDataSet9.Product);
                    dgvManageProducts.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}

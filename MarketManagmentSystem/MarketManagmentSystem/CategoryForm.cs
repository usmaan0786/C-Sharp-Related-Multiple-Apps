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

    public partial class CategoryForm : Form
    {
        private SqlCommand sqlCommand;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            this.Hide();
            sellerForm.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketManagmentDataSet8.CategoriesTable' table. You can move, or remove it, as needed.
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet8.CategoriesTable);
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            this.Hide();
            addCategory.Show();
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet8.CategoriesTable);
            dgvManageCategories.Refresh();
        }

        private void btnCatEdit_Click(object sender, EventArgs e)
        {
            EditCategory editCategory = new EditCategory();
            this.Hide();
            editCategory.Show();
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet8.CategoriesTable);
            dgvManageCategories.Refresh();
        }

        private void btnCatDelete_Click(object sender, EventArgs e)
        {
            DeleteCategory deleteCategory = new DeleteCategory();
            this.Hide();
            deleteCategory.Show();
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet8.CategoriesTable);
            dgvManageCategories.Refresh();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            this.Hide();
            sellingForm.Show();
        }
    }
}

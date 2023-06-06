using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagmentSystem
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketManagmentDataSet12.Seller' table. You can move, or remove it, as needed.
            this.sellerTableAdapter.Fill(this.marketManagmentDataSet12.Seller);

        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSellerAdd_Click(object sender, EventArgs e)
        {
            AddSeller addSeller = new AddSeller();
            this.Hide();
            addSeller.Show();
            this.sellerTableAdapter.Fill(this.marketManagmentDataSet12.Seller);
            dgvManagesSellers.Refresh();
        }

        private void btnSellerDelete_Click(object sender, EventArgs e)
        {
            DeleteSeller deleteSeller = new DeleteSeller();
            this.Hide();
            deleteSeller.Show();
            this.sellerTableAdapter.Fill(this.marketManagmentDataSet12.Seller);
            dgvManagesSellers.Refresh();
        }

        private void btnSellerEdit_Click(object sender, EventArgs e)
        {
            EditSeller editSeller = new EditSeller();
            this.Hide();
            editSeller.Show();
            this.sellerTableAdapter.Fill(this.marketManagmentDataSet12.Seller);
            dgvManagesSellers.Refresh();
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
    }
}

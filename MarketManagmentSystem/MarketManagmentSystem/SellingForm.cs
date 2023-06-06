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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketManagmentDataSet18.CategoriesTable' table. You can move, or remove it, as needed.
            this.categoriesTableTableAdapter.Fill(this.marketManagmentDataSet18.CategoriesTable);
            // TODO: This line of code loads data into the 'marketManagmentDataSet17.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter1.Fill(this.marketManagmentDataSet17.Bill);
            // TODO: This line of code loads data into the 'marketManagmentDataSet16.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.marketManagmentDataSet16.Product);

            // TODO: This line of code loads data into the 'marketManagmentDataSet13.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.marketManagmentDataSet13.Product);
        }
        int RowIndex;
        private void dgvManageSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    RowIndex = e.RowIndex;
                    txtBoxSellingBill.Text = ProdDGV1.Rows[e.RowIndex].Cells["prodIDDataGridViewTextBoxColumn"].Value.ToString();
                    txtBoxSellingName.Text = ProdDGV1.Rows[e.RowIndex].Cells["prodNameDataGridViewTextBoxColumn"].Value.ToString();
                    txtBoxSellingPrice.Text = ProdDGV1.Rows[e.RowIndex].Cells["prodPriceDataGridViewTextBoxColumn"].Value.ToString();               
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Today.Date.ToString();
        }
        int gradTotal , n = 0;
        private SqlCommand sqlCommand;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxSellingQuantity.Text == String.Empty)
                {
                    MessageBox.Show("How much Quantity you need!!! ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }

            int total = Convert.ToInt32(txtBoxSellingPrice.Text) * Convert.ToInt32(txtBoxSellingQuantity.Text);


            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(OrderDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txtBoxSellingName.Text;
            newRow.Cells[2].Value = txtBoxSellingPrice.Text;
            newRow.Cells[3].Value = txtBoxSellingQuantity.Text;
            newRow.Cells[4].Value = Convert.ToInt32(txtBoxSellingPrice.Text) * Convert.ToInt32(txtBoxSellingQuantity.Text);
            OrderDGV.Rows.Add(newRow);
            gradTotal = gradTotal + total;
            n++;
            AmtLbl.Text = "Rs : " + gradTotal;
        }
        
        private void btnSeller_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reachable for Admin !!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reachable for Admin !!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reachable for Admin !!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBoxSellingQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBoxSellingAdd_Click(object sender, EventArgs e)
        {
            if(txtBoxSellingBill.Text == "")
            {
                MessageBox.Show("Missing BIll ID ");
            }
            else
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [MarketManagment].[dbo].[Bill]              
                        VALUES
                        ('" + txtBoxSellingBill.Text + "' ,'" + SellerNameLbl.Text + "','" + DateLabel.Text + "','" + AmtLbl.Text + "');", con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();
                        MessageBox.Show(" Order Added Succesfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            this.billTableAdapter1.Fill(this.marketManagmentDataSet17.Bill);
            BillsDGV.Refresh();
        }

        private int flag = 0;
        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }
        private void btnBoxSellingEdit_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.Yes)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FamilySuperMarket", new Font("Century Gothic", 25,FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID : " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));
            e.Graphics.DrawString("Seller Name : " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));
            e.Graphics.DrawString("Date : " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));
            e.Graphics.DrawString("Total Amount : " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));
            e.Graphics.DrawString("", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));
            e.Graphics.DrawString("", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));
            e.Graphics.DrawString("Receipt Granted ", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100, 230));

        }


        private void btnBoxSellingDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DBConnection.OpenDBConnection();
                if (con.State == ConnectionState.Open)
                {
                    sqlCommand = new SqlCommand(@"Delete from [MarketManagment].[dbo].[Bill] ", con);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.Dispose();
                    con.Close();
                    this.billTableAdapter1.Fill(this.marketManagmentDataSet17.Bill);
                    BillsDGV.Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void btnBoxSellingRefresh_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back back = new Back();
            this.Hide();
            back.Show();

        }

        private void BillsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }
    }
}

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

namespace SecondGUI
{
    public partial class StudentManagment : Form
    {
        int RowIndex;
        public StudentManagment()
        {
            InitializeComponent();
        }
         static SqlDataReader dataReader;
         static SqlDataAdapter dataAdapter;
          static DataTable dataTable;
         static DataSet dataSet;
          static SqlCommand sqlCommand;
          static SqlTransaction sqlTransaction;

        private void DataGridView_Load(object sender, EventArgs e)
        {

        }

        DataTable GetStudents()
        {
            try
            {
                SqlConnection con = DBConnection.OpenDBConnection();
                if (con.State == ConnectionState.Open)
                {
                    dataAdapter = new SqlDataAdapter(@"SELECT [RollNo]
                      ,[Name]
                      ,[Section]
                      ,[Session]
                      ,[CellNo]
                  FROM [FAST,University].[dbo].[Students]", con);

                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    con.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            return dataTable;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TxtName.Text != string.Empty && TxtSection.Text != string.Empty && TxtSession.Text != string.Empty
                && TxtRollNo.Text != string.Empty && TxtCellNo.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if(con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [FAST,University].[dbo].[Students]
                       ([RollNo]
                       ,[Name]
                       ,[Section]
                       ,[Session]
                       ,[CellNo])
                        VALUES
                        (" + TxtRollNo.Text + " ,' " + TxtName.Text + " ' ,' " + TxtSection.Text + " ' , ' " + 
                        TxtSession.Text + " ' , ' " + TxtCellNo.Text + "');",  con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
               
                //int RowIndex = DgvRecords.Rows.Add();
                //DgvRecords.Rows[RowIndex].Cells["Name"].Value = TxtName.Text;
                //DgvRecords.Rows[RowIndex].Cells["Section"].Value = TxtSection.Text;
                //DgvRecords.Rows[RowIndex].Cells["Session"].Value = TxtSession.Text;
                //DgvRecords.Rows[RowIndex].Cells["RollNo"].Value = TxtRollNo.Text;
                //DgvRecords.Rows[RowIndex].Cells["CellNo"].Value = TxtCellNo.Text;
                ////DgvRecords.Rows[RowIndex].Selected = true;
                //DgvRecords.Update();
            }
            else
            {
                MessageBox.Show("Please Fill all fields", "Filed Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                DgvRecords.Rows.RemoveAt(RowIndex);
                DgvRecords.Update();
                DgvRecords.Refresh();
            }
        }
        private void DgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                RowIndex = e.RowIndex;
            }
        }

        private void DgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    RowIndex = e.RowIndex;
                TxtName.Text = DgvRecords.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                TxtSection.Text = DgvRecords.Rows[e.RowIndex].Cells["Section"].Value.ToString();
                TxtSession.Text = DgvRecords.Rows[e.RowIndex].Cells["Session"].Value.ToString();
                TxtRollNo.Text = DgvRecords.Rows[e.RowIndex].Cells["RollNo"].Value.ToString();
                TxtCellNo.Text = DgvRecords.Rows[e.RowIndex].Cells["CellNo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DgvRecords.Rows[RowIndex].Cells["Name"].Value = TxtName.Text;
                DgvRecords.Rows[RowIndex].Cells["Section"].Value = TxtSection.Text;
                DgvRecords.Rows[RowIndex].Cells["Session"].Value = TxtSession.Text;
                DgvRecords.Rows[RowIndex].Cells["RollNo"].Value = TxtRollNo.Text;
                DgvRecords.Rows[RowIndex].Cells["CellNo"].Value = TxtCellNo.Text;
                //DgvRecords.Rows[RowIndex].Selected = true;
                DgvRecords.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

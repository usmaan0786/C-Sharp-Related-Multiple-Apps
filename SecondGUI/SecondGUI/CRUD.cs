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
    public partial class CRUD : Form
    {

        public CRUD()
        {
            InitializeComponent();
        }

        static SqlDataReader dataReader; //  for select command 
        static SqlDataAdapter dataAdapter;//  for select command as well as Update and Insert, delete and fro selecy 
        static DataTable dataTable;//  used to store Database table record
        static DataSet dataSet;//  Set/Group/Combination of Data Table
        static SqlCommand sqlCommand; // there we write our command or querry
        static SqlTransaction sqlTransaction;

        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityStudent.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.universityStudent.Students);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != string.Empty && TxtSection.Text != string.Empty && TxtSession.Text != string.Empty
                && TxtRollNo.Text != string.Empty && TxtCellNo.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [University].[dbo].[Students]
                       ([RollNo]
                       ,[Name]
                       ,[Section]
                       ,[Session]
                       ,[CellNo])
                        VALUES
                        (" + TxtRollNo.Text + " ,'" + TxtName.Text + "' ,'" + TxtSection.Text + "' , '" +
                        TxtSession.Text + "' , '" + TxtCellNo.Text + "');", con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();

                        this.studentsTableAdapter.Fill(this.universityStudent.Students);
                        MessageBox.Show(" Added Succesfully ","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection c = DBConnection.OpenDBConnection();
            DialogResult  dialogResult = MessageBox.Show("DO you want to delete??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                if (TxtRollNo.Text != String.Empty)
                {
                    sqlCommand = new SqlCommand(@"Delete From University.dbo.Students where RollNo =  '" + TxtRollNo.Text + "'", c);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    c.Close();
                    this.studentsTableAdapter.Fill(this.universityStudent.Students);
                }
            }  
        }

        int RowIndex; 
        private void DgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex >= 0)
                {
                    RowIndex = e.RowIndex;
                    TxtName.Text = DgvRecords.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                    TxtSection.Text = DgvRecords.Rows[e.RowIndex].Cells["sectionDataGridViewTextBoxColumn"].Value.ToString();
                    TxtSession.Text = DgvRecords.Rows[e.RowIndex].Cells["sessionDataGridViewTextBoxColumn"].Value.ToString();
                    TxtRollNo.Text = DgvRecords.Rows[e.RowIndex].Cells["rollNoDataGridViewTextBoxColumn"].Value.ToString();
                    TxtCellNo.Text = DgvRecords.Rows[e.RowIndex].Cells["cellNoDataGridViewTextBoxColumn"].Value.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()) ;  }  
        }

        /*private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand obj = new SqlCommand(@"Update University.dbo.Students set ", obj);

            if(TxtRollNo.Text != String.Empty)
            {
                   

                this.studentsTableAdapter.Fill(this.universityStudent.Students);
            }
        }*/

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != string.Empty && TxtSection.Text != string.Empty && TxtSession.Text != string.Empty
                && TxtRollNo.Text != string.Empty && TxtCellNo.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@" Update [University].[dbo].[Students]
                        Set
                  Name = '" + TxtName.Text + "' , Section = '" + TxtSection.Text + "' , Session =  '" +
                        TxtSession.Text + "' , CellNo =  '" + TxtCellNo.Text + "' Where RollNo = " + TxtRollNo.Text, con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();

                        this.studentsTableAdapter.Fill(this.universityStudent.Students);
                        MessageBox.Show(" Update Succesfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

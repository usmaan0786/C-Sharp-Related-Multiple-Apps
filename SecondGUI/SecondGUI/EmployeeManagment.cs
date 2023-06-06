using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGUI
{
    public partial class EmployeeManagment : Form
    {
        private string img_location;
        private object profile_pic_pictureBox;

        public EmployeeManagment()
        {
            InitializeComponent();
        }

        static SqlDataReader dataReader; //  for select command 
        static SqlDataAdapter dataAdapter;//  for select command as well as Update and Insert, delete and fro selecy 

        static DataTable dataTable;//  used to store Database table record
        static DataSet dataSet;//  Set/Group/Combination of Data Table
        static SqlCommand sqlCommand; // there we write our command or querry
        static SqlTransaction sqlTransaction;

        string ImageLocation = string.Empty;
        private string images;

        private void button4_Click(object sender, EventArgs e)
        {
            #region upload image file
            try
            {
                Image imageFile;
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|Alll files(*.*)|*.*"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageFile = Image.FromFile(dialog.FileName);
                    int imgHeight = imageFile.Height;
                    if (imgHeight > 350)
                        MessageBox.Show("Maximum Image can be 350x350 Image", "Image size is too large..!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        img_location = dialog.FileName.ToString();
                        PicUser.ImageLocation = img_location;
                    }
                }
                dialog.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            #endregion
        }

        private void EmployeeManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emailRecordsDataSet5.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.emailRecordsDataSet5.Department);
            GetEmployee();
        }

        private void GetEmployee ()
        {
            dataTable = new DataTable();
            dataTable.Clear();
            try
            {
                string query = @"SELECT  [Employee].[EmpID]
      ,[Employee].[EmpName]
	  ,[Employee].[EmpDateOfJoining]
      ,[Employee].[EmpPhoto]
      ,[Employee].[EmpDepartment]
      ,[Employee].[EmpPosition]
	  ,[Login].LoginID
	  ,Login.UserName
	  ,Login.[Password]
  FROM [EmailRecords].[dbo].[Employee]

  inner join  Login on Employee.EmpID = [Login].EmpID";
                SqlConnection con = DBConnection.OpenDBConnection();
                if(con.State == ConnectionState.Open)
                {
                    dataAdapter = new SqlDataAdapter(query, con);

                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    con.Close();
                    if (DgvRecords.RowCount > 0)
                    {
                        DgvRecords.Rows.Clear();
                    }
                   
                        for (int x = 0; x < dataTable.Rows.Count; x++)
                        {
                            int RowIndex = DgvRecords.Rows.Add();
                            DgvRecords.Rows[RowIndex].Cells["EmpID"].Value = dataTable.Rows[x]["EmpID"];
                            DgvRecords.Rows[RowIndex].Cells["EmpName"].Value = dataTable.Rows[x]["EmpName"];
                            DgvRecords.Rows[RowIndex].Cells["EmpDepartment"].Value = dataTable.Rows[x]["EmpDepartment"];
                            DgvRecords.Rows[RowIndex].Cells["EmpPosition"].Value = dataTable.Rows[x]["EmpPosition"];
                            DgvRecords.Rows[RowIndex].Cells["EmpDateOfJoining"].Value = dataTable.Rows[x]["EmpDateOfJoining"];
                            DgvRecords.Rows[RowIndex].Cells["LoginID"].Value = dataTable.Rows[x]["LoginID"];
                            DgvRecords.Rows[RowIndex].Cells["Password"].Value = dataTable.Rows[x]["Password"];
                            DgvRecords.Rows[RowIndex].Cells["UserName"].Value = dataTable.Rows[x]["UserName"];
                            DgvRecords.Rows[RowIndex].Cells["EmpPhoto"].Value = dataTable.Rows[x]["EmpPhoto"];

                        DgvRecords.Update();
                            DgvRecords.Refresh();
                        }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            HashCode hashcode = new HashCode();

            if (TxtName.Text != string.Empty && ComboBoxDepartment.SelectedValue.ToString() != string.Empty && TxtPassword.Text != string.Empty
               && TxtConfirmPassword.Text != string.Empty && TxtUserName.Text != string.Empty && TxtEmpID.Text != string.Empty)
            {
                byte[] images = null;
                if (ImageLocation != string.Empty)
                {
                    FileStream stream = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                }
                else
                { /*images = ImageToByteArray(profile_pic_pictureBox.Image);*/
                    Image img = PicUser.Image;

                    ImageConverter converter = new ImageConverter();
                    images = (byte[])converter.ConvertTo(img, typeof(byte[]));
                }

                SqlConnection con = DBConnection.OpenDBConnection();
                sqlTransaction = con.BeginTransaction();
                //sqlTransaction = con.BeginTransaction();
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@"INSERT INTO [EmailRecords].[dbo].[Employee]
                       ([EmpID]
                       ,[EmpName]
                       ,[EmpDepartment]
                       ,[EmpPosition]
                       ,[EmpPhoto]
                       ,[EmpDateOfJoining])
                        VALUES
                        ( @EmpID, @EmpName, @EmpDepartment, @EmpPosition, @EmpPhoto, @EmpDateOfJoining)", con, sqlTransaction);

                        sqlCommand.Parameters.Add(new SqlParameter("@EmpID", TxtEmpID.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@EmpName", TxtName.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@EmpDepartment", ComboBoxDepartment.SelectedValue.ToString()));
                        sqlCommand.Parameters.Add(new SqlParameter("@EmpPosition", TxtPosition.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@EmpDateOfJoining", DateJoining.Text));
                        sqlCommand.Parameters.Add("@EmpPhoto", SqlDbType.Binary).Value = images;

                    ///    sqlTransaction = sqlCommand.Transaction;
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();


                        sqlCommand = new SqlCommand(@"INSERT INTO [EmailRecords].[dbo].[Login]
                       ([EmpID]
                       ,[UserName]
                       ,[Passwordere])
                        VALUES
                        (" + TxtEmpID.Text + " ,'" + TxtUserName.Text + "' ,'" + hashcode.GetMd5Hash(TxtPassword.Text) + "');", con, sqlTransaction);

                        sqlTransaction = sqlCommand.Transaction;
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        sqlTransaction.Commit();
                        con.Close();
                        GetEmployee();
                        MessageBox.Show(" Added Succesfully ");
                    }
                }
                catch (Exception ex) {
                    sqlTransaction.Rollback();
                    con.Close();
                    MessageBox.Show(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Fill out all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != string.Empty && ComboBoxDepartment.SelectedValue.ToString() != string.Empty && TxtPassword.Text != string.Empty
               && TxtConfirmPassword.Text != string.Empty && TxtUserName.Text != string.Empty && TxtEmpID.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();
                    if (con.State == ConnectionState.Open)
                    {
                        sqlCommand = new SqlCommand(@" Update [EmailRecords].[dbo].[Employee]
                        Set
                        EmpName = '" + TxtName.Text + "' , EmpDateOfJoining = '" + DateJoining.Text + "' , EmpDepartment =  '" +
                        ComboBoxDepartment.SelectedValue.ToString() + "' , EmpPosition =  '" + TxtPosition.Text + "', EmpPhoto = '"+images+"' Where EmpID = " + TxtEmpID.Text, con);

                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        con.Close();
                        GetEmployee();
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

        #region GetImage
        public Image GetImage(int EmpID)
        {
            Image img = PicUser.Image;
            try
            {
                byte[] b = new byte[0];
                string Query = @"SELECT  [Employee].[EmpPhoto] FROM [Employee] Where [EmpID] = @EmpID";


                SqlConnection con = DBConnection.OpenDBConnection();
                if (con.State == ConnectionState.Open)
                {
                    sqlCommand = new SqlCommand(Query, con);
                    sqlCommand.Parameters.Add(new SqlParameter("@EmpID", EmpID));
                    dataReader = sqlCommand.ExecuteReader();
                    {
                        if (dataReader.Read())
                            b = (Byte[])dataReader.GetValue(0);
                        MemoryStream ms = new MemoryStream(b);
                        img = Image.FromStream(ms);
                        dataReader.Dispose();
                    }
                    con.Close();
                    con.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return img;
        }
        #endregion
        int RowIndex;

        private void DgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    RowIndex = e.RowIndex;
                    TxtName.Text = DgvRecords.Rows[e.RowIndex].Cells["EmpName"].Value.ToString();
                    TxtEmpID.Text = DgvRecords.Rows[e.RowIndex].Cells["EmpID"].Value.ToString();
                    TxtUserName.Text = DgvRecords.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                    DateJoining.Text = DgvRecords.Rows[e.RowIndex].Cells["EmpDateOfJoining"].Value.ToString();
                    int value = int.Parse(DgvRecords.Rows[e.RowIndex].Cells["EmpDepartment"].Value.ToString());
                    ComboBoxDepartment.SelectedValue = value;
                    TxtPosition.Text = DgvRecords.Rows[e.RowIndex].Cells["EmpPosition"].Value.ToString();

                    Byte[] data = new byte[0];
                    data = (Byte[])(DgvRecords.Rows[e.RowIndex].Cells["EmpPhoto"].Value);
                    MemoryStream mem = new MemoryStream(data);
                    PicUser.Image = Image.FromStream(mem);

                    //PicUser.Image = GetImage(int.Parse(DgvRecords.Rows[e.RowIndex].Cells["empIDDataGridViewImageColumn"].Value.ToString()));

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void TxtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(TxtPassword.Text != TxtConfirmPassword.Text)
            {
                TxtConfirmPassword.Clear();
                TxtConfirmPassword.Focus(); // By this Cursor will remian stay on the same textbox
                MessageBox.Show("Password doesn't Match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmpID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecondGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        string UserPassword = string.Empty;
        private void Login()
        {
            if (texBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                try
                {
                    SqlConnection con = DBConnection.OpenDBConnection();

                    if(con.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(@"SELECT [LoginID]
      ,[Password]
      ,[UserName]
  FROM[EmailRecords].[dbo].[Login] where UserName = '"+ texBoxUsername.Text+"'; ", con);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        if(sqlDataReader.Read())
                        {
                            UserPassword = sqlDataReader["Passwprd"].ToString();
                        }                
                        sqlDataReader.Dispose();
                        con.Close();
                        HashCode hashCode = new HashCode();
                        if(hashCode.VerifyMd5Hash(textBoxPassword.Text, UserPassword))
                        {
                            HomePage homepage = new HomePage();
                            this.Hide();
                            homepage.ShowDialog();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ToString());
                }
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Fill all Fields", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Hide();
            picHidePassword.Show();
            textBoxPassword.PasswordChar = '\0';
        }

        private void picHidePassword_Click(object sender, EventArgs e)
        {
            picShowPassword.Show();
            picHidePassword.Hide();
            textBoxPassword.PasswordChar = '*';
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
            
        }

        private void texBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

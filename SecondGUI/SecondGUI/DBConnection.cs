using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGUI
{
    class DBConnection
    {
        private static String DBConnectionString = @"Data Source=.\SQLEXPRESS;
                                                   Initial Catalog = EmailRecords;
                                                   Integrated Security = True";
        
        public static SqlConnection OpenDBConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = DBConnectionString;
                sqlConnection.Open();

            }
            catch(Exception ex) { MessageBox.Show(ex.ToString());  }
            return sqlConnection;
        }
             
        
    }
}

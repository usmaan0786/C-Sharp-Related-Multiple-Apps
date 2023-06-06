using System;
using System.Data.SqlClient;

namespace SecondGUI
{
    internal class sqlConnection
    {
        public sqlConnection()
        {
        }

        public static implicit operator SqlConnection(sqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}
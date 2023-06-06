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
    public partial class Graph : Form
    {

        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            SqlConnection con = DBConnection.OpenDBConnection();
            if(con.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("Select * from Salary", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet st = new DataSet();
                sda.Fill(st, "Salary");

                chart1.DataSource = st.Tables["Salary"];
                chart1.Series["Salary"].XValueMember = "EmpName";
                chart1.Series["Salary"].YValueMembers = "Salary";
                this.chart1.Titles.Add("Salary Chart for Employee");
                chart1.Series["Salary"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Series["Salary"].IsValueShownAsLabel = true;
                con.Close();
            }
        }
    }
}

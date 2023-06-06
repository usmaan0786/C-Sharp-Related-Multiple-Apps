using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGUI
{
    public partial class AdvancedTools : Form
    {
        public AdvancedTools()
        {
            InitializeComponent();
        }

        private void AdvancedTools_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
            tNode = treeView1.Nodes.Add("Website");

            treeView1.Nodes[0].Nodes.Add("Net-informations.com");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("CLR");

            treeView1.Nodes[0].Nodes.Add("Vb.net-information.com");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("String Tutorial");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Excel Tutorial");

            treeView1.Nodes[0].Nodes.Add("Csharp.net-information.com");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("ADO.NET");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Data Set");
        }
    }
}

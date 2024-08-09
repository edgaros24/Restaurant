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

namespace Restaurant
{
    public partial class DarboLaikas : Form
    {
        public DarboLaikas(int id)
        {
            InitializeComponent();
            label1.Text = id.ToString();
            label1.Visible = false;
            LoadGrid();
        }
        public void convertInt(ref int b)
        {
            string c = label1.Text;
            b = Int32.Parse(c);
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
        public void LoadGrid()
        {
            int a = 0;
            convertInt(ref a);
            SqlCommand cmd = new SqlCommand("Select * from DarboLaikas WHERE DarbuotojoID='" + a + "'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            convertInt(ref a);
            MenuDarbuotojams md = new MenuDarbuotojams(a);
            md.Show();
            this.Hide();
        }
    }
}

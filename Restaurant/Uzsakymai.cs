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
    public partial class Uzsakymai : Form
    {
        public Uzsakymai(int id)
        {
            InitializeComponent();
            LoadGrid();
            label1.Text = id.ToString();
            label1.Visible = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");

        public int ConvertInt()
        {
            string c = label1.Text;
            return Int32.Parse(c);
        }
        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("Select * from Kliento_uzsakymai", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = ConvertInt();

            if (a == 1)
            {
                MenuVadovas mv = new MenuVadovas(a);
                mv.Show();
                this.Hide();
            }
            else
            {
                MenuDarbuotojams md = new MenuDarbuotojams(a);
                md.Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class Rezervacija : Form
    {
        public Rezervacija(int id)
        {
            InitializeComponent();
            label4.Text = id.ToString();
            label4.Visible = false;
        }

        public void convertInt(ref int b)
        {
            string c = label4.Text;
            b = Int32.Parse(c);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
            try
            {
                int f = 0;
                convertInt(ref f);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rezervacija VALUES (@KlientoID, @Laikas, @Vieta, @Adresas)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@KlientoID", f);
                cmd.Parameters.AddWithValue("@Laikas", textBox1.Text);
                cmd.Parameters.AddWithValue("@Vieta", textBox2.Text);
                cmd.Parameters.AddWithValue("@Adresas", textBox3.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uzrezervavo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = 0;
            convertInt(ref d);
            MenuKlientai mk = new MenuKlientai(d);
            mk.Show();
            this.Hide();
        }
    }
}

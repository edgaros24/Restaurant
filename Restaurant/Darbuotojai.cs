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
    public partial class Darbuotojai : Form
    {
        public Darbuotojai()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("Select * from Darbuotojai", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Darbuotojai VALUES (@Vardas, @Pavarde, @TelNumeris, @ElPastas, @PareiguID)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Vardas", textBox2.Text);
            cmd.Parameters.AddWithValue("@Pavarde", textBox3.Text);
            cmd.Parameters.AddWithValue("@TelNumeris", textBox4.Text);
            cmd.Parameters.AddWithValue("@ElPastas", textBox5.Text);
            cmd.Parameters.AddWithValue("@PareiguID", textBox6.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            LoadGrid();
            MessageBox.Show("Sekmingai sukurtas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Darbuotojai set Vardas = '" + textBox2.Text + "', Pavarde = '" + textBox3.Text + "', TelNumeris = '" + textBox4.Text + "', ElPastas = '" + textBox5.Text + "', PareiguID = '" + textBox6.Text + "' WHERE ID = '" + textBox1.Text + "'", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sekmingai atnaujinta", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Neatnaujinta" + ex.Message);
            }
            finally
            {
                con.Close();
                LoadGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Darbuotojai where ID=" + textBox1.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pasalinta sekmingai", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                LoadGrid();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nepasalinta" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuVadovas mv = new MenuVadovas(1);
            mv.Show();
            this.Hide();
        }
    }
}

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
    public partial class Uzsisakyti : Form
    {
        public Uzsisakyti(int id)
        {
            InitializeComponent();
            LoadGridUzkandziai();
            LoadGridSPatiekalai();
            LoadGridKPatiekalai();
            LoadGridGerimai();
            label5.Text = id.ToString();
            label5.Visible = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
        public void LoadGridUzkandziai()  
        {
            SqlCommand cmd = new SqlCommand("Select * from Uzkandziai", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt.DefaultView;
        }
        public void LoadGridSPatiekalai() 
        {
            SqlCommand cmd = new SqlCommand("Select * from SaltiejiPatiekalai", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView2.DataSource = dt.DefaultView;
        }
        public void LoadGridKPatiekalai() 
        {
            SqlCommand cmd = new SqlCommand("Select * from KarstiejiPatiekalai", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView3.DataSource = dt.DefaultView;
        }
        public void LoadGridGerimai() 
        {
            SqlCommand cmd = new SqlCommand("Select * from Gerimas", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView4.DataSource = dt.DefaultView;
        }
        public void convertInt(ref int b)
        {
            string c = label5.Text;
            b = Int32.Parse(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Meniu VALUES (@UzkandziaiID, @KarstiejiPatiekalaiID, @SaltiejiPatiekalaiID, @GerimaiID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UzkandziaiID", textBox1.Text);
                cmd.Parameters.AddWithValue("@KarstiejiPatiekalaiID", textBox3.Text);
                cmd.Parameters.AddWithValue("@SaltiejiPatiekalaiID", textBox2.Text);
                cmd.Parameters.AddWithValue("@GerimaiID", textBox4.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Jusu uzsakymas buvo uzsakytas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(2);
                    int key;
                    if (randomNumber == 0)
                    {
                        key = 3;
                    }
                    else
                    {
                        key = 8;
                    }

                    int g = 0;
                    convertInt(ref g);
                    con.Open();
                    SqlCommand sqlcmd = new SqlCommand("INSERT INTO Kliento_uzsakymai VALUES (@KlientoID, @Kaina, @MeniuID, @KuponoID, @DarbuotojoID)", con);
                    SqlCommand sql = new SqlCommand("SELECT TOP 1 ID FROM Meniu ORDER BY ID DESC", con);
                    int lastRow = (int)sql.ExecuteScalar();
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Parameters.AddWithValue("@KlientoID", g);
                    sqlcmd.Parameters.AddWithValue("@Kaina", "60");
                    sqlcmd.Parameters.AddWithValue("@MeniuID", lastRow);
                    sqlcmd.Parameters.AddWithValue("@KuponoID", 1);
                    sqlcmd.Parameters.AddWithValue("@DarbuotojoID", key);

                    sqlcmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = 0;
            convertInt(ref f);
            MenuKlientai mk = new MenuKlientai(f);
            mk.Show();
            this.Hide();
        }
    }
}

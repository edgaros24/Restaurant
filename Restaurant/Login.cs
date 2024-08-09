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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Klientai WHERE Vardas = '" + txt_name.Text +
                    "' AND Pavarde = '" + txt_lastName.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    SqlCommand sqlCommand = new SqlCommand("SELECT ID FROM Klientai WHERE Vardas = '" + txt_name.Text +
                    "' AND Pavarde = '" + txt_lastName.Text + "'", con);
                    dr.Close();
                    int id = (int)sqlCommand.ExecuteScalar();
                    MenuKlientai mk = new MenuKlientai(id);
                    mk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neteisingas vardas arba pavarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_darbuotojams_Click(object sender, EventArgs e)
        {
            LoginDarbuotojams ld = new LoginDarbuotojams();
            ld.Show();
            this.Hide();
        }
    }
}

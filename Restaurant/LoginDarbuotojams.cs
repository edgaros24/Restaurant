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
    public partial class LoginDarbuotojams : Form
    {
        public LoginDarbuotojams()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Darbuotojai WHERE Vardas = '" + txt_name.Text +
                    "' AND Pavarde = '" + txt_lastName.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    if(dr[5].ToString() == "5")
                    {
                        MenuVadovas mv = new MenuVadovas(1);
                        mv.Show();
                        this.Hide();
                    }
                    else
                    {
                        SqlCommand sqlCommand = new SqlCommand("SELECT ID FROM Darbuotojai WHERE Vardas = '" + txt_name.Text +
                    "' AND Pavarde = '" + txt_lastName.Text + "'", con);
                        dr.Close();
                        int id = (int)sqlCommand.ExecuteScalar();
                        MenuDarbuotojams md = new MenuDarbuotojams(id);
                        md.Show(); ;
                        this.Hide();
                    }
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
    }
}

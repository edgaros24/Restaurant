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
    public partial class AtsiliepimasKlientams : Form
    {
        public AtsiliepimasKlientams(int id)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int d = 0;
            convertInt(ref d);
            MenuKlientai mk = new MenuKlientai(d);
            mk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G3THV3D\MSSQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
            try
            {
                int f = 0;
                convertInt(ref f);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO KlientoAtsiliepimai VALUES (@KlientoID, @VartotojuSkundai, @VartotojuPagyrimai, @Nuomones)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@KlientoID", f);
                    cmd.Parameters.AddWithValue("@VartotojuSkundai", textBox1.Text);
                    cmd.Parameters.AddWithValue("@VartotojuPagyrimai", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Nuomones", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Atsiliepimas buvo publikuotas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

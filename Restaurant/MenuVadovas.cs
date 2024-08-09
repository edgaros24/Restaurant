using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MenuVadovas : Form
    {
        public MenuVadovas(int id)
        {
            InitializeComponent();
            label1.Text = id.ToString();
                label1.Visible = false;
        }

        private void btn_atsijungti_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
        public void convertInt(ref int b)
        {
            string c = label1.Text;
            b = Int32.Parse(c);
        }

        private void btn_atsiliepimai_Click(object sender, EventArgs e)
        {
            int a = 0;
            convertInt(ref a);
            Atsiliepimai at = new Atsiliepimai(a);
            at.Show();
            this.Hide();
        }

        private void btn_uzsisakyti_Click(object sender, EventArgs e)
        {
            int a = 0;
            convertInt(ref a);
            Uzsakymai uz = new Uzsakymai(a);
            uz.Show();
            this.Hide();
        }

        private void btn_uzrezervuoti_Click(object sender, EventArgs e)
        {
            Darbuotojai d = new Darbuotojai();
            d.Show();
            this.Hide();
        }
    }
}

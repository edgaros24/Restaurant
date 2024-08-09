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
    public partial class MenuKlientai : Form
    {
        public MenuKlientai(int id)
        {
            InitializeComponent();
            label1.Text = id.ToString();
            label1.Visible = false;
        }
        public void convertInt(ref int b)
        {
            string c = label1.Text;
            b = Int32.Parse(c);
        }

        private void btn_atsijungti_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_atsiliepimai_Click(object sender, EventArgs e)
        {
            int a = 0;
            convertInt(ref a);
            AtsiliepimasKlientams ak = new AtsiliepimasKlientams(a);
            ak.Show();
            this.Hide();
        }

        private void btn_uzsisakyti_Click(object sender, EventArgs e)
        {
            int a = 0;
            convertInt(ref a);
            Uzsisakyti uz = new Uzsisakyti(a);
            uz.Show();
            this.Hide();
        }

        private void btn_uzrezervuoti_Click(object sender, EventArgs e)
        {
            int a = 0;
            convertInt(ref a);
            Rezervacija rez = new Rezervacija(a);
            rez.Show();
            this.Hide();
        }
    }
}

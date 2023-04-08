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

namespace p1OkulSistemi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p1OkulSistemi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            FormOgrenciDetay frm = new FormOgrenciDetay();
            frm.OgrNumara = maskedTextBox1.Text;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.SkyBlue;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FormOgretmenDetay frm = new FormOgretmenDetay();
                frm.Show();
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

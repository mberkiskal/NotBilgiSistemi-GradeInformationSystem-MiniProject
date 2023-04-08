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
    public partial class FormOgrenciDetay : Form
    {
        public FormOgrenciDetay()
        {
            InitializeComponent();
        }

        public string OgrNumara;
        public string sonuc;
        int sayac = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p1OkulSistemi;Integrated Security=True");

        private void FormOgrenciDetay_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblNumara.Text = OgrNumara;
            

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_Ders where OGRNUMARA=@p1",baglanti);
            cmd.Parameters.AddWithValue("@p1", OgrNumara);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[2].ToString()+" " + reader[3].ToString();
                lblSınav1.Text = reader[4].ToString();
                if (lblSınav1.Text == "")
                {
                    lblSınav1.Font = new Font("Ebrima", 14);
                    lblSınav1.BackColor = Color.Red;
                    lblSınav1.Text = "Notunuz Henüz Girilmedi!";
                }
                else
                {
                    lblSınav1.Text = reader[4].ToString();
                }
                lblSınav2.Text = reader[5].ToString();
                if (lblSınav2.Text == "")
                {
                    lblSınav2.Font = new Font("Ebrima", 14);
                    lblSınav2.BackColor = Color.Red;
                    lblSınav2.Text = "Notunuz Henüz Girilmedi!";
                }
                else
                {
                    lblSınav3.Text = reader[5].ToString();
                }
                lblSınav3.Text = reader[6].ToString();
                if (lblSınav3.Text == "")
                {
                    lblSınav3.Font = new Font("Ebrima", 14);
                    lblSınav3.BackColor = Color.Red;
                    lblSınav3.Text = "Notunuz Henüz Girilmedi!";
                }
                else
                {
                    lblSınav3.Text = reader[6].ToString();
                }
                lblOrtalama.Text = reader[7].ToString();
                if (lblOrtalama.Text == "")
                {
                    lblOrtalama.Font = new Font("Ebrima", 14);
                    lblOrtalama.ForeColor = Color.Red;
                    lblOrtalama.Text = "Ortalamanız Henüz Belirlenmedi!";
                }
                else
                {
                    lblOrtalama.Text = reader[7].ToString();
                }

                sonuc = reader[8].ToString(); 
                if (sonuc== "False") 
                {
                    lblDurum.Text = "Kaldınız!";
                }
                else if(sonuc == "")
                {
                    lblDurum.Font = new Font("Ebrima", 14);
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "Durumunuz Henüz Belirlenmedi";
                }
                else
                {
                    lblDurum.Text = "Geçtiniz!";
                }
            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            if (sayac == 7)
            {   
                lblOrtalama.ForeColor = Color.White;
                lblDurum.ForeColor = Color.White;
            }
            if(sayac == 14) 
            {
                lblDurum.ForeColor= Color.Red;
                lblOrtalama.ForeColor= Color.Red;
                sayac = 0;
            }
        }
    }
}

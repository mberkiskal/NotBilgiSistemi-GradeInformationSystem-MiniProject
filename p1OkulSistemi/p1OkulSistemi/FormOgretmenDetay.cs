using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace p1OkulSistemi
{
    public partial class FormOgretmenDetay : Form
    {
        public FormOgretmenDetay()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p1OkulSistemi;Integrated Security=True");
        
        private void FormOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'p1OkulSistemiDataSet1.Table_Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_DersTableAdapter.Fill(this.p1OkulSistemiDataSet1.Table_Ders);

            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select count(*) from Table_Ders where DURUM='True'", baglanti);
            SqlDataReader dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                lblGeçen.Text = dr[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select count(*) from Table_Ders where DURUM='False'", baglanti);
            SqlDataReader dr2 = cmd4.ExecuteReader();
            while (dr2.Read())
            {
                lblKalan.Text = dr2[0].ToString();
            }
            baglanti.Close();
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Ders (OGRNUMARA, OGRAD, OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            cmd.Parameters.AddWithValue("@p1", mskNumara.Text);
            cmd.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.ExecuteNonQuery();
            baglanti.Open();
            MessageBox.Show("Öğrenci Başarıyla Sisteme Eklendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.table_DersTableAdapter.Fill(this.p1OkulSistemiDataSet1.Table_Ders);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, sınav1, sınav2, sınav3;
            string durum;
            sınav1 = Convert.ToDouble(txtSınav1.Text);
            sınav2 = Convert.ToDouble(txtSınav2.Text);
            sınav3 = Convert.ToDouble(txtSınav3.Text);

            ortalama = (sınav1 + sınav2 + sınav3) / 3.00;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else 
            { 
                durum = "False";
            }
           
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("update Table_Ders set OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4, DURUM=@p5 where OGRNUMARA=@p6", baglanti);
            cmd2.Parameters.AddWithValue("@p1", txtSınav1.Text);
            cmd2.Parameters.AddWithValue("@p2", txtSınav2.Text);
            cmd2.Parameters.AddWithValue("@p3", txtSınav3.Text);
            cmd2.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            cmd2.Parameters.AddWithValue("@p5", durum);
            cmd2.Parameters.AddWithValue("@p6", mskNumara.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.table_DersTableAdapter.Fill(this.p1OkulSistemiDataSet1.Table_Ders);
            baglanti.Close();
        }


    }
}

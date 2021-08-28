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

namespace elemantakipsis.views
{
    public partial class ElemanEkle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6F4RHLL;Initial Catalog=elemantakipprogram;Integrated Security=True");
        public DataTable dt = new DataTable();
        public ElemanEkle()
        {
            InitializeComponent();
        }
        public void gridyenile()
        {
            dt.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("Select " +
                "Kullaniciad,Ad,Soyad,Tel,Isbasitarih,Elemanmaas,Devampuan,Guvenlikpuan,Amirpuan,Kalitepuan,Oneripuan " +
                "from Elemanlar", baglan);
            adapter.Fill(dt);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Form Kapatılacaktır Emin Misiniz ?", "Formu Kapat", MessageBoxButtons.YesNo);
            if (sonuc==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ElemanEkle_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            gridyenile();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand komut = new SqlCommand("Select Kullaniciad from Elemanlar Where Kullaniciad = '"+ txt_sistemad.Text +"'",baglan);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Belirtilen Kullanıcı Adlı Eleman Sistemde Kayıtlı !","Hata Çakışan Kayıt.");
            }
            else
            {
                oku.Close();
                SqlCommand komut2 = new SqlCommand("Insert Into Elemanlar (Kullaniciad,Ad,Soyad,Tel,Isbasitarih,Elemanmaas) values ('"+txt_sistemad.Text+"','"+txt_elemanad.Text+"','"+txt_soyad.Text+"','"+txt_tel.Text+"','"+date_bastarih.Value.ToString("yyyy-MM-dd")+"','"+txt_maas.Text+"')",baglan);
                komut2.ExecuteNonQuery();
                gridyenile();
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string kuladi = dataGridView1.CurrentRow.Cells["Kullaniciad"].Value.ToString();
            DialogResult sonuc = MessageBox.Show(kuladi+" Kullanıcı Adlı Kişi Silinecektir Emin Misiniz ?","Kullanıcı Silme.",MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from Elemanlar where Kullaniciad = '"+kuladi+"'",baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Belirtilen Kullanıcı Silindi !","Başarılı.");
                gridyenile();
            }
        }

        private void txt_sistemad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElemanPerformans elemanperformans = new ElemanPerformans();
            elemanperformans.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ElemanListele elemanlistele = new ElemanListele();
            elemanlistele.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElemanYetkinlik elemanyetkinlik = new ElemanYetkinlik();
            elemanyetkinlik.ShowDialog();
        }
    }
}

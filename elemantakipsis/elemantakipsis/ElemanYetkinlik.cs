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
    public partial class ElemanYetkinlik : Form
    {
        public ElemanYetkinlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElemanEkle elemanekle = new ElemanEkle();
            elemanekle.ShowDialog();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Form Kapatılacaktır Emin Misiniz ?", "Programı Kapat", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElemanPerformans elemanperformans = new ElemanPerformans();
            elemanperformans.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElemanListele elemanlistele = new ElemanListele();
            elemanlistele.ShowDialog();
        }
    }
}

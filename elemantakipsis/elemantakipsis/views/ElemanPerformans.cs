using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elemantakipsis.views
{
    public partial class ElemanPerformans : Form
    {
        public ElemanPerformans()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ElemanPerformans_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            ElemanListele elemanlistele = new ElemanListele();
            elemanlistele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElemanEkle elemanekle = new ElemanEkle();
            elemanekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElemanYetkinlik elemanyetkinlik = new ElemanYetkinlik();
            elemanyetkinlik.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elemantakipsis.views;

namespace elemantakipsis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElemanEkle elemanekle = new ElemanEkle();
            elemanekle.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Program Kapatılacaktır Emin Misiniz ?", "Programı Kapat", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElemanListele elemanlistele = new ElemanListele();
            elemanlistele.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElemanPerformans elemanperformans = new ElemanPerformans();
            elemanperformans.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElemanYetkinlik elemanyetkinlik = new ElemanYetkinlik();
            elemanyetkinlik.ShowDialog();
        }
    }
}

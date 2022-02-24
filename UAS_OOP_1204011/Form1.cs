using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodi newProdi = new prodi();
            newProdi.MdiParent = this;
            newProdi.Show();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mahasiswa newMahasiswa = new mahasiswa();
            newMahasiswa.MdiParent = this;
            newMahasiswa.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaksi newTransaksi = new transaksi();
            newTransaksi.MdiParent = this;
            newTransaksi.Show();
        }

        private void teskoneksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teskoneksi newTes = new teskoneksi();
            newTes.MdiParent = this;
            newTes.Show();
        }

        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewprodi newViewprodi = new viewprodi();
            newViewprodi.MdiParent = this;
            newViewprodi.Show();
        }

        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewmhs newViewmhs = new viewmhs();
            newViewmhs.MdiParent = this;
            newViewmhs.Show();
        }
    }
}

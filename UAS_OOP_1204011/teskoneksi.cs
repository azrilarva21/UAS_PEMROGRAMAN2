using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace UAS_OOP_1204011
{
    public partial class teskoneksi : Form
    {
        MySqlConnection koneksi = new MySqlConnection("Server=localhost;uid=root;password=; database=uaspem;");
        public teskoneksi()
        {
            InitializeComponent();
        }

        public bool dbOpen()
        {
            try
            {
                koneksi.Open();

            }
            catch
            {
                MessageBox.Show("Tidak Terhubung");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbOpen())
            {
                MessageBox.Show("Terhubung");
                koneksi.Close();
            }
        }
    }
}

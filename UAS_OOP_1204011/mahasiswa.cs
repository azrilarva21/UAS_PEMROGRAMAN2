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
    public partial class mahasiswa : Form
    {
        private string url = "server=localhost;userid=root;password=;database=uaspem";
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        private void UpdateDB(string cmd)
        {
            try
            {
                long npm;
                string urutan;
                string connectionString = "integrated security=true; data source=.; initial catalog=uaspem";
                MySqlConnection conn = new MySqlConnection(connectionString);
                Program newprogram = new Program();
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diinput", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public mahasiswa()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT ms_mhsw VALUES('"
                + textBox1.Text + "','"
                + textBox2.Text + "','"
                + comboBox1.Text + "','";
            UpdateDB(myCmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}

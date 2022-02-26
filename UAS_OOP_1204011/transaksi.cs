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
using System.Globalization;

namespace UAS_OOP_1204011
{
    public partial class transaksi : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        void pertama()
        {
            textBox5.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) * 0.5);
            textBox6.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) - double.Parse(textBox5.Text, NumberStyles.Currency));
        }

        void kedua()
        {
            textBox5.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) * 0.25);
            textBox6.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) - double.Parse(textBox5.Text, NumberStyles.Currency));
        }
        void ketiga()
        {
            textBox5.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) * 0.1);
            textBox6.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) - double.Parse(textBox5.Text, NumberStyles.Currency));
        }
        public transaksi()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi");
            }
            else
            {
                string npm = textBox1.Text.Trim();
                double totalbiaya = double.Parse(textBox6.Text, NumberStyles.Currency);
                string grade = string.Empty;
                if (radioButton1.Checked)
                {
                    grade = "A";
                }
                else if (radioButton2.Checked)
                {
                    grade = "B";
                }
                else if (radioButton3.Checked)
                {
                    grade = "C";
                }

                Program database = new Program();
                MySqlConnection conn = database.GetConn();
                cmd = new MySqlCommand("INSERT INTO tr_daftar_ulang (npm, grade, total_biaya) VALUES(@NPM, @Grade, @Total_Biaya)");
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@NPM", npm);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@Total_Biaya", totalbiaya);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Transaksi Daftar Ulang Berhasil");
                clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pertama();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kedua();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ketiga();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Program database = new Program();
                MySqlConnection conn = database.GetConn();
                conn.Open();
                cmd = new MySqlCommand($"select nama_mhs, nama_prodi, biaya_kuliah from ms_mhsw inner join ms_prodi using(kode_prodi) where npm={textBox1.Text}", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    textBox2.Text = rd[0].ToString();
                    textBox3.Text = rd[1].ToString();
                    textBox4.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", rd[2]);
                }
                else
                {
                    MessageBox.Show("NPM TIDAK DITEMUKAN");
                }
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            Program database = new Program();
            MySqlConnection conn = database.GetConn();
            conn.Open();
            cmd = new MySqlCommand($"select nama_mhs, nama_prodi, biaya_kuliah from ms_mhsw inner join ms_prodi using(kode_prodi) where npm={textBox1.Text}", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                textBox2.Text = rd[0].ToString();
                textBox3.Text = rd[1].ToString();
                textBox4.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", rd[2]);


            }
            else
            {
                MessageBox.Show("NPM TIDAK DITEMUKAN");
            }
        }
    }
}

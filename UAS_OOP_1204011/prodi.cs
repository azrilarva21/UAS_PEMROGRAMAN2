using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;


namespace UAS_OOP_1204011
{
    public partial class prodi : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        private string random()
        {
            long prodi;
            string urutan;
            Program database = new Program();
            MySqlConnection conn = database.GetConn();
            conn.Open();
            cmd = new MySqlCommand("select kode_prodi from ms_prodi where kode_prodi in(select max(kode_prodi) from ms_prodi) order by kode_prodi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                prodi = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_prodi"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + prodi;
                urutan = "PRD" + joinstr.Substring(joinstr.Length - 3, 3);

            }
            else
            {
                urutan = "PRD001";
            }
            rd.Close();
            conn.Close();

            return urutan;
        }

        private void clear_textbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
        public prodi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                Program database = new Program();
                MySqlConnection conn = database.GetConn();
                cmd = new MySqlCommand("insert into ms_prodi values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambah");
                clear_textbox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear_textbox();
        }
    }
}

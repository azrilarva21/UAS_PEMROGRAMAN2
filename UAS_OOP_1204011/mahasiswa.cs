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
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

       

        private void get_prodi_list()
        {
            Program database = new Program();
            MySqlDataReader rd;
            MySqlConnection conn = database.GetConn();
            conn.Open();

            cmd = new MySqlCommand("select * from ms_prodi", conn);
            cmd.CommandType = CommandType.Text;
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                comboBox1.Items.Add(rd[0].ToString());

            }
            rd.Close();
            conn.Close();

        }

        private void clear_textbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.ResetText();
        }
        public mahasiswa()
        {
            InitializeComponent();
            get_prodi_list();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                Program database = new Program();
                MySqlConnection conn = database.GetConn();
                cmd = new MySqlCommand("insert into ms_mhsw values('"+ textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Mahasiswa berhasil ditambahkan");
                clear_textbox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.ResetText();
        }
    }
    }

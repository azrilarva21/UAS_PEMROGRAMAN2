using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace UAS_OOP_1204011
{
    class Program
    {
        private string url = "server=localhost;userid=root;password=;database=uaspem";

        public MySqlConnection GetConn()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                return conn;
            }
            catch
            {
                throw new Exception("Database Error");
            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

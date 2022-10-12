using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanhNgot
{
    internal class ConnectData
    {
        public SqlConnection conn;
        public void connect()
        {
            String strCon = @"Data Source=KEIJET\SQLEXPRESS;Initial Catalog=DoAnWinform;Integrated Security=True";

            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Error", MessageBoxButtons.OK);
            }


        }
        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
    }
}

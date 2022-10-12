using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLBanhNgot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            registerEvent();
        }
        #region Event
        void registerEvent()
        {
            lblClose.Click += lblClose_Click;

        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
       
        
        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection Login = new SqlConnection(@"Data Source=KEIJET\SQLEXPRESS;Initial Catalog=DoAnWinform;Integrated Security=True");
                ConnectData c = new ConnectData();
                c.connect();

                Login.Open();
                string tk = txtUser.Text;
                string mk = txtPassword.Text;
                string sql = "Select * from [Login] where UserName = '" + txtUser.Text + "' and Password = '" + txtPassword.Text + "'";

                SqlCommand com = new SqlCommand(sql, Login);
                SqlDataReader dta = com.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");

                    this.Hide();
                    SanPham sp = new SanPham();
                    sp.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();

                }
                c.disconnect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phide_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                peye.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

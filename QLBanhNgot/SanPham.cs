using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanhNgot.Model;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;

namespace QLBanhNgot
{
    public partial class SanPham : Form
    {
        dbLogin Login = new dbLogin();

        public SanPham()
        {
            InitializeComponent();
            registerEvent();
        }

        void registerEvent()
        {

            
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            dbLogin Login = new dbLogin();
            
            

          

        }

        private void FillDataDGV(List<SanPham> listSanPham)
        {
            throw new NotImplementedException();
        }

        private void pictureThem_Click(object sender, EventArgs e)
        {
            Themsanpham add = new Themsanpham();
            add.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

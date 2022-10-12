using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanhNgot
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            registerEvent();
        }

        void registerEvent()
        {

            pictureThem.Click += pictureThem_Click;
        }

        private void pictureThem_Click(object sender, EventArgs e)
        {
            Themsanpham add = new Themsanpham();
            add.Show();
        }


    }
}

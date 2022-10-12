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
    public partial class Themsanpham : Form
    {
        public Themsanpham()
        {
            InitializeComponent();
            registerEvent();
        }
        void registerEvent()
        {
            lblXoa.Click += lblXoa_Click;
        }

        private void lblXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

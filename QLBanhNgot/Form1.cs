using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//QlQanhngot
namespace QLBanhNgot
{
    public partial class Form1 : Form
    {
        public Form1()
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
            SanPham sp = new SanPham();
            sp.Show();
        }


    }
}

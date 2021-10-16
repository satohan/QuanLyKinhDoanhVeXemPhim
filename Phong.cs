using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmemquanlibanve
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
           thanhtoan tt = new thanhtoan();
            tt.MdiParent = Nhanvien.ActiveForm;
           tt.Show();
        }

        private void btnquaylai1_Click(object sender, EventArgs e)
        {
            timphim tp = new timphim();
            tp.MdiParent = Nhanvien.ActiveForm;
            tp.Show();
        }
    }
}

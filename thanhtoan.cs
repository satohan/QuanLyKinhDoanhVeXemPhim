﻿using System;
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
    public partial class thanhtoan : Form
    {
        public thanhtoan()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnquaylai2_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.MdiParent = Nhanvien.ActiveForm;
            p.Show();
        }
    }
}

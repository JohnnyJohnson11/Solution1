﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Form
{
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perusahaan halamanPerusahaan = new Perusahaan();
            halamanPerusahaan.Show();
            this.Hide();
        }
    }
}
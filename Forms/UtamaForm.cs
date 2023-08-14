﻿using sekolahku_jude.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolahku_jude
{
    public partial class UtamaForm : Form
    {
        public UtamaForm()
        {
            InitializeComponent();
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            var form = new GuruForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            var form = new MapelForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
        }
    }
}

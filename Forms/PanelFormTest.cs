using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolahku_jude.Forms
{
    public partial class PanelFormTest : Form
    {
        public PanelFormTest()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideAll();
            panel2.Visible = true;
        }

        private void HideAll()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAll();
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAll();
            panel3.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideAll();
            panel2.Visible = true;
        }
    }
}

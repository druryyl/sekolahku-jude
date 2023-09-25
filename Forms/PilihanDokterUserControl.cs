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
    public partial class PilihanDokterUserControl : UserControl
    {
        public string DokterName { get => DokterLabel.Text; set => DokterLabel.Text = value; }
        public string Spesialis { get => SpesialisLabel.Text; set => SpesialisLabel.Text = value; }
        public bool IsPilih { get => PIlihCheckbox.Checked; set => PIlihCheckbox.Checked = value; }

        public PilihanDokterUserControl()
        {
            InitializeComponent();
        }
    }
}

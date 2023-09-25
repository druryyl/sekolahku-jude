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
    public partial class JadwalUserControl : UserControl
    {
        private DateTime _tgl;
        private int _umum;
        private int _bpjs;
        
        public DateTime Tgl 
        { 
            get => _tgl;
            set
            {
                _tgl = value;
                TglLabel.Text = _tgl.ToString("ddd, dd MMM yyyy");
            }
        }
        public int Umum
        {
            get => _umum;
            set
            {
                _umum = value;
                UmumLabel.Text = _umum.ToString();
            }
        }
        public int Bpjs
        {
            get => _bpjs;
            set
            {
                _bpjs = value;
                BpjsLabel.Text = _bpjs.ToString();
            }
        }

        public bool IsPilih { get => PIlihCheckbox.Checked; set => PIlihCheckbox.Checked = value; }


        public JadwalUserControl()
        {
            InitializeComponent();
        }
    }
}

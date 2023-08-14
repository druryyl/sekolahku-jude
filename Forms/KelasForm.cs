using sekolahku_jude.DataAkses;
using sekolahku_jude.Models;
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
    public partial class KelasForm : Form
    {
        private readonly KelasDal _kelasDal;
        private readonly GuruDal _guruDal;

        public KelasForm()
        {
            InitializeComponent();
            _kelasDal = new KelasDal();
            _guruDal = new GuruDal();
            RefreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var kelas = new KelasModel
            {
                KelasId = textBox1.Text,
                KelasName = textBox2.Text,
                WaliKelasId = textBox3.Text
            };

            if (kelas.KelasId.Length == 0)
            {
                MessageBox.Show("Kode Kelas kosong");
                return;
            }
            if (kelas.KelasId.Length > 3)
            {
                MessageBox.Show("Kode Kelas terlalu panjang");
                return;
            }

            if (kelas.KelasName.Length == 0)
            {
                MessageBox.Show("Nama Kelas kosong");
                return;
            }
            if (kelas.KelasName.Length > 15)
            {
                MessageBox.Show("Nama Kelas terlalu panjang");
                return;
            }

            var guru = _guruDal.GetData(kelas.WaliKelasId);
            if (guru is null)
            {
                MessageBox.Show("Kode Walikelas invalid");
                return;
            }

            var kelasDb = _kelasDal.GetData(textBox1.Text);
            if (kelasDb is null)
                _kelasDal.Insert(kelas);
            else
                _kelasDal.Update(kelas);

            ClearForm();
            RefreshGrid();
        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            var binding = new BindingSource();
            var listData = _kelasDal.ListData()?.ToList() ?? new List<KelasModel>();

            binding.DataSource = listData.Select(x => new {x.KelasId, x.KelasName}).ToList();
            dataGridView1.DataSource = binding;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listGuru = _guruDal.ListData()?.ToList() ?? new List<GuruModel>();
            var browser = new BrowseData<GuruModel>(listGuru);
            var resultDialog = browser.ShowDialog();
            if (resultDialog == DialogResult.OK)
            {
                textBox3.Text = browser.ResultValue;
                textBox3_Validated(sender, e);
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            var guru = _guruDal.GetData(textBox3.Text);
            if (guru is null)
                textBox4.Text = string.Empty;
            else
                textBox4.Text = guru.GuruName;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            var kelas = _kelasDal.GetData(txt.Text);
            if (kelas is null)
                return;

            textBox2.Text = kelas.KelasName;
            textBox3.Text = kelas.WaliKelasId;
            textBox4.Text = kelas.WaliKelasName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _kelasDal.Delete(textBox1.Text);
                ClearForm();
                RefreshGrid();
            }

        }
    }
}

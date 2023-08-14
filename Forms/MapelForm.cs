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
    public partial class MapelForm : Form
    {
        private readonly MapelDal _mapelDal;

        public MapelForm()
        {
            InitializeComponent();
            _mapelDal = new MapelDal();
            
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var list = _mapelDal.ListData()?.ToList() ?? new List<MapelModel>();
            var binding = new BindingSource();
            binding.DataSource = list;
            dataGridView1.DataSource = binding;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var mapelId = textBox1.Text;
            _mapelDal.Delete(mapelId);
            ClearForm();
            RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Kode Mapel kosong");
                return;
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Nama Mapel kosong");
                return;
            }
            var newMapel = new MapelModel
            {
                MapelId = textBox1.Text,
                MapelName = textBox2.Text,
            };

            var mapelDb = _mapelDal.GetData(textBox1.Text);
            if (mapelDb == null)
                _mapelDal.Insert(newMapel);
            else
                _mapelDal.Update(newMapel);

            ClearForm();
            RefreshGrid();
        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var mapelId = grid.CurrentRow.Cells["MapelId"].Value.ToString();
            var mapel = _mapelDal.GetData(mapelId);
            if (mapel == null)
            {
                ClearForm();
                return;
            }
            textBox1.Text = mapel.MapelId;
            textBox2.Text = mapel.MapelName;
        }
    }
}

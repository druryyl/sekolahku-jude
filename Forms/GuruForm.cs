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
    public partial class GuruForm : Form
    {
        private GuruDal _guruDal;
        public GuruForm()
        {
            InitializeComponent();
            _guruDal = new GuruDal();
            ListDataGuru();
        }

        private void ListDataGuru()
        {
            var listGuru = _guruDal.ListData().ToList();
            var binding = new BindingSource();
            binding.DataSource = listGuru;
            dataGridView1.DataSource = binding;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //var grid = (DataGridView)sender;
            //if (grid.CurrentRow is null)
            //    return;
            //var guruId = grid.CurrentRow.Cells["GuruId"].Value.ToString();
            //var guru = _guruDal.GetData(guruId);
            //if (guru is null)
            //    return;
            //textBox1.Text = guru.GuruId;
            //textBox2.Text = guru.GuruName;

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("ID Guru tidak boleh kosong");
                return;
            }

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Nama Guru tidak boleh kosong");
                return;
            }

            if (textBox1.Text.Length > 3)
            {
                MessageBox.Show("ID Guru maximal 3 digit");
                return;
            }
            if (textBox2.Text.Length > 30)
            {
                MessageBox.Show("Nama Guru maximal 30 huruf");
                return;
            }


            var guru = new GuruModel
            {
                GuruId = textBox1.Text,
                GuruName = textBox2.Text
            };
            var guruDb = _guruDal.GetData(guru.GuruId);
            if (guruDb is null)
                _guruDal.Insert(guru);
            else
                _guruDal.Update(guru);

            ClearForm();
            ListDataGuru();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.CurrentRow is null)
                return;
            var guruId = grid.CurrentRow.Cells["GuruId"].Value.ToString();
            var guru = _guruDal.GetData(guruId);
            if (guru is null)
                return;
            textBox1.Text = guru.GuruId;
            textBox2.Text = guru.GuruName;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow is null)
                return;
            var guruId = dataGridView1.CurrentRow.Cells["GuruId"].Value.ToString();
            var guru = _guruDal.GetData(guruId);
            if (guru is null)
                return;

            if (MessageBox.Show($"Hapus data {guru.GuruName}?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                _guruDal.Delete(guru.GuruId);

            ClearForm();
            ListDataGuru();
        }
    }
}

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
    public partial class BrowseData<T> : Form
    {
        public string ResultValue { get; private set; }
        public BrowseData(IEnumerable<T> listData)
        {
            InitializeComponent();
            var binding = new BindingSource();
            binding.DataSource = listData.ToList();
            dataGridView1.DataSource = binding;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            ResultValue = grid.CurrentRow.Cells[0].Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void BrowseData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }
    }
}

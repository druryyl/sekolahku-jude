//using sekolahku_jude.DataAkses;
//using sekolahku_jude.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace sekolahku_jude.Forms
//{
//    public partial class JadwalForm : Form
//    {
//        private readonly KelasDal _kelasDal;
//        private readonly MapelDal _mapelDal;
//        private readonly JadwalDal _jadwalDal;
        
//        private BindingList<JadwalMapelDto> _listMapel;

//        public JadwalForm()
//        {
//            InitializeComponent();
//            _kelasDal = new KelasDal();
//            _mapelDal = new MapelDal();
//            _jadwalDal = new JadwalDal();

//            InitKelasGrid();
//            InitJadwalGrid();
//            InitHariCombo();
//            RegisterEventHandler();
//        }


//        private void RegisterEventHandler()
//        {
//            KelasGrid.CellDoubleClick+= KelasGrid_CellDoubleClick;
//            JadwalGrid.CellValidated += JadwalGrid_CellValidated;
//            KelasIdText.Validated += KelasIdText_Validated;
//            HariCombo.SelectedIndexChanged += HariCombo_SelectedIndexChanged;

//            SaveButton.Click += SaveButton_Click;
//            NewButton.Click += NewButton_Click;
//        }

//        private void NewButton_Click(object sender, EventArgs e)
//        {
//            KelasIdText.Text = string.Empty;
//            KelasNameText.Text = string.Empty;
//            HariCombo.SelectedIndex = 0;
//            _listMapel.Clear();
//            LoadJawal();

//        }

//        #region GRID-KELAS
//        private void InitKelasGrid()
//        {
//            var listKelas = _kelasDal.ListData().ToList();
//            var dataSource = (
//                from c in listKelas
//                select new
//                {
//                    Id = c.KelasId,
//                    Name = c.KelasName
//                }).ToList();
//            KelasGrid.DataSource = dataSource;
//            KelasGrid.DefaultCellStyle.BackColor = Color.AliceBlue;

//            KelasGrid.Columns["Id"].ReadOnly = true;
//            KelasGrid.Columns["Id"].Width = 50;
//            KelasGrid.Columns["Name"].ReadOnly = true;
//            KelasGrid.Columns["Name"].Width = 100;
//        }
//        private void KelasGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (KelasGrid.CurrentRow is null)
//                return;

//            var kelasId = KelasGrid.CurrentRow.Cells["Id"].Value.ToString();
//            var kelasName = KelasGrid.CurrentRow.Cells["Name"].Value.ToString();


//            KelasIdText.Text = kelasId;
//            KelasNameText.Text = kelasName;

//            _listMapel.Clear();
//            JadwalGrid.Refresh();
//            LoadJawal();
//        }
//        #endregion

//        #region HEADER-JADWAL
//        private void HariCombo_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            _listMapel.Clear();
//            JadwalGrid.Refresh();
//            LoadJawal();
//        }

//        private void KelasIdText_Validated(object sender, EventArgs e)
//        {
//            _listMapel.Clear();
//            JadwalGrid.Refresh();
//            LoadJawal();
//        }

//        private void InitHariCombo()
//        {
//            var listHari = new List<string>
//            {
//                "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"
//            };
//            HariCombo.DataSource = listHari;
//        }

//        private void LoadJawal()
//        {
//            var kelas = KelasIdText.Text;
//            var hari = HariCombo.SelectedItem.ToString();

//            var listMapel = _jadwalDal.ListData(kelas, hari);
//            if (listMapel is null)
//                return;

//            foreach (var item in listMapel)
//            {
//                _listMapel.Add(new JadwalMapelDto
//                {
//                    JamMulai = item.JamMulai,
//                    JamSelesai = item.JamSelesai,
//                    MapelId = item.MapelId,
//                    MapelName = item.MapelName,
//                });
//            }
//            JadwalGrid.Refresh();

//        }
//        #endregion

//        #region GRID-JADWAL
//        private void InitJadwalGrid()
//        {
//            _listMapel = new BindingList<JadwalMapelDto>();
//            var binding = new BindingSource();
//            binding.DataSource = _listMapel;
//            JadwalGrid.DataSource = binding;

//            JadwalGrid.Columns["JamMulai"].Width = 50;
//            JadwalGrid.Columns["JamMulai"].HeaderText = "Mulai";

//            JadwalGrid.Columns["JamSelesai"].Width = 50;
//            JadwalGrid.Columns["JamSelesai"].HeaderText = "Selesai";

//            JadwalGrid.Columns["MapelId"].Width = 40;
//            JadwalGrid.Columns["MapelId"].HeaderText = "ID";

//            JadwalGrid.Columns["MapelName"].Width = 150;
//            JadwalGrid.Columns["MapelName"].HeaderText = "Nama Mata Pelajaran";
//            JadwalGrid.Columns["MapelName"].ReadOnly = true;
//            JadwalGrid.Columns["MapelName"].DefaultCellStyle.BackColor = Color.Beige;
//        }

//        private void JadwalGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
//        {
//            var grid = (DataGridView)sender;
//            if(grid.CurrentCell.ColumnIndex == grid.Columns["MapelId"].Index)
//            {
//                var mapelId = grid?.CurrentCell?.Value?.ToString() ?? string.Empty;
//                var mapel = _mapelDal.GetData(mapelId);
//                if (mapel != null)
//                {
//                    _listMapel[e.RowIndex].MapelName = mapel.MapelName;
//                    JadwalGrid.Refresh();
//                }
//            }
//            else
//                _listMapel[e.RowIndex].MapelName = string.Empty;
//        }
//        #endregion

//        #region SAVE
//        private void SaveButton_Click(object sender, EventArgs e)
//        {
//            var kelas = KelasIdText.Text;
//            var hari = HariCombo.SelectedItem.ToString();
//            if (KelasNameText.Text == string.Empty)
//            {
//                MessageBox.Show("'KELAS ID' tidak benar");
//                return;
//            }
//            if (HariCombo.Text == string.Empty)
//            {
//                MessageBox.Show("'HARI' tidak benar");
//                return;
//            }


//            _jadwalDal.Delete(kelas, hari);
//            foreach (var item in _listMapel)
//            {
//                var jadwal = new JadwalModel
//                {
//                    KelasId = kelas,
//                    Hari = hari,
//                    JamMulai = item.JamMulai,
//                    JamSelesai = item.JamSelesai,
//                    MapelId = item.MapelId,
//                };
//                _jadwalDal.Insert(jadwal);
//            }
//            MessageBox.Show("Save berhasil");

//        }
//        #endregion
//    }

//    public class JadwalMapelDto
//    {
//        public string JamMulai { get; set; }
//        public string JamSelesai { get; set; }
//        public string MapelId { get; set; }
//        public string MapelName { get; set; }

//    }
//}

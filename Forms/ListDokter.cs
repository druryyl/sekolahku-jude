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
    public partial class ListDokter : Form
    {
        public ListDokter()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listDokter = new List<DokterModel>
            {
                new DokterModel("D1", "Agus Budiman, Sp.OG", "Spesialis Kandungan"),
                new DokterModel("D2", "Budi Cahyadi, Sp.OG", "Spesialis Kandungan"),
                new DokterModel("D3", "Candra Darusman, Sp.B", "Spesialis Bedah"),
                new DokterModel("D4", "Detty Eryani, Sp.OG", "Spesialis Kandungan"),
                new DokterModel("D5", "Fatimah Gunadi, Sp.A", "Spesialis Anak"),
                new DokterModel("D6", "Gina Harjunawati, Sp.KK", "Spesialis Kulit-Kelamin"),
                new DokterModel("D7", "Hendra Ibrahim, Sp.THT", "Spesialis THT"),
                new DokterModel("D8", "Inge Jesica, Sp.B", "Spesialis Bedah"),
                new DokterModel("D9", "Jusuf Muhammad, Sp.A", "Spesialis Anak"),
                new DokterModel("D10", "Kolonel Lelono, dr", "Dokter Umum"),
            };
            foreach(var item in listDokter)
            {
                var dokter = new PilihanDokterUserControl();
                dokter.DokterName = item.DokterName;
                dokter.Spesialis = item.Spesialisasi;
                dokter.Visible = true;
                ListDokterFlowPanel.Controls.Add(dokter);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listJadwal = new List<JadwalModel>
            {
                new JadwalModel("Dr.Agus", new DateTime(2023,9,26), 7,3),
                new JadwalModel("Dr.Agus", new DateTime(2023,9,28), 8,2),
                new JadwalModel("Dr.Agus", new DateTime(2023,9,30), 9,1),
            };

            //  list hari senin - sabtu;
            var skrg = DateTime.Now;
            var listTgl = new List<DateTime>();
            for(var i = 1; i <= 7; i++)
            {
                listTgl.Add(skrg.AddDays(i));
            }

            foreach(var tgl in listTgl.OrderBy(x => x.DayOfWeek))
            {
                if (tgl.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                var data = listJadwal.FirstOrDefault(x => x.Tgl.Date == tgl.Date);
                var newControl = new JadwalUserControl
                {
                    Tgl = tgl,
                    Bpjs = data?.Bpjs ?? 0,
                    Umum = data?.Umum ?? 0,
                    Visible = true,
                };

                JadwalFlowPanel.Controls.Add(newControl);
            }
        }
    }

    public class JadwalModel
    {

        public string DokterName { get; set; }

        public JadwalModel(string dokterName, DateTime tgl, int umum, int bpjs)
        {
            DokterName = dokterName;
            Tgl = tgl;
            Umum = umum;
            Bpjs = bpjs;
        }

        public DateTime Tgl { get; set; }
        public int Umum { get; set; }
        public int Bpjs{ get; set; }
    }

    public class DokterModel
    {
        public DokterModel(string dokterId, string dokterName, string spesialisasi)
        {
            DokterId = dokterId;
            DokterName = dokterName;
            Spesialisasi = spesialisasi;
        }
        public string DokterId { get; set; }
        public string DokterName { get; set; }
        public string Spesialisasi { get; set; }
    }
}

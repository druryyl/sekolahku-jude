using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolahku_jude.DesignFormAskep
{
    public partial class ImplementasiForm : Form
    {
        public ImplementasiForm()
        {
            InitializeComponent();

            var listRefelection = new List<ReflectionModel>
            {
                new ReflectionModel("","GCS", ""),
                new ReflectionModel("CC000B","    GCS Score", "8"),
                new ReflectionModel("CC000C","    GCS - Eye	4", "Response Normal"),
                new ReflectionModel("CC000D","    GCS - Motor", "2 Gerak Jari Tangan-Kaki"),
                new ReflectionModel("CC000E","    GCS - Verbal", "2 Rintihan"),
                new ReflectionModel("CC000F","    Tingkat Kesadaran", "Delirium"),
                new ReflectionModel("","Keadaan Umum", ""),
                new ReflectionModel("CC0287","    Keadaan Umum", "Sakit Ringan"),
                new ReflectionModel("CC02CA","    Kebutuhan Penerjemah Saat Edukasi", "Ya"),
                new ReflectionModel("CC0245","    Hambatan Komunikasi", "Ya"),
                new ReflectionModel("CC02E2","    Luka Anak", "Ada"),
                new ReflectionModel("CC004E","    Expresi Wajah	1", "Kadang Meringis"),
                new ReflectionModel("CC004F","    Kaki	2", "Menendang-nendang"),
                new ReflectionModel("","Imunisasi", ""),
                new ReflectionModel("CC0065","    Imunisasi HB-3 (Hepatitis)", "Ya"),
                new ReflectionModel("","Tanda Vital", ""),
                new ReflectionModel("CC0001","    Sistole", "100"),
                new ReflectionModel("CC0002","    Diastole", "100"),
                new ReflectionModel("CC0003","    Body Temperature", "38"),
                new ReflectionModel("CC0004","    Heart Rate", "100"),
                new ReflectionModel("CC0005","    Respiratory Rate", "100"),
                new ReflectionModel("CC0006","    SpO2", "100"),
            };
            ReflectionGrid.DataSource = listRefelection;
            HideAll();
            TimeboxPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAll();
            TimeboxPanel.Visible = true;
        }

        private void HideAll()
        {
            ReflectionPanel.Visible = false;
            ReflectionPanel.Location = new Point(6,30);
            TimeboxPanel.Visible = false;
            TimeboxPanel.Location = new Point(6, 30);
            InsightPanel.Visible = false;
            InsightPanel.Location = new Point(6, 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAll();
            ReflectionPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAll();
            InsightPanel.Visible = true;
        }
    }

    public class ReflectionModel
    {
        public ReflectionModel(string id, string concept, string value)
        {
            //Id = id;
            Concept = concept;
            Value = value;
        }
        //public string Id { get; set; }
        public string Concept { get; set; }
        public string Value { get; set; }
        public bool Attach { get; set; }
    }

    //public class 
}

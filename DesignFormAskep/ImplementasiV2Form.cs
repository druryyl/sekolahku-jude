using AutoMapper;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace sekolahku_jude.DesignFormAskep
{
    public partial class ImplementasiV2Form : Form
    {
        public ImplementasiV2Form()
        {
            InitializeComponent();
            InitInsightGrid();
            InitTindakanGrid();
            HideAll();
            TimeboxPanel.Visible = true;
            InsightGrid.QueryCellStyleInfo += InsightGrid_QueryCellStyleInfo; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HideAll();
            TimeboxPanel.Visible = true;
        }

        private void HideAll()
        {
            TimeboxPanel.Visible = false;
            TimeboxPanel.Location = new Point(6,35);
            InsightGrid.Visible = false;
            InsightGrid.Location = new Point(6, 35);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAll();
            InsightGrid.Visible = true;
        }

        private void InitInsightGrid()
        {
            var list = new List<InsightModel>
            {
                new InsightModel("Vital Sign", "TimeBox", "3 Okt", "4 Okt", "5 Okt", "6 Okt", "7 Okt"),
                new InsightModel("Vital Sign", "Sistole", "80", "85", "85", "90", "95"),
                new InsightModel("Vital Sign", "Diastole", "120", "130", "128", "130", "135"),
                new InsightModel("Vital Sign", "Heart Rate", "30 bpm", "28 bpm", "30 bpm", "35 bpm", "30 bpm"),
                new InsightModel("Vital Sign", "Respiration Rate", "40 /min", "45 /min", "41 /min", "35 /min", "30 /min"),
                new InsightModel("Vital Sign", "Body Temp", "36⁰C", "36.5⁰C", "36⁰C", "36⁰C", "37⁰C"),

                new InsightModel("GCS", "TimeBox", "3 Okt 06:00", "3 Okt 12:00", "3 Okt 18:00", "4 Okt 00:00", "4 Okt 06:00"),
                new InsightModel("GCS", "Score", "4", "5", "5", "5", "5"),
                new InsightModel("GCS", "Eye", "No Response", "No Response","Sentuhan", "Sentuhan", "Suara"),
                new InsightModel("GCS", "Motor", "Diam", "Diam", "Gerak Jari", "Gerak Jari", "Respons Sakit"),
                new InsightModel("GCS", "Verbal", "Diam", "Rintih", "Bergumam", "Bergumam", "Menjawab Pertanyaan"),

                new InsightModel("PQRST Pain Scale", "TimeBox", "3 Okt", "4 Okt", "5 Okt", "6 Okt", "7 Okt"),
                new InsightModel("PQRST Pain Scale", "P (Penyebab)","Aktifitas","","","Batuk",""),
                new InsightModel("PQRST Pain Scale", "Q (Kualitas)","Panas","","","",""),
                new InsightModel("PQRST Pain Scale", "R (Penyebaran)","Kepala, Perut","","","",""),
                new InsightModel("PQRST Pain Scale", "S (Keparahan)","Ringan","","","",""),
                new InsightModel("PQRST Pain Scale", "T (Waktu)","Kadang2","","","",""),

                new InsightModel("Humpty DUmpty", "Humpty Dumpty Scale Score","6 Okt", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Usia","Umur Kurang 3th", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Gender","Perempuan", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Diagnosis","Perubahan Oksigenasi", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Gangguan Kognitif","Lupa Keterbatasan", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Faktor Lingkungan","Pakai Alat Bantu Jalan", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Bedah Anestes","Kurang 24 Jam", "", "", "", ""),
                new InsightModel("Humpty DUmpty", "Penggunaan Medika Mentosa","Bermacam Obat Sedative", "", "", "", ""),
            };

            InsightGrid.DataSource = list;
            InsightGrid.ShowGroupDropArea = true;
            InsightGrid.TableDescriptor.AllowNew = false;
            InsightGrid.TableDescriptor.AllowEdit = false;
            InsightGrid.FilterRuntimeProperties = true;
        }

        private void InitTindakanGrid()
        {
            var list = new List<TindakanModel>
            {
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Periksa kemampuan untuk disapih (meliputi hemodinamik stabil, kondisi optimal, bebas infeksi)"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Monitor prediktor kemampuan untuk mentolerir penyapihan (mis. tingkat kemampuan bernapas, kapasistas vital, Vd/Vt, MW, kekuatan inspirasi, FEV1, tekanan inspirasi negatif)"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Monitor tanda-tanda kelelahan otot pemapasan (mis. kenaikan PaCOz mendadak, napas cepat dan dangkal, gerakan dinding abdomen paradoks), hipoksemia, dan hipoksia jaringan saat penyapihan"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Monitor status cairan dan elektorlit"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Posisikan pasien semi Fowler (30 - 45 derajat)"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Lakukan pengisapan jalan napas, jika perlu"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Berikan fisioterapi dada, jika perlu"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Lakukan uji coba penyapihan (30 - 120 menit dengan napas spontan yang dibantu ventilator)"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Gunakan teknik relaksasi, jika perlu"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Hindari pemberian sedasi farmakologis selama percobaan penyapihan"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Berikan dukungan psikologis"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Ajarkan cara pengontrolan napas saat penyapihan"),
                new TindakanModel("Penyapihan Ventilasi Mekanik", "Kolaborasi pemberian obat yang meningkatkan kepatenan jalan napas dan pertukaran gas"),
            };
            TindakanGrid.DataSource = list;
            TindakanGrid.Columns["Intervensi"].Visible = false;
            TindakanGrid.Columns["Tindakan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            TindakanGrid.Columns["Tindakan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            TindakanGrid.Columns["Tindakan"].Width = 250;
            TindakanGrid.Columns["IsPilih"].Width = 40;

            TindakanGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TindakanGrid.AutoResizeRows();
            TindakanGrid.RowHeadersVisible = false;

        }

        private void InsightGrid_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.TableCellType == Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellType.GroupCaptionCell)
            {
                e.Style.Themed = false;
                e.Style.BackColor = Color.Pink;
            }
        }

        private void ImplementasiV2Form_Load(object sender, EventArgs e)
        {

        }

        private void RenpraPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class InsightModel
    {
        public InsightModel(string insight, string concept, string tgl1, string tgl2, string tgl3, string tgl4, string tgl5)
        {
            InsightName = insight;
            ConceptName = concept;
            T1 = tgl1;
            T2 = tgl2;
            T3 = tgl3;
            T4 = tgl4;
            T5 = tgl5;
        }
        
        public string InsightName { get; set; }
        public string ConceptName { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
        public string T5 { get; set; }
    }

    public class IntervensiModel
    {
        public IntervensiModel(string intervensi, int count)
        {
            Intervensi = intervensi;
            JumImplementasi = count;
        }
        public string Intervensi { get; set; }
        public int JumImplementasi { get; set; }
    }

    public class TindakanModel
    {
        public TindakanModel(string intervensi, string tdk)
        {
            Intervensi = intervensi;
            Tindakan = tdk;
        }
        public string Intervensi { get; set; }
        public string Tindakan { get; set; }
        public bool IsPilih { get; set; }
    }
}

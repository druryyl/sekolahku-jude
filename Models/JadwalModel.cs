using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekolahku_jude.Models
{
    public class JadwalModel
    {
        public string KelasId { get; set; }
        public string KelasName { get; set; }
        public string Hari { get; set; }
        public string JamMulai { get; set; }
        public string JamSelesai { get; set; }
        public string MapelId { get; set; }
        public string MapelName { get; set; }
    }
}

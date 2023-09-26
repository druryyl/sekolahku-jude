using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekolahku_jude.Models
{
    public class NilaiSiswaModel
    {
        public string SiswaId { get; set; } 
        public string SiswaName { get; set; }
        public string KelasId { get; set; }
        public string KelasName { get; set; }
        public string MapelId { get; set; }
        public string MapelName { get; set; }
        public decimal Nilai { get; set; }
    }
}

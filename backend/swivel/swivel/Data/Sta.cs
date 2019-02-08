using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Sta
    {
        public int Ref { get; set; }
        public string Labno { get; set; }
        public string Status { get; set; }
        public DateTime? Stime { get; set; }
        public string Station { get; set; }
        public decimal? Lon { get; set; }
        public decimal? Lat { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

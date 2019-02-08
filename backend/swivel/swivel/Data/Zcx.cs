using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Zcx
    {
        public int Ref { get; set; }
        public string Fmtable { get; set; }
        public string Fmkey { get; set; }
        public string Totable { get; set; }
        public string Tokey { get; set; }
        public string Tosite { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

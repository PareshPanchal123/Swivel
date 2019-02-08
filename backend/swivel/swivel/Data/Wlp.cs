using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Wlp
    {
        public int Ref { get; set; }
        public string Liner { get; set; }
        public string Port { get; set; }
        public string Wdesc { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

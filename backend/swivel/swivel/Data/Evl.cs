using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Evl
    {
        public int Ref { get; set; }
        public string Site { get; set; }
        public string Module { get; set; }
        public string Housebill { get; set; }
        public string Event { get; set; }
        public DateTime Edate { get; set; }
        public string Etime { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

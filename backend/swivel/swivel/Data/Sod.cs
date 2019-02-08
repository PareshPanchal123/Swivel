using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Sod
    {
        public int Ref { get; set; }
        public string Type { get; set; }
        public int? Seq { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Trm
    {
        public string Code { get; set; }
        public string Tdesc { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

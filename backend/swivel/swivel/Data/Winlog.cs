using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Winlog
    {
        public int Ref { get; set; }
        public string Oper { get; set; }
        public string Cont { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public DateTime? Crtdate { get; set; }
        public DateTime Upddate { get; set; }
        public string Errdesc { get; set; }
        public int? Retry { get; set; }
    }
}

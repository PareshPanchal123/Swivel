using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Ftplog
    {
        public int Ref { get; set; }
        public string Filename { get; set; }
        public DateTime? Downloadtime { get; set; }
        public string Etype { get; set; }
        public string Mawb { get; set; }
    }
}

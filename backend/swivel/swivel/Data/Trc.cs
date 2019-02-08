using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Trc
    {
        public int Ref { get; set; }
        public string Tradecode { get; set; }
        public string Country { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

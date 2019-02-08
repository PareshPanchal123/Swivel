using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Bas
    {
        public string Code { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Type { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public decimal? Factor { get; set; }
        public bool? Perunit { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Brd
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

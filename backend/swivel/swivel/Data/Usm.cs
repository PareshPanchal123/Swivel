using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Usm
    {
        public int Ref { get; set; }
        public string Usrname { get; set; }
        public string Usalesman { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

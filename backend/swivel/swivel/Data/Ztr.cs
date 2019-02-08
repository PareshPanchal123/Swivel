using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Ztr
    {
        public int Ref { get; set; }
        public string Tfrom { get; set; }
        public string Tto { get; set; }
        public string Tchin { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
        public string Program { get; set; }
        public string Japanese { get; set; }
    }
}

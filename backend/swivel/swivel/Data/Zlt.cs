using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Zlt
    {
        public int Ref { get; set; }
        public string Ltype { get; set; }
        public string Prg { get; set; }
        public string Pdesc { get; set; }
        public string Dbf { get; set; }
        public string Sql { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Error { get; set; }
        public string Emessage { get; set; }
        public string Mkey { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Word { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
    }
}

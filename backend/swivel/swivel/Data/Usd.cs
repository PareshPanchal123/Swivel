using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Usd
    {
        public int Ref { get; set; }
        public string Usrname { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Ldte { get; set; }
        public bool? Success { get; set; }
        public string Ip { get; set; }
        public string Remark { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
    }
}

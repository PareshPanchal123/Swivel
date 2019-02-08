using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Zyl
    {
        public int Ref { get; set; }
        public int Zyh { get; set; }
        public int? Zyd { get; set; }
        public int? Zyl1 { get; set; }
        public DateTime? Fstart { get; set; }
        public DateTime? Fend { get; set; }
        public string Message { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Subj { get; set; }
        public string Xfrom { get; set; }
        public string Sto { get; set; }
        public string Scc { get; set; }
        public string Sbcc { get; set; }
        public string Sbody { get; set; }
        public string Eto { get; set; }
        public string Ebody { get; set; }
        public DateTime? Mailsent { get; set; }
        public string Xattach { get; set; }
    }
}

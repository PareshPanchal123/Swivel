using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Zyd
    {
        public int Ref { get; set; }
        public int Zyh { get; set; }
        public string Parameter { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public int? Seq { get; set; }
        public string Newname { get; set; }
        public string Batchemail { get; set; }
        public string Batchparameter { get; set; }
        public string Batchparameter2 { get; set; }
        public string Batchparameter3 { get; set; }
    }
}

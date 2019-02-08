using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Custrem
    {
        public int Ref { get; set; }
        public DateTime? Mdate { get; set; }
        public string Subject { get; set; }
        public string Mdesc { get; set; }
        public string Code2 { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
    }
}

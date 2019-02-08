using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Carrmstr
    {
        public string Carrier { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }
        public decimal? AwbMinwgt { get; set; }
        public string WgtUnit { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Subcode { get; set; }
        public string Myc { get; set; }
        public string Secu { get; set; }
        public string Ssent { get; set; }
        public string Sform { get; set; }
        public string Terminal { get; set; }
        public string Eawbcode { get; set; }
        public string ApprStatus { get; set; }
        public string ApprUser { get; set; }
        public DateTime? ApprDate { get; set; }
    }
}

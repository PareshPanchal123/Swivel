using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Linermstr
    {
        public Linermstr()
        {
            Veslmstr = new HashSet<Veslmstr>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Subcode { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public bool? Quotenable { get; set; }
        public string Short { get; set; }
        public string Issudate { get; set; }
        public int Ref { get; set; }
        public string Wincode { get; set; }
        public string ApprStatus { get; set; }
        public string ApprUser { get; set; }
        public DateTime? ApprDate { get; set; }
        public string Scac { get; set; }
        public string Intracode { get; set; }
        public string Caption { get; set; }
        public bool? Inttraedi { get; set; }

        public virtual ICollection<Veslmstr> Veslmstr { get; set; }
    }
}

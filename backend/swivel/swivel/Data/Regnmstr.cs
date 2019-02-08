using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Regnmstr
    {
        public Regnmstr()
        {
            Ctrymstr = new HashSet<Ctrymstr>();
        }

        public string Code { get; set; }
        public string ShortDesc { get; set; }
        public string Remarks { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Rgroup { get; set; }

        public virtual ICollection<Ctrymstr> Ctrymstr { get; set; }
    }
}

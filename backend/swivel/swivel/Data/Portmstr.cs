using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Portmstr
    {
        public Portmstr()
        {
            Custgrp = new HashSet<Custgrp>();
            Custsub = new HashSet<Custsub>();
        }

        public string Code { get; set; }
        public string Country { get; set; }
        public string PortLdes1 { get; set; }
        public string PortLdes2 { get; set; }
        public string PortLdes3 { get; set; }
        public string PortLdes4 { get; set; }
        public string Remark { get; set; }
        public string ZoneCode { get; set; }
        public string Uncode { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Edi { get; set; }
        public string Ams { get; set; }
        public string Fams { get; set; }
        public string Module { get; set; }
        public string ApprStatus { get; set; }
        public string ApprUser { get; set; }
        public DateTime? ApprDate { get; set; }
        public string State { get; set; }

        public virtual Ctrymstr CountryNavigation { get; set; }
        public virtual ICollection<Custgrp> Custgrp { get; set; }
        public virtual ICollection<Custsub> Custsub { get; set; }
    }
}

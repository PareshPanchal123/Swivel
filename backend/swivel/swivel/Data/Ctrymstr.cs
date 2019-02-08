using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Ctrymstr
    {
        public Ctrymstr()
        {
            Custsub = new HashSet<Custsub>();
            Portmstr = new HashSet<Portmstr>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Userregion { get; set; }
        public string Xregion { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Desc1 { get; set; }
        public bool? Showscac { get; set; }
        public string Areacode { get; set; }
        public string Defaware { get; set; }
        public string Skey { get; set; }
        public string Desc0 { get; set; }
        public string ApprStatus { get; set; }
        public string ApprUser { get; set; }
        public DateTime? ApprDate { get; set; }

        public virtual Regnmstr XregionNavigation { get; set; }
        public virtual ICollection<Custsub> Custsub { get; set; }
        public virtual ICollection<Portmstr> Portmstr { get; set; }
    }
}

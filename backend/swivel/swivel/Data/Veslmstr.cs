using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Veslmstr
    {
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Conference { get; set; }
        public string Register { get; set; }
        public string LinerCode { get; set; }
        public string LinerPort { get; set; }
        public string LinerCtry { get; set; }
        public string LinerGrp { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string ApprStatus { get; set; }
        public string ApprUser { get; set; }
        public DateTime? ApprDate { get; set; }

        public virtual Linermstr LinerCodeNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Zpt
    {
        public int Seq { get; set; }
        public string Repid { get; set; }
        public string Title { get; set; }
        public string Mark { get; set; }
        public string Note { get; set; }
        public string Parameter { get; set; }
        public DateTime? Startdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public DateTime? Bdate { get; set; }
        public DateTime? Bsdate { get; set; }
        public DateTime? Bedate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Jobid { get; set; }
        public string Faxno { get; set; }
        public string Rname { get; set; }
        public string Fileno { get; set; }
        public bool? Faxsent { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
        public string Faxjobn { get; set; }
        public string Faxstat { get; set; }
        public string Emailaddr { get; set; }
        public string Senddoctype { get; set; }
        public string Emailaddcc { get; set; }
    }
}

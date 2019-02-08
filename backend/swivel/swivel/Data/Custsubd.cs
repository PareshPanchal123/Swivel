using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Custsubd
    {
        public int Ref { get; set; }
        public string Code { get; set; }
        public string PayeCode { get; set; }
        public decimal? PsRate { get; set; }
        public string CreatBy { get; set; }
        public DateTime? CreatDate { get; set; }
        public string CreatTime { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public bool? Isagent { get; set; }
        public string Atype { get; set; }
        public decimal? Cmypss { get; set; }
        public bool? Istate { get; set; }
        public bool? Separate { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}

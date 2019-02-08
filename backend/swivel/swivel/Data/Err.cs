using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Err
    {
        public string Code { get; set; }
        public string Desc { get; set; }
        public string Cdesc { get; set; }
        public string Err1 { get; set; }
        public string Dbf { get; set; }
        public string Field { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
        public int Id { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Pic
    {
        public int Ref { get; set; }
        public int? Mkey { get; set; }
        public byte[] Pict { get; set; }
        public string Filename { get; set; }
        public long? Filesize { get; set; }
        public DateTime? Pdte { get; set; }
        public string Remk { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Pgm { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Type { get; set; }
        public int? Blhead { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public int? Operinv { get; set; }
        public string Jobn { get; set; }
        public string Subcode { get; set; }
        public string Doc { get; set; }
        public string Body { get; set; }
        public string Emailfrom { get; set; }
        public string Emailto { get; set; }
        public string Emailtocc { get; set; }
        public string Attached { get; set; }
        public string Blno { get; set; }
        public string Role { get; set; }
        public bool? Send { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
        public string Module { get; set; }
    }
}

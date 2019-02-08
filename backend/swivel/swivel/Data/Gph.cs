using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Gph
    {
        public int Gkey { get; set; }
        public string Gcode { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public string Menubar { get; set; }
        public string Twcolor { get; set; }
        public string Nmcolor { get; set; }
        public string Hmcolor { get; set; }
        public string Nwcolor { get; set; }
        public string Hwcolor { get; set; }
        public string Tmsize { get; set; }
        public string Nmsize { get; set; }
        public string Tmwidth { get; set; }
        public string Nmwidth { get; set; }
        public string Menuhigh { get; set; }
        public string Help { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Custlog
    {
        public int Ref { get; set; }
        public string Code2 { get; set; }
        public string MalEName { get; set; }
        public string MalEAdd1 { get; set; }
        public string MalEAdd2 { get; set; }
        public string MalEAdd3 { get; set; }
        public string MalEAdd4 { get; set; }
        public string MalEAdd5 { get; set; }
        public string DocEName { get; set; }
        public string DocEAdd1 { get; set; }
        public string DocEAdd2 { get; set; }
        public string DocEAdd3 { get; set; }
        public string DocEAdd4 { get; set; }
        public string DocEAdd5 { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string SalesmanC { get; set; }
        public string ManEName { get; set; }
        public string ManEAdd1 { get; set; }
        public string ManEAdd2 { get; set; }
        public string ManEAdd3 { get; set; }
        public string ManEAdd4 { get; set; }
        public string ManEAdd5 { get; set; }
        public string Xmlcity { get; set; }
        public string Xmlmatchcode { get; set; }
        public string XmluidNum { get; set; }
        public string XmlvatNum { get; set; }
        public string XmltaxNum { get; set; }
        public string Xmlcreg { get; set; }
        public string Xmlindustry { get; set; }
        public string Xmldelete { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public DateTime? Logdate { get; set; }
        public bool? Isdel { get; set; }
    }
}

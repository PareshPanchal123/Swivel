using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Airquoh
    {
        public int Ref { get; set; }
        public string Quono { get; set; }
        public string CustType { get; set; }
        public string TxCust { get; set; }
        public string CustGpid { get; set; }
        public string PotnTmid { get; set; }
        public string Salesman { get; set; }
        public DateTime? Effective { get; set; }
        public DateTime? Expiry { get; set; }
        public string Status { get; set; }
        public string RecType { get; set; }
        public string CreStamp { get; set; }
        public string AmeStamp { get; set; }
        public string AprStamp { get; set; }
        public string AccStamp { get; set; }
        public string IusStamp { get; set; }
        public string AcceptBy { get; set; }
        public string AptStamp { get; set; }
        public string ApplyBy { get; set; }
        public string AppStamp { get; set; }
        public string SubStamp { get; set; }
        public string TrfStamp { get; set; }
        public string Payor { get; set; }
        public string ServType { get; set; }
        public DateTime? EffDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string DeleFlag { get; set; }
        public string Remarks { get; set; }
        public string TranFlag { get; set; }
        public string TermLo { get; set; }
        public string TermFr { get; set; }
        public string TermDe { get; set; }
        public string PayorLo { get; set; }
        public string PayorDe { get; set; }
        public string CrLo { get; set; }
        public string CrFr { get; set; }
        public string CrDe { get; set; }
        public string SubTo { get; set; }
        public DateTime? SubTime { get; set; }
        public string SubConfirm { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public bool? Stnduse { get; set; }
        public bool? Cdefa { get; set; }
        public string Xremark { get; set; }
        public string Attn { get; set; }
        public string Qtype { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }

        public virtual Usermstr SalesmanNavigation { get; set; }
        public virtual Custsub TxCustNavigation { get; set; }
    }
}

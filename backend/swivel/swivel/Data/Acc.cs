using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Acc
    {
        public int Ref { get; set; }
        public string CusNum { get; set; }
        public string AccLoc { get; set; }
        public string AccountGroup { get; set; }
        public string CusType { get; set; }
        public string BookingAccount { get; set; }
        public string PaymentTerms { get; set; }
        public string Assignment { get; set; }
        public string PaymentAgreement { get; set; }
        public string PaymentAgreementText1 { get; set; }
        public string PaymentAgreementText2 { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
    }
}

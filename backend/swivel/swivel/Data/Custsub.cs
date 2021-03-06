﻿using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Custsub
    {
        public Custsub()
        {
            Airquoh = new HashSet<Airquoh>();
        }

        public string Codeforair { get; set; }
        public string Code { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
        public string Code4 { get; set; }
        public string ShprType { get; set; }
        public string CgneType { get; set; }
        public string AgntType { get; set; }
        public string LinerType { get; set; }
        public string OtherType { get; set; }
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
        public string DocEOrd1 { get; set; }
        public string DocEOrd2 { get; set; }
        public string InvEName { get; set; }
        public string InvEAdd1 { get; set; }
        public string InvEAdd2 { get; set; }
        public string InvEAdd3 { get; set; }
        public string InvEAdd4 { get; set; }
        public string MalCName { get; set; }
        public string MalCAdd1 { get; set; }
        public string MalCAdd2 { get; set; }
        public string MalCAdd3 { get; set; }
        public string MalCAdd4 { get; set; }
        public string MalCAdd5 { get; set; }
        public string DocCName { get; set; }
        public string DocCAdd1 { get; set; }
        public string DocCAdd2 { get; set; }
        public string DocCAdd3 { get; set; }
        public string DocCAdd4 { get; set; }
        public string DocCAdd5 { get; set; }
        public string DocCOrd1 { get; set; }
        public string DocCOrd2 { get; set; }
        public string InvCName { get; set; }
        public string InvCAdd1 { get; set; }
        public string InvCAdd2 { get; set; }
        public string InvCAdd3 { get; set; }
        public string InvCAdd4 { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Telex { get; set; }
        public string Contact { get; set; }
        public string Title { get; set; }
        public string Salesman { get; set; }
        public string Nature { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string OrderType { get; set; }
        public DateTime? BussDate { get; set; }
        public int? DuratMon { get; set; }
        public string BrokCode { get; set; }
        public string Carrier { get; set; }
        public string Prefix { get; set; }
        public bool? ProtFlag { get; set; }
        public decimal? Profit { get; set; }
        public decimal? Loyalty { get; set; }
        public decimal? VolFactor { get; set; }
        public string OverGrade { get; set; }
        public string Contact1 { get; set; }
        public string Title1 { get; set; }
        public string Phone1 { get; set; }
        public string Email1 { get; set; }
        public string Contact2 { get; set; }
        public string Title2 { get; set; }
        public string Phone2 { get; set; }
        public string Email2 { get; set; }
        public string Contact3 { get; set; }
        public string Title3 { get; set; }
        public string Phone3 { get; set; }
        public string Email3 { get; set; }
        public string Contact4 { get; set; }
        public string Title4 { get; set; }
        public string Phone4 { get; set; }
        public string Email4 { get; set; }
        public string SalesmanC { get; set; }
        public string ManEName { get; set; }
        public string ManEAdd1 { get; set; }
        public string ManEAdd2 { get; set; }
        public string ManEAdd3 { get; set; }
        public string ManEAdd4 { get; set; }
        public string ManEAdd5 { get; set; }
        public string ManCName { get; set; }
        public string ManCAdd1 { get; set; }
        public string ManCAdd2 { get; set; }
        public string ManCAdd3 { get; set; }
        public string ManCAdd4 { get; set; }
        public string ManCAdd5 { get; set; }
        public string RiMemo { get; set; }
        public string DoMemo { get; set; }
        public string OhMemo { get; set; }
        public string DhMemo { get; set; }
        public string SvcEndAt { get; set; }
        public string SvcInland { get; set; }
        public string SvcConsol { get; set; }
        public string DocCollec { get; set; }
        public string Insurance { get; set; }
        public string NomiCode { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string CrCurr { get; set; }
        public decimal? CrLimit { get; set; }
        public bool? CrChkflg { get; set; }
        public decimal? CrBal { get; set; }
        public string Party1 { get; set; }
        public string Party2 { get; set; }
        public string Party3 { get; set; }
        public string PayTerm { get; set; }
        public string CreatBy { get; set; }
        public DateTime? CreatDate { get; set; }
        public string AmendBy { get; set; }
        public DateTime? AmendDate { get; set; }
        public string ShortName { get; set; }
        public string PostFlag { get; set; }
        public string CommTbl { get; set; }
        public string MpTbl { get; set; }
        public string AutoFax { get; set; }
        public string Country { get; set; }
        public string TaxCode { get; set; }
        public string ArTbl { get; set; }
        public string Warndesc { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Updmemo { get; set; }
        public string Updhigh { get; set; }
        public bool? Prov { get; set; }
        public bool? Useusd { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string ApTbl { get; set; }
        public int Xref { get; set; }
        public decimal? Mypss { get; set; }
        public bool? Isdel { get; set; }
        public string Kccode { get; set; }
        public string Racode { get; set; }
        public string Scac { get; set; }
        public string Iatacode { get; set; }
        public bool? Chkcou { get; set; }
        public string Ilogin { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
        public string Column9 { get; set; }
        public string Column10 { get; set; }
        public string Remark { get; set; }
        public string Acctcode { get; set; }
        public string NotEName { get; set; }
        public string NotEAdd1 { get; set; }
        public string NotEAdd2 { get; set; }
        public string NotEAdd3 { get; set; }
        public string NotEAdd4 { get; set; }
        public string NotEAdd5 { get; set; }
        public string Xtemp2 { get; set; }
        public string Dcode { get; set; }
        public string Adduser { get; set; }
        public DateTime? Adddate { get; set; }
        public string Mktref { get; set; }
        public string Xmlcity { get; set; }
        public string Xmlmatchcode { get; set; }
        public string XmluidNum { get; set; }
        public string XmlvatNum { get; set; }
        public string XmltaxNum { get; set; }
        public string Xmlcreg { get; set; }
        public string Xmlindustry { get; set; }
        public string Xmldelete { get; set; }
        public string Bookacct { get; set; }
        public bool? Asshpr { get; set; }
        public bool? Ascgne { get; set; }
        public bool? Asagnt { get; set; }
        public bool? Asliner { get; set; }
        public bool? Astruck { get; set; }
        public bool? Aswarehouse { get; set; }
        public bool? Asforwarder { get; set; }
        public bool? Asother { get; set; }
        public string ShortName2 { get; set; }
        public string Cass { get; set; }
        public string Brand { get; set; }
        public string Network { get; set; }
        public DateTime? Kceffect { get; set; }
        public DateTime? Kcexpiry { get; set; }
        public string Ocode { get; set; }
        public string Xemail { get; set; }
        public string Groupname { get; set; }
        public bool? Asintercom { get; set; }
        public string Bankacct { get; set; }
        public bool? Asairline { get; set; }
        public bool? Ascoload { get; set; }
        public bool? Asinteraso { get; set; }
        public bool? Asinterrp { get; set; }
        public bool? Asinterjv { get; set; }
        public string Hbltype { get; set; }
        public string CommTbl2 { get; set; }
        public string Parent { get; set; }

        public virtual Portmstr CityNavigation { get; set; }
        public virtual Ctrymstr CountryNavigation { get; set; }
        public virtual Usermstr SalesmanCNavigation { get; set; }
        public virtual ICollection<Airquoh> Airquoh { get; set; }
    }
}

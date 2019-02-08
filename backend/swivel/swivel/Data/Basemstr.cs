using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Basemstr
    {
        public Basemstr()
        {
            Chrgcode = new HashSet<Chrgcode>();
        }

        public string Code { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string UnitType { get; set; }
        public decimal? ConFactor { get; set; }
        public string ChrgFlg { get; set; }
        public short? Figure { get; set; }
        public decimal? RoundCase { get; set; }
        public decimal? MaxCbm { get; set; }
        public decimal? MaxWgt { get; set; }
        public string Reefer { get; set; }
        public decimal? TareWgt { get; set; }
        public short? StorageDa { get; set; }
        public string MSize { get; set; }
        public string MType { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string LocalDesc { get; set; }

        public virtual ICollection<Chrgcode> Chrgcode { get; set; }
    }
}

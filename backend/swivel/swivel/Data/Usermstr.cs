using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Usermstr
    {
        public Usermstr()
        {
            Airquoh = new HashSet<Airquoh>();
            Custsub = new HashSet<Custsub>();
        }

        public string Office { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Upduser { get; set; }
        public DateTime? Upddate { get; set; }
        public string Crtuser { get; set; }
        public DateTime? Crtdate { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public bool? Isinact { get; set; }
        public string ApprStatus { get; set; }
        public string ApprUser { get; set; }
        public DateTime? ApprDate { get; set; }
        public string Remark { get; set; }
        public string Ownsite { get; set; }

        public virtual ICollection<Airquoh> Airquoh { get; set; }
        public virtual ICollection<Custsub> Custsub { get; set; }
    }
}

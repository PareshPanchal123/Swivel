using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace swivel.Data
{
    public partial class sysMasterContext : DbContext
    {
        public sysMasterContext()
        {
        }

        public sysMasterContext(DbContextOptions<sysMasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acc> Acc { get; set; }
        public virtual DbSet<Achrgcode> Achrgcode { get; set; }
        public virtual DbSet<Airquoh> Airquoh { get; set; }
        public virtual DbSet<Amsport1> Amsport1 { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Bas> Bas { get; set; }
        public virtual DbSet<Basemstr> Basemstr { get; set; }
        public virtual DbSet<Brd> Brd { get; set; }
        public virtual DbSet<Carrmstr> Carrmstr { get; set; }
        public virtual DbSet<Chrgcode> Chrgcode { get; set; }
        public virtual DbSet<Col> Col { get; set; }
        public virtual DbSet<Ctrymstr> Ctrymstr { get; set; }
        public virtual DbSet<Ctypmstr> Ctypmstr { get; set; }
        public virtual DbSet<Custgrp> Custgrp { get; set; }
        public virtual DbSet<Custlog> Custlog { get; set; }
        public virtual DbSet<Custrem> Custrem { get; set; }
        public virtual DbSet<Custsub> Custsub { get; set; }
        public virtual DbSet<Custsubd> Custsubd { get; set; }
        public virtual DbSet<Err> Err { get; set; }
        public virtual DbSet<Evl> Evl { get; set; }
        public virtual DbSet<Ftplog> Ftplog { get; set; }
        public virtual DbSet<Gcd> Gcd { get; set; }
        public virtual DbSet<Gdm> Gdm { get; set; }
        public virtual DbSet<Ggm> Ggm { get; set; }
        public virtual DbSet<Gph> Gph { get; set; }
        public virtual DbSet<Gtp> Gtp { get; set; }
        public virtual DbSet<Linermstr> Linermstr { get; set; }
        public virtual DbSet<Osf> Osf { get; set; }
        public virtual DbSet<Pic> Pic { get; set; }
        public virtual DbSet<Portmstr> Portmstr { get; set; }
        public virtual DbSet<Rco> Rco { get; set; }
        public virtual DbSet<Regnmstr> Regnmstr { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Site2> Site2 { get; set; }
        public virtual DbSet<Sizemstr> Sizemstr { get; set; }
        public virtual DbSet<Sod> Sod { get; set; }
        public virtual DbSet<Sta> Sta { get; set; }
        public virtual DbSet<TempRpt> TempRpt { get; set; }
        public virtual DbSet<Ter> Ter { get; set; }
        public virtual DbSet<Trc> Trc { get; set; }
        public virtual DbSet<Trm> Trm { get; set; }
        public virtual DbSet<Trp> Trp { get; set; }
        public virtual DbSet<Uld> Uld { get; set; }
        public virtual DbSet<Usd> Usd { get; set; }
        public virtual DbSet<Usermstr> Usermstr { get; set; }
        public virtual DbSet<Usm> Usm { get; set; }
        public virtual DbSet<Usp> Usp { get; set; }
        public virtual DbSet<Usr> Usr { get; set; }
        public virtual DbSet<Uss> Uss { get; set; }
        public virtual DbSet<Veslmstr> Veslmstr { get; set; }
        public virtual DbSet<Winlog> Winlog { get; set; }
        public virtual DbSet<Winlogd> Winlogd { get; set; }
        public virtual DbSet<Wlp> Wlp { get; set; }
        public virtual DbSet<Wls> Wls { get; set; }
        public virtual DbSet<Zcx> Zcx { get; set; }
        public virtual DbSet<Zlt> Zlt { get; set; }
        public virtual DbSet<Zpa> Zpa { get; set; }
        public virtual DbSet<Zpt> Zpt { get; set; }
        public virtual DbSet<Ztr> Ztr { get; set; }
        public virtual DbSet<Zyd> Zyd { get; set; }
        public virtual DbSet<Zyl> Zyl { get; set; }

        // Unable to generate entity type for table 'dev.nat'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.operaiv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.operinv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pcf'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reqhinfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.san_ctrymstr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.servmstr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.std'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stndcurd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.stndcurr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tvd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tvh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.usport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.testTBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.usv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ABS_cust'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.waimanh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.waimant'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.winlog2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ams_fport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ams_port'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.winlogd2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ams_state'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ams_uom'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zdf'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zfd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.batch01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgb'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.batchupd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zge'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgf'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgu'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zgx'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zme'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zmh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zmu'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zpp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.custlist2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zrh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zwp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zxd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.div'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zyh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dmc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dup_code'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.edi_qsb'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.edi_qsd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.edi_qsh'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gbg'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ggd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ggp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gjs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gpd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gpm'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nat'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gty'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.gyr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.invquery'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=13.229.228.96;Database=sysMaster;User ID=smDeveloper;Password=beZY26YPc;Trusted_Connection=True;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:DefaultSchema", "dev");

            modelBuilder.Entity<Acc>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("acc", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.AccLoc)
                    .HasColumnName("acc_loc")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountGroup)
                    .HasColumnName("account_group")
                    .HasMaxLength(50);

                entity.Property(e => e.Assignment)
                    .HasColumnName("assignment")
                    .HasMaxLength(50);

                entity.Property(e => e.BookingAccount)
                    .HasColumnName("booking_account")
                    .HasMaxLength(50);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(50);

                entity.Property(e => e.CusNum)
                    .HasColumnName("cus_num")
                    .HasMaxLength(50);

                entity.Property(e => e.CusType)
                    .HasColumnName("cus_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentAgreement)
                    .HasColumnName("payment_agreement")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentAgreementText1)
                    .HasColumnName("payment_agreement_text1")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentAgreementText2)
                    .HasColumnName("payment_agreement_text2")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentTerms)
                    .HasColumnName("payment_terms")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Achrgcode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("achrgcode", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.ChrgAmby)
                    .HasColumnName("chrg_amby")
                    .HasMaxLength(6);

                entity.Property(e => e.ChrgAmon)
                    .HasColumnName("chrg_amon")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChrgBase)
                    .HasColumnName("chrg_base")
                    .HasMaxLength(6);

                entity.Property(e => e.ChrgCrby)
                    .HasColumnName("chrg_crby")
                    .HasMaxLength(6);

                entity.Property(e => e.ChrgCron)
                    .HasColumnName("chrg_cron")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChrgPosit)
                    .HasColumnName("chrg_posit")
                    .HasMaxLength(1);

                entity.Property(e => e.ChrgType)
                    .HasColumnName("chrg_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Chrggrp)
                    .HasColumnName("chrggrp")
                    .HasMaxLength(10);

                entity.Property(e => e.CostCode)
                    .HasColumnName("cost_code")
                    .HasMaxLength(10);

                entity.Property(e => e.CostFunc)
                    .HasColumnName("cost_func")
                    .HasMaxLength(10);

                entity.Property(e => e.CostModu)
                    .HasColumnName("cost_modu")
                    .HasMaxLength(3);

                entity.Property(e => e.CrCoatbl1)
                    .HasColumnName("cr_coatbl1")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl2)
                    .HasColumnName("cr_coatbl2")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl3)
                    .HasColumnName("cr_coatbl3")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl4)
                    .HasColumnName("cr_coatbl4")
                    .HasMaxLength(20);

                entity.Property(e => e.CreditCoa)
                    .HasColumnName("credit_coa")
                    .HasMaxLength(10);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Cwtype)
                    .HasColumnName("cwtype")
                    .HasMaxLength(1);

                entity.Property(e => e.DebitCoa)
                    .HasColumnName("debit_coa")
                    .HasMaxLength(10);

                entity.Property(e => e.DrCoatbl1)
                    .HasColumnName("dr_coatbl1")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl2)
                    .HasColumnName("dr_coatbl2")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl3)
                    .HasColumnName("dr_coatbl3")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl4)
                    .HasColumnName("dr_coatbl4")
                    .HasMaxLength(20);

                entity.Property(e => e.Eawb)
                    .HasColumnName("eawb")
                    .HasMaxLength(2);

                entity.Property(e => e.Function)
                    .HasColumnName("function")
                    .HasMaxLength(10);

                entity.Property(e => e.Grprefer)
                    .HasColumnName("grprefer")
                    .HasMaxLength(10);

                entity.Property(e => e.HousRcase)
                    .HasColumnName("hous_rcase")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.HousRound).HasColumnName("hous_round");

                entity.Property(e => e.HousSpflg).HasColumnName("hous_spflg");

                entity.Property(e => e.Iwtype)
                    .HasColumnName("iwtype")
                    .HasMaxLength(1);

                entity.Property(e => e.LongDesc)
                    .IsRequired()
                    .HasColumnName("long_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.MastRcase)
                    .HasColumnName("mast_rcase")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.MastRound).HasColumnName("mast_round");

                entity.Property(e => e.MastSpflg).HasColumnName("mast_spflg");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(3);

                entity.Property(e => e.Mterms)
                    .HasColumnName("mterms")
                    .HasMaxLength(2);

                entity.Property(e => e.Nature)
                    .HasColumnName("nature")
                    .HasMaxLength(1);

                entity.Property(e => e.Othdesc)
                    .HasColumnName("othdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.PostHold).HasColumnName("post_hold");

                entity.Property(e => e.Ptgrefer)
                    .HasColumnName("ptgrefer")
                    .HasMaxLength(10);

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Remarks1)
                    .HasColumnName("remarks1")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks2)
                    .HasColumnName("remarks2")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks3)
                    .HasColumnName("remarks3")
                    .HasMaxLength(50);

                entity.Property(e => e.Rndtype)
                    .HasColumnName("rndtype")
                    .HasMaxLength(20);

                entity.Property(e => e.Roundto)
                    .HasColumnName("roundto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShortDesc)
                    .HasColumnName("short_desc")
                    .HasMaxLength(10);

                entity.Property(e => e.Site01)
                    .HasColumnName("site01")
                    .HasMaxLength(30);

                entity.Property(e => e.Site02)
                    .HasColumnName("site02")
                    .HasMaxLength(30);

                entity.Property(e => e.Site03)
                    .HasColumnName("site03")
                    .HasMaxLength(30);

                entity.Property(e => e.Site04)
                    .HasColumnName("site04")
                    .HasMaxLength(30);

                entity.Property(e => e.Site05)
                    .HasColumnName("site05")
                    .HasMaxLength(30);

                entity.Property(e => e.Site06)
                    .HasColumnName("site06")
                    .HasMaxLength(30);

                entity.Property(e => e.Site07)
                    .HasColumnName("site07")
                    .HasMaxLength(30);

                entity.Property(e => e.Site08)
                    .HasColumnName("site08")
                    .HasMaxLength(30);

                entity.Property(e => e.Site09)
                    .HasColumnName("site09")
                    .HasMaxLength(30);

                entity.Property(e => e.Site10)
                    .HasColumnName("site10")
                    .HasMaxLength(30);

                entity.Property(e => e.Site11)
                    .HasColumnName("site11")
                    .HasMaxLength(30);

                entity.Property(e => e.Site12)
                    .HasColumnName("site12")
                    .HasMaxLength(30);

                entity.Property(e => e.Site13)
                    .HasColumnName("site13")
                    .HasMaxLength(30);

                entity.Property(e => e.Site14)
                    .HasColumnName("site14")
                    .HasMaxLength(30);

                entity.Property(e => e.Site15)
                    .HasColumnName("site15")
                    .HasMaxLength(30);

                entity.Property(e => e.Site16)
                    .HasColumnName("site16")
                    .HasMaxLength(30);

                entity.Property(e => e.Site17)
                    .HasColumnName("site17")
                    .HasMaxLength(30);

                entity.Property(e => e.Site18)
                    .HasColumnName("site18")
                    .HasMaxLength(30);

                entity.Property(e => e.Site19)
                    .HasColumnName("site19")
                    .HasMaxLength(30);

                entity.Property(e => e.Site20)
                    .HasColumnName("site20")
                    .HasMaxLength(30);

                entity.Property(e => e.Site21)
                    .HasColumnName("site21")
                    .HasMaxLength(30);

                entity.Property(e => e.Site22)
                    .HasColumnName("site22")
                    .HasMaxLength(30);

                entity.Property(e => e.Site23)
                    .HasColumnName("site23")
                    .HasMaxLength(30);

                entity.Property(e => e.Site24)
                    .HasColumnName("site24")
                    .HasMaxLength(30);

                entity.Property(e => e.Site25)
                    .HasColumnName("site25")
                    .HasMaxLength(30);

                entity.Property(e => e.Site26)
                    .HasColumnName("site26")
                    .HasMaxLength(30);

                entity.Property(e => e.Site27)
                    .HasColumnName("site27")
                    .HasMaxLength(30);

                entity.Property(e => e.Site28)
                    .HasColumnName("site28")
                    .HasMaxLength(30);

                entity.Property(e => e.Site29)
                    .HasColumnName("site29")
                    .HasMaxLength(30);

                entity.Property(e => e.Site30)
                    .HasColumnName("site30")
                    .HasMaxLength(30);

                entity.Property(e => e.Site31)
                    .HasColumnName("site31")
                    .HasMaxLength(30);

                entity.Property(e => e.Site32)
                    .HasColumnName("site32")
                    .HasMaxLength(30);

                entity.Property(e => e.Site33)
                    .HasColumnName("site33")
                    .HasMaxLength(30);

                entity.Property(e => e.Site34)
                    .HasColumnName("site34")
                    .HasMaxLength(30);

                entity.Property(e => e.Site35)
                    .HasColumnName("site35")
                    .HasMaxLength(30);

                entity.Property(e => e.Site36)
                    .HasColumnName("site36")
                    .HasMaxLength(30);

                entity.Property(e => e.Site37)
                    .HasColumnName("site37")
                    .HasMaxLength(30);

                entity.Property(e => e.Site38)
                    .HasColumnName("site38")
                    .HasMaxLength(30);

                entity.Property(e => e.Site39)
                    .HasColumnName("site39")
                    .HasMaxLength(30);

                entity.Property(e => e.Site40)
                    .HasColumnName("site40")
                    .HasMaxLength(30);

                entity.Property(e => e.Site41)
                    .HasColumnName("site41")
                    .HasMaxLength(30);

                entity.Property(e => e.Taxtype)
                    .HasColumnName("taxtype")
                    .HasMaxLength(20);

                entity.Property(e => e.Trnrefer)
                    .HasColumnName("trnrefer")
                    .HasMaxLength(10);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Airquoh>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("airquoh", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.AccStamp)
                    .HasColumnName("acc_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.AcceptBy)
                    .HasColumnName("accept_by")
                    .HasMaxLength(30);

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.AmeStamp)
                    .HasColumnName("ame_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.AppStamp)
                    .HasColumnName("app_stamp")
                    .HasMaxLength(14);

                entity.Property(e => e.ApplyBy)
                    .HasColumnName("apply_by")
                    .HasMaxLength(30);

                entity.Property(e => e.AprStamp)
                    .HasColumnName("apr_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.AptStamp)
                    .HasColumnName("apt_stamp")
                    .HasMaxLength(14);

                entity.Property(e => e.Attn)
                    .HasColumnName("attn")
                    .HasMaxLength(50);

                entity.Property(e => e.Cdefa)
                    .HasColumnName("cdefa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrDe)
                    .HasColumnName("cr_de")
                    .HasMaxLength(8);

                entity.Property(e => e.CrFr)
                    .HasColumnName("cr_fr")
                    .HasMaxLength(8);

                entity.Property(e => e.CrLo)
                    .HasColumnName("cr_lo")
                    .HasMaxLength(8);

                entity.Property(e => e.CreStamp)
                    .HasColumnName("cre_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.CustGpid)
                    .HasColumnName("cust_gpid")
                    .HasMaxLength(10);

                entity.Property(e => e.CustType)
                    .HasColumnName("cust_type")
                    .HasMaxLength(1);

                entity.Property(e => e.DeleFlag)
                    .HasColumnName("dele_flag")
                    .HasMaxLength(20);

                entity.Property(e => e.EffDate)
                    .HasColumnName("eff_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Effective)
                    .HasColumnName("effective")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("exp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expiry)
                    .HasColumnName("expiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.IusStamp)
                    .HasColumnName("ius_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.Payor)
                    .HasColumnName("payor")
                    .HasMaxLength(25);

                entity.Property(e => e.PayorDe)
                    .HasColumnName("payor_de")
                    .HasMaxLength(25);

                entity.Property(e => e.PayorLo)
                    .HasColumnName("payor_lo")
                    .HasMaxLength(25);

                entity.Property(e => e.PotnTmid)
                    .HasColumnName("potn_tmid")
                    .HasMaxLength(10);

                entity.Property(e => e.Qtype)
                    .HasColumnName("qtype")
                    .HasMaxLength(1);

                entity.Property(e => e.Quono)
                    .HasColumnName("quono")
                    .HasMaxLength(20);

                entity.Property(e => e.RecType)
                    .HasColumnName("rec_type")
                    .HasMaxLength(3);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("ntext");

                entity.Property(e => e.Salesman)
                    .IsRequired()
                    .HasColumnName("salesman")
                    .HasMaxLength(20);

                entity.Property(e => e.ServType)
                    .HasColumnName("serv_type")
                    .HasMaxLength(2);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Stnduse)
                    .HasColumnName("stnduse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubConfirm)
                    .HasColumnName("sub_confirm")
                    .HasMaxLength(1);

                entity.Property(e => e.SubStamp)
                    .HasColumnName("sub_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.SubTime)
                    .HasColumnName("sub_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubTo)
                    .HasColumnName("sub_to")
                    .HasMaxLength(6);

                entity.Property(e => e.TermDe)
                    .HasColumnName("term_de")
                    .HasMaxLength(2);

                entity.Property(e => e.TermFr)
                    .HasColumnName("term_fr")
                    .HasMaxLength(2);

                entity.Property(e => e.TermLo)
                    .HasColumnName("term_lo")
                    .HasMaxLength(2);

                entity.Property(e => e.TranFlag)
                    .HasColumnName("tran_flag")
                    .HasMaxLength(1);

                entity.Property(e => e.TrfStamp)
                    .HasColumnName("trf_stamp")
                    .HasMaxLength(21);

                entity.Property(e => e.TxCust)
                    .IsRequired()
                    .HasColumnName("tx_cust")
                    .HasMaxLength(8);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Xremark)
                    .HasColumnName("xremark")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.SalesmanNavigation)
                    .WithMany(p => p.Airquoh)
                    .HasForeignKey(d => d.Salesman)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_airquoh_usermstr");

                entity.HasOne(d => d.TxCustNavigation)
                    .WithMany(p => p.Airquoh)
                    .HasForeignKey(d => d.TxCust)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_airquoh_custsub");
            });

            modelBuilder.Entity<Amsport1>(entity =>
            {
                entity.HasKey(e => e.Portcode);

                entity.ToTable("amsport", "dbo");

                entity.Property(e => e.Portcode)
                    .HasColumnName("portcode")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Countrycod)
                    .HasColumnName("countrycod")
                    .HasMaxLength(255);

                entity.Property(e => e.Portname)
                    .HasColumnName("portname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.ToTable("AspNetRoleClaims", "dbo");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.ToTable("AspNetRoles", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.ToTable("AspNetUserClaims", "dbo");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("AspNetUserLogins", "dbo");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("AspNetUserRoles", "dbo");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("AspNetUserTokens", "dbo");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.ToTable("AspNetUsers", "dbo");

                entity.HasIndex(e => e.CompUser);

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => new { e.CompCode, e.CompUser })
                    .HasName("IX_AspNetUsers_CompCode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompCode).HasMaxLength(50);

                entity.Property(e => e.CompUser).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Bas>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("bas", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Factor)
                    .HasColumnName("factor")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.LongDesc)
                    .HasColumnName("long_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.Perunit).HasColumnName("perunit");

                entity.Property(e => e.ShortDesc)
                    .HasColumnName("short_desc")
                    .HasMaxLength(20);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(1);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Basemstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("basemstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.ChrgFlg)
                    .HasColumnName("chrg_flg")
                    .HasMaxLength(1);

                entity.Property(e => e.ConFactor)
                    .HasColumnName("con_factor")
                    .HasColumnType("decimal(13, 6)");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Figure).HasColumnName("figure");

                entity.Property(e => e.LocalDesc)
                    .HasColumnName("local_desc")
                    .HasMaxLength(20);

                entity.Property(e => e.LongDesc)
                    .HasColumnName("long_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.MSize)
                    .HasColumnName("m_size")
                    .HasMaxLength(5);

                entity.Property(e => e.MType)
                    .HasColumnName("m_type")
                    .HasMaxLength(3);

                entity.Property(e => e.MaxCbm)
                    .HasColumnName("max_cbm")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.MaxWgt)
                    .HasColumnName("max_wgt")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Reefer)
                    .HasColumnName("reefer")
                    .HasMaxLength(6);

                entity.Property(e => e.RoundCase)
                    .HasColumnName("round_case")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ShortDesc)
                    .HasColumnName("short_desc")
                    .HasMaxLength(20);

                entity.Property(e => e.StorageDa).HasColumnName("storage_da");

                entity.Property(e => e.TareWgt)
                    .HasColumnName("tare_wgt")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.UnitType)
                    .HasColumnName("unit_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Brd>(entity =>
            {
                entity.HasKey(e => e.Brand);

                entity.ToTable("brd", "dbo");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Carrmstr>(entity =>
            {
                entity.HasKey(e => e.Carrier);

                entity.ToTable("carrmstr", "dbo");

                entity.Property(e => e.Carrier)
                    .HasColumnName("carrier")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.AwbMinwgt)
                    .HasColumnName("awb_minwgt")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Eawbcode)
                    .HasColumnName("eawbcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Myc)
                    .HasColumnName("myc")
                    .HasMaxLength(5);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasMaxLength(3);

                entity.Property(e => e.Secu)
                    .HasColumnName("secu")
                    .HasMaxLength(5);

                entity.Property(e => e.Sform)
                    .HasColumnName("sform")
                    .HasMaxLength(20);

                entity.Property(e => e.Ssent)
                    .HasColumnName("ssent")
                    .HasMaxLength(99);

                entity.Property(e => e.Subcode)
                    .HasColumnName("subcode")
                    .HasMaxLength(8);

                entity.Property(e => e.Terminal)
                    .HasColumnName("terminal")
                    .HasMaxLength(10);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.WgtUnit)
                    .HasColumnName("wgt_unit")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Chrgcode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("chrgcode", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Backtoback)
                    .HasColumnName("backtoback")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChrgBase)
                    .HasColumnName("chrg_base")
                    .HasMaxLength(6);

                entity.Property(e => e.ChrgPosit)
                    .HasColumnName("chrg_posit")
                    .HasMaxLength(1);

                entity.Property(e => e.ChrgType)
                    .HasColumnName("chrg_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Chrggrp)
                    .HasColumnName("chrggrp")
                    .HasMaxLength(10);

                entity.Property(e => e.CrCoatbl1)
                    .HasColumnName("cr_coatbl1")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl2)
                    .HasColumnName("cr_coatbl2")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl3)
                    .HasColumnName("cr_coatbl3")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl4)
                    .HasColumnName("cr_coatbl4")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl5)
                    .HasColumnName("cr_coatbl5")
                    .HasMaxLength(20);

                entity.Property(e => e.CrCoatbl6)
                    .HasColumnName("cr_coatbl6")
                    .HasMaxLength(20);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Csc)
                    .HasColumnName("csc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DrCoatbl1)
                    .HasColumnName("dr_coatbl1")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl2)
                    .HasColumnName("dr_coatbl2")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl3)
                    .HasColumnName("dr_coatbl3")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl4)
                    .HasColumnName("dr_coatbl4")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl5)
                    .HasColumnName("dr_coatbl5")
                    .HasMaxLength(20);

                entity.Property(e => e.DrCoatbl6)
                    .HasColumnName("dr_coatbl6")
                    .HasMaxLength(20);

                entity.Property(e => e.LongDesc)
                    .HasColumnName("long_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.Nature)
                    .HasColumnName("nature")
                    .HasMaxLength(1);

                entity.Property(e => e.Othdesc)
                    .HasColumnName("othdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Ptgrefer)
                    .HasColumnName("ptgrefer")
                    .HasMaxLength(10);

                entity.Property(e => e.Quotenable).HasColumnName("quotenable");

                entity.Property(e => e.Remarks1)
                    .HasColumnName("remarks1")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks2)
                    .HasColumnName("remarks2")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks3)
                    .HasColumnName("remarks3")
                    .HasMaxLength(50);

                entity.Property(e => e.ShortDesc)
                    .HasColumnName("short_desc")
                    .HasMaxLength(10);

                entity.Property(e => e.Showport)
                    .HasColumnName("showport")
                    .HasMaxLength(1);

                entity.Property(e => e.Site01)
                    .HasColumnName("site01")
                    .HasMaxLength(30);

                entity.Property(e => e.Site02)
                    .HasColumnName("site02")
                    .HasMaxLength(30);

                entity.Property(e => e.Site03)
                    .HasColumnName("site03")
                    .HasMaxLength(30);

                entity.Property(e => e.Site04)
                    .HasColumnName("site04")
                    .HasMaxLength(30);

                entity.Property(e => e.Site05)
                    .HasColumnName("site05")
                    .HasMaxLength(30);

                entity.Property(e => e.Site06)
                    .HasColumnName("site06")
                    .HasMaxLength(30);

                entity.Property(e => e.Site07)
                    .HasColumnName("site07")
                    .HasMaxLength(30);

                entity.Property(e => e.Site08)
                    .HasColumnName("site08")
                    .HasMaxLength(30);

                entity.Property(e => e.Site09)
                    .HasColumnName("site09")
                    .HasMaxLength(30);

                entity.Property(e => e.Site10)
                    .HasColumnName("site10")
                    .HasMaxLength(30);

                entity.Property(e => e.Site11)
                    .HasColumnName("site11")
                    .HasMaxLength(30);

                entity.Property(e => e.Site12)
                    .HasColumnName("site12")
                    .HasMaxLength(30);

                entity.Property(e => e.Site13)
                    .HasColumnName("site13")
                    .HasMaxLength(30);

                entity.Property(e => e.Site14)
                    .HasColumnName("site14")
                    .HasMaxLength(30);

                entity.Property(e => e.Site15)
                    .HasColumnName("site15")
                    .HasMaxLength(30);

                entity.Property(e => e.Site16)
                    .HasColumnName("site16")
                    .HasMaxLength(30);

                entity.Property(e => e.Site17)
                    .HasColumnName("site17")
                    .HasMaxLength(30);

                entity.Property(e => e.Site18)
                    .HasColumnName("site18")
                    .HasMaxLength(30);

                entity.Property(e => e.Site19)
                    .HasColumnName("site19")
                    .HasMaxLength(30);

                entity.Property(e => e.Site20)
                    .HasColumnName("site20")
                    .HasMaxLength(30);

                entity.Property(e => e.Site21)
                    .HasColumnName("site21")
                    .HasMaxLength(30);

                entity.Property(e => e.Site22)
                    .HasColumnName("site22")
                    .HasMaxLength(30);

                entity.Property(e => e.Site23)
                    .HasColumnName("site23")
                    .HasMaxLength(30);

                entity.Property(e => e.Site24)
                    .HasColumnName("site24")
                    .HasMaxLength(30);

                entity.Property(e => e.Site25)
                    .HasColumnName("site25")
                    .HasMaxLength(30);

                entity.Property(e => e.Site26)
                    .HasColumnName("site26")
                    .HasMaxLength(30);

                entity.Property(e => e.Site27)
                    .HasColumnName("site27")
                    .HasMaxLength(30);

                entity.Property(e => e.Site28)
                    .HasColumnName("site28")
                    .HasMaxLength(30);

                entity.Property(e => e.Site29)
                    .HasColumnName("site29")
                    .HasMaxLength(30);

                entity.Property(e => e.Site30)
                    .HasColumnName("site30")
                    .HasMaxLength(30);

                entity.Property(e => e.Site31)
                    .HasColumnName("site31")
                    .HasMaxLength(30);

                entity.Property(e => e.Site32)
                    .HasColumnName("site32")
                    .HasMaxLength(30);

                entity.Property(e => e.Site33)
                    .HasColumnName("site33")
                    .HasMaxLength(30);

                entity.Property(e => e.Site34)
                    .HasColumnName("site34")
                    .HasMaxLength(30);

                entity.Property(e => e.Site35)
                    .HasColumnName("site35")
                    .HasMaxLength(30);

                entity.Property(e => e.Site36)
                    .HasColumnName("site36")
                    .HasMaxLength(30);

                entity.Property(e => e.Site37)
                    .HasColumnName("site37")
                    .HasMaxLength(30);

                entity.Property(e => e.Site38)
                    .HasColumnName("site38")
                    .HasMaxLength(30);

                entity.Property(e => e.Site39)
                    .HasColumnName("site39")
                    .HasMaxLength(30);

                entity.Property(e => e.Site40)
                    .HasColumnName("site40")
                    .HasMaxLength(30);

                entity.Property(e => e.Site41)
                    .HasColumnName("site41")
                    .HasMaxLength(30);

                entity.Property(e => e.Taxtype)
                    .HasColumnName("taxtype")
                    .HasMaxLength(1);

                entity.Property(e => e.Tbcode)
                    .HasColumnName("tbcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.HasOne(d => d.ChrgBaseNavigation)
                    .WithMany(p => p.Chrgcode)
                    .HasForeignKey(d => d.ChrgBase)
                    .HasConstraintName("FK_chrgcode_basemstr");
            });

            modelBuilder.Entity<Col>(entity =>
            {
                entity.ToTable("col", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.BrDtB1Co)
                    .HasColumnName("BR_DT_B1_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtB2Co)
                    .HasColumnName("BR_DT_B2_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtB3Co)
                    .HasColumnName("BR_DT_B3_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtHvCo)
                    .HasColumnName("BR_DT_HV_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtLnCo)
                    .HasColumnName("BR_DT_LN_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtTbCo)
                    .HasColumnName("BR_DT_TB_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtTtCo)
                    .HasColumnName("BR_DT_TT_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtWoCo)
                    .HasColumnName("BR_DT_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrDtWoFo)
                    .HasColumnName("BR_DT_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.BrDtWoSi)
                    .HasColumnName("BR_DT_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.BrHdBgCo)
                    .HasColumnName("BR_HD_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrHdHvCo)
                    .HasColumnName("BR_HD_HV_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrHdWoCo)
                    .HasColumnName("BR_HD_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.BrHdWoFo)
                    .HasColumnName("BR_HD_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.BrHdWoSi)
                    .HasColumnName("BR_HD_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.Ccode)
                    .IsRequired()
                    .HasColumnName("CCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Desc)
                    .HasColumnName("DESC")
                    .HasMaxLength(50);

                entity.Property(e => e.DpFeBgCo)
                    .HasColumnName("DP_FE_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpFeWoCo)
                    .HasColumnName("DP_FE_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpFeWoFo)
                    .HasColumnName("DP_FE_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpFeWoSi)
                    .HasColumnName("DP_FE_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT1BgCo)
                    .HasColumnName("DP_T1_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT1WoCo)
                    .HasColumnName("DP_T1_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT1WoFo)
                    .HasColumnName("DP_T1_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT1WoSi)
                    .HasColumnName("DP_T1_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT2BgCo)
                    .HasColumnName("DP_T2_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT2WoCo)
                    .HasColumnName("DP_T2_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT2WoFo)
                    .HasColumnName("DP_T2_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT2WoSi)
                    .HasColumnName("DP_T2_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT3BgCo)
                    .HasColumnName("DP_T3_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT3WoCo)
                    .HasColumnName("DP_T3_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT3WoFo)
                    .HasColumnName("DP_T3_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT3WoSi)
                    .HasColumnName("DP_T3_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT4BgCo)
                    .HasColumnName("DP_T4_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT4WoCo)
                    .HasColumnName("DP_T4_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT4WoFo)
                    .HasColumnName("DP_T4_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT4WoSi)
                    .HasColumnName("DP_T4_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT5BgCo)
                    .HasColumnName("DP_T5_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT5WoCo)
                    .HasColumnName("DP_T5_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT5WoFo)
                    .HasColumnName("DP_T5_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT5WoSi)
                    .HasColumnName("DP_T5_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT6BgCo)
                    .HasColumnName("DP_T6_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT6WoCo)
                    .HasColumnName("DP_T6_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT6WoFo)
                    .HasColumnName("DP_T6_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT6WoSi)
                    .HasColumnName("DP_T6_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT7BgCo)
                    .HasColumnName("DP_T7_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT7WoCo)
                    .HasColumnName("DP_T7_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT7WoFo)
                    .HasColumnName("DP_T7_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT7WoSi)
                    .HasColumnName("DP_T7_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT8BgCo)
                    .HasColumnName("DP_T8_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT8WoCo)
                    .HasColumnName("DP_T8_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT8WoFo)
                    .HasColumnName("DP_T8_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT8WoSi)
                    .HasColumnName("DP_T8_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.DpT9BgCo)
                    .HasColumnName("DP_T9_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT9WoCo)
                    .HasColumnName("DP_T9_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.DpT9WoFo)
                    .HasColumnName("DP_T9_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.DpT9WoSi)
                    .HasColumnName("DP_T9_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.GeBuBgCo)
                    .HasColumnName("GE_BU_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeGeBgCo)
                    .HasColumnName("GE_GE_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeGeBgIm)
                    .HasColumnName("GE_GE_BG_IM")
                    .HasMaxLength(20);

                entity.Property(e => e.GeHlAtCo)
                    .HasColumnName("GE_HL_AT_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeHlHvCo)
                    .HasColumnName("GE_HL_HV_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeHlLnCo)
                    .HasColumnName("GE_HL_LN_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeHlViCo)
                    .HasColumnName("GE_HL_VI_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeInBgCo)
                    .HasColumnName("GE_IN_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.GeSeWoSi)
                    .HasColumnName("GE_SE_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.TiStDpFe)
                    .HasColumnName("TI_ST_DP_FE")
                    .HasMaxLength(20);

                entity.Property(e => e.TiStDpWo)
                    .HasColumnName("TI_ST_DP_WO")
                    .HasMaxLength(20);

                entity.Property(e => e.TiStWoCo)
                    .HasColumnName("TI_ST_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.TiStWoFo)
                    .HasColumnName("TI_ST_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.TiStWoSi)
                    .HasColumnName("TI_ST_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.TiTiBgCo)
                    .HasColumnName("TI_TI_BG_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.TiTiBoCo)
                    .HasColumnName("TI_TI_BO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.TiTiTiPe)
                    .HasColumnName("TI_TI_TI_PE")
                    .HasMaxLength(10);

                entity.Property(e => e.TiTiWoCo)
                    .HasColumnName("TI_TI_WO_CO")
                    .HasMaxLength(7);

                entity.Property(e => e.TiTiWoFo)
                    .HasColumnName("TI_TI_WO_FO")
                    .HasMaxLength(20);

                entity.Property(e => e.TiTiWoSi)
                    .HasColumnName("TI_TI_WO_SI")
                    .HasMaxLength(2);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Ctrymstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("ctrymstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(6);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Defaware)
                    .HasColumnName("defaware")
                    .HasMaxLength(5);

                entity.Property(e => e.Desc0)
                    .HasColumnName("desc0")
                    .HasColumnType("ntext");

                entity.Property(e => e.Desc1)
                    .HasColumnName("desc1")
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(1);

                entity.Property(e => e.Showscac).HasColumnName("showscac");

                entity.Property(e => e.Skey)
                    .HasColumnName("skey")
                    .HasMaxLength(1);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Userregion)
                    .HasColumnName("userregion")
                    .HasMaxLength(2);

                entity.Property(e => e.Xregion)
                    .HasColumnName("xregion")
                    .HasMaxLength(5);

                entity.HasOne(d => d.XregionNavigation)
                    .WithMany(p => p.Ctrymstr)
                    .HasForeignKey(d => d.Xregion)
                    .HasConstraintName("FK_ctrymstr_regnmstr");
            });

            modelBuilder.Entity<Ctypmstr>(entity =>
            {
                entity.HasKey(e => e.ContType);

                entity.ToTable("ctypmstr", "dbo");

                entity.Property(e => e.ContType)
                    .HasColumnName("cont_type")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.CfsFlg)
                    .HasColumnName("cfs_flg")
                    .HasMaxLength(1);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Definition)
                    .HasColumnName("definition")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Custgrp>(entity =>
            {
                entity.HasKey(e => e.Group);

                entity.ToTable("custgrp", "dbo");

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Aarea)
                    .HasColumnName("aarea")
                    .HasMaxLength(50);

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(50);

                entity.Property(e => e.Address4)
                    .HasColumnName("address4")
                    .HasMaxLength(50);

                entity.Property(e => e.Address5)
                    .HasColumnName("address5")
                    .HasMaxLength(50);

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Aemail)
                    .HasColumnName("aemail")
                    .HasMaxLength(200);

                entity.Property(e => e.AgntType)
                    .HasColumnName("agnt_type")
                    .HasMaxLength(1);

                entity.Property(e => e.AirChkflg).HasColumnName("air_chkflg");

                entity.Property(e => e.AirCurr)
                    .HasColumnName("air_curr")
                    .HasMaxLength(3);

                entity.Property(e => e.Amessage)
                    .HasColumnName("amessage")
                    .HasColumnType("ntext");

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(3);

                entity.Property(e => e.Asagnt).HasColumnName("asagnt");

                entity.Property(e => e.Asairline).HasColumnName("asairline");

                entity.Property(e => e.Ascgne).HasColumnName("ascgne");

                entity.Property(e => e.Ascoload).HasColumnName("ascoload");

                entity.Property(e => e.Asforwarder).HasColumnName("asforwarder");

                entity.Property(e => e.Asinteraso).HasColumnName("asinteraso");

                entity.Property(e => e.Asintercom).HasColumnName("asintercom");

                entity.Property(e => e.Asinterjv).HasColumnName("asinterjv");

                entity.Property(e => e.Asinterrp).HasColumnName("asinterrp");

                entity.Property(e => e.Asliner).HasColumnName("asliner");

                entity.Property(e => e.Asother).HasColumnName("asother");

                entity.Property(e => e.Asshpr).HasColumnName("asshpr");

                entity.Property(e => e.Astate)
                    .HasColumnName("astate")
                    .HasMaxLength(50);

                entity.Property(e => e.Astatement)
                    .HasColumnName("astatement")
                    .HasMaxLength(50);

                entity.Property(e => e.Astruck).HasColumnName("astruck");

                entity.Property(e => e.Aswarehouse).HasColumnName("aswarehouse");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(12);

                entity.Property(e => e.BrokGroup)
                    .HasColumnName("brok_group")
                    .HasMaxLength(10);

                entity.Property(e => e.BussDate)
                    .HasColumnName("buss_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CgneType)
                    .HasColumnName("cgne_type")
                    .HasMaxLength(1);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(5);

                entity.Property(e => e.ConbyOffc)
                    .HasColumnName("conby_offc")
                    .HasMaxLength(4);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact1)
                    .HasColumnName("contact1")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact2)
                    .HasColumnName("contact2")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact3)
                    .HasColumnName("contact3")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact4)
                    .HasColumnName("contact4")
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("credit_limit")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(3);

                entity.Property(e => e.CustType).HasColumnName("cust_type");

                entity.Property(e => e.Dupcode)
                    .HasColumnName("dupcode")
                    .HasMaxLength(1);

                entity.Property(e => e.DuratMon).HasColumnName("durat_mon");

                entity.Property(e => e.Eori)
                    .HasColumnName("eori")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(25);

                entity.Property(e => e.Fax1)
                    .HasColumnName("fax1")
                    .HasMaxLength(25);

                entity.Property(e => e.Fax2)
                    .HasColumnName("fax2")
                    .HasMaxLength(25);

                entity.Property(e => e.ForAbs).HasColumnName("for_abs");

                entity.Property(e => e.ForDirectory).HasColumnName("for_directory");

                entity.Property(e => e.ForLifting).HasColumnName("for_lifting");

                entity.Property(e => e.Gremark)
                    .HasColumnName("gremark")
                    .HasMaxLength(200);

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(50);

                entity.Property(e => e.Hcode)
                    .HasColumnName("hcode")
                    .HasMaxLength(8);

                entity.Property(e => e.Hub)
                    .HasColumnName("hub")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LinerType)
                    .HasColumnName("liner_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Nature)
                    .HasColumnName("nature")
                    .HasMaxLength(50);

                entity.Property(e => e.Network)
                    .HasColumnName("network")
                    .HasMaxLength(50);

                entity.Property(e => e.Ocode)
                    .HasColumnName("ocode")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(1);

                entity.Property(e => e.OtherType)
                    .HasColumnName("other_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone1")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone3)
                    .HasColumnName("phone3")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone4)
                    .HasColumnName("phone4")
                    .HasMaxLength(25);

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasMaxLength(3);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(3);

                entity.Property(e => e.ReqbyDate)
                    .HasColumnName("reqby_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqbyOffc)
                    .HasColumnName("reqby_offc")
                    .HasMaxLength(4);

                entity.Property(e => e.ReqbyTime)
                    .HasColumnName("reqby_time")
                    .HasMaxLength(5);

                entity.Property(e => e.Salesman)
                    .HasColumnName("salesman")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesmanC)
                    .IsRequired()
                    .HasColumnName("salesman_c")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(25);

                entity.Property(e => e.ShortName2)
                    .HasColumnName("short_name2")
                    .HasMaxLength(25);

                entity.Property(e => e.ShprType)
                    .HasColumnName("shpr_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Site01)
                    .HasColumnName("site01")
                    .HasMaxLength(30);

                entity.Property(e => e.Site02)
                    .HasColumnName("site02")
                    .HasMaxLength(30);

                entity.Property(e => e.Site03)
                    .HasColumnName("site03")
                    .HasMaxLength(30);

                entity.Property(e => e.Site04)
                    .HasColumnName("site04")
                    .HasMaxLength(30);

                entity.Property(e => e.Site05)
                    .HasColumnName("site05")
                    .HasMaxLength(30);

                entity.Property(e => e.Site06)
                    .HasColumnName("site06")
                    .HasMaxLength(30);

                entity.Property(e => e.Site07)
                    .HasColumnName("site07")
                    .HasMaxLength(30);

                entity.Property(e => e.Site08)
                    .HasColumnName("site08")
                    .HasMaxLength(30);

                entity.Property(e => e.Site09)
                    .HasColumnName("site09")
                    .HasMaxLength(30);

                entity.Property(e => e.Site10)
                    .HasColumnName("site10")
                    .HasMaxLength(30);

                entity.Property(e => e.Site11)
                    .HasColumnName("site11")
                    .HasMaxLength(30);

                entity.Property(e => e.Site12)
                    .HasColumnName("site12")
                    .HasMaxLength(30);

                entity.Property(e => e.Site13)
                    .HasColumnName("site13")
                    .HasMaxLength(30);

                entity.Property(e => e.Site14)
                    .HasColumnName("site14")
                    .HasMaxLength(30);

                entity.Property(e => e.Site15)
                    .HasColumnName("site15")
                    .HasMaxLength(30);

                entity.Property(e => e.Site16)
                    .HasColumnName("site16")
                    .HasMaxLength(30);

                entity.Property(e => e.Site17)
                    .HasColumnName("site17")
                    .HasMaxLength(30);

                entity.Property(e => e.Site18)
                    .HasColumnName("site18")
                    .HasMaxLength(30);

                entity.Property(e => e.Site19)
                    .HasColumnName("site19")
                    .HasMaxLength(30);

                entity.Property(e => e.Site20)
                    .HasColumnName("site20")
                    .HasMaxLength(30);

                entity.Property(e => e.Site21)
                    .HasColumnName("site21")
                    .HasMaxLength(30);

                entity.Property(e => e.Site22)
                    .HasColumnName("site22")
                    .HasMaxLength(30);

                entity.Property(e => e.Site23)
                    .HasColumnName("site23")
                    .HasMaxLength(30);

                entity.Property(e => e.Site24)
                    .HasColumnName("site24")
                    .HasMaxLength(30);

                entity.Property(e => e.Site25)
                    .HasColumnName("site25")
                    .HasMaxLength(30);

                entity.Property(e => e.Site26)
                    .HasColumnName("site26")
                    .HasMaxLength(30);

                entity.Property(e => e.Site27)
                    .HasColumnName("site27")
                    .HasMaxLength(30);

                entity.Property(e => e.Site28)
                    .HasColumnName("site28")
                    .HasMaxLength(30);

                entity.Property(e => e.Site29)
                    .HasColumnName("site29")
                    .HasMaxLength(30);

                entity.Property(e => e.Site30)
                    .HasColumnName("site30")
                    .HasMaxLength(30);

                entity.Property(e => e.Site31)
                    .HasColumnName("site31")
                    .HasMaxLength(30);

                entity.Property(e => e.Site32)
                    .HasColumnName("site32")
                    .HasMaxLength(30);

                entity.Property(e => e.Site33)
                    .HasColumnName("site33")
                    .HasMaxLength(30);

                entity.Property(e => e.Site34)
                    .HasColumnName("site34")
                    .HasMaxLength(30);

                entity.Property(e => e.Site35)
                    .HasColumnName("site35")
                    .HasMaxLength(30);

                entity.Property(e => e.Site36)
                    .HasColumnName("site36")
                    .HasMaxLength(30);

                entity.Property(e => e.Site37)
                    .HasColumnName("site37")
                    .HasMaxLength(30);

                entity.Property(e => e.Site38)
                    .HasColumnName("site38")
                    .HasMaxLength(30);

                entity.Property(e => e.Site39)
                    .HasColumnName("site39")
                    .HasMaxLength(30);

                entity.Property(e => e.Site40)
                    .HasColumnName("site40")
                    .HasMaxLength(30);

                entity.Property(e => e.Site41)
                    .HasColumnName("site41")
                    .HasMaxLength(30);

                entity.Property(e => e.SourceFrom)
                    .HasColumnName("source_from")
                    .HasMaxLength(200);

                entity.Property(e => e.Stat1Date)
                    .HasColumnName("stat1_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Stat2Date)
                    .HasColumnName("stat2_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Stat3Date)
                    .HasColumnName("stat3_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Stat4Date)
                    .HasColumnName("stat4_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Stat5Date)
                    .HasColumnName("stat5_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Stat5Sign)
                    .HasColumnName("stat5_sign")
                    .HasMaxLength(200);

                entity.Property(e => e.Stat6Date)
                    .HasColumnName("stat6_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Stat7Date)
                    .HasColumnName("stat7_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.SubgCode)
                    .HasColumnName("subg_code")
                    .HasMaxLength(10);

                entity.Property(e => e.SubgCtry)
                    .HasColumnName("subg_ctry")
                    .HasMaxLength(2);

                entity.Property(e => e.SubgPort)
                    .HasColumnName("subg_port")
                    .HasMaxLength(3);

                entity.Property(e => e.TaxCode)
                    .HasColumnName("tax_code")
                    .HasMaxLength(20);

                entity.Property(e => e.Telex)
                    .HasColumnName("telex")
                    .HasMaxLength(60);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(20);

                entity.Property(e => e.Title1)
                    .HasColumnName("title1")
                    .HasMaxLength(30);

                entity.Property(e => e.Title2)
                    .HasColumnName("title2")
                    .HasMaxLength(30);

                entity.Property(e => e.Title3)
                    .HasColumnName("title3")
                    .HasMaxLength(30);

                entity.Property(e => e.Title4)
                    .HasColumnName("title4")
                    .HasMaxLength(30);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Wsaref)
                    .HasColumnName("wsaref")
                    .HasMaxLength(10);

                entity.Property(e => e.Xemail)
                    .HasColumnName("xemail")
                    .HasMaxLength(50);

                entity.Property(e => e.Xtemp)
                    .HasColumnName("xtemp")
                    .HasMaxLength(50);

                entity.Property(e => e.Xtemp2)
                    .HasColumnName("xtemp2")
                    .HasMaxLength(100);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(16);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Custgrp)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_custgrp_portmstr");
            });

            modelBuilder.Entity<Custlog>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("custlog", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Code2)
                    .IsRequired()
                    .HasColumnName("code2")
                    .HasMaxLength(8);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.DocEAdd1)
                    .HasColumnName("doc_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd2)
                    .HasColumnName("doc_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd3)
                    .HasColumnName("doc_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd4)
                    .HasColumnName("doc_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd5)
                    .HasColumnName("doc_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEName)
                    .HasColumnName("doc_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Isdel).HasColumnName("isdel");

                entity.Property(e => e.Logdate)
                    .HasColumnName("logdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MalEAdd1)
                    .HasColumnName("mal_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd2)
                    .HasColumnName("mal_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd3)
                    .HasColumnName("mal_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd4)
                    .HasColumnName("mal_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd5)
                    .HasColumnName("mal_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEName)
                    .HasColumnName("mal_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd1)
                    .HasColumnName("man_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd2)
                    .HasColumnName("man_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd3)
                    .HasColumnName("man_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd4)
                    .HasColumnName("man_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd5)
                    .HasColumnName("man_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEName)
                    .HasColumnName("man_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesmanC)
                    .IsRequired()
                    .HasColumnName("salesman_c")
                    .HasMaxLength(20);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Xmlcity)
                    .HasColumnName("xmlcity")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlcreg)
                    .HasColumnName("xmlcreg")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmldelete)
                    .HasColumnName("xmldelete")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlindustry)
                    .HasColumnName("xmlindustry")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlmatchcode)
                    .HasColumnName("xmlmatchcode")
                    .HasMaxLength(50);

                entity.Property(e => e.XmltaxNum)
                    .HasColumnName("xmltax_num")
                    .HasMaxLength(50);

                entity.Property(e => e.XmluidNum)
                    .HasColumnName("xmluid_num")
                    .HasMaxLength(50);

                entity.Property(e => e.XmlvatNum)
                    .HasColumnName("xmlvat_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<Custrem>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("custrem", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Code2)
                    .HasColumnName("code2")
                    .HasMaxLength(8);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Mdate)
                    .HasColumnName("mdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Mdesc)
                    .HasColumnName("mdesc")
                    .HasColumnType("ntext");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(100);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Custsub>(entity =>
            {
                entity.HasKey(e => e.Code2);

                entity.ToTable("custsub", "dbo");

                entity.Property(e => e.Code2)
                    .HasColumnName("code2")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.Acctcode)
                    .HasColumnName("acctcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.AgntType)
                    .HasColumnName("agnt_type")
                    .HasMaxLength(1);

                entity.Property(e => e.AmendBy)
                    .HasColumnName("amend_by")
                    .HasMaxLength(6);

                entity.Property(e => e.AmendDate)
                    .HasColumnName("amend_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApTbl)
                    .HasColumnName("ap_tbl")
                    .HasMaxLength(12);

                entity.Property(e => e.ArTbl)
                    .HasColumnName("ar_tbl")
                    .HasMaxLength(12);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(3);

                entity.Property(e => e.Asagnt).HasColumnName("asagnt");

                entity.Property(e => e.Asairline).HasColumnName("asairline");

                entity.Property(e => e.Ascgne).HasColumnName("ascgne");

                entity.Property(e => e.Ascoload).HasColumnName("ascoload");

                entity.Property(e => e.Asforwarder).HasColumnName("asforwarder");

                entity.Property(e => e.Asinteraso).HasColumnName("asinteraso");

                entity.Property(e => e.Asintercom).HasColumnName("asintercom");

                entity.Property(e => e.Asinterjv).HasColumnName("asinterjv");

                entity.Property(e => e.Asinterrp).HasColumnName("asinterrp");

                entity.Property(e => e.Asliner).HasColumnName("asliner");

                entity.Property(e => e.Asother).HasColumnName("asother");

                entity.Property(e => e.Asshpr).HasColumnName("asshpr");

                entity.Property(e => e.Astruck).HasColumnName("astruck");

                entity.Property(e => e.Aswarehouse).HasColumnName("aswarehouse");

                entity.Property(e => e.AutoFax)
                    .HasColumnName("auto_fax")
                    .HasMaxLength(3);

                entity.Property(e => e.Bankacct)
                    .HasColumnName("bankacct")
                    .HasMaxLength(200);

                entity.Property(e => e.Bookacct)
                    .HasColumnName("bookacct")
                    .HasMaxLength(10);

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(12);

                entity.Property(e => e.BrokCode)
                    .HasColumnName("brok_code")
                    .HasMaxLength(25);

                entity.Property(e => e.BussDate)
                    .HasColumnName("buss_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Carrier)
                    .HasColumnName("carrier")
                    .HasMaxLength(2);

                entity.Property(e => e.Cass)
                    .HasColumnName("cass")
                    .HasMaxLength(5);

                entity.Property(e => e.CgneType)
                    .HasColumnName("cgne_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Chkcou).HasColumnName("chkcou");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(5);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(25);

                entity.Property(e => e.Code1)
                    .HasColumnName("code1")
                    .HasMaxLength(8);

                entity.Property(e => e.Code3)
                    .HasColumnName("code3")
                    .HasMaxLength(5);

                entity.Property(e => e.Code4)
                    .HasColumnName("code4")
                    .HasMaxLength(5);

                entity.Property(e => e.Codeforair)
                    .HasColumnName("codeforair")
                    .HasMaxLength(10);

                entity.Property(e => e.Column1)
                    .HasColumnName("column1")
                    .HasMaxLength(20);

                entity.Property(e => e.Column10)
                    .HasColumnName("column10")
                    .HasMaxLength(20);

                entity.Property(e => e.Column2)
                    .HasColumnName("column2")
                    .HasMaxLength(20);

                entity.Property(e => e.Column3)
                    .HasColumnName("column3")
                    .HasMaxLength(20);

                entity.Property(e => e.Column4)
                    .HasColumnName("column4")
                    .HasMaxLength(20);

                entity.Property(e => e.Column5)
                    .HasColumnName("column5")
                    .HasMaxLength(20);

                entity.Property(e => e.Column6)
                    .HasColumnName("column6")
                    .HasMaxLength(20);

                entity.Property(e => e.Column7)
                    .HasColumnName("column7")
                    .HasMaxLength(20);

                entity.Property(e => e.Column8)
                    .HasColumnName("column8")
                    .HasMaxLength(20);

                entity.Property(e => e.Column9)
                    .HasColumnName("column9")
                    .HasMaxLength(20);

                entity.Property(e => e.CommTbl)
                    .HasColumnName("comm_tbl")
                    .HasMaxLength(40);

                entity.Property(e => e.CommTbl2)
                    .HasColumnName("comm_tbl2")
                    .HasMaxLength(40);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact1)
                    .HasColumnName("contact1")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact2)
                    .HasColumnName("contact2")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact3)
                    .HasColumnName("contact3")
                    .HasMaxLength(30);

                entity.Property(e => e.Contact4)
                    .HasColumnName("contact4")
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.CrBal)
                    .HasColumnName("cr_bal")
                    .HasColumnType("decimal(17, 2)");

                entity.Property(e => e.CrChkflg).HasColumnName("cr_chkflg");

                entity.Property(e => e.CrCurr)
                    .HasColumnName("cr_curr")
                    .HasMaxLength(3);

                entity.Property(e => e.CrLimit)
                    .HasColumnName("cr_limit")
                    .HasColumnType("decimal(17, 2)");

                entity.Property(e => e.CreatBy)
                    .HasColumnName("creat_by")
                    .HasMaxLength(6);

                entity.Property(e => e.CreatDate)
                    .HasColumnName("creat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Dcode)
                    .HasColumnName("dcode")
                    .HasMaxLength(8);

                entity.Property(e => e.DhMemo)
                    .HasColumnName("dh_memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.DoMemo)
                    .HasColumnName("do_memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.DocCAdd1)
                    .HasColumnName("doc_c_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCAdd2)
                    .HasColumnName("doc_c_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCAdd3)
                    .HasColumnName("doc_c_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCAdd4)
                    .HasColumnName("doc_c_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCAdd5)
                    .HasColumnName("doc_c_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCName)
                    .HasColumnName("doc_c_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCOrd1)
                    .HasColumnName("doc_c_ord1")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCOrd2)
                    .HasColumnName("doc_c_ord2")
                    .HasMaxLength(50);

                entity.Property(e => e.DocCollec)
                    .HasColumnName("doc_collec")
                    .HasColumnType("text");

                entity.Property(e => e.DocEAdd1)
                    .HasColumnName("doc_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd2)
                    .HasColumnName("doc_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd3)
                    .HasColumnName("doc_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd4)
                    .HasColumnName("doc_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEAdd5)
                    .HasColumnName("doc_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEName)
                    .HasColumnName("doc_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEOrd1)
                    .HasColumnName("doc_e_ord1")
                    .HasMaxLength(50);

                entity.Property(e => e.DocEOrd2)
                    .HasColumnName("doc_e_ord2")
                    .HasMaxLength(50);

                entity.Property(e => e.DuratMon).HasColumnName("durat_mon");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax1)
                    .HasColumnName("fax1")
                    .HasMaxLength(25);

                entity.Property(e => e.Fax2)
                    .HasColumnName("fax2")
                    .HasMaxLength(25);

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasMaxLength(50);

                entity.Property(e => e.Hbltype)
                    .HasColumnName("hbltype")
                    .HasMaxLength(20);

                entity.Property(e => e.Iatacode)
                    .HasColumnName("iatacode")
                    .HasMaxLength(20);

                entity.Property(e => e.Ilogin)
                    .HasColumnName("ilogin")
                    .HasMaxLength(20);

                entity.Property(e => e.Insurance)
                    .HasColumnName("insurance")
                    .HasColumnType("text");

                entity.Property(e => e.InvCAdd1)
                    .HasColumnName("inv_c_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.InvCAdd2)
                    .HasColumnName("inv_c_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.InvCAdd3)
                    .HasColumnName("inv_c_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.InvCAdd4)
                    .HasColumnName("inv_c_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.InvCName)
                    .HasColumnName("inv_c_name")
                    .HasMaxLength(50);

                entity.Property(e => e.InvEAdd1)
                    .HasColumnName("inv_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.InvEAdd2)
                    .HasColumnName("inv_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.InvEAdd3)
                    .HasColumnName("inv_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.InvEAdd4)
                    .HasColumnName("inv_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.InvEName)
                    .HasColumnName("inv_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Isdel).HasColumnName("isdel");

                entity.Property(e => e.Kccode)
                    .HasColumnName("kccode")
                    .HasMaxLength(15);

                entity.Property(e => e.Kceffect)
                    .HasColumnName("kceffect")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Kcexpiry)
                    .HasColumnName("kcexpiry")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LinerType)
                    .HasColumnName("liner_type")
                    .HasMaxLength(1);

                entity.Property(e => e.Loyalty)
                    .HasColumnName("loyalty")
                    .HasColumnType("decimal(17, 2)");

                entity.Property(e => e.MalCAdd1)
                    .HasColumnName("mal_c_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.MalCAdd2)
                    .HasColumnName("mal_c_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.MalCAdd3)
                    .HasColumnName("mal_c_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.MalCAdd4)
                    .HasColumnName("mal_c_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.MalCAdd5)
                    .HasColumnName("mal_c_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.MalCName)
                    .HasColumnName("mal_c_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd1)
                    .HasColumnName("mal_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd2)
                    .HasColumnName("mal_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd3)
                    .HasColumnName("mal_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd4)
                    .HasColumnName("mal_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEAdd5)
                    .HasColumnName("mal_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.MalEName)
                    .HasColumnName("mal_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ManCAdd1)
                    .HasColumnName("man_c_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.ManCAdd2)
                    .HasColumnName("man_c_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.ManCAdd3)
                    .HasColumnName("man_c_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.ManCAdd4)
                    .HasColumnName("man_c_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.ManCAdd5)
                    .HasColumnName("man_c_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.ManCName)
                    .HasColumnName("man_c_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd1)
                    .HasColumnName("man_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd2)
                    .HasColumnName("man_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd3)
                    .HasColumnName("man_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd4)
                    .HasColumnName("man_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEAdd5)
                    .HasColumnName("man_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.ManEName)
                    .HasColumnName("man_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Mktref)
                    .HasColumnName("mktref")
                    .HasMaxLength(6);

                entity.Property(e => e.MpTbl)
                    .HasColumnName("mp_tbl")
                    .HasMaxLength(140);

                entity.Property(e => e.Mypss)
                    .HasColumnName("mypss")
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nature)
                    .HasColumnName("nature")
                    .HasMaxLength(50);

                entity.Property(e => e.Network)
                    .HasColumnName("network")
                    .HasMaxLength(50);

                entity.Property(e => e.NomiCode)
                    .HasColumnName("nomi_code")
                    .HasMaxLength(25);

                entity.Property(e => e.NotEAdd1)
                    .HasColumnName("not_e_add1")
                    .HasMaxLength(50);

                entity.Property(e => e.NotEAdd2)
                    .HasColumnName("not_e_add2")
                    .HasMaxLength(50);

                entity.Property(e => e.NotEAdd3)
                    .HasColumnName("not_e_add3")
                    .HasMaxLength(50);

                entity.Property(e => e.NotEAdd4)
                    .HasColumnName("not_e_add4")
                    .HasMaxLength(50);

                entity.Property(e => e.NotEAdd5)
                    .HasColumnName("not_e_add5")
                    .HasMaxLength(50);

                entity.Property(e => e.NotEName)
                    .HasColumnName("not_e_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Ocode)
                    .HasColumnName("ocode")
                    .HasMaxLength(50);

                entity.Property(e => e.OhMemo)
                    .HasColumnName("oh_memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(1);

                entity.Property(e => e.OtherType)
                    .HasColumnName("other_type")
                    .HasMaxLength(1);

                entity.Property(e => e.OverGrade)
                    .HasColumnName("over_grade")
                    .HasMaxLength(20);

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasMaxLength(12);

                entity.Property(e => e.Party1)
                    .HasColumnName("party1")
                    .HasMaxLength(50);

                entity.Property(e => e.Party2)
                    .HasColumnName("party2")
                    .HasMaxLength(50);

                entity.Property(e => e.Party3)
                    .HasColumnName("party3")
                    .HasMaxLength(50);

                entity.Property(e => e.PayTerm)
                    .HasColumnName("pay_term")
                    .HasMaxLength(10);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone1")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone3)
                    .HasColumnName("phone3")
                    .HasMaxLength(25);

                entity.Property(e => e.Phone4)
                    .HasColumnName("phone4")
                    .HasMaxLength(25);

                entity.Property(e => e.PostFlag)
                    .HasColumnName("post_flag")
                    .HasMaxLength(1);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(3);

                entity.Property(e => e.Profit)
                    .HasColumnName("profit")
                    .HasColumnType("decimal(17, 2)");

                entity.Property(e => e.ProtFlag).HasColumnName("prot_flag");

                entity.Property(e => e.Prov)
                    .HasColumnName("prov")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Racode)
                    .HasColumnName("racode")
                    .HasMaxLength(8);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext");

                entity.Property(e => e.RiMemo)
                    .HasColumnName("ri_memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.Salesman)
                    .HasColumnName("salesman")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesmanC)
                    .IsRequired()
                    .HasColumnName("salesman_c")
                    .HasMaxLength(20);

                entity.Property(e => e.Scac)
                    .HasColumnName("scac")
                    .HasMaxLength(5);

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(15);

                entity.Property(e => e.ShortName2)
                    .HasColumnName("short_name2")
                    .HasMaxLength(25);

                entity.Property(e => e.ShprType)
                    .HasColumnName("shpr_type")
                    .HasMaxLength(1);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.SvcConsol)
                    .HasColumnName("svc_consol")
                    .HasColumnType("text");

                entity.Property(e => e.SvcEndAt)
                    .HasColumnName("svc_end_at")
                    .HasMaxLength(2);

                entity.Property(e => e.SvcInland)
                    .HasColumnName("svc_inland")
                    .HasColumnType("text");

                entity.Property(e => e.TaxCode)
                    .HasColumnName("tax_code")
                    .HasMaxLength(20);

                entity.Property(e => e.Telex)
                    .HasColumnName("telex")
                    .HasMaxLength(60);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(20);

                entity.Property(e => e.Title1)
                    .HasColumnName("title1")
                    .HasMaxLength(30);

                entity.Property(e => e.Title2)
                    .HasColumnName("title2")
                    .HasMaxLength(30);

                entity.Property(e => e.Title3)
                    .HasColumnName("title3")
                    .HasMaxLength(30);

                entity.Property(e => e.Title4)
                    .HasColumnName("title4")
                    .HasMaxLength(30);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updhigh)
                    .HasColumnName("updhigh")
                    .HasMaxLength(1);

                entity.Property(e => e.Updmemo)
                    .HasColumnName("updmemo")
                    .HasColumnType("ntext");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Useusd).HasColumnName("useusd");

                entity.Property(e => e.VolFactor)
                    .HasColumnName("vol_factor")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Warndesc)
                    .HasColumnName("warndesc")
                    .HasColumnType("ntext");

                entity.Property(e => e.Xemail)
                    .HasColumnName("xemail")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlcity)
                    .HasColumnName("xmlcity")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlcreg)
                    .HasColumnName("xmlcreg")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmldelete)
                    .HasColumnName("xmldelete")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlindustry)
                    .HasColumnName("xmlindustry")
                    .HasMaxLength(50);

                entity.Property(e => e.Xmlmatchcode)
                    .HasColumnName("xmlmatchcode")
                    .HasMaxLength(50);

                entity.Property(e => e.XmltaxNum)
                    .HasColumnName("xmltax_num")
                    .HasMaxLength(50);

                entity.Property(e => e.XmluidNum)
                    .HasColumnName("xmluid_num")
                    .HasMaxLength(50);

                entity.Property(e => e.XmlvatNum)
                    .HasColumnName("xmlvat_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Xref)
                    .HasColumnName("xref")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Xtemp2)
                    .HasColumnName("xtemp2")
                    .HasMaxLength(100);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(16);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Custsub)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_custsub_portmstr");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Custsub)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_custsub_ctrymstr");

                entity.HasOne(d => d.SalesmanCNavigation)
                    .WithMany(p => p.Custsub)
                    .HasForeignKey(d => d.SalesmanC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_custsub_usermstr");
            });

            modelBuilder.Entity<Custsubd>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("custsubd", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Atype)
                    .HasColumnName("atype")
                    .HasMaxLength(20);

                entity.Property(e => e.Cmypss)
                    .HasColumnName("cmypss")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(8);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatBy)
                    .HasColumnName("creat_by")
                    .HasMaxLength(6);

                entity.Property(e => e.CreatDate)
                    .HasColumnName("creat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatTime)
                    .HasColumnName("creat_time")
                    .HasMaxLength(5);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Isagent).HasColumnName("isagent");

                entity.Property(e => e.Istate).HasColumnName("istate");

                entity.Property(e => e.PayeCode)
                    .HasColumnName("paye_code")
                    .HasMaxLength(8);

                entity.Property(e => e.PsRate)
                    .HasColumnName("ps_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Separate).HasColumnName("separate");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Err>(entity =>
            {
                entity.ToTable("err", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Cdesc)
                    .HasColumnName("cdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(4);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Dbf)
                    .HasColumnName("dbf")
                    .HasMaxLength(10);

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(50);

                entity.Property(e => e.Err1)
                    .HasColumnName("err")
                    .HasMaxLength(10);

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasMaxLength(20);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Evl>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("evl", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etime)
                    .HasColumnName("etime")
                    .HasMaxLength(5);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasMaxLength(100);

                entity.Property(e => e.Housebill)
                    .HasColumnName("housebill")
                    .HasMaxLength(20);

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(10);

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasColumnName("site")
                    .HasMaxLength(30);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Ftplog>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("ftplog", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Downloadtime)
                    .HasColumnName("downloadtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etype)
                    .HasColumnName("etype")
                    .HasMaxLength(10);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(100);

                entity.Property(e => e.Mawb)
                    .HasColumnName("mawb")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Gcd>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("gcd", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Attn)
                    .HasColumnName("attn")
                    .HasMaxLength(50);

                entity.Property(e => e.ConNum).HasColumnName("con_num");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Daddr)
                    .HasColumnName("daddr")
                    .HasColumnType("ntext");

                entity.Property(e => e.Defa)
                    .HasColumnName("defa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("dept")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50);

                entity.Property(e => e.Gcocode)
                    .IsRequired()
                    .HasColumnName("gcocode")
                    .HasMaxLength(8);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(20);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Gdm>(entity =>
            {
                entity.HasKey(e => new { e.Dept, e.Dcode });

                entity.ToTable("gdm", "dbo");

                entity.Property(e => e.Dept)
                    .HasColumnName("dept")
                    .HasMaxLength(30);

                entity.Property(e => e.Dcode)
                    .HasColumnName("dcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.DirectPrint)
                    .HasColumnName("direct_print")
                    .HasMaxLength(50);

                entity.Property(e => e.InvPrint)
                    .HasColumnName("inv_print")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Ggm>(entity =>
            {
                entity.HasKey(e => e.Account);

                entity.ToTable("GGM", "dbo");

                entity.Property(e => e.Account)
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Account2)
                    .HasColumnName("account2")
                    .HasMaxLength(15);

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Bankcode)
                    .HasColumnName("bankcode")
                    .HasMaxLength(3);

                entity.Property(e => e.Bankno)
                    .HasColumnName("bankno")
                    .HasMaxLength(50);

                entity.Property(e => e.Cat)
                    .IsRequired()
                    .HasColumnName("cat")
                    .HasMaxLength(20);

                entity.Property(e => e.Cdesc)
                    .HasColumnName("cdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Coaccount).HasColumnName("coaccount");

                entity.Property(e => e.Contrast)
                    .HasColumnName("contrast")
                    .HasMaxLength(12);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Curr)
                    .HasColumnName("curr")
                    .HasMaxLength(3);

                entity.Property(e => e.CurrentComp)
                    .HasColumnName("current_comp")
                    .HasMaxLength(8);

                entity.Property(e => e.Currentacc)
                    .HasColumnName("currentacc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Depreciation)
                    .HasColumnName("depreciation")
                    .HasMaxLength(12);

                entity.Property(e => e.Desc2)
                    .HasColumnName("desc2")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Gcur)
                    .HasColumnName("gcur")
                    .HasMaxLength(3);

                entity.Property(e => e.Grate)
                    .HasColumnName("grate")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Group).HasMaxLength(2);

                entity.Property(e => e.Group1)
                    .HasColumnName("group1")
                    .HasMaxLength(30);

                entity.Property(e => e.Lock)
                    .HasColumnName("lock")
                    .HasMaxLength(1);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasMaxLength(1);

                entity.Property(e => e.Nochq).HasColumnName("nochq");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("ntext");

                entity.Property(e => e.Ocost).HasColumnName("ocost");

                entity.Property(e => e.Oincome).HasColumnName("oincome");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasMaxLength(8);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(2);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext");

                entity.Property(e => e.Short).HasMaxLength(10);

                entity.Property(e => e.Site01)
                    .HasColumnName("site01")
                    .HasMaxLength(30);

                entity.Property(e => e.Site02)
                    .HasColumnName("site02")
                    .HasMaxLength(30);

                entity.Property(e => e.Site03)
                    .HasColumnName("site03")
                    .HasMaxLength(30);

                entity.Property(e => e.Site04)
                    .HasColumnName("site04")
                    .HasMaxLength(30);

                entity.Property(e => e.Site05)
                    .HasColumnName("site05")
                    .HasMaxLength(30);

                entity.Property(e => e.Site06)
                    .HasColumnName("site06")
                    .HasMaxLength(30);

                entity.Property(e => e.Site07)
                    .HasColumnName("site07")
                    .HasMaxLength(30);

                entity.Property(e => e.Site08)
                    .HasColumnName("site08")
                    .HasMaxLength(30);

                entity.Property(e => e.Site09)
                    .HasColumnName("site09")
                    .HasMaxLength(30);

                entity.Property(e => e.Site10)
                    .HasColumnName("site10")
                    .HasMaxLength(30);

                entity.Property(e => e.Site11)
                    .HasColumnName("site11")
                    .HasMaxLength(30);

                entity.Property(e => e.Site12)
                    .HasColumnName("site12")
                    .HasMaxLength(30);

                entity.Property(e => e.Site13)
                    .HasColumnName("site13")
                    .HasMaxLength(30);

                entity.Property(e => e.Site14)
                    .HasColumnName("site14")
                    .HasMaxLength(30);

                entity.Property(e => e.Site15)
                    .HasColumnName("site15")
                    .HasMaxLength(30);

                entity.Property(e => e.Site16)
                    .HasColumnName("site16")
                    .HasMaxLength(30);

                entity.Property(e => e.Site17)
                    .HasColumnName("site17")
                    .HasMaxLength(30);

                entity.Property(e => e.Site18)
                    .HasColumnName("site18")
                    .HasMaxLength(30);

                entity.Property(e => e.Site19)
                    .HasColumnName("site19")
                    .HasMaxLength(30);

                entity.Property(e => e.Site20)
                    .HasColumnName("site20")
                    .HasMaxLength(30);

                entity.Property(e => e.Site21)
                    .HasColumnName("site21")
                    .HasMaxLength(30);

                entity.Property(e => e.Site22)
                    .HasColumnName("site22")
                    .HasMaxLength(30);

                entity.Property(e => e.Site23)
                    .HasColumnName("site23")
                    .HasMaxLength(30);

                entity.Property(e => e.Site24)
                    .HasColumnName("site24")
                    .HasMaxLength(30);

                entity.Property(e => e.Site25)
                    .HasColumnName("site25")
                    .HasMaxLength(30);

                entity.Property(e => e.Site26)
                    .HasColumnName("site26")
                    .HasMaxLength(30);

                entity.Property(e => e.Site27)
                    .HasColumnName("site27")
                    .HasMaxLength(30);

                entity.Property(e => e.Site28)
                    .HasColumnName("site28")
                    .HasMaxLength(30);

                entity.Property(e => e.Site29)
                    .HasColumnName("site29")
                    .HasMaxLength(30);

                entity.Property(e => e.Site30)
                    .HasColumnName("site30")
                    .HasMaxLength(30);

                entity.Property(e => e.Site31)
                    .HasColumnName("site31")
                    .HasMaxLength(30);

                entity.Property(e => e.Site32)
                    .HasColumnName("site32")
                    .HasMaxLength(30);

                entity.Property(e => e.Site33)
                    .HasColumnName("site33")
                    .HasMaxLength(30);

                entity.Property(e => e.Site34)
                    .HasColumnName("site34")
                    .HasMaxLength(30);

                entity.Property(e => e.Site35)
                    .HasColumnName("site35")
                    .HasMaxLength(30);

                entity.Property(e => e.Site36)
                    .HasColumnName("site36")
                    .HasMaxLength(30);

                entity.Property(e => e.Site37)
                    .HasColumnName("site37")
                    .HasMaxLength(30);

                entity.Property(e => e.Site38)
                    .HasColumnName("site38")
                    .HasMaxLength(30);

                entity.Property(e => e.Site39)
                    .HasColumnName("site39")
                    .HasMaxLength(30);

                entity.Property(e => e.Site40)
                    .HasColumnName("site40")
                    .HasMaxLength(30);

                entity.Property(e => e.Site41)
                    .HasColumnName("site41")
                    .HasMaxLength(30);

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Upto).HasColumnName("upto");

                entity.Property(e => e.Yacc1)
                    .HasColumnName("yacc1")
                    .HasMaxLength(20);

                entity.Property(e => e.Yacc2)
                    .HasColumnName("yacc2")
                    .HasMaxLength(20);

                entity.Property(e => e.Yacc3)
                    .HasColumnName("yacc3")
                    .HasMaxLength(20);

                entity.Property(e => e.Yacc4)
                    .HasColumnName("yacc4")
                    .HasMaxLength(20);

                entity.Property(e => e.Ydesc)
                    .HasColumnName("ydesc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Gph>(entity =>
            {
                entity.HasKey(e => e.Gkey);

                entity.ToTable("gph", "dbo");

                entity.Property(e => e.Gkey).HasColumnName("GKEY");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Gcode)
                    .IsRequired()
                    .HasColumnName("GCODE")
                    .HasMaxLength(10);

                entity.Property(e => e.Help)
                    .HasColumnName("HELP")
                    .HasMaxLength(20);

                entity.Property(e => e.Hmcolor)
                    .HasColumnName("HMCOLOR")
                    .HasMaxLength(7);

                entity.Property(e => e.Hwcolor)
                    .HasColumnName("HWCOLOR")
                    .HasMaxLength(7);

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.Menubar)
                    .HasColumnName("MENUBAR")
                    .HasMaxLength(7);

                entity.Property(e => e.Menuhigh)
                    .HasColumnName("MENUHIGH")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nmcolor)
                    .HasColumnName("NMCOLOR")
                    .HasMaxLength(7);

                entity.Property(e => e.Nmsize)
                    .HasColumnName("NMSIZE")
                    .HasMaxLength(2);

                entity.Property(e => e.Nmwidth)
                    .HasColumnName("NMWIDTH")
                    .HasMaxLength(4);

                entity.Property(e => e.Nwcolor)
                    .HasColumnName("NWCOLOR")
                    .HasMaxLength(7);

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasMaxLength(10);

                entity.Property(e => e.System)
                    .HasColumnName("SYSTEM")
                    .HasMaxLength(10);

                entity.Property(e => e.Tmsize)
                    .HasColumnName("TMSIZE")
                    .HasMaxLength(2);

                entity.Property(e => e.Tmwidth)
                    .HasColumnName("TMWIDTH")
                    .HasMaxLength(4);

                entity.Property(e => e.Twcolor)
                    .HasColumnName("TWCOLOR")
                    .HasMaxLength(7);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Gtp>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("gtp", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Account).HasMaxLength(12);

                entity.Property(e => e.Rtype)
                    .HasColumnName("rtype")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Linermstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("linermstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .HasMaxLength(30);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Intracode)
                    .HasColumnName("intracode")
                    .HasMaxLength(20);

                entity.Property(e => e.Inttraedi).HasColumnName("inttraedi");

                entity.Property(e => e.Issudate)
                    .IsRequired()
                    .HasColumnName("issudate")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Quotenable).HasColumnName("quotenable");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Scac)
                    .HasColumnName("scac")
                    .HasMaxLength(4);

                entity.Property(e => e.Short)
                    .HasColumnName("short")
                    .HasMaxLength(15);

                entity.Property(e => e.Subcode)
                    .HasColumnName("subcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Wincode)
                    .HasColumnName("wincode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Osf>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("osf", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Desc2)
                    .HasColumnName("desc2")
                    .HasMaxLength(30);

                entity.Property(e => e.Ocode)
                    .IsRequired()
                    .HasColumnName("ocode")
                    .HasMaxLength(30);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Pic>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("PIC", "dbo");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Attached)
                    .HasColumnName("attached")
                    .HasMaxLength(50);

                entity.Property(e => e.Blhead).HasColumnName("blhead");

                entity.Property(e => e.Blno)
                    .HasColumnName("blno")
                    .HasMaxLength(50);

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("ntext");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Doc)
                    .HasColumnName("doc")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("ntext");

                entity.Property(e => e.Emailfrom)
                    .HasColumnName("emailfrom")
                    .HasMaxLength(100);

                entity.Property(e => e.Emailto)
                    .HasColumnName("emailto")
                    .HasMaxLength(100);

                entity.Property(e => e.Emailtocc)
                    .HasColumnName("emailtocc")
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(200);

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Jobn)
                    .HasColumnName("jobn")
                    .HasMaxLength(20);

                entity.Property(e => e.Mkey).HasColumnName("mkey");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(20);

                entity.Property(e => e.Operinv).HasColumnName("operinv");

                entity.Property(e => e.Pdte)
                    .HasColumnName("pdte")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Pgm)
                    .HasColumnName("pgm")
                    .HasMaxLength(15);

                entity.Property(e => e.Pict)
                    .HasColumnName("pict")
                    .HasColumnType("image");

                entity.Property(e => e.Remk)
                    .HasColumnName("remk")
                    .HasColumnType("ntext");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(20);

                entity.Property(e => e.Send).HasColumnName("send");

                entity.Property(e => e.Subcode)
                    .HasColumnName("subcode")
                    .HasMaxLength(5);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(60);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Portmstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("portmstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ams)
                    .HasColumnName("ams")
                    .HasMaxLength(10);

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Edi)
                    .HasColumnName("edi")
                    .HasMaxLength(5);

                entity.Property(e => e.Fams)
                    .HasColumnName("fams")
                    .HasMaxLength(20);

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(3);

                entity.Property(e => e.PortLdes1)
                    .HasColumnName("port_ldes1")
                    .HasMaxLength(60);

                entity.Property(e => e.PortLdes2)
                    .HasColumnName("port_ldes2")
                    .HasMaxLength(60);

                entity.Property(e => e.PortLdes3)
                    .HasColumnName("port_ldes3")
                    .HasMaxLength(60);

                entity.Property(e => e.PortLdes4)
                    .HasColumnName("port_ldes4")
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(10);

                entity.Property(e => e.Uncode)
                    .HasColumnName("uncode")
                    .HasMaxLength(5);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.ZoneCode)
                    .HasColumnName("zone_code")
                    .HasMaxLength(10);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Portmstr)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_portmstr_ctrymstr");
            });

            modelBuilder.Entity<Rco>(entity =>
            {
                entity.ToTable("rco", "dbo");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasColumnType("ntext");

                entity.Property(e => e.Bank2)
                    .HasColumnName("bank2")
                    .HasColumnType("ntext");

                entity.Property(e => e.Bank3)
                    .HasColumnName("bank3")
                    .HasColumnType("ntext");

                entity.Property(e => e.Caddr)
                    .HasColumnName("caddr")
                    .HasColumnType("ntext");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Ediaddr)
                    .HasColumnName("ediaddr")
                    .HasMaxLength(35);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50);

                entity.Property(e => e.Helpalertemail)
                    .HasColumnName("helpalertemail")
                    .HasMaxLength(1000);

                entity.Property(e => e.Homepage)
                    .HasColumnName("homepage")
                    .HasMaxLength(100);

                entity.Property(e => e.Ownsite)
                    .HasColumnName("ownsite")
                    .HasMaxLength(20);

                entity.Property(e => e.Rptaddr)
                    .HasColumnName("rptaddr")
                    .HasMaxLength(35);

                entity.Property(e => e.Saddr)
                    .HasColumnName("saddr")
                    .HasColumnType("ntext");

                entity.Property(e => e.Smtp)
                    .HasColumnName("smtp")
                    .HasMaxLength(50);

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(50);

                entity.Property(e => e.Sname2)
                    .HasColumnName("sname2")
                    .HasColumnType("ntext");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Regnmstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("regnmstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("ntext");

                entity.Property(e => e.Rgroup)
                    .HasColumnName("rgroup")
                    .HasMaxLength(8);

                entity.Property(e => e.ShortDesc)
                    .HasColumnName("short_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => e.Site1);

                entity.ToTable("site", "dbo");

                entity.Property(e => e.Site1)
                    .HasColumnName("site")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Analgroup)
                    .HasColumnName("analgroup")
                    .HasMaxLength(20);

                entity.Property(e => e.Analysis)
                    .HasColumnName("analysis")
                    .HasMaxLength(20);

                entity.Property(e => e.Autoedi).HasColumnName("autoedi");

                entity.Property(e => e.Autorpt).HasColumnName("autorpt");

                entity.Property(e => e.BiFinRegion)
                    .HasColumnName("bi_fin_region")
                    .HasMaxLength(30);

                entity.Property(e => e.BiOpsRegion)
                    .HasColumnName("bi_ops_region")
                    .HasMaxLength(30);

                entity.Property(e => e.CurrentAccount)
                    .HasColumnName("current_account")
                    .HasMaxLength(10);

                entity.Property(e => e.Dbname)
                    .HasColumnName("dbname")
                    .HasMaxLength(20);

                entity.Property(e => e.Dcur)
                    .HasColumnName("dcur")
                    .HasMaxLength(3);

                entity.Property(e => e.Exrate)
                    .HasColumnName("exrate")
                    .HasColumnType("numeric(14, 6)");

                entity.Property(e => e.Genmenu)
                    .HasColumnName("genmenu")
                    .HasMaxLength(1);

                entity.Property(e => e.InttraCode).HasMaxLength(30);

                entity.Property(e => e.Letter)
                    .HasColumnName("letter")
                    .HasMaxLength(60);

                entity.Property(e => e.Limage)
                    .HasColumnName("limage")
                    .HasMaxLength(60);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(4);

                entity.Property(e => e.Menubreak).HasColumnName("menubreak");

                entity.Property(e => e.Menuname)
                    .HasColumnName("menuname")
                    .HasMaxLength(20);

                entity.Property(e => e.Owncode)
                    .HasColumnName("owncode")
                    .HasMaxLength(20);

                entity.Property(e => e.Redirect)
                    .HasColumnName("redirect")
                    .HasMaxLength(500);

                entity.Property(e => e.Rgdisable).HasColumnName("rgdisable");

                entity.Property(e => e.Rlocation)
                    .HasColumnName("rlocation")
                    .HasMaxLength(4);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Servername)
                    .HasColumnName("servername")
                    .HasMaxLength(100);

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(50);

                entity.Property(e => e.Taxaccount)
                    .HasColumnName("taxaccount")
                    .HasMaxLength(30);

                entity.Property(e => e.Taxdbname)
                    .HasColumnName("taxdbname")
                    .HasMaxLength(20);

                entity.Property(e => e.Taxfhr)
                    .HasColumnName("taxfhr")
                    .HasMaxLength(20);

                entity.Property(e => e.Taxskr)
                    .HasColumnName("taxskr")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Site2>(entity =>
            {
                entity.ToTable("site2", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentAccount)
                    .HasColumnName("current_account")
                    .HasMaxLength(10);

                entity.Property(e => e.Dbname)
                    .HasColumnName("dbname")
                    .HasMaxLength(20);

                entity.Property(e => e.Dcur)
                    .HasColumnName("dcur")
                    .HasMaxLength(3);

                entity.Property(e => e.Exrate)
                    .HasColumnName("exrate")
                    .HasColumnType("numeric(14, 6)");

                entity.Property(e => e.Genmenu)
                    .HasColumnName("genmenu")
                    .HasMaxLength(1);

                entity.Property(e => e.InttraCode).HasMaxLength(30);

                entity.Property(e => e.Letter)
                    .HasColumnName("letter")
                    .HasMaxLength(60);

                entity.Property(e => e.Limage)
                    .HasColumnName("limage")
                    .HasMaxLength(60);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(4);

                entity.Property(e => e.Menubreak).HasColumnName("menubreak");

                entity.Property(e => e.Menuname)
                    .HasColumnName("menuname")
                    .HasMaxLength(20);

                entity.Property(e => e.Owncode)
                    .HasColumnName("owncode")
                    .HasMaxLength(20);

                entity.Property(e => e.Rgdisable).HasColumnName("rgdisable");

                entity.Property(e => e.Rlocation)
                    .HasColumnName("rlocation")
                    .HasMaxLength(4);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Servername)
                    .HasColumnName("servername")
                    .HasMaxLength(50);

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasColumnName("site")
                    .HasMaxLength(30);

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(50);

                entity.Property(e => e.Taxdbname)
                    .HasColumnName("taxdbname")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Sizemstr>(entity =>
            {
                entity.HasKey(e => e.ContSize);

                entity.ToTable("sizemstr", "dbo");

                entity.Property(e => e.ContSize)
                    .HasColumnName("cont_size")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Definition)
                    .HasColumnName("definition")
                    .HasMaxLength(50);

                entity.Property(e => e.Loading)
                    .HasColumnName("loading")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasMaxLength(3);

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasMaxLength(5);

                entity.Property(e => e.Teu)
                    .HasColumnName("teu")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Sod>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("sod", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Sta>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("sta", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Labno)
                    .HasColumnName("labno")
                    .HasMaxLength(30);

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.Station)
                    .HasColumnName("station")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.Stime)
                    .HasColumnName("stime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TempRpt>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("temp_rpt", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Adjust)
                    .HasColumnName("adjust")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Beforetax)
                    .HasColumnName("beforetax")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Blno)
                    .HasColumnName("blno")
                    .HasMaxLength(20);

                entity.Property(e => e.Bound)
                    .HasColumnName("bound")
                    .HasMaxLength(1);

                entity.Property(e => e.Broker)
                    .HasColumnName("broker")
                    .HasMaxLength(8);

                entity.Property(e => e.Brokername)
                    .HasColumnName("brokername")
                    .HasMaxLength(50);

                entity.Property(e => e.Cbm)
                    .HasColumnName("cbm")
                    .HasColumnType("decimal(20, 3)");

                entity.Property(e => e.Cgcode)
                    .HasColumnName("cgcode")
                    .HasMaxLength(8);

                entity.Property(e => e.Cgcrtdate)
                    .HasColumnName("cgcrtdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Cghname)
                    .HasColumnName("cghname")
                    .HasMaxLength(50);

                entity.Property(e => e.Cgname)
                    .HasColumnName("cgname")
                    .HasMaxLength(50);

                entity.Property(e => e.Cgsales)
                    .HasColumnName("cgsales")
                    .HasMaxLength(20);

                entity.Property(e => e.Container)
                    .HasColumnName("container")
                    .HasMaxLength(4000);

                entity.Property(e => e.Cstat)
                    .HasColumnName("cstat")
                    .HasMaxLength(10);

                entity.Property(e => e.Custname)
                    .HasColumnName("custname")
                    .HasMaxLength(50);

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasMaxLength(8);

                entity.Property(e => e.Custsales)
                    .HasColumnName("custsales")
                    .HasMaxLength(20);

                entity.Property(e => e.Deli)
                    .HasColumnName("deli")
                    .HasMaxLength(5);

                entity.Property(e => e.DeliName)
                    .HasColumnName("deli_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DeliRegn)
                    .HasColumnName("deli_regn")
                    .HasMaxLength(50);

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasMaxLength(5);

                entity.Property(e => e.DestName)
                    .HasColumnName("dest_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DestRegn)
                    .HasColumnName("dest_regn")
                    .HasMaxLength(50);

                entity.Property(e => e.Destcou)
                    .HasColumnName("destcou")
                    .HasMaxLength(2);

                entity.Property(e => e.Div1)
                    .HasColumnName("div1")
                    .HasMaxLength(1);

                entity.Property(e => e.Div2)
                    .HasColumnName("div2")
                    .HasMaxLength(1);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(10);

                entity.Property(e => e.Dtcode)
                    .HasColumnName("dtcode")
                    .HasMaxLength(8);

                entity.Property(e => e.Dtname)
                    .HasColumnName("dtname")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtshort)
                    .HasColumnName("dtshort")
                    .HasMaxLength(25);

                entity.Property(e => e.Fcost)
                    .HasColumnName("fcost")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Fincome)
                    .HasColumnName("fincome")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.FrtTerms)
                    .HasColumnName("frt_terms")
                    .HasMaxLength(2);

                entity.Property(e => e.HouseType)
                    .HasColumnName("house_type")
                    .HasMaxLength(20);

                entity.Property(e => e.Jobn)
                    .HasColumnName("jobn")
                    .HasMaxLength(20);

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.Lcl)
                    .HasColumnName("lcl")
                    .HasColumnType("decimal(20, 3)");

                entity.Property(e => e.Lcontract)
                    .HasColumnName("lcontract")
                    .HasMaxLength(20);

                entity.Property(e => e.Liner)
                    .HasColumnName("liner")
                    .HasMaxLength(10);

                entity.Property(e => e.Linername)
                    .HasColumnName("linername")
                    .HasMaxLength(50);

                entity.Property(e => e.LocTerms)
                    .HasColumnName("loc_terms")
                    .HasMaxLength(2);

                entity.Property(e => e.Nature)
                    .HasColumnName("nature")
                    .HasMaxLength(50);

                entity.Property(e => e.Nfcost)
                    .HasColumnName("nfcost")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Nfincome)
                    .HasColumnName("nfincome")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.ObDate)
                    .HasColumnName("ob_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pcustname)
                    .HasColumnName("pcustname")
                    .HasMaxLength(50);

                entity.Property(e => e.Pcustomer)
                    .HasColumnName("pcustomer")
                    .HasMaxLength(8);

                entity.Property(e => e.Pod)
                    .HasColumnName("pod")
                    .HasMaxLength(5);

                entity.Property(e => e.PodCou)
                    .HasColumnName("pod_cou")
                    .HasMaxLength(2);

                entity.Property(e => e.PodName)
                    .HasColumnName("pod_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PodRegn)
                    .HasColumnName("pod_regn")
                    .HasMaxLength(50);

                entity.Property(e => e.Pol)
                    .HasColumnName("pol")
                    .HasMaxLength(5);

                entity.Property(e => e.PolCou)
                    .HasColumnName("pol_cou")
                    .HasMaxLength(2);

                entity.Property(e => e.PolName)
                    .HasColumnName("pol_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PolRegn)
                    .HasColumnName("pol_regn")
                    .HasMaxLength(50);

                entity.Property(e => e.Pscost)
                    .HasColumnName("pscost")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Psincome)
                    .HasColumnName("psincome")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rcustomer)
                    .HasColumnName("rcustomer")
                    .HasMaxLength(8);

                entity.Property(e => e.Rece)
                    .HasColumnName("rece")
                    .HasMaxLength(5);

                entity.Property(e => e.ReceName)
                    .HasColumnName("rece_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceRegn)
                    .HasColumnName("rece_regn")
                    .HasMaxLength(50);

                entity.Property(e => e.Rocode)
                    .HasColumnName("rocode")
                    .HasMaxLength(8);

                entity.Property(e => e.Roname)
                    .HasColumnName("roname")
                    .HasMaxLength(50);

                entity.Property(e => e.Roshort)
                    .HasColumnName("roshort")
                    .HasMaxLength(25);

                entity.Property(e => e.Rotype)
                    .HasColumnName("rotype")
                    .HasMaxLength(2);

                entity.Property(e => e.Salesman)
                    .HasColumnName("salesman")
                    .HasMaxLength(20);

                entity.Property(e => e.Scode)
                    .HasColumnName("scode")
                    .HasMaxLength(8);

                entity.Property(e => e.Scrtdate)
                    .HasColumnName("scrtdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasMaxLength(10);

                entity.Property(e => e.Shname)
                    .HasColumnName("shname")
                    .HasMaxLength(50);

                entity.Property(e => e.Shptno).HasColumnName("shptno");

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(4);

                entity.Property(e => e.Siteseq).HasColumnName("siteseq");

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(50);

                entity.Property(e => e.Spotid)
                    .HasColumnName("spotid")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssales)
                    .HasColumnName("ssales")
                    .HasMaxLength(20);

                entity.Property(e => e.Teu)
                    .HasColumnName("teu")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Vatcost)
                    .HasColumnName("vatcost")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Vatincome)
                    .HasColumnName("vatincome")
                    .HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Vessel)
                    .HasColumnName("vessel")
                    .HasMaxLength(10);

                entity.Property(e => e.Vname)
                    .HasColumnName("vname")
                    .HasMaxLength(200);

                entity.Property(e => e.Voyage)
                    .HasColumnName("voyage")
                    .HasMaxLength(15);

                entity.Property(e => e.Warehouse)
                    .HasColumnName("warehouse")
                    .HasMaxLength(10);

                entity.Property(e => e.Wgt)
                    .HasColumnName("wgt")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.X20)
                    .HasColumnName("x20")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.X40)
                    .HasColumnName("x40")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.X45)
                    .HasColumnName("x45")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Xcommo)
                    .HasColumnName("xcommo")
                    .HasMaxLength(21);

                entity.Property(e => e.Xcq)
                    .HasColumnName("xcq")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Xcrtname)
                    .HasColumnName("xcrtname")
                    .HasMaxLength(50);

                entity.Property(e => e.Xday)
                    .HasColumnName("xday")
                    .HasMaxLength(3);

                entity.Property(e => e.Xeta)
                    .HasColumnName("xeta")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xetd)
                    .HasColumnName("xetd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xfulldate)
                    .HasColumnName("xfulldate")
                    .HasMaxLength(4000);

                entity.Property(e => e.Xmobl)
                    .HasColumnName("xmobl")
                    .HasMaxLength(20);

                entity.Property(e => e.Xmonth)
                    .HasColumnName("xmonth")
                    .HasMaxLength(3);

                entity.Property(e => e.Xosize)
                    .HasColumnName("xosize")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Xweek)
                    .HasColumnName("xweek")
                    .HasMaxLength(3);

                entity.Property(e => e.Xyear)
                    .HasColumnName("xyear")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<Ter>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("ter", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Cdesc2)
                    .HasColumnName("cdesc2")
                    .HasMaxLength(50);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Ddate).HasColumnName("ddate");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Trc>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("trc", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(2);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Tradecode)
                    .HasColumnName("tradecode")
                    .HasMaxLength(30);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Trm>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("trm", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Tdesc)
                    .HasColumnName("tdesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Trp>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("trp", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasMaxLength(5);

                entity.Property(e => e.Tradecode)
                    .HasColumnName("tradecode")
                    .HasMaxLength(30);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Uld>(entity =>
            {
                entity.HasKey(e => e.Utype);

                entity.ToTable("ULD", "dbo");

                entity.Property(e => e.Utype)
                    .HasColumnName("utype")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Usd>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("usd", "dbo");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20);

                entity.Property(e => e.Ldte)
                    .HasColumnName("LDTE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(50);

                entity.Property(e => e.Success).HasColumnName("SUCCESS");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Usrname)
                    .HasColumnName("USRNAME")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Usermstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("usermstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(35);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Isinact).HasColumnName("isinact");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(35);

                entity.Property(e => e.Office)
                    .HasColumnName("office")
                    .HasMaxLength(4);

                entity.Property(e => e.Ownsite)
                    .HasColumnName("ownsite")
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(35);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Usm>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("usm", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Usalesman)
                    .IsRequired()
                    .HasColumnName("usalesman")
                    .HasMaxLength(20);

                entity.Property(e => e.Usrname)
                    .IsRequired()
                    .HasColumnName("usrname")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Usp>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("usp", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Usrname)
                    .HasColumnName("usrname")
                    .HasMaxLength(15);

                entity.Property(e => e.Utype)
                    .HasColumnName("utype")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usr>(entity =>
            {
                entity.ToTable("usr", "dbo");

                entity.Property(e => e.AAdd).HasColumnName("a_add");

                entity.Property(e => e.AAppr).HasColumnName("a_appr");

                entity.Property(e => e.AcAdd).HasColumnName("ac_add");

                entity.Property(e => e.AcAppr).HasColumnName("ac_appr");

                entity.Property(e => e.Acctmenu)
                    .HasColumnName("acctmenu")
                    .HasMaxLength(10);

                entity.Property(e => e.Acctpstart)
                    .HasColumnName("acctpstart")
                    .HasMaxLength(20);

                entity.Property(e => e.Acctuser).HasColumnName("acctuser");

                entity.Property(e => e.AddRight)
                    .HasColumnName("add_right")
                    .HasMaxLength(1);

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Airmenu)
                    .HasColumnName("airmenu")
                    .HasMaxLength(10);

                entity.Property(e => e.Airpstart)
                    .HasColumnName("airpstart")
                    .HasMaxLength(20);

                entity.Property(e => e.Airuser).HasColumnName("airuser");

                entity.Property(e => e.Akey)
                    .HasColumnName("akey")
                    .HasMaxLength(200);

                entity.Property(e => e.Akeytime)
                    .HasColumnName("akeytime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Anlmenu)
                    .HasColumnName("anlmenu")
                    .HasMaxLength(10);

                entity.Property(e => e.Anlpstart)
                    .HasColumnName("anlpstart")
                    .HasMaxLength(20);

                entity.Property(e => e.Anluser).HasColumnName("anluser");

                entity.Property(e => e.ApprRight)
                    .HasColumnName("appr_right")
                    .HasMaxLength(1);

                entity.Property(e => e.C1)
                    .HasColumnName("c1")
                    .HasMaxLength(1);

                entity.Property(e => e.C2)
                    .HasColumnName("c2")
                    .HasMaxLength(1);

                entity.Property(e => e.CAdd).HasColumnName("c_add");

                entity.Property(e => e.CAppr).HasColumnName("c_appr");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(10);

                entity.Property(e => e.Copyfrom)
                    .HasColumnName("copyfrom")
                    .HasMaxLength(20);

                entity.Property(e => e.CorpAccount).HasColumnName("corp_account");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Dep)
                    .HasColumnName("dep")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Expire)
                    .HasColumnName("expire")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50);

                entity.Property(e => e.GAdd).HasColumnName("g_add");

                entity.Property(e => e.GAppr).HasColumnName("g_appr");

                entity.Property(e => e.Initial)
                    .HasColumnName("initial")
                    .HasMaxLength(50);

                entity.Property(e => e.Isinact).HasColumnName("isinact");

                entity.Property(e => e.LAdd).HasColumnName("l_add");

                entity.Property(e => e.LAppr).HasColumnName("l_appr");

                entity.Property(e => e.Lang)
                    .HasColumnName("lang")
                    .HasMaxLength(1);

                entity.Property(e => e.Menu)
                    .HasColumnName("menu")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Noedit).HasColumnName("noedit");

                entity.Property(e => e.Noexcel).HasColumnName("noexcel");

                entity.Property(e => e.Opt01).HasColumnName("opt01");

                entity.Property(e => e.Opt02).HasColumnName("opt02");

                entity.Property(e => e.Opt03).HasColumnName("opt03");

                entity.Property(e => e.Opt04).HasColumnName("opt04");

                entity.Property(e => e.Opt05).HasColumnName("opt05");

                entity.Property(e => e.Opt06).HasColumnName("opt06");

                entity.Property(e => e.Opt07).HasColumnName("opt07");

                entity.Property(e => e.Opt08).HasColumnName("opt08");

                entity.Property(e => e.Opt09).HasColumnName("opt09");

                entity.Property(e => e.Opt10).HasColumnName("opt10");

                entity.Property(e => e.Opt11).HasColumnName("opt11");

                entity.Property(e => e.Opt12).HasColumnName("opt12");

                entity.Property(e => e.Opt13).HasColumnName("opt13");

                entity.Property(e => e.Opt14).HasColumnName("opt14");

                entity.Property(e => e.Opt15).HasColumnName("opt15");

                entity.Property(e => e.PAdd).HasColumnName("p_add");

                entity.Property(e => e.PAppr).HasColumnName("p_appr");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(10);

                entity.Property(e => e.Pmess)
                    .HasColumnName("pmess")
                    .HasMaxLength(20);

                entity.Property(e => e.Pstart)
                    .HasColumnName("pstart")
                    .HasMaxLength(20);

                entity.Property(e => e.ScAdd).HasColumnName("sc_add");

                entity.Property(e => e.ScAppr).HasColumnName("sc_appr");

                entity.Property(e => e.Seamenu)
                    .HasColumnName("seamenu")
                    .HasMaxLength(10);

                entity.Property(e => e.Seapstart)
                    .HasColumnName("seapstart")
                    .HasMaxLength(20);

                entity.Property(e => e.Seauser).HasColumnName("seauser");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.Taxuser).HasColumnName("taxuser");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Trkmenu)
                    .HasColumnName("trkmenu")
                    .HasMaxLength(10);

                entity.Property(e => e.Trkpstart)
                    .HasColumnName("trkpstart")
                    .HasMaxLength(20);

                entity.Property(e => e.Trkuser).HasColumnName("trkuser");

                entity.Property(e => e.UAdd).HasColumnName("u_add");

                entity.Property(e => e.UAppr).HasColumnName("u_appr");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Usrname)
                    .HasColumnName("usrname")
                    .HasMaxLength(15);

                entity.Property(e => e.VAdd).HasColumnName("v_add");

                entity.Property(e => e.VAppr).HasColumnName("v_appr");
            });

            modelBuilder.Entity<Uss>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("uss", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.App).HasColumnName("app");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasColumnName("site")
                    .HasMaxLength(30);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Usrname)
                    .IsRequired()
                    .HasColumnName("usrname")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Veslmstr>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("veslmstr", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprDate)
                    .HasColumnName("appr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprStatus)
                    .HasColumnName("appr_status")
                    .HasMaxLength(1);

                entity.Property(e => e.ApprUser)
                    .HasColumnName("appr_user")
                    .HasMaxLength(15);

                entity.Property(e => e.Conference)
                    .HasColumnName("conference")
                    .HasMaxLength(1);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.LinerCode)
                    .HasColumnName("liner_code")
                    .HasMaxLength(10);

                entity.Property(e => e.LinerCtry)
                    .HasColumnName("liner_ctry")
                    .HasMaxLength(2);

                entity.Property(e => e.LinerGrp)
                    .HasColumnName("liner_grp")
                    .HasMaxLength(10);

                entity.Property(e => e.LinerPort)
                    .HasColumnName("liner_port")
                    .HasMaxLength(3);

                entity.Property(e => e.Register)
                    .HasColumnName("register")
                    .HasMaxLength(2);

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.HasOne(d => d.LinerCodeNavigation)
                    .WithMany(p => p.Veslmstr)
                    .HasForeignKey(d => d.LinerCode)
                    .HasConstraintName("FK_veslmstr_linermstr");
            });

            modelBuilder.Entity<Winlog>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("winlog", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Cont)
                    .HasColumnName("cont")
                    .HasMaxLength(20);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Errdesc).HasColumnName("errdesc");

                entity.Property(e => e.Oper)
                    .HasColumnName("oper")
                    .HasMaxLength(20);

                entity.Property(e => e.Retry)
                    .HasColumnName("retry")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(10);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Winlogd>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("winlogd", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Activity).HasMaxLength(300);

                entity.Property(e => e.ActivityCode)
                    .HasColumnName("Activity_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.Atapod)
                    .HasColumnName("ATAPOD")
                    .HasMaxLength(200);

                entity.Property(e => e.AtapodEventStatus)
                    .HasColumnName("ATAPOD_EventStatus")
                    .HasMaxLength(200);

                entity.Property(e => e.BlNo)
                    .HasColumnName("Bl_no")
                    .HasMaxLength(200);

                entity.Property(e => e.BookingNo)
                    .HasColumnName("Booking_no")
                    .HasMaxLength(200);

                entity.Property(e => e.Capacity).HasMaxLength(200);

                entity.Property(e => e.ContainerNo)
                    .HasColumnName("Container_no")
                    .HasMaxLength(300);

                entity.Property(e => e.ContainerType)
                    .HasColumnName("Container_type")
                    .HasMaxLength(200);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date).HasMaxLength(200);

                entity.Property(e => e.DateEventStatus)
                    .HasColumnName("Date_EventStatus")
                    .HasMaxLength(200);

                entity.Property(e => e.EtaAta)
                    .HasColumnName("ETA_ATA")
                    .HasMaxLength(200);

                entity.Property(e => e.EtaAtaEventStatus)
                    .HasColumnName("ETA_ATA_EventStatus")
                    .HasMaxLength(200);

                entity.Property(e => e.Etd)
                    .HasColumnName("ETD")
                    .HasMaxLength(200);

                entity.Property(e => e.EtdEventStatus)
                    .HasColumnName("ETD_EventStatus")
                    .HasMaxLength(200);

                entity.Property(e => e.FinalDischarge)
                    .HasColumnName("Final_Discharge")
                    .HasMaxLength(200);

                entity.Property(e => e.FinalDischargeCode)
                    .HasColumnName("Final_Discharge_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.ImoNumber)
                    .HasColumnName("Imo_Number")
                    .HasMaxLength(200);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("Location_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.Origin).HasMaxLength(200);

                entity.Property(e => e.OriginCode)
                    .HasColumnName("Origin_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.PortOfDischarging)
                    .HasColumnName("Port_Of_Discharging")
                    .HasMaxLength(200);

                entity.Property(e => e.PortOfDischargingCode)
                    .HasColumnName("Port_Of_Discharging_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.PortOfLoading)
                    .HasColumnName("Port_Of_Loading")
                    .HasMaxLength(200);

                entity.Property(e => e.PortOfLoadingCode)
                    .HasColumnName("Port_Of_Loading_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.ScacCarrierCode)
                    .HasColumnName("SCAC_Carrier_Code")
                    .HasMaxLength(200);

                entity.Property(e => e.ServiceName)
                    .HasColumnName("Service_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Source).HasMaxLength(200);

                entity.Property(e => e.VesselTrainTruck)
                    .HasColumnName("Vessel_Train_Truck")
                    .HasMaxLength(200);

                entity.Property(e => e.VoyageNumber)
                    .HasColumnName("Voyage_Number")
                    .HasMaxLength(200);

                entity.Property(e => e.Weight).HasMaxLength(200);

                entity.Property(e => e.Winlog).HasColumnName("winlog");
            });

            modelBuilder.Entity<Wlp>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("wlp", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Liner)
                    .IsRequired()
                    .HasColumnName("liner")
                    .HasMaxLength(20);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasColumnName("port")
                    .HasMaxLength(5);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Wdesc)
                    .HasColumnName("wdesc")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Wls>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("wls", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Liner)
                    .IsRequired()
                    .HasColumnName("liner")
                    .HasMaxLength(20);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Wdesc)
                    .HasColumnName("wdesc")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Zcx>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("zcx", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(20);

                entity.Property(e => e.Fmkey)
                    .HasColumnName("fmkey")
                    .HasMaxLength(20);

                entity.Property(e => e.Fmtable)
                    .HasColumnName("fmtable")
                    .HasMaxLength(20);

                entity.Property(e => e.Tokey)
                    .HasColumnName("tokey")
                    .HasMaxLength(20);

                entity.Property(e => e.Tosite)
                    .HasColumnName("tosite")
                    .HasMaxLength(20);

                entity.Property(e => e.Totable)
                    .HasColumnName("totable")
                    .HasMaxLength(20);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Zlt>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("zlt", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Dbf)
                    .HasColumnName("dbf")
                    .HasMaxLength(10);

                entity.Property(e => e.Emessage)
                    .HasColumnName("emessage")
                    .HasColumnType("ntext");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasMaxLength(1);

                entity.Property(e => e.Ltype)
                    .HasColumnName("ltype")
                    .HasMaxLength(1);

                entity.Property(e => e.Mkey)
                    .HasColumnName("mkey")
                    .HasMaxLength(20);

                entity.Property(e => e.Pdesc)
                    .HasColumnName("pdesc")
                    .HasMaxLength(30);

                entity.Property(e => e.Prg)
                    .HasColumnName("prg")
                    .HasMaxLength(15);

                entity.Property(e => e.Sql)
                    .HasColumnName("sql")
                    .HasColumnType("ntext");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Word)
                    .HasColumnName("word")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Zpa>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("ZPA", "dbo");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Chgflg)
                    .HasColumnName("chgflg")
                    .HasMaxLength(1);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Deft)
                    .HasColumnName("deft")
                    .HasMaxLength(10);

                entity.Property(e => e.Desc1)
                    .HasColumnName("desc1")
                    .HasMaxLength(60);

                entity.Property(e => e.Eseq)
                    .HasColumnName("eseq")
                    .HasMaxLength(3);

                entity.Property(e => e.Lock)
                    .HasColumnName("lock")
                    .HasMaxLength(1);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasMaxLength(1);

                entity.Property(e => e.Pop)
                    .HasColumnName("pop")
                    .HasColumnType("ntext");

                entity.Property(e => e.Prg)
                    .HasColumnName("prg")
                    .HasMaxLength(10);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("ntext");

                entity.Property(e => e.Remark2)
                    .HasColumnName("remark2")
                    .HasColumnType("ntext");

                entity.Property(e => e.Section2)
                    .HasColumnName("section2")
                    .HasMaxLength(20);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Sub)
                    .HasColumnName("sub")
                    .HasMaxLength(5);

                entity.Property(e => e.Systemuse)
                    .HasColumnName("systemuse")
                    .HasMaxLength(20);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(1);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Updtype)
                    .HasColumnName("updtype")
                    .HasMaxLength(1);

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(30);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Zpt>(entity =>
            {
                entity.HasKey(e => e.Seq);

                entity.ToTable("ZPT", "dbo");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Bdate)
                    .HasColumnName("bdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bedate)
                    .HasColumnName("bedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bsdate)
                    .HasColumnName("bsdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Emailaddcc)
                    .HasColumnName("emailaddcc")
                    .HasMaxLength(500);

                entity.Property(e => e.Emailaddr)
                    .HasColumnName("emailaddr")
                    .HasMaxLength(500);

                entity.Property(e => e.Faxjobn)
                    .HasColumnName("faxjobn")
                    .HasMaxLength(20);

                entity.Property(e => e.Faxno)
                    .HasColumnName("faxno")
                    .HasMaxLength(20);

                entity.Property(e => e.Faxsent).HasColumnName("faxsent");

                entity.Property(e => e.Faxstat)
                    .HasColumnName("faxstat")
                    .HasMaxLength(20);

                entity.Property(e => e.Fileno)
                    .HasColumnName("fileno")
                    .HasMaxLength(60);

                entity.Property(e => e.Jobid)
                    .HasColumnName("jobid")
                    .HasMaxLength(20);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasMaxLength(8);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("ntext");

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(4000);

                entity.Property(e => e.Repid)
                    .HasColumnName("repid")
                    .HasMaxLength(15);

                entity.Property(e => e.Rname)
                    .HasColumnName("rname")
                    .HasMaxLength(100);

                entity.Property(e => e.Senddoctype)
                    .HasColumnName("senddoctype")
                    .HasMaxLength(1);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Ztr>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("ztr", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Adddate)
                    .HasColumnName("adddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Adduser)
                    .HasColumnName("adduser")
                    .HasMaxLength(15);

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(15);

                entity.Property(e => e.Japanese)
                    .HasColumnName("japanese")
                    .HasMaxLength(100);

                entity.Property(e => e.Program)
                    .HasColumnName("program")
                    .HasMaxLength(20);

                entity.Property(e => e.Tchin)
                    .HasColumnName("tchin")
                    .HasMaxLength(100);

                entity.Property(e => e.Tfrom)
                    .IsRequired()
                    .HasColumnName("tfrom")
                    .HasMaxLength(100);

                entity.Property(e => e.Tto)
                    .HasColumnName("tto")
                    .HasMaxLength(100);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Zyd>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("zyd", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Batchemail)
                    .HasColumnName("batchemail")
                    .HasColumnType("ntext");

                entity.Property(e => e.Batchparameter)
                    .HasColumnName("batchparameter")
                    .HasColumnType("ntext");

                entity.Property(e => e.Batchparameter2)
                    .HasColumnName("batchparameter2")
                    .HasColumnType("ntext");

                entity.Property(e => e.Batchparameter3)
                    .HasColumnName("batchparameter3")
                    .HasColumnType("ntext");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(20);

                entity.Property(e => e.Newname)
                    .HasColumnName("newname")
                    .HasMaxLength(50);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasColumnType("ntext");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(20);

                entity.Property(e => e.Zyh).HasColumnName("zyh");
            });

            modelBuilder.Entity<Zyl>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("zyl", "dbo");

                entity.Property(e => e.Ref).HasColumnName("ref");

                entity.Property(e => e.Crtdate)
                    .HasColumnName("crtdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Crtuser)
                    .HasColumnName("crtuser")
                    .HasMaxLength(50);

                entity.Property(e => e.Ebody)
                    .HasColumnName("ebody")
                    .HasColumnType("ntext");

                entity.Property(e => e.Eto)
                    .HasColumnName("eto")
                    .HasColumnType("ntext");

                entity.Property(e => e.Fend)
                    .HasColumnName("fend")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fstart)
                    .HasColumnName("fstart")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mailsent)
                    .HasColumnName("mailsent")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sbcc)
                    .HasColumnName("sbcc")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sbody)
                    .HasColumnName("sbody")
                    .HasColumnType("ntext");

                entity.Property(e => e.Scc)
                    .HasColumnName("scc")
                    .HasColumnType("ntext");

                entity.Property(e => e.Sto)
                    .HasColumnName("sto")
                    .HasColumnType("ntext");

                entity.Property(e => e.Subj)
                    .HasColumnName("subj")
                    .HasMaxLength(300);

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Upduser)
                    .HasColumnName("upduser")
                    .HasMaxLength(20);

                entity.Property(e => e.Xattach)
                    .HasColumnName("xattach")
                    .HasColumnType("ntext");

                entity.Property(e => e.Xfrom)
                    .HasColumnName("xfrom")
                    .HasColumnType("ntext");

                entity.Property(e => e.Zyd).HasColumnName("zyd");

                entity.Property(e => e.Zyh).HasColumnName("zyh");

                entity.Property(e => e.Zyl1).HasColumnName("zyl");
            });
        }
    }
}

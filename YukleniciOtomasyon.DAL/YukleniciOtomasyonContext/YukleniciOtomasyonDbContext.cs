using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Mappings;
using YukleniciOtomasyon.Entities.Mappings.Depo;
using YukleniciOtomasyon.Entities.Mappings.Lojistik;
using YukleniciOtomasyon.Entities.Mappings.Santiye;
using YukleniciOtomasyon.Entities.Mappings.SatinAlma;
using YukleniciOtomasyon.Entities.Mappings.Tanim;
using YukleniciOtomasyon.Entities.Mappings.Teklif;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.YukleniciOtomasyonContext
{
    public class YukleniciOtomasyonDbContext : DbContext
    {
        public YukleniciOtomasyonDbContext()
        {
            #region Kutaycan

            //Database.Connection.ConnectionString = @"Server=WISSEN\MSSQL2017;Database=YukleniciOtomasyonDb;UID=sa;PWD=12345";
            //Database.Connection.ConnectionString = @"Server=KUTAYCAN\KUTAYMSSQLSERVER;Database=YukleniciOtomasyonDb;UID=sa;PWD=12345";
            #endregion

            #region Berfin

            //Database.Connection.ConnectionString = 
            //Database.Connection.ConnectionString =
            #endregion

            #region İbrahim

            //Database.Connection.ConnectionString = @"Server=.; Database=YukleniciOtomasyonDb; Integrated Security = True";
            //Database.Connection.ConnectionString = 
            #endregion

            #region Mahmut

            Database.Connection.ConnectionString = @"Server=DESKTOP-FBFUTQV\SQLEXPRESS;Database=YukleniciOtomasyonDb;UID=mhmt;PWD=Y*ld*z.1420";
            //Database.Connection.ConnectionString =
            #endregion

            #region Neslihan

            //Database.Connection.ConnectionString = @"Server=DESKTOP-Q3UK07S\SQLEXPRESS;Database=YukleniciOtomasyonDb;Integrated Security=true";
            //Database.Connection.ConnectionString = @"Server=WISSEN\MSSQLSRV;Database=YukleniciOtomasyonDb;UID=sa;PWD=12345";
            #endregion

        }
        public DbSet<Departman> Departman { get; set; }

        public DbSet<Depolar> Depolar { get; set; }
        public DbSet<DepoBirimi> DepoBirimi { get; set; }
        
        public DbSet<Personel> Personel { get; set; }
        public DbSet<PersonelIletisim> PersonelIletisim { get; set; }
        public DbSet<PersonelMuhasebe> PersonelMuhasebe { get; set; }

        public DbSet<LojistikBirimi> LojistikBirimi { get; set; }
        public DbSet<NakliyeIrsaliye> NakliyeIrsaliye { get; set; }
        public DbSet<NakliyeIslemi> NakliyeIslemi { get; set; }

        public DbSet<SantiyeBirimi> SantiyeBirimi { get; set; }
        public DbSet<Santiyeler> Santiyeler { get; set; }
        public DbSet<SantiyeIsTakibi> SantiyeIsTakibi { get; set; }

        public DbSet<SatinAlmaBirimi> SatinAlmaBirimi { get; set; }
        public DbSet<SatinAlmalar>  SatinAlmalar { get; set; }
        
        public DbSet<T_DepoOzellikleri> T_DepoOzellikleri { get; set; }
        public DbSet<T_IhaleEvraklari> IhaleEvraklari { get; set; }
        public DbSet<T_MalzemeFiyat> T_Malzemeler { get; set; }
        public DbSet<T_Malzeme> T_MalzemeOzellikleri { get; set; }
        public DbSet<T_Nakliye> Nakliye { get; set; }
        public DbSet<T_NakliyeAraclari> NakliyeAraclari { get; set; }
        public DbSet<T_PersonelUnvan> PersonelUnvan { get; set; }
        public DbSet<T_SantiyeOzellikleri> T_SantiyeOzellikleri { get; set; }
        public DbSet<T_TedarikciFirma> T_TedarikciFirma { get; set; }

        public DbSet<AcilanIhaleler> AcilanIhaleler { get; set; }
        public DbSet<TeklifBirimi> TeklifBirimi { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            modelBuilder.Configurations.Add(new DepartmanMapping());

            //Depo
            modelBuilder.Configurations.Add(new DepoBirimiMapping());
            modelBuilder.Configurations.Add(new DepolarMapping());

            //IK
            modelBuilder.Configurations.Add(new PersonelIletisimMapping());
            modelBuilder.Configurations.Add(new PersonelMapping());
            modelBuilder.Configurations.Add(new PersonelMuhasebeMapping());

            //Lojistik
            modelBuilder.Configurations.Add(new LojistikBirimiMapping());
            modelBuilder.Configurations.Add(new NakliyeIrsaliyeMapping());
            modelBuilder.Configurations.Add(new NakliyeIslemiMapping());

            //Santiye
            modelBuilder.Configurations.Add(new SantiyeBirimiMapping());
            modelBuilder.Configurations.Add(new SantiyeIsTakibiMapping());
            modelBuilder.Configurations.Add(new SantiyelerMapping());

            //SatinAlma
            modelBuilder.Configurations.Add(new SatinAlmaBirimiMapping());
            modelBuilder.Configurations.Add(new SatinAlmalarMapping());

            //Tanim
            modelBuilder.Configurations.Add(new T_DepoOzellikleriMapping());
            modelBuilder.Configurations.Add(new T_IhaleEvraklariMapping());
            modelBuilder.Configurations.Add(new T_MalzemeFiyatMapping());
            modelBuilder.Configurations.Add(new T_MalzemeMapping());
            modelBuilder.Configurations.Add(new T_NakliyeAraclariMapping());
            modelBuilder.Configurations.Add(new T_NakliyeMapping());
            modelBuilder.Configurations.Add(new T_PersonelUnvanMapping());
            modelBuilder.Configurations.Add(new T_SantiyeOzellikleriMapping());
            modelBuilder.Configurations.Add(new T_TedarikciFirmaMapping());

            //Teklif
            modelBuilder.Configurations.Add(new AcilanIhalelerMapping());
            modelBuilder.Configurations.Add(new TeklifBirimiMapping());
        }
    }
}

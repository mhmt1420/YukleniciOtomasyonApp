using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_TedarikciFirmaMapping : EntityTypeConfiguration<T_TedarikciFirma>
    {
        public T_TedarikciFirmaMapping()
        {
            Property(x => x.Ad).HasMaxLength(100).IsRequired();
            Property(x => x.Telefon).HasMaxLength(20).IsRequired();
            Property(x => x.EMail).HasMaxLength(100);
            Property(x => x.Adres).HasMaxLength(500).IsRequired();
            HasRequired(x => x.SatinAlmalar).WithOptional(y => y.TedarikciFirma);
        }
    }
}

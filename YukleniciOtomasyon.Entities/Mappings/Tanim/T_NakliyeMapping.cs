using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_NakliyeMapping : EntityTypeConfiguration<T_Nakliye>
    {
        public T_NakliyeMapping()
        { 
            Property(x => x.Ad).HasMaxLength(20).IsRequired();
            Property(x => x.Telefon).HasMaxLength(11).HasColumnType("nchar").IsRequired();
            Property(x => x.EMail).HasMaxLength(20).IsRequired();
            Property(x => x.Adres).HasMaxLength(20).IsRequired();
            HasRequired(x => x.NakliyeIrsaliye).WithOptional(y => y.GondericiFirmaBilgileri);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_SantiyeOzellikleriMapping : EntityTypeConfiguration<T_SantiyeOzellikleri>
    {
        public T_SantiyeOzellikleriMapping()
        {
            Property(x => x.Ad).HasMaxLength(20).IsRequired();
            Property(x => x.Adres).HasMaxLength(20).IsRequired();
        }
        
    }
}

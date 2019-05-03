using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_DepoOzellikleriMapping : EntityTypeConfiguration<T_DepoOzellikleri>
    {
        public T_DepoOzellikleriMapping()
        {
            Property(x => x.Ad).HasMaxLength(100).IsRequired();
            Property(x => x.Boyutu).HasMaxLength(50).IsRequired();
            Property(x => x.Adres).HasMaxLength(500).IsRequired();
        }
    }
}

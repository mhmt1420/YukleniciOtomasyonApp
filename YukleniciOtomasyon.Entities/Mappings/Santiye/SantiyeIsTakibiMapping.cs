using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.Entities.Mappings.Santiye
{
    public class SantiyeIsTakibiMapping : EntityTypeConfiguration<SantiyeIsTakibi>
    {
        public SantiyeIsTakibiMapping()
        {
            Property(x => x.YapilanIsinAdi).HasMaxLength(100).IsRequired();
            //HasMany(x => x.KullanilanMalzemeler).WithOptional().HasForeignKey(x => x.SantiyeIsTakibiId);
        }
    }
}

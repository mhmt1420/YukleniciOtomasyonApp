using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.Entities.Mappings.SatinAlma
{
    public class SatinAlmalarMapping : EntityTypeConfiguration<SatinAlmalar>
    {
        public SatinAlmalarMapping()
        {
            Property(x => x.ToplamFiyat).HasPrecision(18, 4);
            //HasMany(x => x.AlinanMalzemeler).WithOptional().HasForeignKey(x => x.SatinAlmalarId);
        }
    }
}

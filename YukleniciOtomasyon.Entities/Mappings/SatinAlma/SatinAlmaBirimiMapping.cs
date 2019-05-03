using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.Entities.Mappings.SatinAlma
{
    public class SatinAlmaBirimiMapping : EntityTypeConfiguration<SatinAlmaBirimi>
    {
        public SatinAlmaBirimiMapping()
        {
            Property(x => x.BirimAdi).HasMaxLength(50);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.Entities.Mappings.Santiye
{
    public class SantiyeBirimiMapping : EntityTypeConfiguration<SantiyeBirimi>
    {
        public SantiyeBirimiMapping()
        {
            Property(x => x.BirimAdi).HasMaxLength(50);
        }
    }
}

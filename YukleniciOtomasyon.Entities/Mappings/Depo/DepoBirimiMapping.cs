using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.Entities.Mappings.Depo
{
    public class DepoBirimiMapping : EntityTypeConfiguration<DepoBirimi>
    {
        public DepoBirimiMapping()
        {
            Property(x => x.BirimAdi).HasMaxLength(50);
        }
    }
}

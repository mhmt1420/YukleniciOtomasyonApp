using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.Entities.Mappings.Teklif
{
    public class TeklifBirimiMapping : EntityTypeConfiguration<TeklifBirimi>
    {
        public TeklifBirimiMapping()
        {
            Property(x => x.BirimAdi).HasMaxLength(50);
        }
    }
}

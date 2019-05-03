using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_MalzemeMapping : EntityTypeConfiguration<T_Malzeme>
    {
        public T_MalzemeMapping()
        {
            Property(x => x.MalzemeAdi).HasMaxLength(20).IsRequired();
            Property(x => x.Tur).HasMaxLength(100).IsRequired();
            Property(x => x.AdetTip).HasMaxLength(20).IsRequired();
            Property(x => x.En).HasPrecision(18, 5);
            Property(x => x.Boy).HasPrecision(18, 5);
            Property(x => x.Derinlik).HasPrecision(18, 5);
            Property(x => x.Agirlik).HasPrecision(18, 5);
        }
    }
}

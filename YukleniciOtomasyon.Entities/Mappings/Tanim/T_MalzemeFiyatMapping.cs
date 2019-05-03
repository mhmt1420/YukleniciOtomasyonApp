using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_MalzemeFiyatMapping : EntityTypeConfiguration<T_MalzemeFiyat>
    {
        public T_MalzemeFiyatMapping()
        {
            Property(x => x.BirimFiyat).HasPrecision(18, 4);
            
        }
    }
}

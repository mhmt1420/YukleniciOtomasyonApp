using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.Entities.Mappings.Depo
{
    public class DepolarMapping : EntityTypeConfiguration<Depolar>
    {
        public DepolarMapping()
        {
            Property(x => x.DepoAdi).HasMaxLength(50).IsRequired();
            //HasMany(x => x.DepodakiMalzemeler).WithOptional().HasForeignKey(x => x.DepolarId);
        }
    }
}

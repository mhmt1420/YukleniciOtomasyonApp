using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.Entities.Mappings.Santiye
{
    public class SantiyelerMapping : EntityTypeConfiguration<Santiyeler>
    {
        public SantiyelerMapping()
        {
            //HasMany(x => x.SantiyedekiMalzemeler).WithOptional().HasForeignKey(x => x.SantiyelerId);
        }
    }
}

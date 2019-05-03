using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.Entities.Mappings
{
    public class PersonelMuhasebeMapping : EntityTypeConfiguration<PersonelMuhasebe>
    {
        public PersonelMuhasebeMapping()
        {
            Property(x => x.Maas).HasPrecision(18, 5);
        }
    }
}

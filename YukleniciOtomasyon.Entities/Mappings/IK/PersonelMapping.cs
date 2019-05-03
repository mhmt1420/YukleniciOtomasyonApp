using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.Entities.Mappings
{
    public class PersonelMapping : EntityTypeConfiguration<Personel>
    {
        public PersonelMapping()
        {
            Property(x => x.Ad).HasMaxLength(20).IsRequired();
            Property(x => x.Soyad).HasMaxLength(20).IsRequired();
            this.HasIndex(x => x.KimlikNo).IsClustered(false).IsUnique();
            Property(x => x.KimlikNo).HasMaxLength(11).HasColumnType("nchar").IsRequired();
        }
    }
}

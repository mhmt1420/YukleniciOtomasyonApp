using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.Entities.Mappings
{
    public class PersonelIletisimMapping : EntityTypeConfiguration<PersonelIletisim>
    {
        public PersonelIletisimMapping()
        {
            Property(x => x.Telefon).HasMaxLength(15).IsRequired();
            Property(x => x.EMail).HasMaxLength(50);
            Property(x => x.Adres).HasMaxLength(500).IsRequired();
            Property(x => x.Sifre).HasMaxLength(40).IsRequired();
            Property(x => x.DahiliTel).HasMaxLength(4).HasColumnType("nchar");
            Property(x => x.PostaKodu).HasMaxLength(5).HasColumnType("nchar");
        }
    }
}

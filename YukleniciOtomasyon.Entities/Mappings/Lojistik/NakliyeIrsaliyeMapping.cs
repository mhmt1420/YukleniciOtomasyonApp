using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.Entities.Mappings.Lojistik
{
    public class NakliyeIrsaliyeMapping : EntityTypeConfiguration<NakliyeIrsaliye>
    {
        public NakliyeIrsaliyeMapping()
        {
            Property(x => x.IrsaliyeNo).HasMaxLength(20).IsRequired();
            Property(x => x.YukBirimi).HasMaxLength(20).IsRequired();
            Property(x => x.SoforAdi).HasMaxLength(20).IsRequired();
            Property(x => x.SoforSoyadi).HasMaxLength(20).IsRequired();
            Property(x => x.SoforTelefon).HasMaxLength(20).IsRequired();
            Property(x => x.TeslimAdresi).HasMaxLength(500).IsRequired();
            //HasMany(x => x.TasinanMalzemeler).WithOptional().HasForeignKey(x => x.NakliyeIrsaliyeId);
        }
    }
}

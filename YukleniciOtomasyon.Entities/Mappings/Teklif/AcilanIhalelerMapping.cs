using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.Entities.Mappings.Teklif
{
    public class AcilanIhalelerMapping : EntityTypeConfiguration<AcilanIhaleler>
    {
        public AcilanIhalelerMapping()
        {
            Property(x => x.IsinAdi).HasMaxLength(100);
            Property(x => x.KurumFirmaAdi).HasMaxLength(100).IsRequired();
            Property(x => x.IhaleOturumAdresi).HasMaxLength(300).IsRequired();
            Property(x => x.IhaleyiAlanFirmaAdi).HasMaxLength(100).IsOptional();
            Property(x => x.AlanFirmaninTeklifi).HasMaxLength(20).IsOptional();
            Property(x => x.IsTanimi).HasMaxLength(50).IsRequired();
            Property(x => x.TeknikSartname).HasMaxLength(500).IsRequired();
            Property(x => x.IdariSartname).HasMaxLength(500).IsRequired();
            Property(x => x.SozlesmeTaslagi).HasMaxLength(500).IsRequired();
        }
    }
}

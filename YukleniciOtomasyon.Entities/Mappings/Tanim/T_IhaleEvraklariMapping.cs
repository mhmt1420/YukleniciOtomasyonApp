 using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_IhaleEvraklariMapping : EntityTypeConfiguration<T_IhaleEvraklari>
    {
        public T_IhaleEvraklariMapping()
        {
            Property(x => x.TicaretOdasiKayitBelgesi).HasMaxLength(500).IsRequired();
            Property(x => x.ImzaSirkuleri).HasMaxLength(500).IsRequired();
            Property(x => x.TeklifMektubu).HasMaxLength(500).IsRequired();
            Property(x => x.GeciciTeminatMektubu).HasMaxLength(500).IsRequired();
            Property(x => x.IsBitirmeBelgesi).HasMaxLength(500).IsRequired();
            Property(x => x.Vekaletname).HasMaxLength(500).IsRequired();
            Property(x => x.OrtaklikBeyannamesi).HasMaxLength(500).IsRequired();
            Property(x => x.BankaReferansMektubu).HasMaxLength(500).IsRequired();
            Property(x => x.MeslekiYeterlilik).HasMaxLength(500).IsRequired();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class DepartmanMapping : EntityTypeConfiguration<Departman>
    {
        public DepartmanMapping()
        {
            Property(x => x.DepartmanAdi).HasMaxLength(50);
            HasMany(x=>x.Personeller)
                .WithMany(c => c.Departmanlar)
                .Map(cs =>
                {
                    cs.MapLeftKey("DepartmanId");
                    cs.MapRightKey("PersonelId");
                    cs.ToTable("DepartmanPersonel");
                });
        }
    }
}

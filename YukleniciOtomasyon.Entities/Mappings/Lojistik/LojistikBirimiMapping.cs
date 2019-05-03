using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.Entities.Mappings.Lojistik
{
    public class LojistikBirimiMapping : EntityTypeConfiguration<LojistikBirimi>
    {
        public LojistikBirimiMapping()
        {
            Property(x => x.BirimAdi).HasMaxLength(50);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Mappings.Tanim
{
    public class T_PersonelUnvanMapping : EntityTypeConfiguration<T_PersonelUnvan>
    {
        public T_PersonelUnvanMapping()
        {
            Property(x => x.UnvanAdi).HasMaxLength(80).IsRequired();
        }
    }
}

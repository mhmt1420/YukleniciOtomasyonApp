using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukleniciOtomasyon.Entities.Model
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            AktifMi = true;
            OlusturulmaTarihi = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime? DuzenlenmeTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}

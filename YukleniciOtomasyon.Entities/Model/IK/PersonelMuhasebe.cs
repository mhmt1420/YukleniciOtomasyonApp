using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukleniciOtomasyon.Entities.Model.IK
{
    public class PersonelMuhasebe : BaseEntity
    {
        public decimal Maas { get; set; }

        public int PersonelId { get; set; }

        //Navigation Property
        public virtual Personel Personel { get; set; }
    }
}

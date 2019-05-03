using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_PersonelUnvan:BaseEntity
    {
        public string UnvanAdi { get; set; }

        public int PersonelId { get; set; }

        //Navigation Property
        public virtual Personel Personel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_MalzemeFiyat:BaseEntity
    {
        public decimal BirimFiyat { get; set; }

        public int MalzemeId { get; set; }

        //Navigation Property
        public virtual T_Malzeme Malzeme { get; set; }
    }
}

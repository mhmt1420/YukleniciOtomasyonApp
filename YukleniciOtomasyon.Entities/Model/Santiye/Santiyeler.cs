using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Santiye
{
    public class Santiyeler : BaseEntity
    {
        public Santiyeler()
        {
            SantiyedekiMalzemeler = new List<T_Malzeme>();
            SantiyeIsTakipleri = new List<SantiyeIsTakibi>();
            //SantiyePersonelleri = new List<PersonelTanimi>();
            SantiyeOzellikleri = new List<T_SantiyeOzellikleri>();
        }
        public int SantiyeBirimiId { get; set; }

        //Navigation Properties
        public virtual SantiyeBirimi SantiyeBirimi { get; set; }
        //public virtual ICollection<PersonelTanimi> SantiyePersonelleri { get; set; }
        public virtual ICollection<T_Malzeme> SantiyedekiMalzemeler { get; set; }
        public virtual ICollection<T_SantiyeOzellikleri> SantiyeOzellikleri { get; set; }
        public virtual ICollection<SantiyeIsTakibi> SantiyeIsTakipleri { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Santiye
{
    public class SantiyeIsTakibi : BaseEntity
    {
        public SantiyeIsTakibi()
        {
            KullanilanMalzemeler = new List<T_Malzeme>();
        }
        public string YapilanIsinAdi { get; set; }
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime? IsBitisTarihi { get; set; }
        public int? IsinSuresi { get; set; }

        public int SantiyelerId { get; set; }

        //Navigation Properties
        public virtual ICollection<T_Malzeme> KullanilanMalzemeler { get; set; }
        public virtual Santiyeler Santiyeler { get; set; }
    }
}

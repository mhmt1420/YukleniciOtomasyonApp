using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.SatinAlma
{
    public class SatinAlmalar : BaseEntity
    {
        public SatinAlmalar()
        {
            AlinanMalzemeler = new List<T_Malzeme>();
        }
        public OdemeTurleri OdemeTuru { get; set; }
        public CekVadeleri? CekVadesi { get; set; } 
        public DateTime SatinAlmaTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public decimal ToplamFiyat { get; set; }

        public int SatinAlmaBirimiId { get; set; }
        public int T_TedarikciFirmaId { get; set; }


        //Navigation properties
        public virtual T_TedarikciFirma TedarikciFirma { get; set; }
        public virtual ICollection<T_Malzeme> AlinanMalzemeler { get; set; }
        public virtual SatinAlmaBirimi SatinAlmaBirimi { get; set; }
    }
}

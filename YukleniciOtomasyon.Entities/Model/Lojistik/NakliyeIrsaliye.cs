using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Lojistik
{
    public class NakliyeIrsaliye : BaseEntity
    {
        public NakliyeIrsaliye()
        {
            TasinanMalzemeler = new List<T_Malzeme>();
        }

        public string IrsaliyeNo { get; set; }
        public string YukBirimi { get; set; }
        public NakliyeTipi NakliyeTipleri { get; set; }
        public DateTime CikisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string TeslimAdresi { get; set; }
        public string SoforAdi { get; set; }
        public string SoforSoyadi { get; set; }
        public string SoforTelefon { get; set; }
        
        public int? NakliyeIslemiId { get; set; }

        //Navigation Properties
        public virtual NakliyeIslemi NakliyeIslemi { get; set; }
        public virtual T_Nakliye GondericiFirmaBilgileri { get; set; }
        public virtual ICollection<T_Malzeme> TasinanMalzemeler { get; set; }
    }
}

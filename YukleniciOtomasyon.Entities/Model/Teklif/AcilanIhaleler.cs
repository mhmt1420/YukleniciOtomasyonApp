using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Teklif
{
    public class AcilanIhaleler :BaseEntity
    {
        public AcilanIhaleler()
        {
            HazirlananEvraklar = new List<T_IhaleEvraklari>();
        }

        public string KurumFirmaAdi { get; set; }
        public string IsinAdi { get; set; }
        public string IsTanimi { get; set; }
        public DateTime IhaleTarihSaat { get; set; }
        public string IhaleOturumAdresi { get; set; }
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public string TeknikSartname { get; set; }
        public string IdariSartname { get; set; }
        public string SozlesmeTaslagi { get; set; }

        public string IhaleyiAlanFirmaAdi { get; set; }
        public string AlanFirmaninTeklifi { get; set; }

        
        public int TeklifBirimiId { get; set; }

        //Navigation Property
        public virtual ICollection<T_IhaleEvraklari> HazirlananEvraklar { get; set; }
        public virtual TeklifBirimi TeklifBirimi { get; set; }
    }
}

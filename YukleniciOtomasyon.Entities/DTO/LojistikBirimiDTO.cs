using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;

namespace YukleniciOtomasyon.Entities.DTO
{
    public class LojistikBirimiDTO
    {
        public string IrsaliyeNo { get; set; }
        public string YukBirimi { get; set; }
        public NakliyeTipi NakliyeTipleri { get; set; }
        public DateTime CikisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string TeslimBirimi { get; set; }
        public string TeslimAdresi { get; set; }
        public string SoforAdi { get; set; }
        public string SoforSoyadi { get; set; }
        public string SoforTelefon { get; set; }
        public string FirmaAd { get; set; }
        public string FirmaTelefon { get; set; }
        public string FirmaEMail { get; set; }
        public string FirmaAdres { get; set; }
        public TasitTip TasitTipi { get; set; }
        public string MalzemeAdi { get; set; }
        public string Tur { get; set; }
        public decimal Adet { get; set; }
        public string AdetTip { get; set; }
        public decimal? En { get; set; }
        public decimal? Boy { get; set; }
        public decimal? Derinlik { get; set; }
        public decimal? Agırlik { get; set; }
        public decimal? BirimFiyat { get; set; }
        public decimal? ToplamFiyat { get; set; }
    }
}

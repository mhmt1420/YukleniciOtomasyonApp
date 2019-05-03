using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;

namespace YukleniciOtomasyon.Entities.DTO
{
    public class SatinAlmaBirimiDTO
    {
        public string BirimAdi { get; set; }
        public int PersonelId { get; set; }
        public OdemeTurleri OdemeTuru { get; set; }
        public CekVadeleri? CekVadesi { get; set; }
        public DateTime SatinAlmaTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string FirmaAd { get; set; }
        public string FirmaTelefon { get; set; }
        public string FirmaEMail { get; set; }
        public string FirmaAdres { get; set; }
        public string MalzemeAdi { get; set; }
        public string Tur { get; set; }
        public decimal? Adet { get; set; }
        public string AdetTip { get; set; }
        public decimal? En { get; set; }
        public decimal? Boy { get; set; }
        public decimal? Derinlik { get; set; }
        public decimal? Agırlik { get; set; }
        public decimal? BirimFiyat { get; set; }
        public decimal? ToplamFiyat { get; set; }
    }
}

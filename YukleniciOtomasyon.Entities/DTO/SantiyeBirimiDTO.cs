using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukleniciOtomasyon.Entities.DTO
{
    public class SantiyeBirimiDTO
    {
        public string BirimAdi { get; set; }
        public string SantiyeAdi { get; set; }
        public string Adres { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public int SantiyeSuresi { get; set; }
        public int PersonelId { get; set; }
        public string YapilanIsinAdi { get; set; }
        public int IsiYapanPersonelId { get; set; }
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime? IsBitisTarihi { get; set; }
        public int? IsinSuresi { get; set; }
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

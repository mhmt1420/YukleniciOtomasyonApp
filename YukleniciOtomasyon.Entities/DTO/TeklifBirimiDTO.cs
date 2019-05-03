using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;

namespace YukleniciOtomasyon.Entities.DTO
{
    public class TeklifBirimiDTO
    {
        public int TeklifBirimiId { get; set; }
        public int AcilanIhalelerId { get; set; }
        public int IhaleEvraklariId { get; set; }
        public string BirimAdi { get; set; }
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
        public string TicaretOdasiKayitBelgesi { get; set; }
        public string ImzaSirkuleri { get; set; }
        public string TeklifMektubu { get; set; }
        public string GeciciTeminatMektubu { get; set; }
        public string IsBitirmeBelgesi { get; set; }
        public string Vekaletname { get; set; }
        public string OrtaklikBeyannamesi { get; set; }
        public string BankaReferansMektubu { get; set; }
        public string MeslekiYeterlilik { get; set; }
    }
}

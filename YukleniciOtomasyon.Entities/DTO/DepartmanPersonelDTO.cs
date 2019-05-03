using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;

namespace YukleniciOtomasyon.Entities.DTO
{
    public class DepartmanPersonelDTO
    {
        public string DepartmanAdi { get; set; }
        public string CalistigiYer { get; set; }
        public string UnvanAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KimlikNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public Cinsiyeti Cinsiyet { get; set; }
        public MedeniHali MedeniHal { get; set; }
        public EgitimDurumlari EgitimDurumu { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string DahiliTel { get; set; }
        public string PostaKodu { get; set; }
        public string ResimUrl { get; set; }
        public decimal? Maas { get; set; }

    }
}

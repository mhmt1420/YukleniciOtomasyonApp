using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.Entities.Model.IK
{
    public class Personel : BaseEntity
    {
        public Personel()
        {
            Departmanlar = new List<Departman>();
            PersonelUnvanlar = new List<T_PersonelUnvan>();
            Personelletisimleri = new List<PersonelIletisim>();
            PersonelMuhasebeleri = new List<PersonelMuhasebe>();
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyeti Cinsiyet { get; set; }
        public MedeniHali MedeniHal { get; set; }
        public EgitimDurumlari EgitimDurumu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? CikisTarihi { get; set; }

        //Navigation Properties
        public virtual ICollection<Departman> Departmanlar { get; set; }
        public virtual ICollection<T_PersonelUnvan> PersonelUnvanlar { get; set; }
        public virtual ICollection<PersonelIletisim> Personelletisimleri { get; set; }
        public virtual ICollection<PersonelMuhasebe> PersonelMuhasebeleri { get; set; }

    }
}

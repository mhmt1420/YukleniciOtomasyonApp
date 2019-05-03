using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukleniciOtomasyon.Entities.Model.IK
{
    public class PersonelIletisim : BaseEntity
    {
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string DahiliTel { get; set; }
        public string PostaKodu { get; set; }
        public string ResimUrl { get; set; }

        public int PersonelId { get; set; }

        //Navigation Properties
        public virtual Personel Personel { get; set; }
    }
}

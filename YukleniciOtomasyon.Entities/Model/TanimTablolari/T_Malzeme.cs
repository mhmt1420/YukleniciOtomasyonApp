using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_Malzeme:BaseEntity
    {
        public T_Malzeme()
        {
            MalzemeFiyatlari = new List<T_MalzemeFiyat>();

        }
        public string MalzemeAdi { get; set; }
        public string Tur { get; set; }
        public decimal Adet { get; set; }
        public string AdetTip { get; set; }
        public decimal? En { get; set; }
        public decimal? Boy { get; set; }
        public decimal? Derinlik { get; set; }
        public decimal? Agirlik { get; set; }

        public int? SantiyeIsTakibiId { get; set; }
        public int? NakliyeIrsaliyeId { get; set; }
        public int? SantiyelerId { get; set; }
        public int? SatinAlmalarId { get; set; }
        public int? DepolarId { get; set; }


        //Navigation Property
        public virtual ICollection<T_MalzemeFiyat> MalzemeFiyatlari { get; set; }

        public virtual SantiyeIsTakibi SantiyeIsTakibi { get; set; }
        public virtual NakliyeIrsaliye NakliyeIrsaliye { get; set; }
        public virtual Santiyeler Santiyeler { get; set; }
        public virtual SatinAlmalar SatinAlmalar { get; set; }
        public virtual Depolar Depolar { get; set; }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_IhaleEvraklari : BaseEntity
    {

        public string TicaretOdasiKayitBelgesi { get; set; }
        public string ImzaSirkuleri { get; set; }
        public string TeklifMektubu { get; set; }
        public string GeciciTeminatMektubu { get; set; }
        public string IsBitirmeBelgesi { get; set; }
        public string Vekaletname { get; set; }
        public string OrtaklikBeyannamesi { get; set; }
        public string BankaReferansMektubu { get; set; }
        public string MeslekiYeterlilik { get; set; }

        public int AcilanIhalelerId { get; set; }

        //Navigation Property
        public virtual AcilanIhaleler AcilanIhaleler { get; set; }
    }
}

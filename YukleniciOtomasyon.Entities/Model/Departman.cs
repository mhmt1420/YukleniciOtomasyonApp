using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class Departman : BaseEntity
    {
        public Departman()
        {
            Personeller = new List<Personel>();
            DepoBirimleri = new List<DepoBirimi>();
            LojistikBirimleri = new List<LojistikBirimi>();
            SantiyeBirimleri = new List<SantiyeBirimi>();
            SatinAlmaBirimleri = new List<SatinAlmaBirimi>();
            TeklifBirimleri = new List<TeklifBirimi>();
            
        }
        public string DepartmanAdi { get; set; }

        //Navigation Property
        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<DepoBirimi> DepoBirimleri { get; set; }
        public virtual ICollection<LojistikBirimi> LojistikBirimleri { get; set; }
        public virtual ICollection<SantiyeBirimi> SantiyeBirimleri { get; set; }
        public virtual ICollection<SatinAlmaBirimi> SatinAlmaBirimleri { get; set; }
        public virtual ICollection<TeklifBirimi> TeklifBirimleri { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_TedarikciFirma:BaseEntity
    {
        public int SatinAlmalarId { get; set; }
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }

        public virtual SatinAlmalar SatinAlmalar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_SantiyeOzellikleri:BaseEntity
    {
        public int SantiyeleriId { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi{ get; set; }
        public int IsinSuresi { get; set; }
        
        //Navigation Property
        public virtual Santiyeler Santiyeler { get; set; }
    }
}

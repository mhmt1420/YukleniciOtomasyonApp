using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_Nakliye:BaseEntity
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }

        //Navigation Property
        public virtual NakliyeIrsaliye NakliyeIrsaliye { get; set; }
    }
}

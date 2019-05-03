using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Depo
{
    public class Depolar : BaseEntity
    {
        public Depolar()
        {
            DepodakiMalzemeler = new List<T_Malzeme>();
            DepoOzellikleri= new List<T_DepoOzellikleri>();
        }
    
        public string DepoAdi { get; set; }

        public int DepoBirimiId { get; set; }

        //Navigation Properties
        public virtual ICollection<T_Malzeme> DepodakiMalzemeler { get; set; }
        public virtual ICollection<T_DepoOzellikleri> DepoOzellikleri { get; set; }
        public virtual DepoBirimi DepoBirimi { get; set; }
    }
}

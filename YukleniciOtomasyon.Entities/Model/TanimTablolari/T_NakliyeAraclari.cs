using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.Entities.Model.TanimTablolari
{
    public class T_NakliyeAraclari:BaseEntity
    {
        public TasitTip TasitTipi { get; set; }

        public int? LojistikBirimiId { get; set; }

        //Navigation Property
        public virtual LojistikBirimi LojistikBirimi { get; set; }

    }
}

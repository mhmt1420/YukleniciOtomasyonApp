using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.SatinAlma
{
    public class SatinAlmaBirimi : BaseEntity
    {

        public SatinAlmaBirimi()
        {
            YapilanSatinAlmalar = new List<SatinAlmalar>();
           // SatinAlmaPersonelleri = new List<PersonelTanimi>();
        }
        public string BirimAdi { get; set; }
        public int DepartmanId { get; set; }
        //Navigation Properties
        public virtual ICollection<SatinAlmalar> YapilanSatinAlmalar { get; set; }
        public virtual Departman Departman { get; set; }
        //  public virtual ICollection<PersonelTanimi> SatinAlmaPersonelleri { get; set; }
    }
}

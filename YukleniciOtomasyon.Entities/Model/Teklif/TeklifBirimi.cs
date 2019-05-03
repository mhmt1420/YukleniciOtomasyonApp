using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Teklif
{
    public class TeklifBirimi : BaseEntity
    {

        public TeklifBirimi()
        {
            
            KatilimSaglananIhaleler = new List<AcilanIhaleler>();
         //  TeklifPersonelleri = new List<PersonelTanimi>();
        }
        public string BirimAdi { get; set; }
        public int DepartmanId { get; set; }
      

        //Navigation Properties
        
        public virtual ICollection<AcilanIhaleler> KatilimSaglananIhaleler { get; set; }
        public virtual Departman Departman { get; set; }
    }
}

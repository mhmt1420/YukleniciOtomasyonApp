using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Santiye
{
    public class SantiyeBirimi : BaseEntity
    {

        public SantiyeBirimi()
        {
            Santiyeler = new List<Santiyeler>();
            //SantiyePersonelleri = new List<PersonelTanimi>();
        }
        public string BirimAdi { get; set; }
        public int DepartmanId { get; set; }

        //Navigation Properties
        // public virtual ICollection<PersonelTanimi> SantiyePersonelleri { get; set; }
        public virtual ICollection<Santiyeler> Santiyeler { get; set; }
        public virtual Departman Departman { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Depo
{
    public class DepoBirimi : BaseEntity
    {
        public DepoBirimi()
        {
            Depolar = new List<Depolar>();
           // DepoPersonelleri = new List<PersonelTanimi>();
        }
        public string BirimAdi { get; set; }
        public int DepartmanId { get; set; }

        //Navigation Properties
        //public virtual ICollection<PersonelTanimi> DepoPersonelleri { get; set; }
        public virtual ICollection<Depolar> Depolar  { get; set; }
        public virtual Departman Departman { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.Entities.Model.Lojistik
{
    public class LojistikBirimi:BaseEntity
    {

        public LojistikBirimi()
        {
            NakliyeAraclari = new List<T_NakliyeAraclari>();
            NakliyeIslemleri = new List<NakliyeIslemi>();
            //LojistikPersonelleri = new List<PersonelTanimi>();
        }
        public string BirimAdi { get; set; }
        public int DepartmanId { get; set; }
        //Navigation Properties
        public virtual ICollection<T_NakliyeAraclari> NakliyeAraclari { get; set; }
        public virtual ICollection<NakliyeIslemi> NakliyeIslemleri { get; set; }
        public virtual Departman Departman { get; set; }
        // public virtual ICollection<PersonelTanimi> LojistikPersonelleri { get; set; }



    }
}

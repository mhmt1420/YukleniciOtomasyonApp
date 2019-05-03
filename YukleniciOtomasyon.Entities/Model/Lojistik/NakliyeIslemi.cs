using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.Entities.Model.Lojistik
{
    public class NakliyeIslemi : BaseEntity //deniz, demir ve hava yolu eklenmes durumunda bu tablo silinmemeli.
    {
        public NakliyeIslemi()
        {
            Irsaliyeler = new List<NakliyeIrsaliye>();
        }
        public int? LojistikBirimiId { get; set; }

        public virtual Depolar Depolar { get; set; }
        public virtual Santiyeler Santiyeler { get; set; }
        public virtual ICollection<NakliyeIrsaliye> Irsaliyeler { get; set; }
        public virtual LojistikBirimi LojistikBirimi { get; set; }
    }
}

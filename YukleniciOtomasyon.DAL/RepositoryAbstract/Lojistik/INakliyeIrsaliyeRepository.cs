using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface INakliyeIrsaliyeRepository : IBaseRepository<NakliyeIrsaliye>
    {
        ICollection<NakliyeIrsaliye> IrsaliyeAra(string text);
        ICollection<NakliyeIrsaliye> NakliyeTarihAra(DateTime baslangicTarihi, DateTime bitisTarihi);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface ISatinAlmalarRepository : IBaseRepository<SatinAlmalar>
    {
        ICollection<SatinAlmalar> SatinAlmaAra(string text);
        ICollection<SatinAlmalar> SatinAlmaTarihAra(DateTime baslangicTarihi, DateTime bitisTarihi);
    }
}

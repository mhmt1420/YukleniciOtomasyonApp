using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract.Santiye
{
    interface ISantiyelerRepository :IBaseRepository<Santiyeler>
    {
        ICollection<Santiyeler> SantiyeAra(string text);
        ICollection<Santiyeler> SantiyeTarihAra(DateTime baslangicTarihi, DateTime bitisTarihi);
    }
}

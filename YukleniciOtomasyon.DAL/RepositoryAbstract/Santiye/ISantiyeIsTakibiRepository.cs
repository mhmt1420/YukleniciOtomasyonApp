using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface ISantiyeIsTakibiRepository : IBaseRepository<SantiyeIsTakibi>
    {
        ICollection<SantiyeIsTakibi> IsTakibiAra(string text);
        ICollection<SantiyeIsTakibi> IsTakibiTarihAra(DateTime baslangicTarihi, DateTime bitisTarihi);
    }
}

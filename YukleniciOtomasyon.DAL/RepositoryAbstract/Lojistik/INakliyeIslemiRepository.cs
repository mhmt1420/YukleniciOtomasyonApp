using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface INakliyeIslemiRepository : IBaseRepository<NakliyeIslemi>
    {
        ICollection<NakliyeIslemi> NakliyeAra(string text);
    }
}

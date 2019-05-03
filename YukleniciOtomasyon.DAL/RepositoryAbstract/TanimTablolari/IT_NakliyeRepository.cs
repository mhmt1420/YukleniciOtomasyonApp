using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract.TanimTablolari
{
    interface IT_NakliyeRepository : IBaseRepository<T_Nakliye>
    {
        ICollection<T_Nakliye> NakliyeFirmaAra(string text);
    }
}

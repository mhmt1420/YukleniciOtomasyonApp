using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface IT_MalzemeOzellikleriRepository :IBaseRepository<T_Malzeme>
    {
        ICollection<T_Malzeme> MalzemeAra(string text);
    }
}

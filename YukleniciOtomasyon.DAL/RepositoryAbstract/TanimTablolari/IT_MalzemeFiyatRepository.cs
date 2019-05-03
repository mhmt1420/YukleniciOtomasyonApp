using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface IT_MalzemelerRepository :IBaseRepository<T_MalzemeFiyat>
    {
        ICollection<T_MalzemeFiyat> BirimFiyatAra(decimal birimFiyat);
    }
}

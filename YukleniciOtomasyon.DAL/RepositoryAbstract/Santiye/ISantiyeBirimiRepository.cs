using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface ISantiyeBirimiRepository : IBaseRepository<SantiyeBirimi>
    {
        ICollection<SantiyeBirimiDTO> DTOSantiyeBirimiGetir();
    }
}

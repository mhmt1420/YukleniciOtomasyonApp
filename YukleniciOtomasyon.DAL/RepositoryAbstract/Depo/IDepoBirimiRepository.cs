using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface IDepoBirimiRepository : IBaseRepository<DepoBirimi>
    {
        ICollection<DepoBirimiDTO> DTODepoBirimiGetir();
    }
}

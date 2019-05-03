using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface ILojistikBirimiRepository : IBaseRepository<LojistikBirimi>
    {
        ICollection<LojistikBirimiDTO> DTOLojistikBirimiGetir();
    }
}

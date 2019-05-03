using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface IT_DepartmanRepository : IBaseRepository<Departman>
    {
        ICollection<Departman> DepartmanAra(string departmanAdi);
        ICollection<DepartmanPersonelDTO> DTODepartmanPersonelGetir(string text);
    }
}

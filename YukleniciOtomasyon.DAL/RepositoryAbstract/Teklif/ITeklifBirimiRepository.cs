using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract.Teklif
{
    interface ITeklifBirimiRepository : IBaseRepository<TeklifBirimi>
    {
        ICollection<TeklifBirimiDTO> DTOTeklifBirimiGetir();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract
{
    interface IPersonelRepository : IBaseRepository<Personel>
    {
        bool PersonelLoginKontrol(string kimlikNo, string sifre);
        ICollection<Personel> PersonelAra(string text);
    }
}

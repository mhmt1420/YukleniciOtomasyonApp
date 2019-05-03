using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract.Teklif
{
    interface IAcilanIhalelerRepository : IBaseRepository<AcilanIhaleler>
    {
        ICollection<AcilanIhaleler> IhaleAra(string text);
        ICollection<AcilanIhaleler> IhaleTarihiAra(DateTime baslangicTarihi, DateTime bitisTarihi);
    }
}

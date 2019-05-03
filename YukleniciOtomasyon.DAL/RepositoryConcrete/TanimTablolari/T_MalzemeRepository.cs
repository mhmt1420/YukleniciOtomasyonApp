using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class T_MalzemeRepository : IT_MalzemeOzellikleriRepository
    {
        YukleniciOtomasyonDbContext _db;
        public T_MalzemeRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        int _etkilenenSatir;

        public int AddItem(T_Malzeme item)
        {
            _db.T_MalzemeOzellikleri.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
        public int DeleteItem(T_Malzeme item)
        {
            _db.T_MalzemeOzellikleri.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
        public ICollection<T_Malzeme> GetAll()
        {
            return _db.T_MalzemeOzellikleri.ToList();
        }
        public T_Malzeme GetById(int id)
        {
            return _db.T_MalzemeOzellikleri.Where(x => x.Id == id).FirstOrDefault();
        }
        public int UpdateItem(T_Malzeme item)
        {
            T_Malzeme eskiMalzeme = _db.T_MalzemeOzellikleri.Where(x => x.Id == item.Id).FirstOrDefault();
            eskiMalzeme.MalzemeAdi = item.MalzemeAdi;
            eskiMalzeme.Tur = item.Tur;
            eskiMalzeme.Adet = item.Adet;
            eskiMalzeme.AdetTip = item.AdetTip;
            eskiMalzeme.En = item.En;
            eskiMalzeme.Boy = item.Boy;
            eskiMalzeme.Agirlik = item.Agirlik;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
        public ICollection<T_Malzeme> MalzemeAra(string text)
        {
            throw new NotImplementedException();
        }
    }
}

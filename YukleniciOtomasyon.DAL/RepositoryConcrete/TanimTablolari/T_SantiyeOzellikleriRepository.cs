using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.TanimTablolari;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class T_SantiyeOzellikleriRepository : IT_SantiyeOzellikleriRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public T_SantiyeOzellikleriRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(T_SantiyeOzellikleri item)
        {
            
                _db.T_SantiyeOzellikleri.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(T_SantiyeOzellikleri item)
        {
            
                _db.T_SantiyeOzellikleri.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<T_SantiyeOzellikleri> GetAll()
        {
                return _db.T_SantiyeOzellikleri.ToList();
            
        }

        public T_SantiyeOzellikleri GetById(int id)
        {
            
                return _db.T_SantiyeOzellikleri.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(T_SantiyeOzellikleri item)
        {
            
                T_SantiyeOzellikleri eskiSantiyeOzelligi = _db.T_SantiyeOzellikleri.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiSantiyeOzelligi.Ad = item.Ad;
                eskiSantiyeOzelligi.Adres = item.Adres;
                eskiSantiyeOzelligi.BaslangicTarihi = item.BaslangicTarihi;
                eskiSantiyeOzelligi.BitisTarihi = item.BitisTarihi;
                eskiSantiyeOzelligi.IsinSuresi = item.IsinSuresi;
                eskiSantiyeOzelligi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
    }
}

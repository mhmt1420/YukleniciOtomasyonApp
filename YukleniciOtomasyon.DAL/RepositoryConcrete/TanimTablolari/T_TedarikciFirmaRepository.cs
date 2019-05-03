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
    public class T_TedarikciFirmaRepository : IT_TedarikciFirmaRepository
    {
        YukleniciOtomasyonDbContext _db;
        public T_TedarikciFirmaRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        int _etkilenenSatir;

        public int AddItem(T_TedarikciFirma item)
        {
            _db.T_TedarikciFirma.Add(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public int DeleteItem(T_TedarikciFirma item)
        {
            _db.T_TedarikciFirma.Remove(item);
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }

        public ICollection<T_TedarikciFirma> GetAll()
        {
            return _db.T_TedarikciFirma.ToList();
        }

        public T_TedarikciFirma GetById(int id)
        {
            return _db.T_TedarikciFirma.Where(x => x.Id == id).FirstOrDefault();
        }

        T_TedarikciFirma _eski;

        public int UpdateItem(T_TedarikciFirma item)
        {
            T_TedarikciFirma eskiTedarikci = _db.T_TedarikciFirma.Where(x => x.Id == item.Id).FirstOrDefault();
            eskiTedarikci.Ad = item.Ad;
            eskiTedarikci.Telefon = item.Telefon;
            eskiTedarikci.EMail = item.EMail;
            eskiTedarikci.Adres = item.Adres;
            eskiTedarikci.DuzenlenmeTarihi = DateTime.Now;
            _etkilenenSatir = _db.SaveChanges();
            return _etkilenenSatir;
        }
    }
}

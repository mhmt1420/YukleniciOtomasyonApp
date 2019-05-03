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
    public class T_MalzemeFiyatRepository : IT_MalzemelerRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public T_MalzemeFiyatRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(T_MalzemeFiyat item)
        {
           
                _db.T_Malzemeler.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(T_MalzemeFiyat item)
        {
                _db.T_Malzemeler.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<T_MalzemeFiyat> GetAll()
        {
            
                return _db.T_Malzemeler.ToList();
            
        }

        public T_MalzemeFiyat GetById(int id)
        {
            
                return _db.T_Malzemeler.Where(x => x.Id == id).FirstOrDefault();
            
        }

        T_MalzemeFiyat _eski;

        public int UpdateItem(T_MalzemeFiyat item)
        {
           
                T_MalzemeFiyat eskiFiyat = _db.T_Malzemeler.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiFiyat.BirimFiyat = item.BirimFiyat;
                eskiFiyat.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<T_MalzemeFiyat> BirimFiyatAra(decimal birimFiyat)
        {
            
                return _db.T_Malzemeler.Where(x => x.BirimFiyat==birimFiyat).ToList();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using YukleniciOtomasyon.DAL.RepositoryAbstract.Santiye;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye
{
    public class SantiyelerRepository : ISantiyelerRepository
    {
        private int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public SantiyelerRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(Santiyeler item)
        {
           
                _db.Santiyeler.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public int DeleteItem(Santiyeler item)
        {
            
                _db.Santiyeler.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<Santiyeler> GetAll()
        {
            
                return _db.Santiyeler.ToList();
            
        }
        public Santiyeler GetById(int id)
        {
          
                return _db.Santiyeler.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(Santiyeler item)
        {
            
                Santiyeler eskiSantiye = _db.Santiyeler.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiSantiye.SantiyedekiMalzemeler = item.SantiyedekiMalzemeler;
                eskiSantiye.SantiyeOzellikleri = item.SantiyeOzellikleri;
                //eskiSantiye.NakliyeIslemleri = item.NakliyeIslemleri;
                eskiSantiye.SantiyeIsTakipleri = item.SantiyeIsTakipleri;
                eskiSantiye.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<Santiyeler> SantiyeAra(string text)
        {
            

                return _db.Santiyeler.Where(x => x.SantiyeOzellikleri.FirstOrDefault().Ad.Contains(text)
                || x.SantiyeOzellikleri.FirstOrDefault().Adres.Contains(text)
                || x.SantiyeOzellikleri.FirstOrDefault().BaslangicTarihi.ToString().Contains(text)
                ).ToList();
            
        }

        public ICollection<Santiyeler> SantiyeTarihAra(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            
                return _db.Santiyeler.Where(x => x.SantiyeOzellikleri.FirstOrDefault().BaslangicTarihi >= baslangicTarihi 
                || x.SantiyeOzellikleri.FirstOrDefault().BitisTarihi <= bitisTarihi
                ).ToList();
            
        }
        
    }
}


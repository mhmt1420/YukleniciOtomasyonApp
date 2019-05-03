using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.SatinAlma
{
    public class SatinAlmalarRepository : ISatinAlmalarRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public SatinAlmalarRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }

        public int AddItem(SatinAlmalar item)
        {
            
                _db.SatinAlmalar.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(SatinAlmalar item)
        {
            

                _db.SatinAlmalar.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<SatinAlmalar> GetAll()
        {
            
                return _db.SatinAlmalar.ToList();
            
        }

        public SatinAlmalar GetById(int id)
        {
           
                return _db.SatinAlmalar.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(SatinAlmalar item)
        {
            
                SatinAlmalar eskiSatinAlmalar = _db.SatinAlmalar.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiSatinAlmalar.OdemeTuru = item.OdemeTuru;
                eskiSatinAlmalar.CekVadesi = item.CekVadesi;
                eskiSatinAlmalar.SatinAlmaTarihi = item.SatinAlmaTarihi;
                eskiSatinAlmalar.TeslimTarihi = item.TeslimTarihi;
                eskiSatinAlmalar.ToplamFiyat = item.ToplamFiyat;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }


        public ICollection<SatinAlmalar> SatinAlmaAra(string text)
        {
           
                return _db.SatinAlmalar.Where(x => x.OdemeTuru.ToString().Contains(text)
                || x.CekVadesi.ToString().Contains(text) 
                || x.ToplamFiyat.ToString().Contains(text)
                || x.TedarikciFirma.Ad.Contains(text) 
                || x.TeslimTarihi.ToString().Contains(text)
                || x.TedarikciFirma.Telefon.Contains(text) 
                || x.TedarikciFirma.Adres.Contains(text) 
                || x.TedarikciFirma.EMail.Contains(text)
                ).ToList();
            
        }

        public ICollection<SatinAlmalar> SatinAlmaTarihAra(DateTime satinAlmaTarihi, DateTime teslimTarihi)
        {
            
                return _db.SatinAlmalar.Where(x => x.SatinAlmaTarihi >= satinAlmaTarihi || x.TeslimTarihi <= teslimTarihi
                  ).ToList();
            
        }
    }
}

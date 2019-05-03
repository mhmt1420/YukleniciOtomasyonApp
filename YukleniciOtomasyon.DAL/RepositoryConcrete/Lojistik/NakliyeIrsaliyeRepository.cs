using System;
using System.Collections.Generic;
using System.Linq;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Lojistik
{
    public class NakliyeIrsaliyeRepository : INakliyeIrsaliyeRepository
    {
        private int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public NakliyeIrsaliyeRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }

        public int AddItem(NakliyeIrsaliye item)
        {
           
                _db.NakliyeIrsaliye.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public int DeleteItem(NakliyeIrsaliye item)
        {
           
                _db.NakliyeIrsaliye.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<NakliyeIrsaliye> GetAll()
        {
           
                return _db.NakliyeIrsaliye.ToList();
            
        }
        public NakliyeIrsaliye GetById(int id)
        {
            
                return _db.NakliyeIrsaliye.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(NakliyeIrsaliye item)
        {
            
                NakliyeIrsaliye eskiIrsaliye = _db.NakliyeIrsaliye.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIrsaliye.IrsaliyeNo = item.IrsaliyeNo;
                eskiIrsaliye.YukBirimi = item.YukBirimi;
                eskiIrsaliye.NakliyeTipleri = item.NakliyeTipleri;
                eskiIrsaliye.CikisTarihi = item.CikisTarihi;
                eskiIrsaliye.TeslimTarihi = item.TeslimTarihi;
                eskiIrsaliye.TeslimAdresi = item.TeslimAdresi;
                eskiIrsaliye.SoforAdi = item.SoforAdi;
                eskiIrsaliye.SoforSoyadi = item.SoforSoyadi;
                eskiIrsaliye.SoforTelefon = item.SoforTelefon;
                eskiIrsaliye.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<NakliyeIrsaliye> NakliyeTarihAra(DateTime cikisTarihi, DateTime bitisTarihi)
        {
            
                return _db.NakliyeIrsaliye.Where(x => x.CikisTarihi >= cikisTarihi || x.TeslimTarihi <= bitisTarihi
                ).ToList();
            
        }
        public ICollection<NakliyeIrsaliye> IrsaliyeAra(string text)
        {
            

                return _db.NakliyeIrsaliye.Where(x => x.IrsaliyeNo.Contains(text)
                || x.YukBirimi.Contains(text) || x.NakliyeTipleri.ToString().Contains(text) || x.TeslimAdresi.Contains(text)
                || x.CikisTarihi.ToString().Contains(text) || x.TeslimTarihi.ToString().Contains(text)
                || x.SoforAdi.Contains(text) || x.SoforSoyadi.Contains(text) || x.SoforTelefon.Contains(text)
                ).ToList();
            
        }
    }
}

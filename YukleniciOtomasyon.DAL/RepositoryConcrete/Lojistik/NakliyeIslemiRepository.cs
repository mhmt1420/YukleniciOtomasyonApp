using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Lojistik
{
    public class NakliyeIslemiRepository : INakliyeIslemiRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public NakliyeIslemiRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }

        public int AddItem(NakliyeIslemi item)
        {
            
                _db.NakliyeIslemi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public int DeleteItem(NakliyeIslemi item)
        {
            
                _db.NakliyeIslemi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<NakliyeIslemi> GetAll()
        {
            
                return _db.NakliyeIslemi.ToList();
            
        }
        public NakliyeIslemi GetById(int id)
        {
           
                return _db.NakliyeIslemi.Where(x => x.Id == id).FirstOrDefault();
            
        }
        
        public int UpdateItem(NakliyeIslemi item)
        {
           
                NakliyeIslemi eskiNakliyeIslemi = _db.NakliyeIslemi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiNakliyeIslemi.Irsaliyeler = item.Irsaliyeler;
                eskiNakliyeIslemi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<NakliyeIslemi> NakliyeAra(string text)
        {
            
                return _db.NakliyeIslemi.Where(x => x.Irsaliyeler.FirstOrDefault().IrsaliyeNo.Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().YukBirimi.Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().NakliyeTipleri.ToString().Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().CikisTarihi.ToString().Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().TeslimTarihi.ToString().Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().SoforAdi.Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().SoforSoyadi.Contains(text)
                        || x.Irsaliyeler.FirstOrDefault().SoforTelefon.Contains(text)
                        ).ToList();
            
        }
    }
}

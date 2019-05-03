using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.Teklif;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Teklif
{
    public class AcilanIhalelerRepository : IAcilanIhalelerRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public AcilanIhalelerRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(AcilanIhaleler item)
        {
            
                _db.AcilanIhaleler.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(AcilanIhaleler item)
        {
            
                _db.AcilanIhaleler.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<AcilanIhaleler> GetAll()
        {
           
                return _db.AcilanIhaleler.ToList();
            
        }

        public AcilanIhaleler GetById(int id)
        {
          
                return _db.AcilanIhaleler.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(AcilanIhaleler item)
        {
            
                AcilanIhaleler eskiIhaleler = _db.AcilanIhaleler.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIhaleler.KurumFirmaAdi = item.KurumFirmaAdi;
                eskiIhaleler.IsinAdi = item.IsinAdi;
                eskiIhaleler.IsTanimi = item.IsTanimi;
                eskiIhaleler.IhaleTarihSaat = item.IhaleTarihSaat;
                eskiIhaleler.IhaleOturumAdresi = item.IhaleOturumAdresi;
                eskiIhaleler.IsBaslangicTarihi = item.IsBaslangicTarihi;
                eskiIhaleler.IsBitisTarihi = item.IsBitisTarihi;
                eskiIhaleler.TeklifBirimi = item.TeklifBirimi;
                eskiIhaleler.IdariSartname = item.IdariSartname;
                eskiIhaleler.SozlesmeTaslagi = item.SozlesmeTaslagi;
                eskiIhaleler.IhaleyiAlanFirmaAdi = item.IhaleyiAlanFirmaAdi;
                eskiIhaleler.AlanFirmaninTeklifi = item.AlanFirmaninTeklifi;
                eskiIhaleler.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<AcilanIhaleler> IhaleAra(string text)
        {
           
                return _db.AcilanIhaleler.Where(x => x.KurumFirmaAdi.Contains(text)
               || x.IsinAdi.Contains(text)
               || x.IsTanimi.Contains(text)
               || x.IhaleOturumAdresi.Contains(text)
               || x.IdariSartname.Contains(text)
               || x.SozlesmeTaslagi.Contains(text)
               || x.IhaleyiAlanFirmaAdi.Contains(text)
               || x.IhaleTarihSaat.ToString().Contains(text)
               || x.AlanFirmaninTeklifi.ToString().Contains(text)
               || x.IsBaslangicTarihi.ToString().Contains(text)
               || x.IsBitisTarihi.ToString().Contains(text)
               ).ToList();
            
        }

        public ICollection<AcilanIhaleler> IhaleTarihiAra(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            
                return _db.AcilanIhaleler.Where(x => x.IsBaslangicTarihi >= baslangicTarihi || x.IsBitisTarihi <= bitisTarihi
                ).ToList();
            
        }
    }
}

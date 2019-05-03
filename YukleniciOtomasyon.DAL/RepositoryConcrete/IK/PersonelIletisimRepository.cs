using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.IK
{
    public class PersonelIletisimRepository : IPersonelletisimRepository
    {
        int _etkilenenSatir;

        YukleniciOtomasyonDbContext _db;
        public PersonelIletisimRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(PersonelIletisim item)
        {
          
                _db.PersonelIletisim.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public int DeleteItem(PersonelIletisim item)
        {
                _db.PersonelIletisim.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<PersonelIletisim> GetAll()
        {
         
                return _db.PersonelIletisim.ToList();
            
        }
        public PersonelIletisim GetById(int id)
        {
           
                return _db.PersonelIletisim.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(PersonelIletisim item)
        {
            
                PersonelIletisim eskiIletisim = _db.PersonelIletisim.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIletisim.Telefon = item.Telefon;
                eskiIletisim.EMail = item.EMail;
                eskiIletisim.Sifre = item.Sifre;
                eskiIletisim.Adres = item.Adres;
                eskiIletisim.DahiliTel = item.DahiliTel;
                eskiIletisim.PostaKodu = item.PostaKodu;
                eskiIletisim.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
    }
}

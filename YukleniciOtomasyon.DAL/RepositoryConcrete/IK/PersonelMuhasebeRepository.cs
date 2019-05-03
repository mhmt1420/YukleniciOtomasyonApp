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
    public class PersonelMuhasebeRepository : IPersonelMuhasebeRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public PersonelMuhasebeRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(PersonelMuhasebe item)
        {
                _db.PersonelMuhasebe.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(PersonelMuhasebe item)
        {
            
                _db.PersonelMuhasebe.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<PersonelMuhasebe> GetAll()
        {
            
                return _db.PersonelMuhasebe.ToList();
            
        }
        public PersonelMuhasebe GetById(int id)
        {
           
                return _db.PersonelMuhasebe.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(PersonelMuhasebe item)
        {
            
                PersonelMuhasebe eskiMaas = _db.PersonelMuhasebe.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiMaas.Maas = item.Maas;
                eskiMaas.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
    }
}

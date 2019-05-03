using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Depo
{
    public class DepolarRepository : IDepolarRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public DepolarRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }

        public int AddItem(Depolar item)
        {
            
                _db.Depolar.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(Depolar item)
        {
            
                _db.Depolar.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<Depolar> GetAll()
        {
         
                return _db.Depolar.ToList();
           
        }

        public Depolar GetById(int id)
        {
       
                return _db.Depolar.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(Depolar item)
        {
        
                Depolar eskiDepo = _db.Depolar.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiDepo.DepoAdi = item.DepoAdi;
                eskiDepo.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<Depolar> DepoAra(string depoAdi)
        {
         
                return depoAdi == null ?
                 _db.Depolar.ToList() :
                 _db.Depolar.Where(x => x.DepoAdi.Contains(depoAdi)).ToList();
            
        }
    }
}

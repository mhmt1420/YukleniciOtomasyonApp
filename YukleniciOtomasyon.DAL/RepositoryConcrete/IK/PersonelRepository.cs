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
    public class PersonelRepository : IPersonelRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public PersonelRepository()
        {
            _db = new YukleniciOtomasyonDbContext();

        }

        public int AddItem(Personel item)
        {
          
                _db.Personel.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(Personel item)
        {
           
                _db.Personel.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<Personel> GetAll()
        {
            YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext();
            
                return _db.Personel.ToList();
            
        }
        public Personel GetById(int id)
        {
           
                return _db.Personel.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(Personel item)
        {
            
                Personel eskiPersonel = _db.Personel.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiPersonel.Ad = item.Ad;
                eskiPersonel.Soyad = item.Soyad;
                eskiPersonel.DogumTarihi = item.DogumTarihi;
                eskiPersonel.MedeniHal = item.MedeniHal;
                eskiPersonel.EgitimDurumu = item.EgitimDurumu;
                eskiPersonel.Departmanlar = item.Departmanlar;
                eskiPersonel.PersonelUnvanlar = item.PersonelUnvanlar;
                eskiPersonel.Personelletisimleri = item.Personelletisimleri;
                eskiPersonel.PersonelMuhasebeleri = item.PersonelMuhasebeleri;
                eskiPersonel.CikisTarihi = item.CikisTarihi;
                eskiPersonel.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public bool PersonelLoginKontrol(string kimlikNo, string sifre)
        {
            
                Personel Personel = _db.Personel
                    .Where(x => x.KimlikNo == kimlikNo && x.Personelletisimleri.FirstOrDefault().Sifre == sifre)
                    .FirstOrDefault();

                if (Personel != null)
                {
                    return true;
                }
                return false;
            
        }
        public ICollection<Personel> PersonelAra(string text)
        {
           
                return _db.Personel.Where(x => x.Ad.Contains(text)
                || x.Soyad.Contains(text) || x.KimlikNo.Contains(text) || x.DogumTarihi.ToString().Contains(text)
                ).ToList();
               
            
        }
    }
}

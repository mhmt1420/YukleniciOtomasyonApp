using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Depo
{
    public class DepoBirimiRepository : IDepoBirimiRepository
    {
        int _etkilenenSatir;

        YukleniciOtomasyonDbContext _db;
        public DepoBirimiRepository()
        {
           _db = new YukleniciOtomasyonDbContext();
        }

        public int AddItem(DepoBirimi item)
        {
                _db.DepoBirimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

        }
        public int DeleteItem(DepoBirimi item)
        {
                _db.DepoBirimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<DepoBirimi> GetAll()
        {
                return _db.DepoBirimi.ToList();
            
        }

        public DepoBirimi GetById(int id)
        {
            
                return _db.DepoBirimi.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(DepoBirimi item)
        {
                DepoBirimi eskiDepoBirimi = _db.DepoBirimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiDepoBirimi.BirimAdi = item.BirimAdi;
                eskiDepoBirimi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<DepoBirimiDTO> DTODepoBirimiGetir()
        {
                return (from malzeme in _db.T_MalzemeOzellikleri
                        join depo in _db.Depolar on malzeme.Id equals depo.DepodakiMalzemeler.FirstOrDefault().Id
                        join depoozellikleri in _db.T_DepoOzellikleri on depo.Id equals depoozellikleri.DepolarId
                        join depobirimi in _db.DepoBirimi on depo.DepoBirimiId equals depobirimi.Id
                        join departman in _db.Departman on depobirimi.DepartmanId equals departman.Id
                        join personel in _db.Personel on departman.Personeller.FirstOrDefault().Id equals personel.Id
                        select new DepoBirimiDTO
                        {
                            BirimAdi = depobirimi.BirimAdi,
                            Boyutu = depoozellikleri.Boyutu,
                            Adres = depoozellikleri.Adres,
                            DepoAdi = depo.DepoAdi,
                            MalzemeAdi = malzeme.MalzemeAdi,
                            PersonelId = depo.DepoBirimi.Departman.Personeller.FirstOrDefault().Id,
                            Tur = malzeme.Tur,
                            Adet = malzeme.Adet,
                            AdetTip = malzeme.AdetTip,
                            En = malzeme.En,
                            Boy = malzeme.Boy,
                            Derinlik = malzeme.Derinlik,
                            Agırlik = malzeme.Agirlik,
                            BirimFiyat = malzeme.MalzemeFiyatlari.FirstOrDefault().BirimFiyat,
                            ToplamFiyat = malzeme.MalzemeFiyatlari.FirstOrDefault().BirimFiyat * malzeme.Adet
                        }).ToList();
            
        }
    }
}

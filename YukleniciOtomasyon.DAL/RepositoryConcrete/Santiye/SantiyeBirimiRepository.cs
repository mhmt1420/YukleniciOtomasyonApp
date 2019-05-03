using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye
{
    public class SantiyeBirimiRepository : ISantiyeBirimiRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public SantiyeBirimiRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(SantiyeBirimi item)
        {
           
                _db.SantiyeBirimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(SantiyeBirimi item)
        {
            
                _db.SantiyeBirimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<SantiyeBirimi> GetAll()
        {
            
                return _db.SantiyeBirimi.ToList();
            
        }

        public SantiyeBirimi GetById(int id)
        {
           
                return _db.SantiyeBirimi.Where(x => x.Id == id).FirstOrDefault();
            
        }
        public int UpdateItem(SantiyeBirimi item)
        {
            
                SantiyeBirimi eskisantiyeBirimi = _db.SantiyeBirimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskisantiyeBirimi.Santiyeler = item.Santiyeler;
                eskisantiyeBirimi.Departman = item.Departman;
                eskisantiyeBirimi.DuzenlenmeTarihi = DateTime.Now;
                return _etkilenenSatir;
            
        }
        public ICollection<SantiyeBirimiDTO> DTOSantiyeBirimiGetir()
        {
           
                return (from santiye in _db.Santiyeler
                        join santiyebirimi in _db.SantiyeBirimi on santiye.Id equals santiyebirimi.Santiyeler.FirstOrDefault().Id
                        join departman in _db.Departman on santiyebirimi.DepartmanId equals departman.Id
                        join Personel in _db.Personel on departman.Personeller.FirstOrDefault().Id equals Personel.Id
                        join santiyeozellikleri in _db.T_SantiyeOzellikleri on santiye.SantiyeOzellikleri.FirstOrDefault().Id equals santiyeozellikleri.Id
                        join santiyeis in _db.SantiyeIsTakibi on santiye.SantiyeIsTakipleri.FirstOrDefault().Id equals santiyeis.Id
                        join malzeme in _db.T_MalzemeOzellikleri on santiye.Id equals malzeme.SantiyelerId
                        select new SantiyeBirimiDTO
                        {
                            SantiyeSuresi = santiyeozellikleri.IsinSuresi,
                            PersonelId = santiye.SantiyeBirimi.Departman.Personeller.FirstOrDefault().Id,
                            BirimAdi = santiyebirimi.BirimAdi,
                            BaslangicTarihi = santiyeozellikleri.BaslangicTarihi,
                            BitisTarihi = santiyeozellikleri.BitisTarihi,
                            IsBaslangicTarihi = santiyeis.IsBaslangicTarihi,
                            YapilanIsinAdi = santiyeis.YapilanIsinAdi,
                            IsBitisTarihi = santiyeis.IsBitisTarihi,
                            IsinSuresi = santiyeis.IsinSuresi,
                            IsiYapanPersonelId = santiyeis.Santiyeler.SantiyeBirimi.Departman.Personeller.FirstOrDefault().Id,
                            Adres = santiyeozellikleri.Adres,
                            SantiyeAdi = santiye.SantiyeOzellikleri.FirstOrDefault().Ad,
                            MalzemeAdi = malzeme.MalzemeAdi,
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

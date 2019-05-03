using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Lojistik
{
    public class LojistikBirimiRepository : ILojistikBirimiRepository
    {
        int _etkilenenSatir;

        YukleniciOtomasyonDbContext _db;
        public LojistikBirimiRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(LojistikBirimi item)
        {
           
                _db.LojistikBirimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(LojistikBirimi item)
            {
            
                _db.LojistikBirimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<LojistikBirimi> GetAll()
                {
            
                return _db.LojistikBirimi.ToList();
            
        }

        public LojistikBirimi GetById(int id)
                    {
            
                return _db.LojistikBirimi.Where(x => x.Id == id).FirstOrDefault();
            
        }

        public int UpdateItem(LojistikBirimi item)
        {
            
                LojistikBirimi eskiLojistikBirimi = _db.LojistikBirimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiLojistikBirimi.BirimAdi = item.BirimAdi;
                eskiLojistikBirimi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }
        public ICollection<LojistikBirimiDTO> DTOLojistikBirimiGetir()
        {
            
                /*string brmadi = "";
                var depoadi = from nakliyeIrsaliye in _db.NakliyeIrsaliye
                              join nakliyeislemi in _db.NakliyeIslemi on nakliyeIrsaliye.Id equals nakliyeislemi.Irsaliyeler.FirstOrDefault().Id
                              select _db.NakliyeIslemi.FirstOrDefault().DepolarId;

                if (Convert.ToInt32(depoadi) != 0)
                {
                    brmadi = "DepoBirimi";
                }
                var santiyeadi = from nakliyeIrsaliye in _db.NakliyeIrsaliye
                                 join nakliyeislemi in _db.NakliyeIslemi on nakliyeIrsaliye.Id equals nakliyeislemi.Irsaliyeler.FirstOrDefault().Id
                                 select _db.NakliyeIslemi.FirstOrDefault().SantiyelerId;

                if (Convert.ToInt32(santiyeadi) != 0)
                {
                    brmadi = "SantiyeBirimi";
                }
                */
                return (from nakliyeIrsaliye in _db.NakliyeIrsaliye
                        join malzeme in _db.T_MalzemeOzellikleri on nakliyeIrsaliye.Id equals malzeme.NakliyeIrsaliyeId
                        select new LojistikBirimiDTO
                        {
                            TeslimBirimi = nakliyeIrsaliye.NakliyeIslemi.LojistikBirimi.BirimAdi,
                            MalzemeAdi = malzeme.MalzemeAdi,
                            Tur = malzeme.Tur,
                            Adet = malzeme.Adet,
                            AdetTip = malzeme.AdetTip,
                            En = malzeme.En,
                            Boy = malzeme.Boy,
                            Derinlik = malzeme.Derinlik,
                            Agırlik = malzeme.Agirlik,
                            BirimFiyat = malzeme.MalzemeFiyatlari.FirstOrDefault().BirimFiyat,
                            TeslimTarihi = malzeme.SatinAlmalar.TeslimTarihi,
                            ToplamFiyat = malzeme.SatinAlmalar.ToplamFiyat,
                            IrsaliyeNo = malzeme.NakliyeIrsaliye.IrsaliyeNo,
                            YukBirimi = malzeme.NakliyeIrsaliye.YukBirimi,
                            NakliyeTipleri = malzeme.NakliyeIrsaliye.NakliyeTipleri,
                            CikisTarihi = malzeme.NakliyeIrsaliye.CikisTarihi,
                            TeslimAdresi = malzeme.NakliyeIrsaliye.TeslimAdresi,
                            SoforAdi = malzeme.NakliyeIrsaliye.SoforAdi,
                            SoforSoyadi = malzeme.NakliyeIrsaliye.SoforSoyadi,
                            SoforTelefon = malzeme.NakliyeIrsaliye.SoforTelefon,
                            FirmaAd = malzeme.NakliyeIrsaliye.GondericiFirmaBilgileri.Ad,
                            FirmaAdres = malzeme.NakliyeIrsaliye.GondericiFirmaBilgileri.Adres,
                            FirmaEMail = malzeme.NakliyeIrsaliye.GondericiFirmaBilgileri.EMail,
                            FirmaTelefon = malzeme.NakliyeIrsaliye.GondericiFirmaBilgileri.Telefon
                        }).ToList();
            
        }
    }
}

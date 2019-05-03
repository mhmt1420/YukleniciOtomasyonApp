using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.Teklif;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Teklif
{
    public class TeklifBirimiRepository : ITeklifBirimiRepository
    {
        int _etkilenenSatir;
        YukleniciOtomasyonDbContext _db;
        public TeklifBirimiRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(TeklifBirimi item)
        {
                _db.TeklifBirimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public int DeleteItem(TeklifBirimi item)
        {
           
                _db.TeklifBirimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<TeklifBirimi> GetAll()
        {
           
                return _db.TeklifBirimi.ToList();
            
        }

        public TeklifBirimi GetById(int id)
        {
            
                return _db.TeklifBirimi.Where(x => x.Id == id).FirstOrDefault();
            
        }


        TeklifBirimi _eski;

        public int UpdateItem(TeklifBirimi item)
        {
            
                TeklifBirimi eskiTeklifBirimi = _db.TeklifBirimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiTeklifBirimi.BirimAdi = item.BirimAdi;
                eskiTeklifBirimi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<TeklifBirimiDTO> DTOTeklifBirimiGetir()
        {
            
                return (from teklifbirimi in _db.TeklifBirimi 
                        join ihaleler in _db.AcilanIhaleler on teklifbirimi.Id equals ihaleler.TeklifBirimiId
                        join evraklar in _db.IhaleEvraklari on ihaleler.Id equals evraklar.AcilanIhalelerId
                        select new TeklifBirimiDTO
                        {
                            TeklifBirimiId = teklifbirimi.Id,
                            AcilanIhalelerId = ihaleler.Id,
                            IhaleEvraklariId = evraklar.Id,
                            BirimAdi = teklifbirimi.BirimAdi,
                            KurumFirmaAdi = ihaleler.KurumFirmaAdi,
                            IsinAdi = ihaleler.IsinAdi,
                            IsTanimi = ihaleler.IsTanimi,
                            IhaleTarihSaat = ihaleler.IhaleTarihSaat,
                            IhaleOturumAdresi = ihaleler.IhaleOturumAdresi,
                            IsBaslangicTarihi = ihaleler.IsBaslangicTarihi,
                            IsBitisTarihi = ihaleler.IsBitisTarihi,
                            TeknikSartname = ihaleler.TeknikSartname,
                            IdariSartname = ihaleler.IdariSartname,
                            SozlesmeTaslagi = ihaleler.SozlesmeTaslagi,
                            IhaleyiAlanFirmaAdi = ihaleler.IhaleyiAlanFirmaAdi,
                            AlanFirmaninTeklifi = ihaleler.AlanFirmaninTeklifi,
                            TicaretOdasiKayitBelgesi = evraklar.TicaretOdasiKayitBelgesi,
                            ImzaSirkuleri = evraklar.ImzaSirkuleri,
                            TeklifMektubu = evraklar.TeklifMektubu,
                            GeciciTeminatMektubu = evraklar.GeciciTeminatMektubu,
                            IsBitirmeBelgesi = evraklar.IsBitirmeBelgesi,
                            Vekaletname = evraklar.Vekaletname,
                            OrtaklikBeyannamesi = evraklar.OrtaklikBeyannamesi,
                            BankaReferansMektubu = evraklar.BankaReferansMektubu,
                            MeslekiYeterlilik = evraklar.MeslekiYeterlilik
                        }).ToList();
            
        }
        public ICollection<TeklifBirimiDTO> DTOTeklifBirimiGetir(object o,string text)
        {
            List<TeklifBirimiDTO> teklifBirimiDTO = new List<TeklifBirimiDTO>();
            teklifBirimiDTO = DTOTeklifBirimiGetir().ToList();

            if (o is TeklifBirimi)
            {
                teklifBirimiDTO = teklifBirimiDTO.Where(x =>
                 x.BirimAdi.Contains(text) ||
                 x.KurumFirmaAdi.Contains(text) ||
                 x.IsinAdi.Contains(text) ||
                 x.IsTanimi.Contains(text)
                ).ToList();
            }
            else if (o is AcilanIhaleler)
            {
                teklifBirimiDTO = teklifBirimiDTO.Where(x =>
                 x.BirimAdi.Contains(text) ||
                 x.KurumFirmaAdi.Contains(text) ||
                 x.IsinAdi.Contains(text) ||
                 x.IsTanimi.Contains(text) ||
                 x.IhaleTarihSaat.ToString().Contains(text) ||
                 x.IsBaslangicTarihi.ToString().Contains(text) ||
                 x.IsBitisTarihi.ToString().Contains(text) ||
                 x.IhaleOturumAdresi.Contains(text)
                ).ToList();
            }
               

                

            return teklifBirimiDTO;
        }
        public ICollection<TeklifBirimiDTO> DTOTeklifBirimiGetir(int ihaleId)
        {

            List<TeklifBirimiDTO> teklifBirimiDTO = new List<TeklifBirimiDTO>();
            teklifBirimiDTO = DTOTeklifBirimiGetir().ToList();
            return teklifBirimiDTO.Where(x =>
            x.TeklifBirimiId==ihaleId
            ).ToList();
        }
    }
}

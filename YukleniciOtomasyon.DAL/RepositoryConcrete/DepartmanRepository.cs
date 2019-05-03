using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class DepartmanRepository : IT_DepartmanRepository
    {
        int _etkilenenSatir=0;
        YukleniciOtomasyonDbContext _db;
        public DepartmanRepository()
        {
            _db = new YukleniciOtomasyonDbContext();
        }
        public int AddItem(Departman item)
        {
           
                _db.Departman.Add(item);
                try
                {
                    // Your code...
                    // Could also be before try if you know the exception occurs in SaveChanges
                    //_etkilenenEntity=_db.ChangeTracker.Entries().ToList().Count;
                    //for (int i = 0; i < _etkilenenEntity; i++)
                    //{
                    _etkilenenSatir += _db.SaveChanges();
                    //}
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                return _etkilenenSatir;
            
        }

        public int DeleteItem(Departman item)
        {
            
                _db.Departman.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public Departman GetById(int id)
        {
            
                return _db.Departman.Where(x => x.Id == id).FirstOrDefault();
            
        }
        
        public int UpdateItem(Departman item)
        {
           
                Departman departman = _db.Departman.Where(x => x.Id == item.Id).FirstOrDefault();
                departman.DepartmanAdi = item.DepartmanAdi;
                departman.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            
        }

        public ICollection<Departman> GetAll()
        {
            
                return _db.Departman.ToList();
            
        }

        public ICollection<Departman> DepartmanAra(string text)
        {
           
                return _db.Departman.Where(x => x.DepartmanAdi.Contains(text)
                || x.DepoBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.LojistikBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.SantiyeBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.SantiyeBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.SatinAlmaBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                ).ToList();
            
        }

        public ICollection<DepartmanPersonelDTO> DTODepartmanPersonelGetir(string text)
        {
            
                string brmadi="";
                var depoadi = from personeltanim in _db.Personel
                                 join departman in _db.Departman on personeltanim.Id equals departman.Personeller.FirstOrDefault().Id
                                 join depobirimi in _db.DepoBirimi on departman.Id equals depobirimi.DepartmanId
                                 join depolar in _db.Depolar on depobirimi.Id equals depolar.DepoBirimiId
                                 select depolar.DepoAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = depoadi.ToString();
                }

                var loj = from personeltanim in _db.Personel
                          join departman in _db.Departman on personeltanim.Id equals departman.Personeller.FirstOrDefault().Id
                              join lojistikbirimi in _db.LojistikBirimi on departman.Id equals lojistikbirimi.DepartmanId
                              select lojistikbirimi.BirimAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = loj.ToString();
                }

                var san = from personeltanim in _db.Personel
                          join departman in _db.Departman on personeltanim.Id equals departman.Personeller.FirstOrDefault().Id
                          join santiyebirimi in _db.SantiyeBirimi on departman.Id equals santiyebirimi.DepartmanId
                          join santiyeler in _db.Santiyeler on santiyebirimi.Id equals santiyeler.SantiyeBirimiId
                          join santiyeozellikleri in _db.T_SantiyeOzellikleri on santiyeler.Id equals santiyeozellikleri.SantiyeleriId
                          select santiyeozellikleri.Ad;

                if (depoadi.ToString() != null)
                {
                    brmadi = san.ToString();
                }
                var sat = from personeltanim in _db.Personel
                          join departman in _db.Departman on personeltanim.Id equals departman.Personeller.FirstOrDefault().Id
                          join santinalmabirimi in _db.SatinAlmaBirimi on departman.Id equals santinalmabirimi.DepartmanId
                          select santinalmabirimi.BirimAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = sat.ToString();
                }
                var tek = from personeltanim in _db.Personel
                          join departman in _db.Departman on personeltanim.Id equals departman.Personeller.FirstOrDefault().Id
                          join teklifbirimi in _db.TeklifBirimi on departman.Id equals teklifbirimi.DepartmanId
                          select teklifbirimi.BirimAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = tek.ToString();
                }


                return (from departman in _db.Departman
                        join Personel in _db.Personel on departman.Id equals Personel.Departmanlar.FirstOrDefault().Id
                        select new DepartmanPersonelDTO
                        {
                            DepartmanAdi=departman.DepartmanAdi,
                            CalistigiYer = brmadi,
                            UnvanAdi = Personel.PersonelUnvanlar.FirstOrDefault().UnvanAdi,
                            Ad = Personel.Soyad,
                            KimlikNo = Personel.KimlikNo,
                            DogumTarihi= Personel.DogumTarihi,
                            Cinsiyet= Personel.Cinsiyet,
                            MedeniHal= Personel.MedeniHal,
                            EgitimDurumu= Personel.EgitimDurumu,
                            BaslangicTarihi= Personel.BaslangicTarihi,
                            Telefon= Personel.Personelletisimleri.FirstOrDefault().Telefon,
                            EMail = Personel.Personelletisimleri.FirstOrDefault().EMail,
                            Sifre = Personel.Personelletisimleri.FirstOrDefault().Sifre,
                            Adres = Personel.Personelletisimleri.FirstOrDefault().Adres,
                            DahiliTel = Personel.Personelletisimleri.FirstOrDefault().DahiliTel,
                            PostaKodu = Personel.Personelletisimleri.FirstOrDefault().PostaKodu,
                            ResimUrl = Personel.Personelletisimleri.FirstOrDefault().ResimUrl,
                            Maas = Personel.PersonelMuhasebeleri.FirstOrDefault().Maas
                        }).ToList();
            
        }
        
    }
}

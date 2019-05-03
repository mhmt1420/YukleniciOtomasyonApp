using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Depo;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Lojistik;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Santiye;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.SatinAlma;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Teklif;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.WinUI
{
    public class FakeDataDoldur
    {
        #region Database hata debug
        /*
         * try
                {
                    // Your code...
                    // Could also be before try if you know the exception occurs in SaveChanges

                    _etkilenenSatir = _db.SaveChanges();
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
                */
        #endregion

        public List<Personel> PersonelDoldur(int adet)
        {
            PersonelService ps = new PersonelService();
            List<Personel> plist = new List<Personel>();
            int say=ps.TumPersonelleriGetirService().Count;
            string stri = "";
            int j = 0;
            for (int i = say; i <= say+adet; i++)
            {
                Personel p = new Personel();
                PersonelIletisim pi = new PersonelIletisim();
                PersonelMuhasebe pm = new PersonelMuhasebe();
                T_PersonelUnvan pu = new T_PersonelUnvan();
                stri = i.ToString();
                p.Ad = stri + ".ad";
                p.Soyad = stri + ".soyad";
                p.KimlikNo = (11111111 + i).ToString();
                p.DogumTarihi = Convert.ToDateTime("10.10." + (1900 + i).ToString());
                p.Cinsiyet = (Cinsiyeti)(i % 2);
                p.MedeniHal = (MedeniHali)(i % 2);
                p.EgitimDurumu = (EgitimDurumlari)(i % 9);
                p.BaslangicTarihi = Convert.ToDateTime("10.10." + (1910 + i).ToString());
                pi.Telefon = (1111111111111 + adet).ToString();
                pi.EMail = stri + ".Email";
                pi.Sifre = stri + ".Sifre";
                pi.Adres = stri + ".Adres";
                pi.DahiliTel = (1111 + i).ToString();
                pi.PostaKodu = (11111 + i).ToString();
                pi.ResimUrl = stri + ".ResimURL";
                pm.Maas = Convert.ToDecimal(1000 + i);
                pu.UnvanAdi = stri + ".Unvan";

                p.Personelletisimleri.Add(pi);
                p.PersonelMuhasebeleri.Add(pm);
                p.PersonelUnvanlar.Add(pu);
                ps.AddPersonelService(p);

                plist.Add(p);
                j++;
            }
            return plist;
        }
        private List<T_Malzeme> MalzemeDoldur(int adet)
        {
            T_MalzemeService ms = new T_MalzemeService();
            T_MalzemeFiyatService mfs = new T_MalzemeFiyatService();
            List<T_Malzeme> mlist = new List<T_Malzeme>();
            int say = ms.TumMalzemeleriGetirService().Count;
            string stri = "";
            int j = 0;
            for (int i = say; i <= say+adet; i++)
            {
                T_Malzeme m = new T_Malzeme();
                T_MalzemeFiyat mf = new T_MalzemeFiyat();
                stri = i.ToString();
                m.MalzemeAdi = stri + ".Malzeme";
                m.Tur = stri + ".Tür";
                m.Adet = Convert.ToDecimal(i);
                m.AdetTip = stri + ".AdetTip";
                m.En = i;
                m.Boy = i;
                m.Derinlik = i;
                m.Agirlik = i;
                mf.BirimFiyat = Convert.ToDecimal(i);
                m.MalzemeFiyatlari.Add(mf);
                mlist.Add(m);
                j++;
            }
            return mlist;

        }
        private List<NakliyeIslemi> NakliyeDoldur(int adet)
        {
            T_NakliyeAraclari na = new T_NakliyeAraclari();
            T_NakliyeAraclariService nas = new T_NakliyeAraclariService();
            NakliyeIrsaliye ni = new NakliyeIrsaliye();
            NakliyeIrsaliyeService nis = new NakliyeIrsaliyeService();
            NakliyeIslemi nai = new NakliyeIslemi();
            NakliyeIslemiService nais = new NakliyeIslemiService();
            T_Nakliye n = new T_Nakliye();
            T_NakliyeService ns = new T_NakliyeService();
            T_MalzemeService ms = new T_MalzemeService();
            List<T_Malzeme> malze = new List<T_Malzeme>();
            malze = MalzemeDoldur(adet);
            List<NakliyeIslemi> nlist = new List<NakliyeIslemi>();
            int say = ns.TumNakliyeleriGetirService().Count;
            int j = 0;
            string stri = "";
            for (int i = say; i <= say+adet; i++)
            {
                stri = i.ToString();
                ni.IrsaliyeNo = stri + ".IrsaliyeNo";
                ni.YukBirimi = stri + ".YukBirimi";
                ni.NakliyeTipleri = (NakliyeTipi)(i % 4);
                ni.CikisTarihi = Convert.ToDateTime("11.11." + (1910 + i).ToString());
                ni.TeslimTarihi = Convert.ToDateTime("11.11." + (1910 + i).ToString());
                ni.TeslimAdresi = stri + ".TeslimAdresi";
                ni.SoforAdi = stri + ".SoforAdi";
                ni.SoforSoyadi = stri + "Soyadi";
                ni.SoforTelefon = stri + ".Telefon";
                na.TasitTipi = (TasitTip)(j % 5);
                

                n.Ad = stri + ".Ad";
                n.Telefon = stri + ".Telefon";
                n.EMail = stri + ".EMail";
                n.Adres = stri + ".Adres";
                ni.GondericiFirmaBilgileri = n;

                ni.TasinanMalzemeler.Add(malze[j]);
                nai.Irsaliyeler.Add(ni);
                nlist.Add(nai);
                j++;
            }
            return nlist;

        }
        private List<AcilanIhaleler> TeklifDoldur(int adet)
        {
            List<AcilanIhaleler> alist = new List<AcilanIhaleler>();
            TeklifBirimi tb = new TeklifBirimi();
            T_IhaleEvraklari ie = new T_IhaleEvraklari();
            AcilanIhaleler a = new AcilanIhaleler();
            AcilanIhalelerService ass = new AcilanIhalelerService();
            int say = ass.TumAcilanIhaleleriGetirService().Count;
            string stri = "";
            int j = 0;
            for (int i = say; i <= say+ adet; i++)
            {
                tb.BirimAdi = "Teklif Birimi";
                stri = i.ToString();
                ie.TicaretOdasiKayitBelgesi = stri + ".TicaretOdasiKayitBelgesi";
                ie.ImzaSirkuleri = stri + ".ImzaSirkuleri";
                ie.TeklifMektubu = stri + ".TeklifMektubu";
                ie.GeciciTeminatMektubu = stri + ".GeciciTeminatMektubu";
                ie.IsBitirmeBelgesi = stri + ".IsBitirmeBelgesi";
                ie.Vekaletname = stri + ".Vekaletname";
                ie.OrtaklikBeyannamesi = stri + ".OrtaklikBeyannamesi";
                ie.BankaReferansMektubu = stri + ".BankaReferansMektubu";
                ie.MeslekiYeterlilik = stri + ".MeslekiYeterlilik";

                a.KurumFirmaAdi = stri + ".KurumFirmaAdi";
                a.IsinAdi = stri + ".IsinAdi";
                a.IsTanimi = stri + ".IsTanimi";
                a.IhaleTarihSaat = Convert.ToDateTime("11.11." + (1910 + i).ToString());
                a.IsBaslangicTarihi = Convert.ToDateTime("12.12." + (1910 + i).ToString());
                a.IsBitisTarihi = Convert.ToDateTime("10.10." + (1910 + i).ToString());
                a.IhaleOturumAdresi = stri + ".IhaleOturumAdresi";
                a.TeknikSartname = stri + ".TeknikSartname";
                a.IdariSartname = stri + ".IdariSartname";
                a.SozlesmeTaslagi = stri + ".SozlesmeTaslagi";
                a.IhaleyiAlanFirmaAdi = stri + ".IhaleyiAlanFirmaAdi";
                a.AlanFirmaninTeklifi = stri + ".Teklifi";
                a.HazirlananEvraklar.Add(ie);
                tb.KatilimSaglananIhaleler.Add(a);
                
                alist.Add(a);
                j++;
            }
            return alist;

        }
        private List<SatinAlmalar> SatinAlmaDoldur(int adet)
        {
            List<SatinAlmalar> salist = new List<SatinAlmalar>();
            T_MalzemeService ms = new T_MalzemeService();
            List<T_Malzeme> ma = new List<T_Malzeme>();
            SatinAlmalar sa = new SatinAlmalar();
            T_TedarikciFirma tf = new T_TedarikciFirma();
            SatinAlmalarService sas = new SatinAlmalarService();
            int say = sas.TumSatinAlmalariGetirService().Count;
            int j = 0;
            ma = MalzemeDoldur(adet);
            string stri = "";
            for (int i = say; i <= say+adet; i++)
            {
                stri = i.ToString();
                sa.OdemeTuru = (OdemeTurleri)(i % 2);
                sa.CekVadesi = null;
                sa.SatinAlmaTarihi = Convert.ToDateTime("11.11." + (1920 + i).ToString());
                sa.TeslimTarihi = Convert.ToDateTime("12.12." + (1930 + i).ToString());
                //sa.ToplamFiyat=Convert.ToDecimal(m.Adet * m.MalzemeFiyatlari.Where(x => x.MalzemeId == x.Malzeme.Id).FirstOrDefault().BirimFiyat);
                tf.Ad = stri + ".Ad";
                tf.Telefon = stri + ".Telefon";
                tf.EMail = stri + ".EMail";
                tf.Adres = stri + ".Adres";
                sa.TedarikciFirma = tf;
                sa.AlinanMalzemeler.Add(ma[j]);
                
                salist.Add(sa);
                j++;
            }
            return salist;
        }
        private DepoBirimi DepoBirimiDoldur(int adet)
        {
            DepoBirimi db = new DepoBirimi();
            T_DepoOzellikleri d_o = new T_DepoOzellikleri();
            Depolar d = new Depolar();
            List<NakliyeIslemi> nailist = new List<NakliyeIslemi>();
            T_MalzemeService ms = new T_MalzemeService();
            DepoBirimiService dbs = new DepoBirimiService();
            int say = dbs.TumDepoBirimleriniGetir().Count;
            if (nailist.Count == 0)
            {
                nailist = NakliyeDoldur(adet).ToList();
            }

            List<T_Malzeme> malz = new List<T_Malzeme>();
            malz = MalzemeDoldur(adet);
            int j = 0;
            string stri = "";
            for (int i = say; i <= say+adet; i++)
            {
                db.BirimAdi = "Depo Birimi";
                stri = i.ToString();

                d.DepoAdi = stri + ".Depo";
                d_o.Ad = stri + ".Depo";
                d_o.Boyutu = stri + ".Boyut";
                d_o.Adres = stri + ".Adres";

                 
                d.DepoOzellikleri.Add(d_o);
                d.DepodakiMalzemeler.Add(malz[j]);

                db.Depolar.Add(d);
                j++;
            }
            return db;
        }
        private LojistikBirimi LojistikBirimiDoldur(int adet)
        {
            LojistikBirimi lb = new LojistikBirimi();
            LojistikBirimiService lbs = new LojistikBirimiService();
            T_NakliyeAraclari na = new T_NakliyeAraclari();
            T_MalzemeService ms = new T_MalzemeService();
            
            string stri = "";
            List<NakliyeIslemi> nailist = new List<NakliyeIslemi>();
            if (nailist.Count == 0)
            {
                nailist = NakliyeDoldur(adet).ToList();
            }
            int say = lbs.TumLojistikleriGetirService().Count;
            int j = 0;
            for (int i = say; i <= say+adet; i++)
            {
                lb.BirimAdi = "Lojistik Birimi";
                na.TasitTipi = (TasitTip)(i % 5);
                stri = i.ToString();
                lb.NakliyeAraclari.Add(na);
                lb.NakliyeIslemleri.Add(nailist[j]);
                j++;
            }
            return lb;
        }
        private SantiyeBirimi SantiyeBirimiDoldur(int adet)
        {
            SantiyeBirimi sb = new SantiyeBirimi();
            SantiyeBirimiService sbs = new SantiyeBirimiService();
            Santiyeler s = new Santiyeler();
            SantiyelerService ss = new SantiyelerService();
            SantiyeIsTakibi sit = new SantiyeIsTakibi();
            SantiyeIsTakibiService sits = new SantiyeIsTakibiService();
            T_SantiyeOzellikleri so = new T_SantiyeOzellikleri();
            T_SantiyeOzellikleriService sos = new T_SantiyeOzellikleriService();
            T_MalzemeService ms = new T_MalzemeService();


            List<T_Malzeme> malze = new List<T_Malzeme>();
            malze = MalzemeDoldur(adet);
            int say = sbs.TumSantiyeBirimleriniGetirService().Count;
            int j = 0;
            List<NakliyeIslemi> nailist = new List<NakliyeIslemi>();
            if (nailist.Count == 0)
            {
                nailist = NakliyeDoldur(adet).ToList();
            }
            
            string stri = "";
            for (int i = say; i <= say+adet; i++)
            {
                sb.BirimAdi = "Şantiye Birimi";
                stri = i.ToString();
                so.Ad = stri + ".Ad";
                so.Adres = stri + ".Adres";
                so.BaslangicTarihi = Convert.ToDateTime("11.11." + (1950+i));
                so.BitisTarihi = Convert.ToDateTime("12.12." + (1950 + i));
                so.IsinSuresi = 400;

                s.SantiyeOzellikleri.Add(so);
                s.SantiyedekiMalzemeler.Add(malze[j]);

                sb.Santiyeler.Add(s);
                j++;
            }
            return sb;
        }
        private SatinAlmaBirimi SatinAlmaBirimiDoldur(int adet)
        {
            List<SatinAlmalar> salist = new List<SatinAlmalar>();
            SatinAlmaBirimi sab = new SatinAlmaBirimi();
            SatinAlmaBirimiService sabs = new SatinAlmaBirimiService();
            int say = sabs.TumSatinAlmaBirimiGetirService().Count;
            salist = SatinAlmaDoldur(adet).ToList();
            string stri = "";
            int j = 0;
            for (int i = say; i <= say+adet; i++)
            {
                sab.BirimAdi = "Satın Alma Birimi";
                stri = i.ToString();
                sab.YapilanSatinAlmalar.Add(salist[j]);
                j++;
            }
            return sab;
        }
        private TeklifBirimi TeklifBirimiDoldur(int adet)
        {
            List<AcilanIhaleler> ailist = new List<AcilanIhaleler>();
            TeklifBirimiService tbs = new TeklifBirimiService();
            TeklifBirimi tb = new TeklifBirimi();
            int say = tbs.TumTeklifBirimleriniGetirService().Count;
            int j = 0;
            ailist = TeklifDoldur(adet).ToList();
            string stri = "";
            for (int i = say; i <= say+adet; i++)
            {
                tb.BirimAdi = "Teklif Birimi";
                stri = i.ToString();
                tb.KatilimSaglananIhaleler.Add(ailist[j]);
                j++;
            }
            return tb;
        }
        public void DepartmanDoldur(string birimAdi,int adet)
        {
            Departman departman = new Departman();
            DepartmanService departmanService = new DepartmanService();
            switch (birimAdi)
            {
                case "Depo Birimi": departman.DepartmanAdi = birimAdi; departman.DepoBirimleri.Add(DepoBirimiDoldur(adet));  break;
                case "Lojistik Birimi": departman.DepartmanAdi = birimAdi; departman.LojistikBirimleri.Add(LojistikBirimiDoldur(adet));  break;
                case "Şantiye Birimi": departman.DepartmanAdi = birimAdi; departman.SantiyeBirimleri.Add(SantiyeBirimiDoldur(adet));  break;
                case "Satın Alma Birimi": departman.DepartmanAdi = birimAdi; departman.SatinAlmaBirimleri.Add(SatinAlmaBirimiDoldur(adet)); break;
                case "Teklif Birimi": departman.DepartmanAdi = birimAdi; departman.TeklifBirimleri.Add(TeklifBirimiDoldur(adet)); break;
                default:
                    System.Windows.Forms.MessageBox.Show("Birim Adını Yanlış Girdiniz!");
                    break;
            }
            departmanService.AddDepartmanService(departman);
        }
        public void DepartmanDoldur()
        {
            Departman dep = new Departman();
            DepartmanService deps = new DepartmanService();
            dep.DepoBirimleri.Add(DepoBirimiDoldur(1));
            deps.AddDepartmanService(dep);
            Departman dep11 = new Departman();
            DepartmanService deps11 = new DepartmanService();
            dep11.LojistikBirimleri.Add(LojistikBirimiDoldur(1));
            deps11.AddDepartmanService(dep);
            Departman dep22 = new Departman();
            DepartmanService deps22 = new DepartmanService();
            dep22.SantiyeBirimleri.Add(SantiyeBirimiDoldur(1));
            deps22.AddDepartmanService(dep);
            Departman dep33 = new Departman();
            DepartmanService deps33 = new DepartmanService();
            dep33.SatinAlmaBirimleri.Add(SatinAlmaBirimiDoldur(1));
            deps33.AddDepartmanService(dep);
            Departman dep44 = new Departman();
            DepartmanService deps44 = new DepartmanService();
            dep44.TeklifBirimleri.Add(TeklifBirimiDoldur(1));
            deps44.AddDepartmanService(dep);

        }
    }
}

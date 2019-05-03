using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Teklif;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Teklif
{
    public class TeklifBirimiService
    {
        TeklifBirimiRepository _teklifBirimiRepository;
        public TeklifBirimiService()
        {
            _teklifBirimiRepository = new TeklifBirimiRepository();
        }


        public int AddTeklifBirimiService(TeklifBirimi eklencekTeklifBirimi)
        {
            try
            {
                return _teklifBirimiRepository.AddItem(eklencekTeklifBirimi);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int DeleteTeklifBirimiService(TeklifBirimi silinecekTeklifBirimi)
        {
            try
            {
                return _teklifBirimiRepository.DeleteItem(silinecekTeklifBirimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<TeklifBirimi> TumTeklifBirimleriniGetirService()
        {
            try
            {
                return _teklifBirimiRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public TeklifBirimi BirTeklifBirimiGetirService(int id)
        {
            try
            {
                return _teklifBirimiRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateTeklifBirimi(TeklifBirimi guncellenecekTeklifBirimi)
        {
            try
            {
                return _teklifBirimiRepository.UpdateItem(guncellenecekTeklifBirimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<TeklifBirimiDTO> DTOTeklifBirimiGetirService()
        {
            try
            {
                return _teklifBirimiRepository.DTOTeklifBirimiGetir().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<TeklifBirimiDTO> DTOTeklifBirimiGetirService(object o, string text)
        {
            try
            {
                return _teklifBirimiRepository.DTOTeklifBirimiGetir(o,text).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<TeklifBirimiDTO> DTOTeklifBirimiGetirService(int id)
        {
            try
            {
                return _teklifBirimiRepository.DTOTeklifBirimiGetir(id).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }






















    }
}
